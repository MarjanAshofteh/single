Imports System.IO
Imports System.Text
Imports System.Threading

Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnAbout808_Click(sender As Object, e As EventArgs) Handles BtnAbout808.Click
        Dim webAddress As String = "http://civil808.com/page/about"
        Process.Start(webAddress)
    End Sub

    Private Sub BtnSiteLink_Click(sender As Object, e As EventArgs) Handles BtnSiteLink.Click
        Dim webAddress As String = "http://civil808.com/"
        Process.Start(webAddress)
    End Sub

    Private Sub BtnHelp_Click(sender As Object, e As EventArgs) Handles BtnHelp.Click
        Dim tfrm As New FrmHelp
        tfrm.ShowDialog()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        binPath = Path.Combine(Environment.CurrentDirectory, "data\data.bin")
        detailsPath = Path.Combine(Environment.CurrentDirectory, "data\details.bin")

        LocalKey = ToMD5(LocalKey + Environment.MachineName + Environment.UserName)
        LocalIV = ToMD5(LocalIV + Environment.MachineName + Environment.UserName)
        Dim tempBytes As Byte() = CryptBytes(Encoding.UTF32.GetString(password), File.ReadAllBytes(Path.Combine(Environment.CurrentDirectory, "data\Loader32.dll")), False)
        Dim SettingsStr As String = AES_decrypt(Encoding.UTF8.GetString(tempBytes))
        Dim SettingItems() As String = SettingsStr.Split("@@")
        serverURI = SettingItems(0)
        PackageCode = SettingItems(2).ToLower.Trim
        CheckumBin = SettingItems(4)

        If (FileIO.FileSystem.FileExists(AppDomain.CurrentDomain.BaseDirectory & "reset.reset")) = True Then
            File.Delete(AppDomain.CurrentDomain.BaseDirectory & "reset.reset")
            set_setting("version", "")
            Application.Restart()
        End If

        'read header 1218 bytes
        encodedFileHeader = File.ReadAllBytes(detailsPath)

        If ToMD5(encodedFileHeader) <> CheckumBin Then
            set_setting("version", "")
            Application.Exit()
        End If

        Dim temppath2 As String = IO.Path.GetTempPath()
        If Strings.Right(temppath2, 1) <> "\" Then temppath2 &= "\"
        tempPath = get_setting("tempdir", "")
        If tempPath <> "" And FileIO.FileSystem.DirectoryExists(tempPath) Then
            FileIO.FileSystem.DeleteDirectory(tempPath, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
        tempPath = temppath2 & CStr(GetRandom(1, 10000000)) & CStr(GetRandom(1, 10000000)) & CStr(GetRandom(1, 10000000))
        If Directory.Exists(tempPath) = False Then
            FileSystem.MkDir(tempPath)
        End If
        File.SetAttributes(tempPath, File.GetAttributes(tempPath) Or FileAttributes.Hidden Or FileAttributes.System)
        set_setting("tempdir", tempPath)

        GETPUID()
        If (get_setting("version", "") = PUID) Then
            Me.Hide()
            Me.WindowState = FormWindowState.Minimized
            Me.Opacity = 0
            runFile()
        End If

        If My.Computer.Network.IsAvailable And get_setting("version", "") <> "" Then
            Dim syncUser As Thread = New Thread(AddressOf syncOfflineUser)
            syncUser.SetApartmentState(ApartmentState.MTA)
            syncUser.Start()
        End If

    End Sub


    Private Sub BtnActivate_Click(sender As Object, e As EventArgs) Handles BtnActivate.Click
        lblStatus.Visible = True
        lblStatus.Text = ""
        If TxtPass.Text.Length < 8 Or txtPhone.Text = "" Or txtName.Text = "" Or txtEmail.Text = "" Then
            lblStatus.Text = "فیلدها را به درستی پر کنید"
            lblStatus.ForeColor = Color.Red
            Exit Sub
        End If
        If IsEmail(txtEmail.Text) = False Then
            lblStatus.Text = "ایمیل نادرست"
            lblStatus.ForeColor = Color.Red
            Exit Sub
        End If
        If txtPhone.Text.Length <> 11 Then
            MsgBox("شماره تماس اشتباه است" & vbNewLine & "(نمونه صحیح) 9120001111", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If


        Try

            If My.Computer.Network.IsAvailable Then
                If Strings.Left(TxtPass.Text.Trim.ToLower, PackageCode.Length) <> PackageCode Then
                    lblStatus.Text = "سریال نامعتبر!"
                    lblStatus.ForeColor = Color.Red
                Else

                    Dim ranber As Long = GetRandom(10000, 100000)
                    Dim hash As String = Web.HttpUtility.UrlEncodeUnicode(jsonSerilizer(1, PUID, TxtPass.Text.Trim.ToLower, PackageCode, ranber, txtName.Text, txtEmail.Text, txtPhone.Text))
                    Dim response As String = HttpPostRequest(serverURI, "hash=" & hash.Trim)

                    Dim result As New jsonStructure
                    If response.Length > 20 Then
                        result = importJson(response)
                    Else
                        lblStatus.Text = "خطای نامعلوم"
                        lblStatus.ForeColor = Color.Black
                        Return
                    End If

                    If result.ranber = (ranber * 73) - 320 Then
                        lblStatus.Text = "..."
                        Select Case CInt(result.response)
                            Case 1
                                lblStatus.Text = "ورود موفق!"
                                lblStatus.ForeColor = Color.Green

                                set_setting("version", PUID)
                                set_setting("serial", TxtPass.Text.Trim.ToLower)
                                set_setting("user_name", txtName.Text)
                                set_setting("user_phone", txtPhone.Text)
                                set_setting("user_email", txtEmail.Text)

                                runFile()

                            Case 2
                                lblStatus.Text = "سریال باطل شده"
                                lblStatus.ForeColor = Color.Red
                            Case 3
                                lblStatus.Text = "خطای سرور, مجددا سعی کنید"
                                lblStatus.ForeColor = Color.Red
                            Case 4
                                lblStatus.Text = "سریال نامعتبر!"
                                lblStatus.ForeColor = Color.Red
                            Case 5
                                lblStatus.Text = "..."
                                lblStatus.ForeColor = Color.Green
                            Case Else

                        End Select
                    End If
                End If
            Else
                lblStatus.Text = "عدم دسترسی به اینترنت"
                lblStatus.ForeColor = Color.Black
                Exit Sub
            End If

        Catch
            lblStatus.Text = "خطای نامعلوم"
            lblStatus.ForeColor = Color.Black
        End Try


    End Sub

    Private Sub runFile()

        Dim foundFormat As Boolean = False

        FrmLoadingObj = New Loading
        FrmLoadingObj.Show()
        FrmLoadingObj.Refresh()

        Try

            'read view file
            Dim viewFile As Byte() = CryptBytes(Encoding.UTF32.GetString(password), encodedFileHeader, False)

            'copy bin file
            Dim filePath As String = tempPath & "\WinUpdate-KB-" & GetRandom(1, 9999999) & ".chm"
            File.Copy(binPath, filePath)

            'replace 1218 bytes
            Using fs As New FileStream(filePath, FileMode.Open, FileAccess.ReadWrite)
                fs.Seek(0, SeekOrigin.Begin)
                fs.Write(viewFile, 0, 1218)
            End Using

            Dim playerVideoDir As String = Path.Combine(Environment.CurrentDirectory, "data\video")
            Dim playerPDFDir As String = Path.Combine(Environment.CurrentDirectory, "data\book")

            Dim proc As ProcessStartInfo = New ProcessStartInfo
            If Directory.Exists(playerPDFDir) Then
                foundFormat = True
                proc.UseShellExecute = True
                proc.FileName = "data\book\play808.exe"
                proc.Arguments = AES_encrypt(filePath, "JH8d*42(sF964Zc=820Di2!sF353EG#^", "@4gD348dsghFgjr$92Dk4036ksga28fH")
            ElseIf Directory.Exists(playerVideoDir) Then
                foundFormat = True
                proc.UseShellExecute = True
                proc.FileName = "data\video\play808.exe"
                proc.Arguments = AES_encrypt(filePath, "JH8d*42(sF964Zc=820Di2!sF353EG#^", "@4gD348dsghFgjr$92Dk4036ksga28fH")
            End If
            If foundFormat = False Then
                MsgBox("خطا در فرمت فایل", MsgBoxStyle.Critical, "خطا")
                Application.Exit()
            End If


            FrmLoadingObj.workCompleted = True
            FrmLoadingObj.Hide()

            Using exeProcess As Process = Process.Start(proc)
                exeProcess.WaitForExit()
            End Using
            File.Delete(filePath)
            Directory.Delete(tempPath)

        Catch ee As Exception
            FrmLoadingObj.workCompleted = True
            FrmLoadingObj.Hide()
            MsgBox("خطا حین باز کردن فایل" & vbNewLine & ee.Message, MsgBoxStyle.Critical, "")
        End Try

        Application.Exit()
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim foundFormat As Boolean = False
        Dim filePath As String = Path.Combine(Environment.CurrentDirectory, "data\demo.mov")
        Dim playerVideoDir As String = Path.Combine(Environment.CurrentDirectory, "data\video")
        Dim playerPDFDir As String = Path.Combine(Environment.CurrentDirectory, "data\book")

        Try
            Dim proc As ProcessStartInfo = New ProcessStartInfo
            If Directory.Exists(playerPDFDir) Then
                foundFormat = True
                proc.UseShellExecute = True
                proc.FileName = "data\book\play808.exe"
                proc.Arguments = AES_encrypt(filePath, "JH8d*42(sF964Zc=820Di2!sF353EG#^", "@4gD348dsghFgjr$92Dk4036ksga28fH")
            ElseIf Directory.Exists(playerVideoDir) Then
                foundFormat = True
                proc.UseShellExecute = True
                proc.FileName = "data\video\play808.exe"
                proc.Arguments = AES_encrypt(filePath, "JH8d*42(sF964Zc=820Di2!sF353EG#^", "@4gD348dsghFgjr$92Dk4036ksga28fH")
            End If
            If foundFormat = False Then
                MsgBox("خطا در فرمت فایل", MsgBoxStyle.Critical, "خطا")
                Application.Exit()
            End If

            Using exeProcess As Process = Process.Start(proc)
                exeProcess.WaitForExit()
            End Using

        Catch
            MsgBox("خطا حین پخش دمو", MsgBoxStyle.Critical, "808")
        End Try
    End Sub

    Private Sub BtnActivateOffline_Click(sender As Object, e As EventArgs) Handles BtnActivateOffline.Click
        If My.Computer.Network.IsAvailable Then
            MsgBox("لطفا از فعالساز آنلاین استفاده کنید", MsgBoxStyle.Information, "راهنما")
            Exit Sub
        End If
        If txtEmail.Text.Length < 3 Or txtName.Text.Length < 3 Or txtPhone.Text.Length < 3 Then
            MsgBox("لطفا فیلدهای (نام - ایمیل - شماره تماس) را پر کنید", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If
        If IsEmail(txtEmail.Text) = False Then
            MsgBox("ایمیل نادرست", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If
        If txtPhone.Text.Length <> 11 Then
            MsgBox("شماره تماس اشتباه. نمونه صحیح:" & vbNewLine & "9120001111", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If

        Dim frmOffline As New FrmOfflineRegister
        frmOffline.ShowDialog()

        set_setting("user_name", txtName.Text)
        set_setting("user_phone", txtPhone.Text)
        set_setting("user_email", txtEmail.Text)

        If get_setting("version", "") = PUID Then
            runFile()
        Else
            lblStatus.Text = "خطا!"
            lblStatus.ForeColor = Color.Red
            lblStatus.Visible = True
        End If

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        Dim ac As String = "@"
        If e.KeyChar <> ChrW(Keys.Back) Then
            If Asc(e.KeyChar) < 97 Or Asc(e.KeyChar) > 122 Then
                If Asc(e.KeyChar) <> 46 And Asc(e.KeyChar) <> 95 Then
                    If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                        If ac.IndexOf(e.KeyChar) = -1 Then
                            e.Handled = True
                        Else
                            If txtEmail.Text.Contains("@") And e.KeyChar = "@" Then
                                e.Handled = True
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        lblStatus.Visible = False
        lblStatus.Text = ""
    End Sub


End Class

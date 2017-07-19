Imports System.IO
Imports System.Text
Imports System.Threading

Public Class Form1
    'for moving the form lock windows form
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
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

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim t As Thread = New Thread(AddressOf LoadOpacity)
        t.SetApartmentState(ApartmentState.STA)
        t.Start()

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
            MsgBox("خطایی در رابطه با مکان قرارگیری فایل ها در پوشه bin وجود دارد." & vbNewLine & "لطفا فایل ها را به حالت اولیه برگردانید.", MsgBoxStyle.Exclamation, "خطا")
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

        'loading textfield to prevent data lost at every starting
        If get_setting("user_name", "") <> "" Then
            txtName.Text = get_setting("user_name", "")
            txtName.ForeColor = Color.Black
        End If
        If get_setting("user_phone", "") <> "" Then
            txtPhone.Text = get_setting("user_phone", "")
            txtPhone.ForeColor = Color.Black
        End If
        If get_setting("user_email", "") <> "" Then
            txtEmail.Text = get_setting("user_email", "")
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub BtnActivate_Click(sender As Object, e As EventArgs) Handles BtnActivate.Click
        If txtPhone.Text <> "09120000000" Then
            set_setting("user_phone", txtPhone.Text)
        End If
        If txtName.Text <> "میثم رزمی" Then
            set_setting("user_name", txtName.Text)
        End If
        If txtEmail.Text <> "sample@gmail.com" Then
            set_setting("user_email", txtEmail.Text)
        End If

        lblStatus.Visible = True
        lblStatus.Text = ""
        If TxtPass.Text.Length < 2 Or txtPhone.Text = "" Or txtPhone.Text = "09120000000" Or txtName.Text = "" Or txtName.Text = "میثم رزمی" Or txtEmail.Text = "" Or txtEmail.Text = "sample@gmail.com" Then
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
            MsgBox("شماره تلفن اشتباه است. شماره باید 11 رقم باشد مانند:" & vbNewLine & "9120001111", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If

        Try
            If My.Computer.Network.IsAvailable Then
                If Strings.Left(TxtPass.Text.Trim.ToLower, PackageCode.Length) <> PackageCode Then
                    lblStatus.Text = "سریال برای پکیج دیگری می باشد و بر روی این پکیج فعال نیست."
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
                                set_setting("package", PackageCode)
                                set_setting("user_name", txtName.Text)
                                set_setting("user_phone", txtPhone.Text)
                                set_setting("user_email", txtEmail.Text)

                                runFile()

                            Case 2
                                lblStatus.Text = "تعداد دفعات استفاده از سریال مجاز نیست."
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

        Catch ee As Exception
            lblStatus.Text = "خطای نامعلوم"
            MsgBox("خطای نامعلوم" & vbNewLine & ee.Message, MsgBoxStyle.Critical, "خطا")
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
            MsgBox("خطا حین باز کردن فایل" & vbNewLine & ee.Message, MsgBoxStyle.Critical, "خطا")
        End Try

        Application.Exit()
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

        Catch ee As Exception
            MsgBox("خطا حین پخش دمو" & vbNewLine & ee.Message, MsgBoxStyle.Critical, "خطا")
        End Try
    End Sub

    Private Sub BtnActivateOffline_Click(sender As Object, e As EventArgs) Handles BtnActivateOffline.Click
        If txtPhone.Text <> "09120000000" Or txtPhone.Text <> "" Then
            set_setting("user_phone", txtPhone.Text)
        End If
        If txtName.Text <> "میثم رزمی" Or txtName.Text <> "" Then
            set_setting("user_name", txtName.Text)
        End If
        If txtEmail.Text <> "sample@gmail.com" Or txtEmail.Text <> "" Then
            set_setting("user_email", txtEmail.Text)
        End If

        If My.Computer.Network.IsAvailable Then
            MsgBox("برای جلوگیری از بروز خطا در استفاده های بعدی در صورت اتصال به اینترنت لطفا از فعال سازی آنلاین استفاده کنید.", MsgBoxStyle.Information, "راهنما")
        End If
        If txtPhone.Text = "" Or txtPhone.Text = "09120000000" Or txtName.Text = "" Or txtName.Text = "میثم رزمی" Or txtEmail.Text = "" Or txtEmail.Text = "sample@gmail.com" Then
            MsgBox("لطفا فیلدهای (نام - ایمیل - شماره تلفن) را پر کنید. حداقل 3 حرف باید وارد شود.", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If
        If IsEmail(txtEmail.Text) = False Then
            MsgBox("ایمیل نادرست", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If
        If txtPhone.Text.Length <> 11 Then
            MsgBox("شماره تلفن اشتباه است. شماره باید 11 رقم باشد مانند:" & vbNewLine & "09120001111", MsgBoxStyle.Exclamation, "خطا")
            Exit Sub
        End If

        Dim frmOffline As New FrmOfflineRegister
        frmOffline.ShowDialog()

        set_setting("user_name", txtName.Text)
        set_setting("user_phone", txtPhone.Text)
        set_setting("user_email", txtEmail.Text)
        set_setting("package", PackageCode)

        If get_setting("version", "") = PUID Then
            runFile()
        End If

    End Sub

    'form loading animation
    Private Sub LoadOpacity()
        For i As Integer = 1 To 100
            Me.Invoke(New Action(Of Integer)(AddressOf LoadOpacityChild), i)
            System.Threading.Thread.Sleep(3)
        Next
    End Sub

    Private Sub LoadOpacityChild(ByVal input As Integer)
        Me.Opacity = input / 100
    End Sub

    'bottom buttons
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

    'textboxes keypressing
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

    'minimize and close buttons
    Private Sub minimize_icon_click(sender As Object, e As EventArgs) Handles minimize_icon.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub close_icon_click(sender As Object, e As EventArgs) Handles close_icon.Click
        Me.Close()
    End Sub

    'handling textboxes placeholders
    Private Sub txtName_GotFocus(sender As Object, e As EventArgs) Handles txtName.GotFocus
        If txtName.Text = "میثم رزمی" Then
            txtName.Text = ""
            txtName.ForeColor = Color.Black
            Dim iran As Font = CustomFont.GetInstance(10, FontStyle.Regular)
            txtName.Font = iran
        End If
    End Sub

    Private Sub txtName_LostFocus(sender As Object, e As EventArgs) Handles txtName.LostFocus
        If txtName.Text = "" Then
            txtName.Text = "میثم رزمی"
            txtName.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtPhone_GotFocus(sender As Object, e As EventArgs) Handles txtPhone.GotFocus
        If txtPhone.Text = "09120000000" Then
            txtPhone.Text = ""
            txtPhone.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPhone_LostFocus(sender As Object, e As EventArgs) Handles txtPhone.LostFocus
        If txtPhone.Text = "" Then
            txtPhone.Text = "09120000000"
            txtPhone.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtEmail_GotFocus(sender As Object, e As EventArgs) Handles txtEmail.GotFocus
        If txtEmail.Text = "sample@gmail.com" Then
            txtEmail.Text = ""
            txtEmail.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If txtEmail.Text = "" Then
            txtEmail.Text = "sample@gmail.com"
            txtEmail.ForeColor = Color.Silver
        End If
    End Sub
End Class

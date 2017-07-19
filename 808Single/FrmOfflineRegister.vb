Imports System.Threading
Imports System.Windows.Forms

Public Class FrmOfflineRegister
    Dim xCode As String
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub tempThreadWorker()
        xCode = AES_encrypt(GenerateHash(textPUID.Text & textPUID.Text.Length * AscW(Strings.Left(PUID, 1)), textPUID.Text.Length * 1023), LocalKey, LocalIV)
    End Sub

    Private Function GenerateHash(ByVal input As String, ByVal salt As String) As String
        Dim code As String = ServerHash(PUID + salt + input)
        Dim x As Long = 2146
        For Each c As Char In code
            x += ((((AscW(c) * 256) + 2048) / 64) + 1073) ^ 3

        Next
        x += -261
        If (x < 0) Then x = x * -1
        Dim tempStr As String = Strings.Right(CStr(x), CStr(x).Length - 2)
        Return tempStr
    End Function

    Private Sub BtnActivate_Click(sender As Object, e As EventArgs) Handles BtnActivate.Click
        If textPUID.Visible = False Or textPUID.Text = "" Then
            MsgBox("فعالسازی انجام نشد!", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If
        If txtConfirmCode.Visible = False Or txtConfirmCode.Text.Length < 9 Or txtConfirmCode.Text = "کد دریافتی" Then
            MsgBox("کد دریافت شده را به درستی وارد نمایید.", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If
        If TxtSerial.Text.Length < 2 Or txtConfirmCode.Text = "سریال فعال سازی" Then
            MsgBox("سریال فعال سازی را به درستی وارد نمایید.", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If
        If Strings.Left(TxtSerial.Text.Trim.ToLower, PackageCode.Length) <> PackageCode Then
            MsgBox("سریال برای پکیج دیگری می باشد و بر روی این پکیج فعال نیست.", MsgBoxStyle.Critical, "خطا")
            Exit Sub
        End If

        If (xCode <> "") Then
            If txtConfirmCode.Text = AES_decrypt(xCode, LocalKey, LocalIV) Then
                set_setting("version", PUID)
                set_setting("serial", TxtSerial.Text.Trim.ToLower)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnActivateFake_Click(sender As Object, e As EventArgs)
        If textPUID.Visible = False Or textPUID.Text = "" Or txtConfirmCode.Visible = False Or txtConfirmCode.Text = "" Then
            MsgBox("فعالسازی انجام نشد!", MsgBoxStyle.Critical, "خطا")
        End If
    End Sub

    Private Sub LoadOpacity()
        For i As Integer = 1 To 100
            Me.Invoke(New Action(Of Integer)(AddressOf LoadOpacityChild), i)
            System.Threading.Thread.Sleep(3)
        Next
    End Sub

    Private Sub LoadOpacityChild(ByVal input As Integer)
        Me.Opacity = input / 100
    End Sub

    Dim iran As Font = CustomFont.GetInstance(10, FontStyle.Regular)

    Private Sub DlgOfflineRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textPUID.Text = PUID
        textPUID.Left = (Me.Width / 2) - (textPUID.Width / 2)
        TxtSerial.Font = iran
        txtConfirmCode.Font = iran
        Dim t As Thread = New Thread(AddressOf LoadOpacity)
        t.SetApartmentState(ApartmentState.STA)
        t.Start()

        Dim tempThread As Thread = New Thread(AddressOf tempThreadWorker)
        tempThread.Start()
    End Sub

    Private Sub txtConfirmCode_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmCode.GotFocus
        If txtConfirmCode.Text = "کد دریافتی" Then
            txtConfirmCode.Text = ""
            txtConfirmCode.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtConfirmCode_LostFocus(sender As Object, e As EventArgs) Handles txtConfirmCode.LostFocus
        If txtConfirmCode.Text = "" Then
            txtConfirmCode.Text = "کد دریافتی"
            txtConfirmCode.ForeColor = Color.DimGray
        End If
    End Sub

    Private Sub TxtSerial_GotFocus(sender As Object, e As EventArgs) Handles TxtSerial.GotFocus
        If TxtSerial.Text = "سریال فعال سازی" Then
            TxtSerial.Text = ""
            TxtSerial.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TxtSerial_LostFocus(sender As Object, e As EventArgs) Handles TxtSerial.LostFocus
        If TxtSerial.Text = "" Then
            TxtSerial.Text = "سریال فعال سازی"
            TxtSerial.ForeColor = Color.DimGray
            TxtSerial.Font = iran
        End If
    End Sub

    'minimize and close buttons
    Private Sub close_icon_click(sender As Object, e As EventArgs) Handles close_icon.Click
        Me.Close()
    End Sub

End Class

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

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
    End Sub



    Private Sub tempThreadWorker()
        xCode = AES_encrypt(GenerateHash(lblPUID.Text & lblPUID.Text.Length * AscW(Strings.Left(PUID, 1)), lblPUID.Text.Length * 1023), LocalKey, LocalIV)
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
        If (xCode <> "") Then
            If txtConfirmCode.Text = AES_decrypt(xCode, LocalKey, LocalIV) Then
                set_setting("version", PUID)
                set_setting("serial", TxtSerial.Text.Trim.ToLower)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub BtnActivateFake_Click(sender As Object, e As EventArgs)
        If lblPUID.Visible = False Or lblPUID.Text = "" Or txtConfirmCode.Visible = False Or txtConfirmCode.Text = "" Then
            MsgBox("فعالسازی انجام نشد!", MsgBoxStyle.Critical, "خطا")
        End If
    End Sub

    Private Sub LoadOpacity()
        For i As Integer = 1 To 100
            Me.Invoke(New Action(Of Integer)(AddressOf LoadOpacityChild), i)
            System.Threading.Thread.Sleep(10)
        Next
    End Sub

    Private Sub LoadOpacityChild(ByVal input As Integer)
        Me.Opacity = input / 100
    End Sub

    Private Sub DlgOfflineRegister_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPUID.Text = PUID
        lblPUID.Left = (Me.Width / 2) - (lblPUID.Width / 2)
        Dim t As Thread = New Thread(AddressOf LoadOpacity)
        t.SetApartmentState(ApartmentState.STA)
        t.Start()


        Dim tempThread As Thread = New Thread(AddressOf tempThreadWorker)
        tempThread.Start()
    End Sub



    Private Sub txtConfirmCode_GotFocus(sender As Object, e As EventArgs) Handles txtConfirmCode.GotFocus
        If txtConfirmCode.Text = "Code" Then
            txtConfirmCode.Text = ""
        End If
    End Sub

    Private Sub TxtSerial_TextChanged(sender As Object, e As EventArgs) Handles TxtSerial.TextChanged
        If TxtSerial.Text = "Serial ...." Then
            TxtSerial.Text = ""
        End If
    End Sub

    Private Sub TxtSerial_Click(sender As Object, e As EventArgs) Handles TxtSerial.Click
        If TxtSerial.Text = "Serial ...." Then
            TxtSerial.Text = ""
        End If
    End Sub
End Class

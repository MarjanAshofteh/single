Public Class FrmHelp
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Me.Close()
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As EventArgs) Handles Label14.MouseEnter
        TableLayoutPanel1.BackColor = Color.FromArgb(72, 72, 72)
    End Sub

    Private Sub Label14_MouseLeave(sender As Object, e As EventArgs) Handles Label14.MouseLeave
        TableLayoutPanel1.BackColor = Color.FromArgb(80, 80, 80)
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim webAddress As String = "http://civil808.com/shop"
        Process.Start(webAddress)
    End Sub
End Class
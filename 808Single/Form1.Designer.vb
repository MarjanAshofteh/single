<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.BtnActivate = New System.Windows.Forms.PictureBox()
        Me.BtnHelp = New System.Windows.Forms.PictureBox()
        Me.BtnSiteLink = New System.Windows.Forms.PictureBox()
        Me.BtnAbout808 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnActivateOffline = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        CType(Me.BtnActivate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSiteLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAbout808, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnActivateOffline, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Rockwell", 12.25!, System.Drawing.FontStyle.Bold)
        Me.TxtPass.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtPass.Location = New System.Drawing.Point(143, 446)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(199, 20)
        Me.TxtPass.TabIndex = 0
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnActivate
        '
        Me.BtnActivate.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActivate.Location = New System.Drawing.Point(337, 524)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.Size = New System.Drawing.Size(62, 62)
        Me.BtnActivate.TabIndex = 1
        Me.BtnActivate.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnActivate, "فعالسازی آنلاین")
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelp.Location = New System.Drawing.Point(99, 524)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(60, 62)
        Me.BtnHelp.TabIndex = 2
        Me.BtnHelp.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnHelp, "راهنما")
        '
        'BtnSiteLink
        '
        Me.BtnSiteLink.BackColor = System.Drawing.Color.Transparent
        Me.BtnSiteLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSiteLink.Location = New System.Drawing.Point(403, 32)
        Me.BtnSiteLink.Name = "BtnSiteLink"
        Me.BtnSiteLink.Size = New System.Drawing.Size(89, 21)
        Me.BtnSiteLink.TabIndex = 3
        Me.BtnSiteLink.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnSiteLink, "ورود به سایت")
        '
        'BtnAbout808
        '
        Me.BtnAbout808.BackColor = System.Drawing.Color.Transparent
        Me.BtnAbout808.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbout808.Location = New System.Drawing.Point(12, 30)
        Me.BtnAbout808.Name = "BtnAbout808"
        Me.BtnAbout808.Size = New System.Drawing.Size(97, 21)
        Me.BtnAbout808.TabIndex = 4
        Me.BtnAbout808.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnAbout808, "درباره 808")
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global._808Single.My.Resources.Resources._exit
        Me.PictureBox1.Location = New System.Drawing.Point(471, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox1, "خروج")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(161, 173)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(181, 62)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "پیش نمایش (دمو)")
        '
        'BtnActivateOffline
        '
        Me.BtnActivateOffline.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivateOffline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActivateOffline.Location = New System.Drawing.Point(221, 524)
        Me.BtnActivateOffline.Name = "BtnActivateOffline"
        Me.BtnActivateOffline.Size = New System.Drawing.Size(61, 62)
        Me.BtnActivateOffline.TabIndex = 23
        Me.BtnActivateOffline.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnActivateOffline, "فعالسازی آفلاین")
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.Info
        Me.lblStatus.Location = New System.Drawing.Point(71, 492)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(351, 16)
        Me.lblStatus.TabIndex = 21
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Location = New System.Drawing.Point(135, 333)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(159, 18)
        Me.txtPhone.TabIndex = 25
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Location = New System.Drawing.Point(135, 363)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(159, 18)
        Me.txtEmail.TabIndex = 26
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(233, Byte), Integer))
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtName.Location = New System.Drawing.Point(135, 301)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(159, 18)
        Me.txtName.TabIndex = 24
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._808Single.My.Resources.Resources.BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(504, 662)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.BtnActivateOffline)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnAbout808)
        Me.Controls.Add(Me.BtnSiteLink)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnActivate)
        Me.Controls.Add(Me.TxtPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.BtnActivate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSiteLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAbout808, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnActivateOffline, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnActivate As PictureBox
    Friend WithEvents BtnHelp As PictureBox
    Friend WithEvents BtnSiteLink As PictureBox
    Friend WithEvents BtnAbout808 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnActivateOffline As PictureBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
End Class

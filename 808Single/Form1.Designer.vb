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
        Me.close_icon = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnActivateOffline = New System.Windows.Forms.PictureBox()
        Me.minimize_icon = New System.Windows.Forms.PictureBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.PackageTitle = New System.Windows.Forms.Label()
        Me.lblversion = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.BtnActivate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnSiteLink, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnAbout808, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.close_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnActivateOffline, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.minimize_icon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtPass
        '
        Me.TxtPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPass.Font = New System.Drawing.Font("Tahoma", 12.25!)
        Me.TxtPass.ForeColor = System.Drawing.SystemColors.Desktop
        Me.TxtPass.Location = New System.Drawing.Point(159, 403)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(183, 20)
        Me.TxtPass.TabIndex = 3
        Me.TxtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnActivate
        '
        Me.BtnActivate.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActivate.Location = New System.Drawing.Point(155, 436)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.Size = New System.Drawing.Size(193, 39)
        Me.BtnActivate.TabIndex = 1
        Me.BtnActivate.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnActivate, "فعالسازی آنلاین")
        '
        'BtnHelp
        '
        Me.BtnHelp.BackColor = System.Drawing.Color.Transparent
        Me.BtnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHelp.Location = New System.Drawing.Point(198, 612)
        Me.BtnHelp.Name = "BtnHelp"
        Me.BtnHelp.Size = New System.Drawing.Size(105, 22)
        Me.BtnHelp.TabIndex = 2
        Me.BtnHelp.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnHelp, "راهنما")
        '
        'BtnSiteLink
        '
        Me.BtnSiteLink.BackColor = System.Drawing.Color.Transparent
        Me.BtnSiteLink.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSiteLink.Location = New System.Drawing.Point(349, 612)
        Me.BtnSiteLink.Name = "BtnSiteLink"
        Me.BtnSiteLink.Size = New System.Drawing.Size(105, 22)
        Me.BtnSiteLink.TabIndex = 3
        Me.BtnSiteLink.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnSiteLink, "ورود به سایت")
        '
        'BtnAbout808
        '
        Me.BtnAbout808.BackColor = System.Drawing.Color.Transparent
        Me.BtnAbout808.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbout808.Location = New System.Drawing.Point(47, 612)
        Me.BtnAbout808.Name = "BtnAbout808"
        Me.BtnAbout808.Size = New System.Drawing.Size(105, 22)
        Me.BtnAbout808.TabIndex = 4
        Me.BtnAbout808.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnAbout808, "درباره 808")
        '
        'close_icon
        '
        Me.close_icon.BackColor = System.Drawing.Color.Transparent
        Me.close_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.close_icon.Image = Global._808Single.My.Resources.Resources.close
        Me.close_icon.Location = New System.Drawing.Point(479, 3)
        Me.close_icon.Name = "close_icon"
        Me.close_icon.Size = New System.Drawing.Size(21, 21)
        Me.close_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.close_icon.TabIndex = 6
        Me.close_icon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.close_icon, "Close")
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(169, 220)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(165, 45)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 22
        Me.PictureBox2.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox2, "پیش نمایش (دمو)")
        '
        'BtnActivateOffline
        '
        Me.BtnActivateOffline.BackColor = System.Drawing.Color.Transparent
        Me.BtnActivateOffline.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActivateOffline.Location = New System.Drawing.Point(176, 549)
        Me.BtnActivateOffline.Name = "BtnActivateOffline"
        Me.BtnActivateOffline.Size = New System.Drawing.Size(151, 30)
        Me.BtnActivateOffline.TabIndex = 23
        Me.BtnActivateOffline.TabStop = False
        Me.ToolTip1.SetToolTip(Me.BtnActivateOffline, "فعالسازی آفلاین")
        '
        'minimize_icon
        '
        Me.minimize_icon.BackColor = System.Drawing.Color.Transparent
        Me.minimize_icon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.minimize_icon.Image = Global._808Single.My.Resources.Resources.negative
        Me.minimize_icon.Location = New System.Drawing.Point(452, 3)
        Me.minimize_icon.Name = "minimize_icon"
        Me.minimize_icon.Size = New System.Drawing.Size(21, 21)
        Me.minimize_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.minimize_icon.TabIndex = 27
        Me.minimize_icon.TabStop = False
        Me.ToolTip1.SetToolTip(Me.minimize_icon, "Minimize")
        '
        'lblStatus
        '
        Me.lblStatus.BackColor = System.Drawing.Color.Transparent
        Me.lblStatus.Font = New System.Drawing.Font("IRANSans Medium", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblStatus.Location = New System.Drawing.Point(77, 478)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(351, 31)
        Me.lblStatus.TabIndex = 21
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.Color.White
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPhone.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.ForeColor = System.Drawing.Color.Silver
        Me.txtPhone.Location = New System.Drawing.Point(125, 313)
        Me.txtPhone.MaxLength = 11
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(159, 17)
        Me.txtPhone.TabIndex = 1
        Me.txtPhone.Text = "09120000000"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Tai Le", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Silver
        Me.txtEmail.Location = New System.Drawing.Point(125, 343)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(157, 18)
        Me.txtEmail.TabIndex = 2
        Me.txtEmail.Text = "sample@gmail.com"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtName.Font = New System.Drawing.Font("IRANSans", 8.25!)
        Me.txtName.ForeColor = System.Drawing.Color.Silver
        Me.txtName.Location = New System.Drawing.Point(125, 280)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(157, 18)
        Me.txtName.TabIndex = 0
        Me.txtName.Text = "میثم رزمی"
        '
        'PackageTitle
        '
        Me.PackageTitle.BackColor = System.Drawing.Color.Transparent
        Me.PackageTitle.Font = New System.Drawing.Font("IRANSans", 11.0!, System.Drawing.FontStyle.Bold)
        Me.PackageTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.PackageTitle.Location = New System.Drawing.Point(47, 142)
        Me.PackageTitle.Name = "PackageTitle"
        Me.PackageTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.PackageTitle.Size = New System.Drawing.Size(407, 75)
        Me.PackageTitle.TabIndex = 31
        Me.PackageTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.PackageTitle.UseCompatibleTextRendering = True
        '
        'lblversion
        '
        Me.lblversion.AutoSize = True
        Me.lblversion.BackColor = System.Drawing.Color.Transparent
        Me.lblversion.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblversion.Location = New System.Drawing.Point(51, 646)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(23, 13)
        Me.lblversion.TabIndex = 33
        Me.lblversion.Text = "2.0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.Location = New System.Drawing.Point(3, 646)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 13)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "version"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._808Single.My.Resources.Resources._single
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(504, 662)
        Me.Controls.Add(Me.lblversion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.PackageTitle)
        Me.Controls.Add(Me.minimize_icon)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.BtnActivateOffline)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.close_icon)
        Me.Controls.Add(Me.BtnAbout808)
        Me.Controls.Add(Me.BtnSiteLink)
        Me.Controls.Add(Me.BtnHelp)
        Me.Controls.Add(Me.BtnActivate)
        Me.Controls.Add(Me.TxtPass)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "808 single Lock"
        CType(Me.BtnActivate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnHelp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnSiteLink, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnAbout808, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.close_icon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnActivateOffline, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.minimize_icon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtPass As TextBox
    Friend WithEvents BtnActivate As PictureBox
    Friend WithEvents BtnHelp As PictureBox
    Friend WithEvents BtnSiteLink As PictureBox
    Friend WithEvents BtnAbout808 As PictureBox
    Friend WithEvents close_icon As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents lblStatus As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnActivateOffline As PictureBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents minimize_icon As PictureBox
    Friend WithEvents PackageTitle As Label
    Friend WithEvents lblversion As Label
    Friend WithEvents Label11 As Label
End Class

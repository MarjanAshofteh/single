<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHelp))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.iran = New System.Windows.Forms.PictureBox()
        Me.codec = New System.Windows.Forms.PictureBox()
        Me.dotnet = New System.Windows.Forms.PictureBox()
        Me.btn_about = New System.Windows.Forms.PictureBox()
        Me.btn_site = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.iran, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.codec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dotnet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_about, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_site, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global._808Single.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(726, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(21, 21)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 385)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 21)
        Me.Button1.TabIndex = 8
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(206, 591)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(338, 58)
        Me.Button2.TabIndex = 9
        Me.Button2.UseVisualStyleBackColor = False
        '
        'iran
        '
        Me.iran.BackColor = System.Drawing.Color.Transparent
        Me.iran.Cursor = System.Windows.Forms.Cursors.Hand
        Me.iran.Location = New System.Drawing.Point(334, 174)
        Me.iran.Name = "iran"
        Me.iran.Size = New System.Drawing.Size(106, 27)
        Me.iran.TabIndex = 20
        Me.iran.TabStop = False
        '
        'codec
        '
        Me.codec.BackColor = System.Drawing.Color.Transparent
        Me.codec.Cursor = System.Windows.Forms.Cursors.Hand
        Me.codec.Location = New System.Drawing.Point(182, 174)
        Me.codec.Name = "codec"
        Me.codec.Size = New System.Drawing.Size(86, 27)
        Me.codec.TabIndex = 19
        Me.codec.TabStop = False
        '
        'dotnet
        '
        Me.dotnet.BackColor = System.Drawing.Color.Transparent
        Me.dotnet.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dotnet.Location = New System.Drawing.Point(22, 174)
        Me.dotnet.Name = "dotnet"
        Me.dotnet.Size = New System.Drawing.Size(90, 27)
        Me.dotnet.TabIndex = 18
        Me.dotnet.TabStop = False
        '
        'btn_about
        '
        Me.btn_about.BackColor = System.Drawing.Color.Transparent
        Me.btn_about.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_about.Location = New System.Drawing.Point(24, 588)
        Me.btn_about.Name = "btn_about"
        Me.btn_about.Size = New System.Drawing.Size(118, 27)
        Me.btn_about.TabIndex = 22
        Me.btn_about.TabStop = False
        '
        'btn_site
        '
        Me.btn_site.BackColor = System.Drawing.Color.Transparent
        Me.btn_site.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_site.Location = New System.Drawing.Point(613, 588)
        Me.btn_site.Name = "btn_site"
        Me.btn_site.Size = New System.Drawing.Size(120, 27)
        Me.btn_site.TabIndex = 21
        Me.btn_site.TabStop = False
        '
        'FrmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global._808Single.My.Resources.Resources.help
        Me.ClientSize = New System.Drawing.Size(750, 650)
        Me.Controls.Add(Me.btn_about)
        Me.Controls.Add(Me.btn_site)
        Me.Controls.Add(Me.iran)
        Me.Controls.Add(Me.codec)
        Me.Controls.Add(Me.dotnet)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHelp"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHelp"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.iran, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.codec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dotnet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_about, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_site, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents iran As PictureBox
    Friend WithEvents codec As PictureBox
    Friend WithEvents dotnet As PictureBox
    Friend WithEvents btn_about As PictureBox
    Friend WithEvents btn_site As PictureBox
End Class

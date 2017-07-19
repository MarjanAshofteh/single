<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOfflineRegister
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPUID = New System.Windows.Forms.Label()
        Me.txtConfirmCode = New System.Windows.Forms.TextBox()
        Me.BtnActivate = New System.Windows.Forms.Button()
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox5, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(369, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(78, 36)
        Me.TableLayoutPanel1.TabIndex = 25
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.BackgroundImage = Global._808Single.My.Resources.Resources._exit
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Location = New System.Drawing.Point(42, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 19)
        Me.PictureBox5.TabIndex = 22
        Me.PictureBox5.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.LightGray
        Me.GroupBox1.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(424, 109)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "راهنما"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(245, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(88, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "021-88272694"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(330, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "*شماره تماس: "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(64, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(354, 36)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "- در صورت عدم دسترسی به اینترنت با شرکت 808 تماس گرفته و درخواست فعالسازی آفلاین " &
    "نمایید"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(64, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(354, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "- در صورت دسترسی به اینترنت لطفا از فعالساز اینترنتی استفاده کنید"
        '
        'lblPUID
        '
        Me.lblPUID.AutoSize = True
        Me.lblPUID.BackColor = System.Drawing.Color.Transparent
        Me.lblPUID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPUID.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblPUID.Location = New System.Drawing.Point(33, 274)
        Me.lblPUID.Name = "lblPUID"
        Me.lblPUID.Size = New System.Drawing.Size(0, 24)
        Me.lblPUID.TabIndex = 27
        '
        'txtConfirmCode
        '
        Me.txtConfirmCode.BackColor = System.Drawing.Color.MediumTurquoise
        Me.txtConfirmCode.Font = New System.Drawing.Font("Lucida Fax", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConfirmCode.ForeColor = System.Drawing.Color.Indigo
        Me.txtConfirmCode.Location = New System.Drawing.Point(59, 327)
        Me.txtConfirmCode.Multiline = True
        Me.txtConfirmCode.Name = "txtConfirmCode"
        Me.txtConfirmCode.Size = New System.Drawing.Size(336, 49)
        Me.txtConfirmCode.TabIndex = 34
        Me.txtConfirmCode.Text = "Code"
        Me.txtConfirmCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnActivate
        '
        Me.BtnActivate.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.BtnActivate.Location = New System.Drawing.Point(23, 382)
        Me.BtnActivate.Name = "BtnActivate"
        Me.BtnActivate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BtnActivate.Size = New System.Drawing.Size(413, 42)
        Me.BtnActivate.TabIndex = 40
        Me.BtnActivate.Text = "فعال کن!"
        Me.BtnActivate.UseVisualStyleBackColor = True
        '
        'TxtSerial
        '
        Me.TxtSerial.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TxtSerial.ForeColor = System.Drawing.SystemColors.Info
        Me.TxtSerial.Location = New System.Drawing.Point(59, 301)
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(336, 20)
        Me.TxtSerial.TabIndex = 32
        Me.TxtSerial.Text = "Serial ...."
        '
        'FrmOfflineRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._808Single.My.Resources.Resources.offline
        Me.ClientSize = New System.Drawing.Size(459, 441)
        Me.Controls.Add(Me.TxtSerial)
        Me.Controls.Add(Me.BtnActivate)
        Me.Controls.Add(Me.txtConfirmCode)
        Me.Controls.Add(Me.lblPUID)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOfflineRegister"
        Me.Opacity = 0R
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DlgOfflineRegister"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPUID As Label
    Friend WithEvents txtConfirmCode As TextBox
    Friend WithEvents BtnActivate As Button
    Friend WithEvents TxtSerial As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class

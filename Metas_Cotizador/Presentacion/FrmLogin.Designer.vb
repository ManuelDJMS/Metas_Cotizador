<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLogin
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaLinkLabel2 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaDragControl1 = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.txtPass = New Guna.UI.WinForms.GunaTextBox()
        Me.txtUser = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinkLabel1 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaLinkLabel3 = New Guna.UI.WinForms.GunaLinkLabel()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Gainsboro
        Me.GunaSeparator1.Location = New System.Drawing.Point(89, 326)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(217, 10)
        Me.GunaSeparator1.TabIndex = 5
        '
        'GunaLinkLabel2
        '
        Me.GunaLinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLinkLabel2.AutoSize = True
        Me.GunaLinkLabel2.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.GunaLinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GunaLinkLabel2.LinkColor = System.Drawing.Color.Gray
        Me.GunaLinkLabel2.Location = New System.Drawing.Point(90, 339)
        Me.GunaLinkLabel2.Name = "GunaLinkLabel2"
        Me.GunaLinkLabel2.Size = New System.Drawing.Size(160, 12)
        Me.GunaLinkLabel2.TabIndex = 6
        Me.GunaLinkLabel2.TabStop = True
        Me.GunaLinkLabel2.Text = "METAS METRÓLOGOS ASOCIADOS"
        '
        'GunaDragControl1
        '
        Me.GunaDragControl1.TargetControl = Me.GunaPanel1
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaPanel1.BackgroundImage = Global.Metas_Cotizador.My.Resources.Resources.ccc
        Me.GunaPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaPanel1.Controls.Add(Me.GunaButton1)
        Me.GunaPanel1.Controls.Add(Me.txtPass)
        Me.GunaPanel1.Controls.Add(Me.txtUser)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(390, 320)
        Me.GunaPanel1.TabIndex = 0
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(148, 227)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.OnPressedDepth = 0
        Me.GunaButton1.Radius = 6
        Me.GunaButton1.Size = New System.Drawing.Size(103, 36)
        Me.GunaButton1.TabIndex = 5
        Me.GunaButton1.Text = "Ingresar"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.Transparent
        Me.txtPass.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtPass.BorderColor = System.Drawing.Color.Silver
        Me.txtPass.BorderSize = 0
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPass.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPass.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Silver
        Me.txtPass.Location = New System.Drawing.Point(72, 172)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPass.Radius = 6
        Me.txtPass.Size = New System.Drawing.Size(255, 37)
        Me.txtPass.TabIndex = 4
        Me.txtPass.Text = "password"
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPass.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.Transparent
        Me.txtUser.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUser.BorderColor = System.Drawing.Color.Silver
        Me.txtUser.BorderSize = 0
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUser.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtUser.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Silver
        Me.txtUser.Location = New System.Drawing.Point(72, 124)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.Radius = 6
        Me.txtUser.Size = New System.Drawing.Size(255, 37)
        Me.txtUser.TabIndex = 3
        Me.txtUser.Text = "Nombre de Usuario"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = Global.Metas_Cotizador.My.Resources.Resources.metas_esta
        Me.GunaPictureBox1.Location = New System.Drawing.Point(253, 5)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(132, 51)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 2
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.White
        Me.GunaLabel1.Location = New System.Drawing.Point(95, 75)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(207, 32)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "INICIO DE SESIÓN"
        '
        'GunaLinkLabel1
        '
        Me.GunaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLinkLabel1.AutoSize = True
        Me.GunaLinkLabel1.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.GunaLinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GunaLinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.GunaLinkLabel1.Location = New System.Drawing.Point(269, 339)
        Me.GunaLinkLabel1.Name = "GunaLinkLabel1"
        Me.GunaLinkLabel1.Size = New System.Drawing.Size(31, 12)
        Me.GunaLinkLabel1.TabIndex = 7
        Me.GunaLinkLabel1.TabStop = True
        Me.GunaLinkLabel1.Text = "1.0.0.0"
        '
        'GunaLinkLabel3
        '
        Me.GunaLinkLabel3.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaLinkLabel3.AutoSize = True
        Me.GunaLinkLabel3.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.GunaLinkLabel3.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.GunaLinkLabel3.LinkColor = System.Drawing.Color.Gray
        Me.GunaLinkLabel3.Location = New System.Drawing.Point(256, 339)
        Me.GunaLinkLabel3.Name = "GunaLinkLabel3"
        Me.GunaLinkLabel3.Size = New System.Drawing.Size(7, 12)
        Me.GunaLinkLabel3.TabIndex = 8
        Me.GunaLinkLabel3.TabStop = True
        Me.GunaLinkLabel3.Text = "|"
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.GunaAnimateWindow1.Interval = 800
        Me.GunaAnimateWindow1.TargetControl = Me
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(390, 368)
        Me.Controls.Add(Me.GunaLinkLabel3)
        Me.Controls.Add(Me.GunaLinkLabel1)
        Me.Controls.Add(Me.GunaLinkLabel2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents txtPass As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtUser As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLinkLabel3 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaLinkLabel1 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
End Class

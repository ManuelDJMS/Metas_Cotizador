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
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.f = New Guna.UI.WinForms.GunaTextBox()
        Me.h = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbVersion = New Guna.UI.WinForms.GunaLinkLabel()
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
        Me.GunaPanel1.Controls.Add(Me.txtpass)
        Me.GunaPanel1.Controls.Add(Me.txtUser)
        Me.GunaPanel1.Controls.Add(Me.GunaButton1)
        Me.GunaPanel1.Controls.Add(Me.f)
        Me.GunaPanel1.Controls.Add(Me.h)
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(390, 320)
        Me.GunaPanel1.TabIndex = 0
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtpass.Location = New System.Drawing.Point(78, 178)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(241, 24)
        Me.txtpass.TabIndex = 7
        Me.txtpass.Text = "Contraseña"
        Me.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtpass.UseSystemPasswordChar = True
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUser.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txtUser.Location = New System.Drawing.Point(79, 130)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(241, 24)
        Me.txtUser.TabIndex = 6
        Me.txtUser.Text = "Nombre de Usuario"
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
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
        'f
        '
        Me.f.BackColor = System.Drawing.Color.Transparent
        Me.f.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.f.BorderColor = System.Drawing.Color.Silver
        Me.f.BorderSize = 0
        Me.f.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.f.Enabled = False
        Me.f.FocusedBaseColor = System.Drawing.Color.White
        Me.f.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.f.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.f.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.f.ForeColor = System.Drawing.Color.Silver
        Me.f.Location = New System.Drawing.Point(72, 172)
        Me.f.Name = "f"
        Me.f.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.f.Radius = 6
        Me.f.Size = New System.Drawing.Size(255, 37)
        Me.f.TabIndex = 4
        Me.f.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'h
        '
        Me.h.BackColor = System.Drawing.Color.Transparent
        Me.h.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.h.BorderColor = System.Drawing.Color.Silver
        Me.h.BorderSize = 0
        Me.h.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.h.Enabled = False
        Me.h.FocusedBaseColor = System.Drawing.Color.White
        Me.h.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.h.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.h.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h.ForeColor = System.Drawing.Color.Silver
        Me.h.Location = New System.Drawing.Point(72, 124)
        Me.h.Name = "h"
        Me.h.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.h.Radius = 6
        Me.h.Size = New System.Drawing.Size(255, 37)
        Me.h.TabIndex = 3
        Me.h.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        'lbVersion
        '
        Me.lbVersion.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Font = New System.Drawing.Font("Segoe UI", 7.0!)
        Me.lbVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbVersion.LinkColor = System.Drawing.Color.Gray
        Me.lbVersion.Location = New System.Drawing.Point(269, 339)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(31, 12)
        Me.lbVersion.TabIndex = 7
        Me.lbVersion.TabStop = True
        Me.lbVersion.Text = "1.0.0.2"
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
        Me.Controls.Add(Me.lbVersion)
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
    Friend WithEvents f As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents h As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLinkLabel2 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaDragControl1 As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents GunaLinkLabel3 As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents lbVersion As Guna.UI.WinForms.GunaLinkLabel
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtpass As TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHOME
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHOME))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.PL_Confirmacion = New System.Windows.Forms.Panel()
        Me.PL_Recordatorio = New System.Windows.Forms.Panel()
        Me.PL_PreFact = New System.Windows.Forms.Panel()
        Me.PL_OrdenVenta = New System.Windows.Forms.Panel()
        Me.PL_Cotizacion = New System.Windows.Forms.Panel()
        Me.PL_Contactos = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConfirmacion = New System.Windows.Forms.Button()
        Me.btnRecordatorios = New System.Windows.Forms.Button()
        Me.btnPreFact = New System.Windows.Forms.Button()
        Me.btnOrdenVenta = New System.Windows.Forms.Button()
        Me.btnCotizacion = New System.Windows.Forms.Button()
        Me.btnContactos = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.PanelContenedor.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.PanelFormularios)
        Me.PanelContenedor.Controls.Add(Me.PanelMenu)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(1366, 730)
        Me.PanelContenedor.TabIndex = 0
        '
        'PanelFormularios
        '
        Me.PanelFormularios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelFormularios.Location = New System.Drawing.Point(200, 41)
        Me.PanelFormularios.Name = "PanelFormularios"
        Me.PanelFormularios.Size = New System.Drawing.Size(1166, 689)
        Me.PanelFormularios.TabIndex = 6
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.White
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.Label23)
        Me.PanelMenu.Controls.Add(Me.btnConfirmacion)
        Me.PanelMenu.Controls.Add(Me.PL_Confirmacion)
        Me.PanelMenu.Controls.Add(Me.btnRecordatorios)
        Me.PanelMenu.Controls.Add(Me.PL_Recordatorio)
        Me.PanelMenu.Controls.Add(Me.btnPreFact)
        Me.PanelMenu.Controls.Add(Me.PL_PreFact)
        Me.PanelMenu.Controls.Add(Me.btnOrdenVenta)
        Me.PanelMenu.Controls.Add(Me.PL_OrdenVenta)
        Me.PanelMenu.Controls.Add(Me.btnCotizacion)
        Me.PanelMenu.Controls.Add(Me.PL_Cotizacion)
        Me.PanelMenu.Controls.Add(Me.btnContactos)
        Me.PanelMenu.Controls.Add(Me.PL_Contactos)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 41)
        Me.PanelMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(200, 689)
        Me.PanelMenu.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(3, 667)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(191, 15)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Metrólogos Asociados S.A. de C.V."
        '
        'PL_Confirmacion
        '
        Me.PL_Confirmacion.BackColor = System.Drawing.Color.White
        Me.PL_Confirmacion.Location = New System.Drawing.Point(190, 373)
        Me.PL_Confirmacion.Name = "PL_Confirmacion"
        Me.PL_Confirmacion.Size = New System.Drawing.Size(10, 53)
        Me.PL_Confirmacion.TabIndex = 53
        '
        'PL_Recordatorio
        '
        Me.PL_Recordatorio.BackColor = System.Drawing.Color.White
        Me.PL_Recordatorio.Location = New System.Drawing.Point(190, 319)
        Me.PL_Recordatorio.Name = "PL_Recordatorio"
        Me.PL_Recordatorio.Size = New System.Drawing.Size(10, 53)
        Me.PL_Recordatorio.TabIndex = 51
        '
        'PL_PreFact
        '
        Me.PL_PreFact.BackColor = System.Drawing.Color.White
        Me.PL_PreFact.Location = New System.Drawing.Point(190, 265)
        Me.PL_PreFact.Name = "PL_PreFact"
        Me.PL_PreFact.Size = New System.Drawing.Size(10, 53)
        Me.PL_PreFact.TabIndex = 49
        '
        'PL_OrdenVenta
        '
        Me.PL_OrdenVenta.BackColor = System.Drawing.Color.White
        Me.PL_OrdenVenta.Location = New System.Drawing.Point(190, 211)
        Me.PL_OrdenVenta.Name = "PL_OrdenVenta"
        Me.PL_OrdenVenta.Size = New System.Drawing.Size(10, 53)
        Me.PL_OrdenVenta.TabIndex = 47
        '
        'PL_Cotizacion
        '
        Me.PL_Cotizacion.BackColor = System.Drawing.Color.White
        Me.PL_Cotizacion.Location = New System.Drawing.Point(190, 157)
        Me.PL_Cotizacion.Name = "PL_Cotizacion"
        Me.PL_Cotizacion.Size = New System.Drawing.Size(10, 53)
        Me.PL_Cotizacion.TabIndex = 45
        '
        'PL_Contactos
        '
        Me.PL_Contactos.BackColor = System.Drawing.Color.White
        Me.PL_Contactos.Location = New System.Drawing.Point(190, 103)
        Me.PL_Contactos.Name = "PL_Contactos"
        Me.PL_Contactos.Size = New System.Drawing.Size(10, 53)
        Me.PL_Contactos.TabIndex = 43
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.PanelBarraTitulo.Controls.Add(Me.btnRestaurar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnMaximizar)
        Me.PanelBarraTitulo.Controls.Add(Me.btnCerrar)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(1366, 41)
        Me.PanelBarraTitulo.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Metas_Cotizador.My.Resources.Resources.metas_esta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'btnConfirmacion
        '
        Me.btnConfirmacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmacion.FlatAppearance.BorderSize = 0
        Me.btnConfirmacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfirmacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfirmacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmacion.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnConfirmacion.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_new_post_48
        Me.btnConfirmacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmacion.Location = New System.Drawing.Point(0, 373)
        Me.btnConfirmacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmacion.Name = "btnConfirmacion"
        Me.btnConfirmacion.Size = New System.Drawing.Size(193, 53)
        Me.btnConfirmacion.TabIndex = 54
        Me.btnConfirmacion.Text = "Confirmación de Datos"
        Me.btnConfirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmacion.UseVisualStyleBackColor = True
        '
        'btnRecordatorios
        '
        Me.btnRecordatorios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecordatorios.FlatAppearance.BorderSize = 0
        Me.btnRecordatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRecordatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnRecordatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRecordatorios.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecordatorios.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnRecordatorios.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_notification_48__1_
        Me.btnRecordatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecordatorios.Location = New System.Drawing.Point(0, 319)
        Me.btnRecordatorios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecordatorios.Name = "btnRecordatorios"
        Me.btnRecordatorios.Size = New System.Drawing.Size(193, 53)
        Me.btnRecordatorios.TabIndex = 52
        Me.btnRecordatorios.Text = "Recordatorio de Cotización"
        Me.btnRecordatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecordatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecordatorios.UseVisualStyleBackColor = True
        '
        'btnPreFact
        '
        Me.btnPreFact.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPreFact.FlatAppearance.BorderSize = 0
        Me.btnPreFact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPreFact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnPreFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPreFact.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreFact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnPreFact.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_view_48
        Me.btnPreFact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreFact.Location = New System.Drawing.Point(0, 265)
        Me.btnPreFact.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreFact.Name = "btnPreFact"
        Me.btnPreFact.Size = New System.Drawing.Size(193, 53)
        Me.btnPreFact.TabIndex = 50
        Me.btnPreFact.Text = "Ordenes de Trabajo"
        Me.btnPreFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreFact.UseVisualStyleBackColor = True
        '
        'btnOrdenVenta
        '
        Me.btnOrdenVenta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOrdenVenta.FlatAppearance.BorderSize = 0
        Me.btnOrdenVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnOrdenVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnOrdenVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOrdenVenta.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrdenVenta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnOrdenVenta.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_numbered_list_48
        Me.btnOrdenVenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOrdenVenta.Location = New System.Drawing.Point(0, 211)
        Me.btnOrdenVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrdenVenta.Name = "btnOrdenVenta"
        Me.btnOrdenVenta.Size = New System.Drawing.Size(193, 53)
        Me.btnOrdenVenta.TabIndex = 48
        Me.btnOrdenVenta.Text = "Órdenes de Venta"
        Me.btnOrdenVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrdenVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrdenVenta.UseVisualStyleBackColor = True
        '
        'btnCotizacion
        '
        Me.btnCotizacion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCotizacion.FlatAppearance.BorderSize = 0
        Me.btnCotizacion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCotizacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotizacion.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCotizacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCotizacion.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_purchase_order_48
        Me.btnCotizacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCotizacion.Location = New System.Drawing.Point(0, 157)
        Me.btnCotizacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCotizacion.Name = "btnCotizacion"
        Me.btnCotizacion.Size = New System.Drawing.Size(193, 53)
        Me.btnCotizacion.TabIndex = 46
        Me.btnCotizacion.Text = "Cotización"
        Me.btnCotizacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCotizacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCotizacion.UseVisualStyleBackColor = True
        '
        'btnContactos
        '
        Me.btnContactos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnContactos.FlatAppearance.BorderSize = 0
        Me.btnContactos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnContactos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnContactos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnContactos.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContactos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnContactos.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_contacts_48
        Me.btnContactos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContactos.Location = New System.Drawing.Point(0, 103)
        Me.btnContactos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnContactos.Name = "btnContactos"
        Me.btnContactos.Size = New System.Drawing.Size(193, 53)
        Me.btnContactos.TabIndex = 44
        Me.btnContactos.Text = "Clientes"
        Me.btnContactos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnContactos.UseVisualStyleBackColor = True
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_restore_window_50
        Me.btnRestaurar.Location = New System.Drawing.Point(1298, 5)
        Me.btnRestaurar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(30, 30)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRestaurar.TabIndex = 7
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_minimize_window_50
        Me.btnMinimizar.Location = New System.Drawing.Point(1264, 5)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 6
        Me.btnMinimizar.TabStop = False
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.Location = New System.Drawing.Point(1298, 5)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(30, 30)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 5
        Me.btnMaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_close_window_50
        Me.btnCerrar.Location = New System.Drawing.Point(1332, 5)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(30, 30)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.TabStop = False
        '
        'FrmHOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 730)
        Me.Controls.Add(Me.PanelContenedor)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmHOME2"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        Me.PanelBarraTitulo.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelFormularios As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBarraTitulo As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnMaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label23 As Label
    Friend WithEvents btnConfirmacion As Button
    Friend WithEvents PL_Confirmacion As Panel
    Friend WithEvents btnRecordatorios As Button
    Friend WithEvents PL_Recordatorio As Panel
    Friend WithEvents btnPreFact As Button
    Friend WithEvents PL_PreFact As Panel
    Friend WithEvents btnOrdenVenta As Button
    Friend WithEvents PL_OrdenVenta As Panel
    Friend WithEvents btnCotizacion As Button
    Friend WithEvents PL_Cotizacion As Panel
    Friend WithEvents btnContactos As Button
    Friend WithEvents PL_Contactos As Panel
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHOME))
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.PanelFormularios = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btnConfirmacionOT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCotInformal = New System.Windows.Forms.Button()
        Me.Pl_CotInformal = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnConfirmacion = New System.Windows.Forms.Button()
        Me.PL_Confirmacion = New System.Windows.Forms.Panel()
        Me.btnRecordatorios = New System.Windows.Forms.Button()
        Me.PL_Recordatorio = New System.Windows.Forms.Panel()
        Me.btnPreFact = New System.Windows.Forms.Button()
        Me.PL_PreFact = New System.Windows.Forms.Panel()
        Me.btnOrdenVenta = New System.Windows.Forms.Button()
        Me.PL_OrdenVenta = New System.Windows.Forms.Panel()
        Me.btnCotizacion = New System.Windows.Forms.Button()
        Me.PL_Cotizacion = New System.Windows.Forms.Panel()
        Me.btnContactos = New System.Windows.Forms.Button()
        Me.PL_Contactos = New System.Windows.Forms.Panel()
        Me.PanelBarraTitulo = New System.Windows.Forms.Panel()
        Me.lbInicio = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnMaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.PanelContenedor.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelMenu.Controls.Add(Me.btnConfirmacionOT)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.btnCotInformal)
        Me.PanelMenu.Controls.Add(Me.Pl_CotInformal)
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
        'btnConfirmacionOT
        '
        Me.btnConfirmacionOT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmacionOT.FlatAppearance.BorderSize = 0
        Me.btnConfirmacionOT.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfirmacionOT.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnConfirmacionOT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmacionOT.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmacionOT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnConfirmacionOT.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_purchase_order_481
        Me.btnConfirmacionOT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConfirmacionOT.Location = New System.Drawing.Point(0, 483)
        Me.btnConfirmacionOT.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmacionOT.Name = "btnConfirmacionOT"
        Me.btnConfirmacionOT.Size = New System.Drawing.Size(193, 76)
        Me.btnConfirmacionOT.TabIndex = 58
        Me.btnConfirmacionOT.Text = "Confirmación de Orden de Trabajo"
        Me.btnConfirmacionOT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmacionOT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmacionOT.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(190, 483)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(10, 53)
        Me.Panel1.TabIndex = 57
        '
        'btnCotInformal
        '
        Me.btnCotInformal.BackColor = System.Drawing.Color.White
        Me.btnCotInformal.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCotInformal.FlatAppearance.BorderSize = 0
        Me.btnCotInformal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCotInformal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen
        Me.btnCotInformal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCotInformal.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCotInformal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btnCotInformal.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_file_48
        Me.btnCotInformal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCotInformal.Location = New System.Drawing.Point(0, 210)
        Me.btnCotInformal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCotInformal.Name = "btnCotInformal"
        Me.btnCotInformal.Size = New System.Drawing.Size(193, 53)
        Me.btnCotInformal.TabIndex = 56
        Me.btnCotInformal.Text = "Cotización Informal"
        Me.btnCotInformal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCotInformal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCotInformal.UseVisualStyleBackColor = False
        '
        'Pl_CotInformal
        '
        Me.Pl_CotInformal.BackColor = System.Drawing.Color.White
        Me.Pl_CotInformal.Location = New System.Drawing.Point(190, 210)
        Me.Pl_CotInformal.Name = "Pl_CotInformal"
        Me.Pl_CotInformal.Size = New System.Drawing.Size(10, 53)
        Me.Pl_CotInformal.TabIndex = 48
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
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(3, 667)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(191, 15)
        Me.Label23.TabIndex = 55
        Me.Label23.Text = "Metrólogos Asociados S.A. de C.V."
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
        Me.btnConfirmacion.Location = New System.Drawing.Point(0, 426)
        Me.btnConfirmacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfirmacion.Name = "btnConfirmacion"
        Me.btnConfirmacion.Size = New System.Drawing.Size(193, 53)
        Me.btnConfirmacion.TabIndex = 54
        Me.btnConfirmacion.Text = "Confirmación de Datos"
        Me.btnConfirmacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnConfirmacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmacion.UseVisualStyleBackColor = True
        '
        'PL_Confirmacion
        '
        Me.PL_Confirmacion.BackColor = System.Drawing.Color.White
        Me.PL_Confirmacion.Location = New System.Drawing.Point(190, 426)
        Me.PL_Confirmacion.Name = "PL_Confirmacion"
        Me.PL_Confirmacion.Size = New System.Drawing.Size(10, 53)
        Me.PL_Confirmacion.TabIndex = 53
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
        Me.btnRecordatorios.Location = New System.Drawing.Point(0, 372)
        Me.btnRecordatorios.Margin = New System.Windows.Forms.Padding(2)
        Me.btnRecordatorios.Name = "btnRecordatorios"
        Me.btnRecordatorios.Size = New System.Drawing.Size(193, 53)
        Me.btnRecordatorios.TabIndex = 52
        Me.btnRecordatorios.Text = "Recordatorio de Cotización"
        Me.btnRecordatorios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecordatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnRecordatorios.UseVisualStyleBackColor = True
        '
        'PL_Recordatorio
        '
        Me.PL_Recordatorio.BackColor = System.Drawing.Color.White
        Me.PL_Recordatorio.Location = New System.Drawing.Point(190, 372)
        Me.PL_Recordatorio.Name = "PL_Recordatorio"
        Me.PL_Recordatorio.Size = New System.Drawing.Size(10, 53)
        Me.PL_Recordatorio.TabIndex = 51
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
        Me.btnPreFact.Location = New System.Drawing.Point(0, 318)
        Me.btnPreFact.Margin = New System.Windows.Forms.Padding(2)
        Me.btnPreFact.Name = "btnPreFact"
        Me.btnPreFact.Size = New System.Drawing.Size(193, 53)
        Me.btnPreFact.TabIndex = 50
        Me.btnPreFact.Text = "Ordenes de Trabajo"
        Me.btnPreFact.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPreFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPreFact.UseVisualStyleBackColor = True
        '
        'PL_PreFact
        '
        Me.PL_PreFact.BackColor = System.Drawing.Color.White
        Me.PL_PreFact.Location = New System.Drawing.Point(190, 318)
        Me.PL_PreFact.Name = "PL_PreFact"
        Me.PL_PreFact.Size = New System.Drawing.Size(10, 53)
        Me.PL_PreFact.TabIndex = 49
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
        Me.btnOrdenVenta.Location = New System.Drawing.Point(0, 264)
        Me.btnOrdenVenta.Margin = New System.Windows.Forms.Padding(2)
        Me.btnOrdenVenta.Name = "btnOrdenVenta"
        Me.btnOrdenVenta.Size = New System.Drawing.Size(193, 53)
        Me.btnOrdenVenta.TabIndex = 48
        Me.btnOrdenVenta.Text = "Órdenes de Venta"
        Me.btnOrdenVenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnOrdenVenta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnOrdenVenta.UseVisualStyleBackColor = True
        '
        'PL_OrdenVenta
        '
        Me.PL_OrdenVenta.BackColor = System.Drawing.Color.White
        Me.PL_OrdenVenta.Location = New System.Drawing.Point(190, 264)
        Me.PL_OrdenVenta.Name = "PL_OrdenVenta"
        Me.PL_OrdenVenta.Size = New System.Drawing.Size(10, 53)
        Me.PL_OrdenVenta.TabIndex = 47
        '
        'btnCotizacion
        '
        Me.btnCotizacion.BackColor = System.Drawing.Color.White
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
        Me.btnCotizacion.UseVisualStyleBackColor = False
        '
        'PL_Cotizacion
        '
        Me.PL_Cotizacion.BackColor = System.Drawing.Color.White
        Me.PL_Cotizacion.Location = New System.Drawing.Point(190, 157)
        Me.PL_Cotizacion.Name = "PL_Cotizacion"
        Me.PL_Cotizacion.Size = New System.Drawing.Size(10, 53)
        Me.PL_Cotizacion.TabIndex = 45
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
        Me.PanelBarraTitulo.Controls.Add(Me.lbInicio)
        Me.PanelBarraTitulo.Controls.Add(Me.PictureBox2)
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
        'lbInicio
        '
        Me.lbInicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbInicio.AutoSize = True
        Me.lbInicio.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbInicio.ForeColor = System.Drawing.Color.White
        Me.lbInicio.Location = New System.Drawing.Point(1173, 9)
        Me.lbInicio.Name = "lbInicio"
        Me.lbInicio.Size = New System.Drawing.Size(69, 21)
        Me.lbInicio.TabIndex = 9
        Me.lbInicio.Text = "Manuel"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_verified_account_48
        Me.PictureBox2.Location = New System.Drawing.Point(1133, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
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
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        Me.GunaAnimateWindow1.Interval = 800
        Me.GunaAnimateWindow1.TargetControl = Me
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
        Me.MinimumSize = New System.Drawing.Size(1366, 730)
        Me.Name = "FrmHOME"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelMenu.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lbInicio As Label
    Friend WithEvents btnCotInformal As Button
    Friend WithEvents Pl_CotInformal As Panel
    Friend WithEvents btnConfirmacionOT As Button
    Friend WithEvents Panel1 As Panel
End Class

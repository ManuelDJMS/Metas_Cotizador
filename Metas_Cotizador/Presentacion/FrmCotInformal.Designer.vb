<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCotInformal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCotInformal))
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        Me.Tab2018 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextCorreo = New System.Windows.Forms.TextBox()
        Me.TextTelefono = New System.Windows.Forms.TextBox()
        Me.TextEstado = New System.Windows.Forms.TextBox()
        Me.TextCiudad = New System.Windows.Forms.TextBox()
        Me.TextDireccion = New System.Windows.Forms.TextBox()
        Me.TextRFC = New System.Windows.Forms.TextBox()
        Me.TextEmpresa = New System.Windows.Forms.TextBox()
        Me.TextContacto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txtNombreDeContacto = New System.Windows.Forms.Label()
        Me.btCotizacion = New System.Windows.Forms.Button()
        Me.btCerrar = New System.Windows.Forms.PictureBox()
        Me.btCargarArticulos = New System.Windows.Forms.PictureBox()
        Me.DgAgregar = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCotizaciones = New System.Windows.Forms.DataGridView()
        Me.TextArticulo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.TextID = New System.Windows.Forms.TextBox()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.s = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabConsulta.SuspendLayout()
        Me.Tab2018.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btCargarArticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabConsulta
        '
        Me.TabConsulta.AllowDrop = True
        Me.TabConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabConsulta.Controls.Add(Me.Tab2018)
        Me.TabConsulta.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabConsulta.Location = New System.Drawing.Point(4, 12)
        Me.TabConsulta.Multiline = True
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 657)
        Me.TabConsulta.TabIndex = 145
        '
        'Tab2018
        '
        Me.Tab2018.BackColor = System.Drawing.Color.White
        Me.Tab2018.Controls.Add(Me.GroupBox1)
        Me.Tab2018.Controls.Add(Me.GroupBox2)
        Me.Tab2018.Controls.Add(Me.Label47)
        Me.Tab2018.Controls.Add(Me.txtNombreDeContacto)
        Me.Tab2018.Controls.Add(Me.btCotizacion)
        Me.Tab2018.Location = New System.Drawing.Point(4, 24)
        Me.Tab2018.Name = "Tab2018"
        Me.Tab2018.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2018.Size = New System.Drawing.Size(1140, 629)
        Me.Tab2018.TabIndex = 5
        Me.Tab2018.Text = "Nueva cotización"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(6, 165)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1128, 458)
        Me.GroupBox1.TabIndex = 249
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Catálogo de Artículos"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextCorreo)
        Me.GroupBox2.Controls.Add(Me.TextTelefono)
        Me.GroupBox2.Controls.Add(Me.TextEstado)
        Me.GroupBox2.Controls.Add(Me.TextCiudad)
        Me.GroupBox2.Controls.Add(Me.TextDireccion)
        Me.GroupBox2.Controls.Add(Me.TextRFC)
        Me.GroupBox2.Controls.Add(Me.TextEmpresa)
        Me.GroupBox2.Controls.Add(Me.TextContacto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(6, 52)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1128, 107)
        Me.GroupBox2.TabIndex = 248
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion General"
        '
        'TextCorreo
        '
        Me.TextCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCorreo.Location = New System.Drawing.Point(624, 26)
        Me.TextCorreo.Name = "TextCorreo"
        Me.TextCorreo.Size = New System.Drawing.Size(177, 22)
        Me.TextCorreo.TabIndex = 192
        '
        'TextTelefono
        '
        Me.TextTelefono.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextTelefono.Location = New System.Drawing.Point(890, 26)
        Me.TextTelefono.Name = "TextTelefono"
        Me.TextTelefono.Size = New System.Drawing.Size(177, 22)
        Me.TextTelefono.TabIndex = 191
        '
        'TextEstado
        '
        Me.TextEstado.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEstado.Location = New System.Drawing.Point(890, 65)
        Me.TextEstado.Name = "TextEstado"
        Me.TextEstado.Size = New System.Drawing.Size(177, 22)
        Me.TextEstado.TabIndex = 190
        '
        'TextCiudad
        '
        Me.TextCiudad.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextCiudad.Location = New System.Drawing.Point(624, 65)
        Me.TextCiudad.Name = "TextCiudad"
        Me.TextCiudad.Size = New System.Drawing.Size(177, 22)
        Me.TextCiudad.TabIndex = 189
        '
        'TextDireccion
        '
        Me.TextDireccion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextDireccion.Location = New System.Drawing.Point(375, 65)
        Me.TextDireccion.Name = "TextDireccion"
        Me.TextDireccion.Size = New System.Drawing.Size(177, 22)
        Me.TextDireccion.TabIndex = 188
        '
        'TextRFC
        '
        Me.TextRFC.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextRFC.Location = New System.Drawing.Point(121, 62)
        Me.TextRFC.Name = "TextRFC"
        Me.TextRFC.Size = New System.Drawing.Size(177, 22)
        Me.TextRFC.TabIndex = 187
        '
        'TextEmpresa
        '
        Me.TextEmpresa.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextEmpresa.Location = New System.Drawing.Point(375, 27)
        Me.TextEmpresa.Name = "TextEmpresa"
        Me.TextEmpresa.Size = New System.Drawing.Size(177, 22)
        Me.TextEmpresa.TabIndex = 186
        '
        'TextContacto
        '
        Me.TextContacto.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextContacto.Location = New System.Drawing.Point(121, 26)
        Me.TextContacto.Name = "TextContacto"
        Me.TextContacto.Size = New System.Drawing.Size(177, 22)
        Me.TextContacto.TabIndex = 185
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(50, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 16)
        Me.Label6.TabIndex = 177
        Me.Label6.Text = "Contacto:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(304, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 16)
        Me.Label9.TabIndex = 178
        Me.Label9.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(558, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 179
        Me.Label10.Text = "Ciudad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(819, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 16)
        Me.Label11.TabIndex = 180
        Me.Label11.Text = "Telefono:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(558, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 16)
        Me.Label12.TabIndex = 181
        Me.Label12.Text = "Correo:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(304, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(61, 16)
        Me.Label21.TabIndex = 184
        Me.Label21.Text = "Empresa:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(819, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 16)
        Me.Label20.TabIndex = 182
        Me.Label20.Text = "Estado:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(50, 68)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(33, 16)
        Me.Label26.TabIndex = 183
        Me.Label26.Text = "RFC:"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label47.Location = New System.Drawing.Point(15, 14)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(77, 16)
        Me.Label47.TabIndex = 185
        Me.Label47.Text = "Cotización"
        '
        'txtNombreDeContacto
        '
        Me.txtNombreDeContacto.AutoSize = True
        Me.txtNombreDeContacto.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreDeContacto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.txtNombreDeContacto.Location = New System.Drawing.Point(15, 31)
        Me.txtNombreDeContacto.Name = "txtNombreDeContacto"
        Me.txtNombreDeContacto.Size = New System.Drawing.Size(140, 18)
        Me.txtNombreDeContacto.TabIndex = 184
        Me.txtNombreDeContacto.Text = "Nueva Cotización"
        '
        'btCotizacion
        '
        Me.btCotizacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCotizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btCotizacion.FlatAppearance.BorderSize = 0
        Me.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCotizacion.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCotizacion.ForeColor = System.Drawing.Color.White
        Me.btCotizacion.Location = New System.Drawing.Point(1023, 13)
        Me.btCotizacion.Name = "btCotizacion"
        Me.btCotizacion.Size = New System.Drawing.Size(111, 33)
        Me.btCotizacion.TabIndex = 270
        Me.btCotizacion.Text = "Cotizar"
        Me.btCotizacion.UseVisualStyleBackColor = False
        '
        'btCerrar
        '
        Me.btCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCerrar.Image = CType(resources.GetObject("btCerrar.Image"), System.Drawing.Image)
        Me.btCerrar.Location = New System.Drawing.Point(1130, 2)
        Me.btCerrar.Name = "btCerrar"
        Me.btCerrar.Size = New System.Drawing.Size(24, 24)
        Me.btCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btCerrar.TabIndex = 146
        Me.btCerrar.TabStop = False
        '
        'btCargarArticulos
        '
        Me.btCargarArticulos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btCargarArticulos.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_update_left_rotation_64
        Me.btCargarArticulos.Location = New System.Drawing.Point(18, 227)
        Me.btCargarArticulos.Name = "btCargarArticulos"
        Me.btCargarArticulos.Size = New System.Drawing.Size(30, 30)
        Me.btCargarArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btCargarArticulos.TabIndex = 275
        Me.btCargarArticulos.TabStop = False
        '
        'DgAgregar
        '
        Me.DgAgregar.AllowUserToDeleteRows = False
        Me.DgAgregar.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DgAgregar.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DgAgregar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgAgregar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgAgregar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgAgregar.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4})
        Me.DgAgregar.Location = New System.Drawing.Point(22, 409)
        Me.DgAgregar.Name = "DgAgregar"
        Me.DgAgregar.Size = New System.Drawing.Size(261, 77)
        Me.DgAgregar.TabIndex = 271
        Me.DgAgregar.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Modelo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'DGCotizaciones
        '
        Me.DGCotizaciones.AllowUserToDeleteRows = False
        Me.DGCotizaciones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGCotizaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGCotizaciones.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGCotizaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGCotizaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCotizaciones.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DGCotizaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCotizaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.s, Me.ID, Me.Column5, Me.Column6, Me.Column7, Me.Column8})
        Me.DGCotizaciones.EnableHeadersVisualStyles = False
        Me.DGCotizaciones.Location = New System.Drawing.Point(26, 263)
        Me.DGCotizaciones.Name = "DGCotizaciones"
        Me.DGCotizaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGCotizaciones.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.DGCotizaciones.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DGCotizaciones.Size = New System.Drawing.Size(1107, 390)
        Me.DGCotizaciones.TabIndex = 274
        '
        'TextArticulo
        '
        Me.TextArticulo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextArticulo.Location = New System.Drawing.Point(476, 233)
        Me.TextArticulo.Name = "TextArticulo"
        Me.TextArticulo.Size = New System.Drawing.Size(139, 21)
        Me.TextArticulo.TabIndex = 272
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(384, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 273
        Me.Label7.Text = "Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(54, 234)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 16)
        Me.Label3.TabIndex = 267
        Me.Label3.Text = "Filtrar por:"
        '
        'txtMarca
        '
        Me.txtMarca.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(689, 233)
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Size = New System.Drawing.Size(116, 21)
        Me.txtMarca.TabIndex = 263
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(134, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 17)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "N° de Artículo (SKU):"
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarca.Location = New System.Drawing.Point(630, 235)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(53, 17)
        Me.lblMarca.TabIndex = 264
        Me.lblMarca.Text = "Marca:"
        '
        'TextID
        '
        Me.TextID.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextID.Location = New System.Drawing.Point(271, 233)
        Me.TextID.Name = "TextID"
        Me.TextID.Size = New System.Drawing.Size(112, 21)
        Me.TextID.TabIndex = 268
        '
        'lblModelo
        '
        Me.lblModelo.AutoSize = True
        Me.lblModelo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModelo.Location = New System.Drawing.Point(817, 237)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(61, 17)
        Me.lblModelo.TabIndex = 266
        Me.lblModelo.Text = "Modelo:"
        '
        'txtModelo
        '
        Me.txtModelo.Font = New System.Drawing.Font("Calibri Light", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(884, 231)
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Size = New System.Drawing.Size(117, 21)
        Me.txtModelo.TabIndex = 265
        '
        's
        '
        Me.s.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.s.FillWeight = 126.9036!
        Me.s.HeaderText = "Seleccionar"
        Me.s.Name = "s"
        Me.s.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.s.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.s.Width = 80
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'Column5
        '
        Me.Column5.FillWeight = 93.27411!
        Me.Column5.HeaderText = "N° de Artículo (SKU)"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.FillWeight = 93.27411!
        Me.Column6.HeaderText = "Descripción"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.FillWeight = 93.27411!
        Me.Column7.HeaderText = "Marca/Fabricante"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.FillWeight = 93.27411!
        Me.Column8.HeaderText = "Modelo"
        Me.Column8.Name = "Column8"
        '
        'FrmCotInformal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.btCargarArticulos)
        Me.Controls.Add(Me.DgAgregar)
        Me.Controls.Add(Me.DGCotizaciones)
        Me.Controls.Add(Me.TextArticulo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMarca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMarca)
        Me.Controls.Add(Me.TextID)
        Me.Controls.Add(Me.lblModelo)
        Me.Controls.Add(Me.txtModelo)
        Me.Controls.Add(Me.btCerrar)
        Me.Controls.Add(Me.TabConsulta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCotInformal"
        Me.Text = "Form1"
        Me.TabConsulta.ResumeLayout(False)
        Me.Tab2018.ResumeLayout(False)
        Me.Tab2018.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.btCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btCargarArticulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGCotizaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents Tab2018 As TabPage
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label47 As Label
    Friend WithEvents txtNombreDeContacto As Label
    Friend WithEvents TextCorreo As TextBox
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents TextEstado As TextBox
    Friend WithEvents TextCiudad As TextBox
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents TextRFC As TextBox
    Friend WithEvents TextEmpresa As TextBox
    Friend WithEvents TextContacto As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents btCerrar As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btCotizacion As Button
    Friend WithEvents btCargarArticulos As PictureBox
    Friend WithEvents DgAgregar As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DGCotizaciones As DataGridView
    Friend WithEvents TextArticulo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMarca As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMarca As Label
    Friend WithEvents TextID As TextBox
    Friend WithEvents lblModelo As Label
    Friend WithEvents txtModelo As TextBox
    Friend WithEvents s As DataGridViewCheckBoxColumn
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
End Class

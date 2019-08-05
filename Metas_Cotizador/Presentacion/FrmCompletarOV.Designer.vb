<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCompletarOV
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btCotizacion = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgEquipamiento = New System.Windows.Forms.DataGridView()
        Me.NumOV = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.domEnvio = New System.Windows.Forms.CheckBox()
        Me.txtOrdenCompra = New System.Windows.Forms.TextBox()
        Me.txtRefCot = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.dtpFechaRecep = New System.Windows.Forms.DateTimePicker()
        Me.var = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboRecibidoPor = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCantCajas = New System.Windows.Forms.TextBox()
        Me.embarcarPor = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.cboRecepcion = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.terminosPago = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombreCompania = New System.Windows.Forms.Label()
        Me.numCuenta = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbSubtitylo = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lbTitulo = New System.Windows.Forms.Label()
        Me.txtVolumen = New System.Windows.Forms.TextBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgEquipamiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btCotizacion)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lbSubtitylo)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.lbTitulo)
        Me.Panel1.Controls.Add(Me.txtVolumen)
        Me.Panel1.Location = New System.Drawing.Point(5, 30)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(585, 495)
        Me.Panel1.TabIndex = 167
        '
        'btCotizacion
        '
        Me.btCotizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btCotizacion.FlatAppearance.BorderSize = 0
        Me.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCotizacion.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCotizacion.ForeColor = System.Drawing.Color.White
        Me.btCotizacion.Location = New System.Drawing.Point(467, 19)
        Me.btCotizacion.Name = "btCotizacion"
        Me.btCotizacion.Size = New System.Drawing.Size(111, 33)
        Me.btCotizacion.TabIndex = 179
        Me.btCotizacion.Text = "ENVIAR"
        Me.btCotizacion.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgEquipamiento)
        Me.GroupBox2.Controls.Add(Me.NumOV)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.domEnvio)
        Me.GroupBox2.Controls.Add(Me.txtOrdenCompra)
        Me.GroupBox2.Controls.Add(Me.txtRefCot)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtpFechaRecep)
        Me.GroupBox2.Controls.Add(Me.var)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cboRecibidoPor)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtCantCajas)
        Me.GroupBox2.Controls.Add(Me.embarcarPor)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtPeso)
        Me.GroupBox2.Controls.Add(Me.cboRecepcion)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox2.Location = New System.Drawing.Point(18, 177)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 312)
        Me.GroupBox2.TabIndex = 191
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Cliente"
        '
        'dgEquipamiento
        '
        Me.dgEquipamiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgEquipamiento.Location = New System.Drawing.Point(355, 217)
        Me.dgEquipamiento.Name = "dgEquipamiento"
        Me.dgEquipamiento.Size = New System.Drawing.Size(190, 86)
        Me.dgEquipamiento.TabIndex = 197
        '
        'NumOV
        '
        Me.NumOV.AutoSize = True
        Me.NumOV.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumOV.Location = New System.Drawing.Point(95, 274)
        Me.NumOV.Name = "NumOV"
        Me.NumOV.Size = New System.Drawing.Size(20, 14)
        Me.NumOV.TabIndex = 168
        Me.NumOV.Text = "ov"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(16, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(119, 16)
        Me.Label15.TabIndex = 184
        Me.Label15.Text = "Cantidad de cajas:"
        '
        'domEnvio
        '
        Me.domEnvio.AutoSize = True
        Me.domEnvio.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.domEnvio.ForeColor = System.Drawing.Color.Black
        Me.domEnvio.Location = New System.Drawing.Point(353, 193)
        Me.domEnvio.Name = "domEnvio"
        Me.domEnvio.Size = New System.Drawing.Size(137, 20)
        Me.domEnvio.TabIndex = 196
        Me.domEnvio.Text = "Domicilio de envio"
        Me.domEnvio.UseVisualStyleBackColor = True
        '
        'txtOrdenCompra
        '
        Me.txtOrdenCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenCompra.Location = New System.Drawing.Point(149, 25)
        Me.txtOrdenCompra.Name = "txtOrdenCompra"
        Me.txtOrdenCompra.Size = New System.Drawing.Size(200, 20)
        Me.txtOrdenCompra.TabIndex = 0
        '
        'txtRefCot
        '
        Me.txtRefCot.AutoSize = True
        Me.txtRefCot.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefCot.ForeColor = System.Drawing.Color.Black
        Me.txtRefCot.Location = New System.Drawing.Point(467, 28)
        Me.txtRefCot.Name = "txtRefCot"
        Me.txtRefCot.Size = New System.Drawing.Size(72, 17)
        Me.txtRefCot.TabIndex = 168
        Me.txtRefCot.Text = "Cotizacion"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(16, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 16)
        Me.Label11.TabIndex = 179
        Me.Label11.Text = "Fecha recepción:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(19, 274)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 15)
        Me.Label22.TabIndex = 169
        Me.Label22.Text = "NÚM. OV:"
        '
        'dtpFechaRecep
        '
        Me.dtpFechaRecep.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRecep.Location = New System.Drawing.Point(149, 52)
        Me.dtpFechaRecep.Name = "dtpFechaRecep"
        Me.dtpFechaRecep.Size = New System.Drawing.Size(200, 20)
        Me.dtpFechaRecep.TabIndex = 180
        '
        'var
        '
        Me.var.AutoSize = True
        Me.var.Font = New System.Drawing.Font("Calibri Light", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.var.Location = New System.Drawing.Point(96, 259)
        Me.var.Name = "var"
        Me.var.Size = New System.Drawing.Size(20, 14)
        Me.var.TabIndex = 170
        Me.var.Text = "ov"
        Me.var.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(399, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 16)
        Me.Label13.TabIndex = 179
        Me.Label13.Text = "Cotización:"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(149, 217)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(200, 86)
        Me.txtObservaciones.TabIndex = 195
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(16, 79)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 16)
        Me.Label14.TabIndex = 182
        Me.Label14.Text = "Recibido por:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(16, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 16)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "Orden de compra:"
        '
        'cboRecibidoPor
        '
        Me.cboRecibidoPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecibidoPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecibidoPor.FormattingEnabled = True
        Me.cboRecibidoPor.Items.AddRange(New Object() {"Susana", "Osvaldo", "Karina"})
        Me.cboRecibidoPor.Location = New System.Drawing.Point(149, 79)
        Me.cboRecibidoPor.Name = "cboRecibidoPor"
        Me.cboRecibidoPor.Size = New System.Drawing.Size(200, 21)
        Me.cboRecibidoPor.TabIndex = 183
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Black
        Me.Label20.Location = New System.Drawing.Point(16, 214)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(100, 16)
        Me.Label20.TabIndex = 194
        Me.Label20.Text = "Observaciones:"
        '
        'txtCantCajas
        '
        Me.txtCantCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantCajas.Location = New System.Drawing.Point(149, 107)
        Me.txtCantCajas.Name = "txtCantCajas"
        Me.txtCantCajas.Size = New System.Drawing.Size(200, 20)
        Me.txtCantCajas.TabIndex = 185
        '
        'embarcarPor
        '
        Me.embarcarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.embarcarPor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.embarcarPor.FormattingEnabled = True
        Me.embarcarPor.Location = New System.Drawing.Point(149, 187)
        Me.embarcarPor.Name = "embarcarPor"
        Me.embarcarPor.Size = New System.Drawing.Size(200, 21)
        Me.embarcarPor.TabIndex = 193
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(16, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(39, 16)
        Me.Label16.TabIndex = 186
        Me.Label16.Text = "Peso:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(16, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 16)
        Me.Label19.TabIndex = 192
        Me.Label19.Text = "Embarcar por:"
        '
        'txtPeso
        '
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(149, 134)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(200, 20)
        Me.txtPeso.TabIndex = 187
        '
        'cboRecepcion
        '
        Me.cboRecepcion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecepcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecepcion.FormattingEnabled = True
        Me.cboRecepcion.Location = New System.Drawing.Point(149, 161)
        Me.cboRecepcion.Name = "cboRecepcion"
        Me.cboRecepcion.Size = New System.Drawing.Size(200, 21)
        Me.cboRecepcion.TabIndex = 191
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(16, 160)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(133, 16)
        Me.Label18.TabIndex = 190
        Me.Label18.Text = "Medio de recepción:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.terminosPago)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombreCompania)
        Me.GroupBox1.Controls.Add(Me.numCuenta)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.SteelBlue
        Me.GroupBox1.Location = New System.Drawing.Point(18, 58)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(551, 102)
        Me.GroupBox1.TabIndex = 190
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Información del Cliente"
        '
        'terminosPago
        '
        Me.terminosPago.AutoSize = True
        Me.terminosPago.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.terminosPago.ForeColor = System.Drawing.Color.Black
        Me.terminosPago.Location = New System.Drawing.Point(426, 51)
        Me.terminosPago.Name = "terminosPago"
        Me.terminosPago.Size = New System.Drawing.Size(122, 17)
        Me.terminosPago.TabIndex = 166
        Me.terminosPago.Text = "Correo electronico"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(6, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 16)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Compañia:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(308, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 16)
        Me.Label5.TabIndex = 167
        Me.Label5.Text = "Términos de pago :"
        '
        'txtNombreCompania
        '
        Me.txtNombreCompania.AutoSize = True
        Me.txtNombreCompania.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreCompania.ForeColor = System.Drawing.Color.Black
        Me.txtNombreCompania.Location = New System.Drawing.Point(81, 28)
        Me.txtNombreCompania.Name = "txtNombreCompania"
        Me.txtNombreCompania.Size = New System.Drawing.Size(153, 17)
        Me.txtNombreCompania.TabIndex = 156
        Me.txtNombreCompania.Text = "Nombre de la compañia"
        '
        'numCuenta
        '
        Me.numCuenta.AutoSize = True
        Me.numCuenta.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numCuenta.ForeColor = System.Drawing.Color.Black
        Me.numCuenta.Location = New System.Drawing.Point(426, 28)
        Me.numCuenta.Name = "numCuenta"
        Me.numCuenta.Size = New System.Drawing.Size(107, 17)
        Me.numCuenta.TabIndex = 165
        Me.numCuenta.Text = "Núm. de Cuenta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(6, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 16)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "Dirección:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(323, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 16)
        Me.Label2.TabIndex = 164
        Me.Label2.Text = "Núm. de Cuenta:"
        '
        'txtDireccion
        '
        Me.txtDireccion.AutoSize = True
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.Black
        Me.txtDireccion.Location = New System.Drawing.Point(81, 76)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(66, 17)
        Me.txtDireccion.TabIndex = 158
        Me.txtDireccion.Text = "Direccion"
        '
        'txtCorreo
        '
        Me.txtCorreo.AutoSize = True
        Me.txtCorreo.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreo.ForeColor = System.Drawing.Color.Black
        Me.txtCorreo.Location = New System.Drawing.Point(81, 52)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(0, 17)
        Me.txtCorreo.TabIndex = 162
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 51)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 16)
        Me.Label9.TabIndex = 163
        Me.Label9.Text = "Correo:"
        '
        'lbSubtitylo
        '
        Me.lbSubtitylo.AutoSize = True
        Me.lbSubtitylo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSubtitylo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.lbSubtitylo.Location = New System.Drawing.Point(15, 27)
        Me.lbSubtitylo.Name = "lbSubtitylo"
        Me.lbSubtitylo.Size = New System.Drawing.Size(279, 18)
        Me.lbSubtitylo.TabIndex = 189
        Me.lbSubtitylo.Text = "Completar Datos de Orden de Venta"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(297, 31)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 188
        Me.Label17.Text = "Volumen:"
        Me.Label17.Visible = False
        '
        'lbTitulo
        '
        Me.lbTitulo.AutoSize = True
        Me.lbTitulo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTitulo.ForeColor = System.Drawing.Color.ForestGreen
        Me.lbTitulo.Location = New System.Drawing.Point(15, 10)
        Me.lbTitulo.Name = "lbTitulo"
        Me.lbTitulo.Size = New System.Drawing.Size(112, 16)
        Me.lbTitulo.TabIndex = 188
        Me.lbTitulo.Text = "Orden de Venta"
        '
        'txtVolumen
        '
        Me.txtVolumen.Location = New System.Drawing.Point(368, 26)
        Me.txtVolumen.Name = "txtVolumen"
        Me.txtVolumen.Size = New System.Drawing.Size(93, 20)
        Me.txtVolumen.TabIndex = 189
        Me.txtVolumen.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_minimize_window_50
        Me.btnMinimizar.Location = New System.Drawing.Point(537, 3)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 190
        Me.btnMinimizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_close_window_50
        Me.btnCerrar.Location = New System.Drawing.Point(565, 3)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 189
        Me.btnCerrar.TabStop = False
        '
        'FrmCompletarOV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(595, 532)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnMinimizar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCompletarOV"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Completar OV"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgEquipamiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtCorreo As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDireccion As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtNombreCompania As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents numCuenta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents terminosPago As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantCajas As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents cboRecibidoPor As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents dtpFechaRecep As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents txtOrdenCompra As TextBox
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents embarcarPor As ComboBox
    Friend WithEvents Label19 As Label
    Friend WithEvents cboRecepcion As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtVolumen As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtPeso As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btCotizacion As Button
    Friend WithEvents NumOV As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents var As Label
    Friend WithEvents txtRefCot As Label
    Friend WithEvents domEnvio As CheckBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lbSubtitylo As Label
    Friend WithEvents lbTitulo As Label
    Friend WithEvents dgEquipamiento As DataGridView
End Class

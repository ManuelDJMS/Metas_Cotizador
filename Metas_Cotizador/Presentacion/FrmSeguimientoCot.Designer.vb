<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSeguimientoCot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSeguimientoCot))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DGRes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.TabConsulta = New System.Windows.Forms.TabControl()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DGRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1127, 5)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(24, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 45
        Me.PictureBox5.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.White
        Me.TabPage2.Controls.Add(Me.DGRes)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.DtpHasta)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.DtpDesde)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1140, 613)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "Cotizaciones"
        '
        'DGRes
        '
        Me.DGRes.AllowUserToDeleteRows = False
        Me.DGRes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGRes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGRes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGRes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGRes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column15, Me.Column19, Me.Column30, Me.Column31, Me.Column32, Me.Column33, Me.Column34, Me.Column35, Me.Column36, Me.Column37, Me.Column38, Me.Column39, Me.Column40})
        Me.DGRes.EnableHeadersVisualStyles = False
        Me.DGRes.Location = New System.Drawing.Point(16, 85)
        Me.DGRes.Name = "DGRes"
        Me.DGRes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRes.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DGRes.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGRes.Size = New System.Drawing.Size(1109, 505)
        Me.DGRes.TabIndex = 259
        '
        'Column1
        '
        Me.Column1.HeaderText = "Generar"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "NumCot"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'Column3
        '
        Me.Column3.HeaderText = "Contacto"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Empresa"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Correo"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Domicilio"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "CP"
        Me.Column7.Name = "Column7"
        '
        'Column15
        '
        Me.Column15.HeaderText = "Teléfono"
        Me.Column15.Name = "Column15"
        '
        'Column19
        '
        Me.Column19.HeaderText = "Referencia"
        Me.Column19.Name = "Column19"
        '
        'Column30
        '
        Me.Column30.HeaderText = "Fecha Desde"
        Me.Column30.Name = "Column30"
        '
        'Column31
        '
        Me.Column31.HeaderText = "Fecha Hasta"
        Me.Column31.Name = "Column31"
        '
        'Column32
        '
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Format = "0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column32.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column32.HeaderText = "Total"
        Me.Column32.Name = "Column32"
        '
        'Column33
        '
        Me.Column33.HeaderText = "CustomerId"
        Me.Column33.Name = "Column33"
        Me.Column33.Visible = False
        '
        'Column34
        '
        Me.Column34.HeaderText = "Account"
        Me.Column34.Name = "Column34"
        Me.Column34.Visible = False
        '
        'Column35
        '
        Me.Column35.HeaderText = "ShipCity"
        Me.Column35.Name = "Column35"
        Me.Column35.Visible = False
        '
        'Column36
        '
        Me.Column36.HeaderText = "ShipState"
        Me.Column36.Name = "Column36"
        Me.Column36.Visible = False
        '
        'Column37
        '
        Me.Column37.HeaderText = "ShipZip"
        Me.Column37.Name = "Column37"
        Me.Column37.Visible = False
        '
        'Column38
        '
        Me.Column38.HeaderText = "ShipTo"
        Me.Column38.Name = "Column38"
        Me.Column38.Visible = False
        '
        'Column39
        '
        Me.Column39.HeaderText = "CategoryCustomer"
        Me.Column39.Name = "Column39"
        Me.Column39.Visible = False
        '
        'Column40
        '
        Me.Column40.HeaderText = "ShipCounty"
        Me.Column40.Name = "Column40"
        Me.Column40.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 18)
        Me.Label2.TabIndex = 186
        Me.Label2.Text = "Seguimiento de Cotizaciones"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label4.Location = New System.Drawing.Point(18, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 185
        Me.Label4.Text = "Cotizaciones"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(626, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 17)
        Me.Label1.TabIndex = 184
        Me.Label1.Text = "A"
        '
        'DtpHasta
        '
        Me.DtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpHasta.Location = New System.Drawing.Point(646, 35)
        Me.DtpHasta.Name = "DtpHasta"
        Me.DtpHasta.Size = New System.Drawing.Size(230, 20)
        Me.DtpHasta.TabIndex = 183
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(988, 17)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 33)
        Me.Button1.TabIndex = 166
        Me.Button1.Text = "Enviar Correos"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(565, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 17)
        Me.Label3.TabIndex = 182
        Me.Label3.Text = "Rango de Fechas:"
        '
        'DtpDesde
        '
        Me.DtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.DtpDesde.Location = New System.Drawing.Point(391, 35)
        Me.DtpDesde.Name = "DtpDesde"
        Me.DtpDesde.Size = New System.Drawing.Size(230, 20)
        Me.DtpDesde.TabIndex = 167
        '
        'TabConsulta
        '
        Me.TabConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabConsulta.Controls.Add(Me.TabPage2)
        Me.TabConsulta.Location = New System.Drawing.Point(4, 28)
        Me.TabConsulta.Name = "TabConsulta"
        Me.TabConsulta.SelectedIndex = 0
        Me.TabConsulta.Size = New System.Drawing.Size(1148, 639)
        Me.TabConsulta.TabIndex = 44
        '
        'FrmSeguimientoCot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1157, 673)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.TabConsulta)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(203, 47)
        Me.MaximizeBox = False
        Me.Name = "FrmSeguimientoCot"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DGRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabConsulta.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DtpDesde As DateTimePicker
    Friend WithEvents Button1 As Button
    Friend WithEvents TabConsulta As TabControl
    Friend WithEvents DtpHasta As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DGRes As DataGridView
    Friend WithEvents Column1 As DataGridViewCheckBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column30 As DataGridViewTextBoxColumn
    Friend WithEvents Column31 As DataGridViewTextBoxColumn
    Friend WithEvents Column32 As DataGridViewTextBoxColumn
    Friend WithEvents Column33 As DataGridViewTextBoxColumn
    Friend WithEvents Column34 As DataGridViewTextBoxColumn
    Friend WithEvents Column35 As DataGridViewTextBoxColumn
    Friend WithEvents Column36 As DataGridViewTextBoxColumn
    Friend WithEvents Column37 As DataGridViewTextBoxColumn
    Friend WithEvents Column38 As DataGridViewTextBoxColumn
    Friend WithEvents Column39 As DataGridViewTextBoxColumn
    Friend WithEvents Column40 As DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cotizaciones
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.btCotizacion = New System.Windows.Forms.Button()
        Me.txtNumCot = New System.Windows.Forms.Label()
        Me.txtIDListaDetalle = New System.Windows.Forms.Label()
        Me.txtEquipID = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGRes = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label82 = New System.Windows.Forms.Label()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DGRes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btCotizacion
        '
        Me.btCotizacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.btCotizacion.FlatAppearance.BorderSize = 0
        Me.btCotizacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btCotizacion.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCotizacion.ForeColor = System.Drawing.Color.White
        Me.btCotizacion.Location = New System.Drawing.Point(387, 18)
        Me.btCotizacion.Name = "btCotizacion"
        Me.btCotizacion.Size = New System.Drawing.Size(100, 27)
        Me.btCotizacion.TabIndex = 174
        Me.btCotizacion.Text = "Agregar"
        Me.btCotizacion.UseVisualStyleBackColor = False
        '
        'txtNumCot
        '
        Me.txtNumCot.AutoSize = True
        Me.txtNumCot.Location = New System.Drawing.Point(336, 24)
        Me.txtNumCot.Name = "txtNumCot"
        Me.txtNumCot.Size = New System.Drawing.Size(45, 13)
        Me.txtNumCot.TabIndex = 166
        Me.txtNumCot.Text = "NumCot"
        Me.txtNumCot.Visible = False
        '
        'txtIDListaDetalle
        '
        Me.txtIDListaDetalle.AutoSize = True
        Me.txtIDListaDetalle.Location = New System.Drawing.Point(209, 24)
        Me.txtIDListaDetalle.Name = "txtIDListaDetalle"
        Me.txtIDListaDetalle.Size = New System.Drawing.Size(70, 13)
        Me.txtIDListaDetalle.TabIndex = 166
        Me.txtIDListaDetalle.Text = "idListaDetalle"
        Me.txtIDListaDetalle.Visible = False
        '
        'txtEquipID
        '
        Me.txtEquipID.AutoSize = True
        Me.txtEquipID.Location = New System.Drawing.Point(285, 24)
        Me.txtEquipID.Name = "txtEquipID"
        Me.txtEquipID.Size = New System.Drawing.Size(45, 13)
        Me.txtEquipID.TabIndex = 166
        Me.txtEquipID.Text = "EquipID"
        Me.txtEquipID.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.Metas_Cotizador.My.Resources.Resources.icons8_close_window_50
        Me.btnCerrar.Location = New System.Drawing.Point(495, 3)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrar.TabIndex = 188
        Me.btnCerrar.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.DGRes)
        Me.Panel1.Controls.Add(Me.Label79)
        Me.Panel1.Controls.Add(Me.Label82)
        Me.Panel1.Controls.Add(Me.btCotizacion)
        Me.Panel1.Controls.Add(Me.txtEquipID)
        Me.Panel1.Controls.Add(Me.txtIDListaDetalle)
        Me.Panel1.Controls.Add(Me.txtNumCot)
        Me.Panel1.Location = New System.Drawing.Point(8, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(512, 240)
        Me.Panel1.TabIndex = 189
        '
        'DGRes
        '
        Me.DGRes.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGRes.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGRes.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DGRes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGRes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(170, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGRes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGRes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGRes.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGRes.EnableHeadersVisualStyles = False
        Me.DGRes.Location = New System.Drawing.Point(7, 60)
        Me.DGRes.Name = "DGRes"
        Me.DGRes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGRes.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DGRes.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DGRes.Size = New System.Drawing.Size(488, 150)
        Me.DGRes.TabIndex = 263
        '
        'Column1
        '
        Me.Column1.HeaderText = "idServicio"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 75
        '
        'Column2
        '
        Me.Column2.HeaderText = "Servicio"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 170
        '
        'Column3
        '
        Me.Column3.HeaderText = "Precio"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 90
        '
        'Column4
        '
        Me.Column4.HeaderText = "¿Activo?"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 70
        '
        'Column5
        '
        Me.Column5.HeaderText = ""
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 40
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.Label79.Location = New System.Drawing.Point(4, 27)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(136, 18)
        Me.Label79.TabIndex = 192
        Me.Label79.Text = "Agregar servicios"
        '
        'Label82
        '
        Me.Label82.AutoSize = True
        Me.Label82.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label82.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label82.Location = New System.Drawing.Point(4, 10)
        Me.Label82.Name = "Label82"
        Me.Label82.Size = New System.Drawing.Size(65, 16)
        Me.Label82.TabIndex = 191
        Me.Label82.Text = "Servicios"
        '
        'Cotizaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(134, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 285)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cotizaciones"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Servicios"
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGRes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEquipID As Label
    Friend WithEvents btCotizacion As Button
    Friend WithEvents txtNumCot As Label
    Friend WithEvents txtIDListaDetalle As Label
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label79 As Label
    Friend WithEvents Label82 As Label
    Friend WithEvents DGRes As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewCheckBoxColumn
End Class

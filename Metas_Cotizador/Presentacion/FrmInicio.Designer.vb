<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.linerocket = New System.Windows.Forms.Panel()
        Me.anim = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'linerocket
        '
        Me.linerocket.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.anim.SetDecoration(Me.linerocket, BunifuAnimatorNS.DecorationType.None)
        Me.linerocket.Location = New System.Drawing.Point(286, 268)
        Me.linerocket.Name = "linerocket"
        Me.linerocket.Size = New System.Drawing.Size(465, 10)
        Me.linerocket.TabIndex = 9
        '
        'anim
        '
        Me.anim.AnimationType = BunifuAnimatorNS.AnimationType.Transparent
        Me.anim.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(0)
        Animation10.RotateCoeff = 0!
        Animation10.RotateLimit = 0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0!
        Animation10.TransparencyCoeff = 1.0!
        Me.anim.DefaultAnimation = Animation10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.anim.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(172, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(440, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Cargando..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.anim.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(544, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(211, 21)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cotizador LIMS Versión 2.0"
        '
        'FrmInicio
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Metas_Cotizador.My.Resources.Resources.metas_esta
        Me.ClientSize = New System.Drawing.Size(767, 370)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.linerocket)
        Me.anim.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autenticación de Usuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents linerocket As Panel
    Private WithEvents anim As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class

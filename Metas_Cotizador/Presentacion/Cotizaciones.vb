Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class Cotizaciones
    Private Sub Cotizaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        alternarColorColumnas(DGRes)
    End Sub

    Public Sub consultaServicios(ByVal EquipID As Integer)
        txtEquipID.Text = EquipID
        Try
            MetodoLIMS()
            Dim R As String
            R = "select [SetupServices].ServicesId, [SetupServices].ServiceName, [SetupEquipmentServiceMapping].Price, [SetupServices].IsActive 
                from [SetupServices] inner join [SetupEquipmentServiceMapping] on [SetupServices].ServicesId = [SetupEquipmentServiceMapping].ServicesId
                where [SetupEquipmentServiceMapping].EquipId = " & EquipID & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read
                DGRes.Rows.Add(lector(0), lector(1), lector(2), lector(3))
            End While
            conexionLIMS.Close()
            lector.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Cotizaciones", "Error en la consulta de los servicios", Err.Number, cadena)
        End Try
    End Sub

    Public Sub consultaDetalleCotizaciones(ByVal numCot As Integer)
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select [DetalleCotizaciones].idListaCotizacion from [DetalleCotizaciones] where [DetalleCotizaciones].NumCot =" & numCot & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read
                frmEdicionCot2018_2019.DGServicios.Rows.Add(lector(0))
            End While
            conexionMetasCotizador.Close()
            lector.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Cotizaciones", "Error al hacer la consulta de detalle de cotizaciones", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        Dim seleccionado As Boolean
        Dim b As Boolean
        Dim subtotal As Decimal
        If DGRes.Rows.Count < 2 Then
            MsgBox("No hay servicios seleccionados.", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
            For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                seleccionado = DGRes.Rows(i).Cells(4).Value
                If seleccionado = True Then
                    b = True
                    Exit For
                Else
                    b = False
                End If
            Next
            '----------------------------------------------------------------------------------------------------
            If b = True Then
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(4).Value
                    If seleccionado = True Then
                        FrmEdicionCot.DGServicios.Rows.Add(txtEquipID.Text, DGRes.Rows(i).Cells(0).Value, DGRes.Rows(i).Cells(2).Value)
                    End If
                Next
                subtotal = 0
                For Each fila In FrmEdicionCot.DGServicios.Rows
                    subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
                Next
                iva = (subtotal * 0.16)
                Total = subtotal + iva
                FrmEdicionCot.TextSubtotal.Text = subtotal
                FrmEdicionCot.TextTotal.Text = Total
                'accion post
                Me.Dispose()
            Else
                MsgBox("No ha seleccionado ningún servicio", MsgBoxStyle.Critical, "Error del sistema.")
            End If
        End If
    End Sub

    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
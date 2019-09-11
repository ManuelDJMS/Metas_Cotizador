Imports System.Data.SqlClient
Public Class FrmEquipamiento
    Private Sub FrmEquipamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasCotizador()
        R = "select Cotizaciones.NumCot, idContacto, x1.EquipId, isnull(Serie,'-') as Serie, isnull(IdentificadorInventarioCliente, '-') as ID, isnull(DetalleCotizaciones.Observaciones,'-') from Cotizaciones inner join DetalleCotizaciones
        on Cotizaciones.NumCot=DetalleCotizaciones.NumCot inner join " & servidor & "[SetupEquipment] x1 on DetalleCotizaciones.EquipId=x1.EquipId where Cotizaciones.NumCot=" & numcot
        comandoMetasCotizador = New SqlCommand(R, conexionMetasCotizador)
        'Dim lector As SqlDataReader
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            DGArticulos.Rows.Add()
        End While
        conexionMetasCotizador.Close()
    End Sub
End Class
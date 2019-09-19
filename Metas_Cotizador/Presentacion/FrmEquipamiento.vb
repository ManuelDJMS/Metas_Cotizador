Imports System.Data.SqlClient
Public Class FrmEquipamiento
    Private Sub FrmEquipamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasCotizador()
        R = "select Cotizaciones.NumCot, idContacto, x1.EquipId, isnull(Serie,'-') as Serie, isnull(IdentificadorInventarioCliente, '-') as ID, 
            (isnull(DetalleCotizaciones.Observaciones,' ') + isnull('OBSERVACIONES DEL SERVICIO: '+ DetalleCotizaciones.ObservacionesServicios,' ')) as Short from Cotizaciones inner join DetalleCotizaciones
            on Cotizaciones.NumCot=DetalleCotizaciones.NumCot inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupEquipment] x1 on DetalleCotizaciones.EquipId=x1.EquipId  where Cotizaciones.NumCot=" & numcot
        MsgBox(R)
        comandoMetasCotizador = New SqlCommand(R, conexionMetasCotizador)
        'Dim lector As SqlDataReader
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            DGArticulos.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), "", lectorMetasCotizador(3), lectorMetasCotizador(4), "", "", "", False, lectorMetasCotizador(5))
        End While
        conexionMetasCotizador.Close()
    End Sub
End Class
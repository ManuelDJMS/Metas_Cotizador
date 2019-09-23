Imports System.Data.SqlClient
Public Class FrmEquipamiento
    Private Sub FrmEquipamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoMetasCotizador()
        R = "select Cotizaciones.NumCot, idContacto, x1.EquipId, isnull(Serie,'-') as Serie, isnull(IdentificadorInventarioCliente, '-') as ID, 
            (isnull(DetalleCotizaciones.Observaciones,' ') + isnull('OBSERVACIONES DEL SERVICIO: '+ DetalleCotizaciones.ObservacionesServicios,' ')) as Short from Cotizaciones inner join DetalleCotizaciones
            on Cotizaciones.NumCot=DetalleCotizaciones.NumCot inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupEquipment] x1 on DetalleCotizaciones.EquipId=x1.EquipId  where Cotizaciones.NumCot=" & numcot

        comandoMetasCotizador = New SqlCommand(R, conexionMetasCotizador)
        'Dim lector As SqlDataReader
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            DGArticulos.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), "", lectorMetasCotizador(3), lectorMetasCotizador(4), "", "", "", False, lectorMetasCotizador(5))
        End While
        lectorMetasCotizador.Close()
        conexionMetasCotizador.Close()

        MetodoLIMS()
        R = "Select [SetupCustomerAddressDtls].[CustomerId], [CustAccountNo], [FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1], [ShipAddress1],[ShipCity],[ShipState],[ShipZip]
                FROM [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails] x1 INNER JOIN [SetupCustomerAddressDtls] ON x1.[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
		        where x1.[CustomerId] =" & empresa

        comandoLIMS = New SqlCommand(R, conexionLIMS)
        'Dim lector As SqlDataReader
        lectorLIMS = comandoLIMS.ExecuteReader
        lectorLIMS.Read()
        txtNombreCompania.Text = lectorLIMS(5)
        txtDireccion.Text = lectorLIMS(7)
        txtCorreo.Text = lectorLIMS(4)
        terminosPago.Text = lectorLIMS(6)
        numCuenta.Text = lectorLIMS(1)


    End Sub
End Class
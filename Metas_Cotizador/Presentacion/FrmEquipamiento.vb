Imports System.Data.SqlClient
Public Class FrmEquipamiento
    Private Sub FrmEquipamiento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If FrmCompletarOT.dgEquipamiento.Rows.Count < 2 Then
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
        Else
            MetodoMetasCotizador()
            For ii = 0 To FrmCompletarOT.dgEquipamiento.Rows.Count - 2
                R = "if exists(select CustomerId, x1.EquipId, x3.NumCot from [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerEquipmentMapping] x1 inner join [MetasCotizador].[dbo].[Cotizaciones] x2
            on x1.CustomerId=x2.idContacto inner join [MetasCotizador].[dbo].[DetalleCotizaciones] x3 on x2.NumCot=x3.NumCot where x1.CustomerId=" & Val(FrmCompletarOT.dgEquipamiento.Item(1, ii).Value) & " and x1.EquipId=" & Val(FrmCompletarOT.dgEquipamiento.Item(2, ii).Value) & "and x3.NumCot=" & numcot & ") 
            begin print 'El artículo ya esta equipado al cliente' end else begin select Cotizaciones.NumCot, idContacto, x1.EquipId, isnull(Serie,'-') as Serie, isnull(IdentificadorInventarioCliente, '-') as ID, 
            (isnull(DetalleCotizaciones.Observaciones,' ') + isnull('OBSERVACIONES DEL SERVICIO: '+ DetalleCotizaciones.ObservacionesServicios,' ')) as Short from Cotizaciones inner join DetalleCotizaciones
            on Cotizaciones.NumCot=DetalleCotizaciones.NumCot inner join [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupEquipment] x1 on DetalleCotizaciones.EquipId=x1.EquipId  where Cotizaciones.NumCot=" & numcot & "and x1.EquipId=" & FrmCompletarOT.dgEquipamiento.Item(2, ii).Value & "end"
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                comandoMetasCotizador.CommandText = R
                comandoMetasCotizador.ExecuteNonQuery()

            Next
        End If


        MetodoLIMS()
        R = "Select x1.[CustomerId], [CustAccountNo], [FirstName] +' '+[MiddleName] +' '+ [LastName] as Nombre ,[Phone],[Email],[CompanyName],[PaymentTerms], [ContAddress1], [ShipAddress1],[ShipCity],[ShipState],[ShipZip]
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
        lbCustomerId.Text = lectorLIMS(0)
        lectorLIMS.Close()
        conexionLIMS.Close()

    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
End Class
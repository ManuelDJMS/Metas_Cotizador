Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmNuevoContacto
    Dim source, AdminType, isCod, isTaxable, isCalDataReq, isOOT, isCalHistory, QualityRequerment, CalDueDateAdj, DefaultPO, ShipMode, isDigitalCertified,
                RecallNotice, MonedaSeleccionada, AccActive As String
    Dim observaciones As String
    Dim adminpaq As String


    Private Sub cboAvisoDeRecuperacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvisoDeRecuperacion.SelectedIndexChanged
        If cboAvisoDeRecuperacion.Text = "Llamada" Then
            RecallNotice = "0"
        ElseIf cboAvisoDeRecuperacion.Text = "Texto" Then
            RecallNotice = "1"
        ElseIf cboAvisoDeRecuperacion.Text = "Ambos" Then
            RecallNotice = "2"
        Else
            RecallNotice = "-"
        End If
    End Sub

    Private Sub cboVencimientoDeCalibracion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVencimientoDeCalibracion.SelectedIndexChanged
        If cboVencimientoDeCalibracion.Text.Equals("Nunca") Then
            CalDueDateAdj = "0"
        ElseIf cboVencimientoDeCalibracion.Text.Equals("Fin de semana (Domingo)") Then
            CalDueDateAdj = "1"
        ElseIf cboVencimientoDeCalibracion.Text.Equals("Fin de mes") Then
            CalDueDateAdj = "2"
        Else
            CalDueDateAdj = "0"
        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub cboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMoneda.SelectedIndexChanged
        If cboMoneda.Text = "Peso Mexicano" Then
            MonedaSeleccionada = "0"
        ElseIf cboMoneda.Text = "U.S. Dollar" Then
            MonedaSeleccionada = "1"
        ElseIf cboMoneda.Text = "Pound Sterling" Then
            MonedaSeleccionada = "2"
        Else
            MonedaSeleccionada = "-"
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        txtDireccion1Facturacion.Text = txtDireccion1.Text
        txtCodigoPostalFacturacion.Text = txtCodigoPostal.Text
        txtEstadoFacturacion.Text = txtEstado.Text
        txtCiudadFacturacion.Text = txtCiudad.Text
        TextPais2.Text = TextPais1.Text
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        txtDireccion1Entrega.Text = txtDireccion1.Text
        txtCodigoPostalEntrega.Text = txtCodigoPostal.Text
        txtEstadoEntrega.Text = txtEstado.Text
        txtCiudadEntrega.Text = txtCiudad.Text
        TextPais3.Text = TextPais1.Text
    End Sub

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        Dim claveaccess As Integer

        claveaccess = InputBox("Ingrese la clave del contacto almacenado en ACCESS", "Nuevo Cliente")
        MetodoMetasInf()
        R = "select distinct isnull(Nombre,'-'), isnull((CASE WHEN CHARINDEX(' ', Apellidos)= 0 then
									Apellidos
								ELSE
									PARSENAME(REPLACE(Apellidos, ' ', '.'),2) END),'-') as PrimerApellido, 
							   isnull((CASE WHEN CHARINDEX(' ', Apellidos)>0 then
							   PARSENAME(REPLACE(Apellidos, ' ', '.'),1)
							   else
							   '' end),'-') as SegundoApellido,
		 isnull(Tel,'-'), isnull(Celular,'-'), isnull(Email,'-'), isnull(Fax,'-'), isnull(RazonSocial,'-'), isnull(Credito,'-'), isnull(RFC,'-'), isnull(DomicilioConsig,'-'), isnull(CiudadConsig,'-'),
         isnull(EdoConsig,'-'), isnull(CPConsig,'-'), isnull(DomicilioFiscal,'-'), isnull(Ciudad,'-'), isnull(EdooProv,'-'), isnull(CPFiscal,'-'), isnull(PaisConsig,'-'), isnull(Pais,'-'),
         isnull([Num Prov MetAs],'-'), isnull(CondicionesClienteAdmon,'-'), isnull(ObservAdminpaq,'-')  from [Contactos-Clientes-Usuarios] clientes inner join MetAsInf on 
         clientes.Clavempresa=MetAsInf.Clavempresa where clientes.ClaveContacto=" & claveaccess
        comandoMetasInf = conexionMetasInf.CreateCommand
        comandoMetasInf.CommandText = R
        lectorMetasInf = comandoMetasInf.ExecuteReader
        lectorMetasInf.Read()
        txtNombre.Text = lectorMetasInf(0)
        txtApellidoPaterno.Text = lectorMetasInf(1)
        txtApellidoMaterno.Text = lectorMetasInf(2)
        txtTelefono.Text = lectorMetasInf(3)
        txtCelular.Text = lectorMetasInf(4)
        txtCorreo1.Text = lectorMetasInf(5)
        txtFax.Text = lectorMetasInf(6)
        txtCompania.Text = lectorMetasInf(7)
        txtNumeroDeCuenta.Text = lectorMetasInf(7)
        If lectorMetasInf(8).ToUpper() = "SIN CRÉDITO" Or lectorMetasInf(8).ToUpper() = "SIN CREDITO" Then
            cbCOD.Checked = True
            txtTerminosDePago.Text = "CONSULTAR CON COBRANZA"
        ElseIf lectorMetasInf(8).ToUpper() = "CON CRÉDITO" Or lectorMetasInf(8).ToUpper() = "CON CREDITO" Then
            cbCOD.Checked = False
            txtTerminosDePago.Text = "Depósito a Cuenta 100 %  para envió de sus servicios. Para solicitud, aclaración de crédito o envió de comprobante de pago, favor de contactar al departamento de cobranza en el correo electrónico: cobranza@metas.mx"
        End If
        txtRFC.Text = lectorMetasInf(9)
        txtDireccion1.Text = lectorMetasInf(10)
        txtCiudad.Text = lectorMetasInf(11)
        txtEstado.Text = lectorMetasInf(12)
        txtCodigoPostal.Text = lectorMetasInf(13)
        txtDireccion1Facturacion.Text = lectorMetasInf(14)
        txtCiudadFacturacion.Text = lectorMetasInf(15)
        txtEstadoFacturacion.Text = lectorMetasInf(16)
        txtCodigoPostalFacturacion.Text = lectorMetasInf(17)
        TextPais1.Text = lectorMetasInf(18)
        TextPais3.Text = lectorMetasInf(18)
        TextPais2.Text = lectorMetasInf(19)
        'MsgBox(lectorMetasInf(21))
        If lectorMetasInf(20) <> "-" Then
            observaciones = "Número de Proveedor METAS: " & lectorMetasInf(20)
        End If
        txtCorreo2.Text = lectorMetasInf(21)
        txtIDFiscal.Text = lectorMetasInf(22)
        txtNotas.Text = LTrim(observaciones)
        lectorLIMS.Close()
        conexionLIMS.Close()
    End Sub


    Private Sub cboRequerimientosDeCalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboRequerimientosDeCalidad.SelectedIndexChanged
        seleccionarcombo("select id from [SetupQualityRequirement] where [QualityRqment]='", cboRequerimientosDeCalidad)
    End Sub

    Private Sub cboTipoIndustria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTipoIndustria.SelectedIndexChanged
        seleccionarcombo("select Id from MasterCustomerType where MasterCustomerType.CustomerType='", cboTipoIndustria)
    End Sub

    Sub seleccionarcombo(ByVal query As String, ByVal combo As ComboBox)
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            '-----------------Combo moneda ------------------------
            comandoLIMS.CommandText = query & combo.Text & "'"
            lectorLIMS = comandoLIMS.ExecuteReader
            lectorLIMS.Read()
            combo.Tag = lectorLIMS(0)
            lectorLIMS.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos de LIMS.", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Private Sub cboDefaultPO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDefaultPO.SelectedIndexChanged
        seleccionarcombo("select [Id] from [MasterPoPickList] where [POPickList]='", cboDefaultPO)
    End Sub

    Private Sub cboOrigen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboOrigen.SelectedIndexChanged
        seleccionarcombo("select *from SetupCustomerSource where [CustomerSource]='", cboOrigen)
    End Sub


    Dim contador, valorFinal As Integer
    Dim bandera, bandera2 As Integer
    Private Sub FrmNuevoContacto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        '------------------------ LLENADO DE COMBOS -------------------------------------------
        llenarcombo("Select *from SetupCustomerSource", cboOrigen, "id")
        llenarcombo("Select *from SetupQualityRequirement", cboRequerimientosDeCalidad, "id")
        llenarcombo("Select *from MasterCustomerType", cboTipoIndustria, "id")
        llenarcombo("Select *from [MasterPoPickList]", cboDefaultPO, "id")
        llenarcombo("Select *from [SetupShippingMode]", cboModoDeEnvio, "Id")
        llenarEstado("Select *from [StateMaster]", txtEstado, "StateId", TextPais1)
        llenarEstado("Select *from [StateMaster]", txtEstadoEntrega, "StateId", TextPais2)
        llenarEstado("Select *from [StateMaster]", txtEstadoFacturacion, "StateId", TextPais3)
        cboMoneda.Items.Add("Mexican Peso")
        cboMoneda.Items.Add("U.S. Dollar")
        cboMoneda.Items.Add("Pound Sterling")
        cboOpcionesDePago.Items.Add("Diario")
        cboOpcionesDePago.Items.Add("Semanal")
        cboOpcionesDePago.Items.Add("Mensual")
        cboOpcionesDePago.Items.Add("Anual")
        cboAvisoDeRecuperacion.Items.Add("Llamada")
        cboAvisoDeRecuperacion.Items.Add("Texto")
        cboAvisoDeRecuperacion.Items.Add("Ambos")
        cboVencimientoDeCalibracion.Items.Add("Ninguna")
        cboVencimientoDeCalibracion.Items.Add("Fin de semana (Domingo)")
        cboVencimientoDeCalibracion.Items.Add("Fin de mes")
        cboCategoria.Items.Add("Categoria 1")
        cboCategoria.Items.Add("Categoria 2")
        cboCategoria.Items.Add("Categoria 3")
        cboCategoria.Items.Add("Categoria 4")
        cboCategoria.Items.Add("Categoria 5")
        If ccc = True Then
            MetodoMetasCotizador()
            R = "select NumCot, idCliente, Contacto, Empresa, isnull(RFC,'-'), isnull(Domicilio, '-'), isnull(Cp,'-'),  isnull(Ciudad,'-'), isnull(Estado,'-'), isnull(Telefono,'-'),
                 isnull(Correo,'-') from Cotizaciones inner join ClientesInformales on Cotizaciones.idContacto=ClientesInformales.idCliente where NumCot=" & numcot
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            txtNombre.Text = lectorMetasCotizador(2)
            txtCompania.Text = lectorMetasCotizador(3)
            txtRFC.Text = lectorMetasCotizador(4)
            txtDireccion1.Text = lectorMetasCotizador(5)
            txtCodigoPostal.Text = lectorMetasCotizador(6)
            txtCiudad.Text = lectorMetasCotizador(7)
            txtEstado.Text = lectorMetasCotizador(8)
            txtTelefono.Text = lectorMetasCotizador(9)
            txtCorreo1.Text = lectorMetasCotizador(10)
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        End If
        '--------------------------------------------------------------------------------------
    End Sub
    Sub llenarcombo(ByVal query As String, ByVal combo As ComboBox, ByVal id As String)
        '=============================================== METODO PARA LLENAR LOS COMBOS ===================================================
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        comandoLIMS.CommandText = query
        lectorLIMS = comandoLIMS.ExecuteReader
        While lectorLIMS.Read()
            combo.Items.Add(lectorLIMS(1))
        End While
        lectorLIMS.Close()
        comandoLIMS.CommandText = query & " where " & id & "=1"
        'MsgBox(comandoLIMS.CommandText)
        lectorLIMS = comandoLIMS.ExecuteReader
        lectorLIMS.Read()
        combo.Tag = lectorLIMS(0)
        combo.Text = lectorLIMS(1)
        lectorLIMS.Close()
    End Sub
    Sub llenarEstado(ByVal query As String, ByVal combo As ComboBox, ByVal id As String, ByVal txt As TextBox)
        '=============================================== METODO PARA LLENAR LOS COMBOS DE LOS ESTADOS ===================================================
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        comandoLIMS.CommandText = query
        lectorLIMS = comandoLIMS.ExecuteReader
        While lectorLIMS.Read()
            combo.Items.Add(lectorLIMS(1))
        End While
        lectorLIMS.Close()
        comandoLIMS.CommandText = query & " where " & id & "='AGS'"

        lectorLIMS = comandoLIMS.ExecuteReader
        lectorLIMS.Read()
        combo.Tag = lectorLIMS(0)
        combo.Text = lectorLIMS(1)
        txt.Text = lectorLIMS(3)
        lectorLIMS.Close()
    End Sub
    Private Sub cboModoDeEnvio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboModoDeEnvio.SelectedIndexChanged
        seleccionarcombo("select [Id] from [SetupShippingMode] where [ShipVia]='", cboModoDeEnvio)
    End Sub
    Public Sub verificarFinal()
        'Debemos hacer un Select count para saber el valor del registro para asignarlo a las diferentes tablas
        MetodoLIMS()
        Dim comando As New SqlCommand("SELECT MAX(CustomerId) as ultimo from SetupCustomerDetails", conexionLIMS)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        valorFinal = lector(0)
        valorFinal = valorFinal + 1
        lector.Close()
        conexionLIMS.Close()
    End Sub
    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
        verificarFinal()
        Dim indicador1, indicador2 As String
        If cbActivo1.Checked = True Then
            indicador1 = "Y"
        Else
            indicador1 = "N"
        End If
        If cbActivo2.Checked = True Then
            indicador2 = "Y"
        Else
            indicador2 = "N"
        End If
        If cbCOD.Checked = True Then
            isCod = "Y"
        Else
            isCod = "N"
        End If
        If cbTaxable.Checked = True Then
            isTaxable = "Y"
        Else
            isTaxable = "N"
        End If
        If cbDatosRequeridos.Checked = True Then
            isCalDataReq = "Y"
        Else
            isCalDataReq = "N"
        End If
        If cbOOT.Checked = True Then
            isOOT = "Y"
        Else
            isOOT = "N"
        End If
        If cbHistorialDeCalibracion.Checked = True Then
            isCalHistory = "Y"
        Else
            isCalHistory = "N"
        End If
        If cbCertificado.Checked = True Then
            isDigitalCertified = "Y"
        Else
            isDigitalCertified = "N"
        End If
        If cbActivo2.Checked = True Then
            AccActive = "Y"
        Else
            AccActive = "N"
        End If
        Dim telefono As String
        If txtExtension.Text = "" Or txtExtension.Text = " " Then
            telefono = txtTelefono.Text
        Else
            telefono = txtTelefono.Text & " Ext. " & txtExtension.Text
        End If
        MetodoLIMS()
        'If btGuardar.Text = "Convertir" Then
        '    ''validar que no esten vacios los campos obligatorios, que se guarden en contactos
        '    If txtNombre.Text.Equals("") Or txtApellidoPaterno.Text.Equals("") Or txtApellidoMaterno.Text.Equals("") Or txtCompania.Text.Equals("") Or txtRFC.Text.Equals("") Or txtOrganizacion.Text.Equals("") Or txtNumeroDeCuenta.Text.Equals("") Or txtCelular.Text.Equals("") Or txtCorreo1.Text.Equals("") Or txtDireccion1.Text.Equals("") Or txtEstado.Text.Equals("") Or TextPais1.Text.Equals("") Or txtCiudad.Text.Equals("") Or txtCodigoPostal.Text.Equals("") Or cboDefaultPO.Text.Equals("") Then
        '        MsgBox("Completa los campos obligatorios.", MsgBoxStyle.Exclamation)
        '    Else
        '        ''Inserta
        '        'Try
        '        ''--------------------------------------------------------------guardar en Tabla principal de contactos con la insercion 2da en las direcciones de contactos adicionales-----------------------------------------------------------------------------------
        Dim cadena As String
        'MsgBox(cboOrigen.Tag)
        'fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        cadena = "insert into SetupCustomerDetails ([CustAccountNo],[FirstName],[MiddleName],[LastName],[Phone],[Mobile],[Email],[Fax],[CompanyName] ,[IsActive],[Source],[AdminType],[PaymentTerms],[IsCod]
                  ,[IsTaxable],[IsCallDataReq],[IsOOTNoticeReq],[IsCallHistoryReq],[QualityReqment],[CallDueDateAdj],[LabNotes],[CreatedBy],[CreatedOn],[DefaultPO],[ShipMode],[CalDiscount],[TaxExemption]
                  ,[Department],[Email2],[CategoryCustomer],[TaxIDNo],[Currency],[PaymentOption],[ShipmentAccount],[WorkingHours] ,[RecallNotice],[IsDigitalCertificate],[Attachment],[IsShipAccActive]
                  ,[KeyFiscal] ,[Organization])  values ('" & txtNumeroDeCuenta.Text.Trim & "',
                                '" & txtNombre.Text.Trim & "',
                                '" & txtApellidoPaterno.Text.Trim & "',
                                '" & txtApellidoMaterno.Text.Trim & "',
                                '" & telefono & "',
                                '" & txtCelular.Text.Trim & "',
                                '" & txtCorreo1.Text.Trim & "',
                                '" & txtFax.Text.Trim & "',
                                '" & txtCompania.Text.Trim & "','Y'
                                ,'" & cboOrigen.Tag & "',
                                '" & cboTipoIndustria.Tag & "',
                                '" & txtTerminosDePago.Text.Trim & "',
                                '" & isCod & "',
                                '" & isTaxable & "',
                                '" & isCalDataReq & "',
                                '" & isOOT & "',
                                '" & isCalHistory & "',
                                '" & cboRequerimientosDeCalidad.Tag & "',
                                '" & CalDueDateAdj & "',
                                '" & txtNotas.Text.Trim & "',
                                '" & usuario & "', getdate(),       
                                '" & cboDefaultPO.Tag & "',
                                '" & cboModoDeEnvio.Tag & "',
                                '" & txtDescuentoDeCalibracion.Text.Trim & "',
                                '" & txtTaxException.Text.Trim & "',
                                '" & txtDepartamento.Text.Trim & "',
                                '" & txtCorreo2.Text.Trim & "',
                                '" & cboCategoria.Text.Trim & "',
                                '" & txtRFC.Text.Trim & "',
                                '" & MonedaSeleccionada & "',
                                '" & cboOpcionesDePago.Text.Trim & "',
                                '" & txtCuentaDeEnvio.Text.Trim & "',
                                '" & txtHorarioDeTrabajo.Text.Trim & "',
                                '" & RecallNotice & "',
                                '" & isDigitalCertified & "',CONVERT(VARBINARY(25),'0x9473FBCCBC01AF'),
                                '" & AccActive & "',
                                '" & txtIDFiscal.Text.Trim & "',
                                '" & txtOrganizacion.Text.Trim & "')"


        Dim comando As New SqlCommand(cadena, conexionLIMS)
        comando.ExecuteNonQuery()

        R = "insert into SetupCustomerAddressDtls (
                                 [CustomerId]
                                ,[ContAddress1]
                                ,[ContCity]
                                ,[ContState]
                                ,[ContZip]
                                ,[BillAddress1]
                                ,[BillCity]  
                                ,[BillState]
                                ,[BillZip]                           
                                ,[ShipAddress1]  
                                ,[ShipCity]
                                ,[ShipState]
                                ,[ShipZip]
                          ,[ContCountry]
                          ,[BillCountry]
                                ,[ShipCountry]) values (
                                '" & valorFinal & "',
                                '" & txtDireccion1.Text.Trim & "',
                                '" & txtCiudad.Text.Trim & "',
                                '" & txtEstado.Text.Trim & "',
                                '" & txtCodigoPostal.Text.Trim & "',
                                '" & txtDireccion1Facturacion.Text.Trim & "',
                                '" & txtCiudadFacturacion.Text.Trim & "',
                                '" & txtEstadoFacturacion.Text.Trim & "',
                                '" & txtCodigoPostalFacturacion.Text.Trim & "',
                                '" & txtDireccion1Entrega.Text.Trim & "',
                                '" & txtCiudadEntrega.Text.Trim & "',
                                '" & txtEstadoEntrega.Text.Trim & "',
                                '" & txtCodigoPostalEntrega.Text.Trim & "',
                                '" & TextPais1.Text.Trim & "',
                                '" & TextPais2.Text.Trim & "',
                                '" & TextPais3.Text.Trim & "')"
        Dim comando1 As New SqlCommand(R, conexionLIMS)
        comando1.ExecuteNonQuery()
        MsgBox("El cliente se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
        '################################################################# CODIGO PARA ACTUALIZAR LA COTIZACION DEL CLIENTE NUEVO CREADO ######################################################################
        If ccc = True Then
            '========================================================== SACAR EL ULTIMO REGISTRO DEL CONTACTO PARA EL DETALLE DE COTIZACION=============================================================
            Dim maximo As Integer
            MetodoLIMS()
            R = "select MAX(CustomerId) from [SetupCustomerDetails]"
            comandoLIMS = conexionLIMS.CreateCommand
            comandoLIMS.CommandText = R
            lectorMetasCotizador = comandoLIMS.ExecuteReader
            lectorMetasCotizador.Read()
            If ((lectorMetasCotizador(0) Is DBNull.Value) OrElse (lectorMetasCotizador(0) Is Nothing)) Then
                maximo = 1
            Else
                maximo = lectorMetasCotizador(0)
            End If
            lectorMetasCotizador.Close()
            conexionLIMS.Close()
            '==============================================================================================================================================================================================
            MetodoMetasCotizador()
            R = "update Cotizaciones set idContacto=" & maximo & ", Origen='LIMS' where NumCot=" & numcot
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            comandoMetasCotizador.CommandText = R
            comandoMetasCotizador.ExecuteNonQuery()
            conexionMetasCotizador.Close()
            ccc = False
        End If
    End Sub
    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress,
        txtTelefono.KeyPress, txtExtension.KeyPress, txtFax.KeyPress, txtCodigoPostal.KeyPress,
        txtCodigoPostalEntrega.KeyPress, txtCodigoPostalFacturacion.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
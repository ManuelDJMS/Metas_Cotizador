Imports System.Data.SqlClient
Imports System.Data.Sql
Public Class FrmNuevoContacto
    Dim source, AdminType, isCod, isTaxable, isCalDataReq, isOOT, isCalHistory, QualityRequerment, CalDueDateAdj, DefaultPO, ShipMode, isDigitalCertified,
                RecallNotice, MonedaSeleccionada, AccActive As String


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
        llenarcombo("Select *from SetupCustomerSource", cboOrigen, "id")
        llenarcombo("Select *from SetupQualityRequirement", cboRequerimientosDeCalidad, "id")
        llenarcombo("Select *from MasterCustomerType", cboTipoIndustria, "id")
        llenarcombo("Select *from [MasterPoPickList]", cboDefaultPO, "id")
        llenarcombo("Select *from [SetupShippingMode]", cboModoDeEnvio, "id")
        llenarEstado("Select *from [StateMaster]", txtEstado, "StateId", TextPais1)
        llenarEstado("Select *from [StateMaster]", txtEstadoEntrega, "StateId", TextPais2)
        llenarEstado("Select *from [StateMaster]", txtEstadoFacturacion, "StateId", TextPais3)
        If ban = False Then
            btGuardar.Text = "ACTUALIZAR"
            Me.Text = "Actualizar datos de contacto"

        Else
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

            conexionLIMS.Close()
        End If
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

    Private Sub btGuardar_Click(sender As Object, e As EventArgs) Handles btGuardar.Click
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

        MsgBox(cadena)
        Dim comando As New SqlCommand(cadena, conexionLIMS)
        comando.ExecuteNonQuery()
        '        If comando.ExecuteNonQuery() <> True Then
        '            MsgBox("Contacto guardado correctamente en LIMS", MsgBoxStyle.Information)
        '            ''actualizar el estado del prospecto
        '            '    actualizarEstadoDeProspecto()
        '            '    Me.Dispose()
        '            '    Dim admin As New FrmProspectos
        '            '    admin.MdiParent = FrmHOME
        '            '    admin.Show()
        '            'Else
        '            MsgBox("Ya existe el nombre de la compañia, no podemos agregar otro contacto con la misma empresa", MsgBoxStyle.Critical)
        '        End If
        '        'Catch ex As Exception
        '        '    MsgBox("Ocurrio un error en insertar los datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        '        'End Try
        '    End If
        'Else
        '    envio()
        '    'MsgBox(MonedaSeleccionada)

        '    Dim cadena As String
        '    cadena = "Update SetupCustomerDetails Set 
        '        CustAccountNo = '" & txtNumeroDeCuenta.Text.Trim & "',
        '        FirstName = '" & txtNombre.Text.Trim & "',
        '        MiddleName ='" & txtApellidoPaterno.Text.Trim & "',
        '        LastName = '" & txtApellidoMaterno.Text.Trim & "',
        '        Phone ='" & txtTelefono.Text.Trim & "',
        '        Mobile ='" & txtCelular.Text.Trim & "',
        '        Email ='" & txtCorreo1.Text.Trim & "',
        '        Fax ='" & txtFax.Text.Trim & "',
        '        CompanyName ='" & txtCompania.Text.Trim & "',
        '        IsActive ='" & indicador1 & "',
        '        source ='" & source & "',
        '        AdminType ='" & AdminType & "',
        '        PaymentTerms ='" & txtTerminosDePago.Text.Trim & "',
        '        isCod ='" & isCod & "',
        '        isTaxable ='" & isTaxable & "',
        '        IsCallDataReq ='" & isCalDataReq & "',
        '        IsOOTNoticeReq ='" & isOOT & "',
        '        IsCallHistoryReq ='" & isCalHistory & "',
        '        QualityReqment ='" & QualityRequerment & "',
        '        CallDueDateAdj ='" & CalDueDateAdj & "',
        '        LabNotes ='" & txtNotas.Text.Trim & "',
        '        CreatedBy ='" & txtUsuarioActual.Text.Trim & "',
        '        CreatedOn =" & DTPFechaActual.Value.Date & ",                         
        '        DefaultPO ='" & DefaultPO & "',
        '        ShipMode ='" & ShipMode & "',
        '        CalDiscount ='" & txtDescuentoDeCalibracion.Text.Trim & "',
        '        TaxExemption ='" & txtTaxException.Text.Trim & "',
        '        Department ='" & txtDepartamento.Text.Trim & "',
        '        Email2 ='" & txtCorreo2.Text.Trim & "',
        '        CategoryCustomer ='" & cboCategoria.Text.Trim & "',
        '        Currency ='" & MonedaSeleccionada & "',
        '        PaymentOption ='" & cboOpcionesDePago.Text.Trim & "',
        '        ShipmentAccount ='" & txtCuentaDeEnvio.Text.Trim & "',
        '        WorkingHours ='" & txtHorarioDeTrabajo.Text.Trim & "',
        '        RecallNotice ='" & RecallNotice & "',
        '        IsDigitalCertificate ='" & isDigitalCertified & "',
        '        IsShipAccActive ='" & AccActive & "',
        '        KeyFiscal ='" & txtRFC.Text.Trim & "',
        '        Organization ='" & txtOrganizacion.Text.Trim & "' 
        '        where [CustomerId] ='" & Val(ID.Text) & "'"
        '    'MsgBox(cadena)
        '    conexionLIMS.Open()
        '    Dim comando As New SqlCommand(cadena, conexionLIMS)
        '    lectorLIMS = comando.ExecuteReader
        '    lectorLIMS.Close()
        '    Dim cadena2 As String
        '    cadena2 = "Update SetupCustomerAddressDtls Set                                 
        '        [ContAddress1] = '" & txtDireccion1.Text.Trim & "',
        '        [ContCity] = '" & txtCiudad.Text.Trim & "',
        '        [ContState] = '" & txtEstado.Text.Trim & "',
        '        [ContZip] = '" & txtCodigoPostal.Text.Trim & "',
        '        [BillAddress1] = '" & txtDireccion1Facturacion.Text.Trim & "',
        '        [BillCity] = '" & txtCiudadFacturacion.Text.Trim & "',
        '        [BillState] = '" & txtEstadoFacturacion.Text.Trim & "',
        '        [BillZip] = '" & txtCodigoPostalFacturacion.Text.Trim & "',                   
        '        [ShipAddress1] = '" & txtDireccion1Entrega.Text.Trim & "',
        '        [ShipCity] = '" & txtCiudadEntrega.Text.Trim & "',
        '        [ShipState] = '" & txtEstadoEntrega.Text.Trim & "',
        '        [ShipZip] = '" & txtCodigoPostalEntrega.Text.Trim & "',
        '        [ContCountry] = '" & TextPais1.Text.Trim & "',
        '        [BillCountry] = '" & TextPais2.Text.Trim & "',
        '        [ShipCountry] ='" & TextPais3.Text.Trim & "' 
        '        where [CustomerId] ='" & Val(ID.Text) & "'"
        '    'MsgBox(cadena)
        '    Dim comando2 As New SqlCommand(cadena2, conexionLIMS)
        '    lectorLIMS = comando2.ExecuteReader
        '    lectorLIMS.Close()
        '    'MsgBox(cadena2)
        '    MsgBox("Contacto actualizado correctamente en LIMS", MsgBoxStyle.Information)
        '    ''actualizar el estado del prospecto
        '    'actualizarEstadoDeProspecto()
        '    Me.Dispose()
        '    'Dim admin As New 
        '    'admin.MdiParent = FrmHOME
        '    'admin.Show()
        '    'Catch ex As Exception
        '    '    MsgBox("Ocurrio un error en insertar los datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        '    'End Try
        'End If
    End Sub
    Private Sub txtCelular_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCelular.KeyPress,
        txtTelefono.KeyPress, txtExtension.KeyPress, txtFax.KeyPress, txtCodigoPostal.KeyPress,
        txtCodigoPostalEntrega.KeyPress, txtCodigoPostalFacturacion.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class
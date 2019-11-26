Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class FrmCotizacion
    Private Sub BtCargarClientes_Click(sender As Object, e As EventArgs) Handles btCargarClientes.Click
        '============================================ BOTON QUE LLENA EL DATAGRID DE LOS CLIENTES ==========================================================
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email, Phone FROM SetupCustomerDetails"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5), lectorLIMS(6))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al cargar los clientes", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        FrmHOME.PL_Cotizacion.BackColor = Color.White
        Me.Close()
    End Sub

    Private Sub DGEmpresas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGEmpresas.RowHeaderMouseClick
        '================================= EVENTO QUE SELECCIONA UN CLIENTE DE LA REGILLA DE CLIENTES =====================================================
        'clave1 = DGEmpresas.Rows(e.RowIndex).Cells(0).Value.ToString()
        txtNombreProspecto.Text = DGEmpresas.Rows(e.RowIndex).Cells(1).Value & " " & DGEmpresas.Rows(e.RowIndex).Cells(2).Value
        txtNombreCompania.Text = DGEmpresas.Rows(e.RowIndex).Cells(3).Value
        txtCorreo.Text = DGEmpresas.Rows(e.RowIndex).Cells(5).Value
        txtTelefono.Text = DGEmpresas.Rows(e.RowIndex).Cells(6).Value
        empresa = Val(DGEmpresas.Rows(e.RowIndex).Cells(0).Value)
    End Sub

    Private Sub BtCargarArticulos_Click(sender As Object, e As EventArgs) Handles btCargarArticulos.Click
        '=============================================== BOTON QUE LLENA EL DATAGRID DE ARTICULOS =========================================================
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription from SetUpEquipment"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al cargar los Articulos", Err.Number, cadena)
        End Try
    End Sub
    Sub consultaempresas()
        '===============================================METODO PARA CONSULTAR EMPRESAS MEDIANTE LOS DIFERENTES PARAMETROS===================================================
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            DGEmpresas.Rows.Clear()
            If DGEmpresas.Rows.Count < 2 Then
            Else
                DGEmpresas.Rows.RemoveAt(DGEmpresas.CurrentRow.Index)
            End If
            R = "select CustomerId, concat(FirstName, ' ' , MiddleName) as Nombre, LastName,  Organization, KeyFiscal, Email, Phone FROM SetupCustomerDetails 
                where CustomerId like '" & txtClave.Text & "%' and Email like '" & TextCorreo.Text & "%' and Organization like '" & TextEmpresa.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGEmpresas.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), lectorLIMS(5))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al realizar una busqueda", Err.Number, cadena)
        End Try
    End Sub
    Sub consultasarticuloscot()
        '===============================================METODO PARA CONSULTAR ARTICULOS MEDIANTE LOS DIFERENTES PARAMETROS===================================================
        Try
            MetodoLIMS()
            DGCotizaciones.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from SetUpEquipment where ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGCotizaciones.Rows.Add(False, lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al filtrar por articulo", Err.Number, cadena)
        End Try
    End Sub
    Sub consultarEdicion()
        '=============================================== METODO PARA GENERAR BUSQUEDAS MEDIANTE LOS TEXBOX EN LA OPCION DE EDICION ===================================================
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgEmpresa.Rows.Clear()
            If dgEmpresa.Rows.Count < 2 Then
            Else
                dgEmpresa.Rows.RemoveAt(dgEmpresa.CurrentRow.Index)
            End If
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone,Email from " & servidor2 & "[Cotizaciones] x1
                inner join " & servidor & " [SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join " & servidor & " [SetupCustomerAddressDtls] x3
                on x2.Customerid=x3.CustomerId where CompanyName like '" & txtNombreE.Text & "%' and Email like '" & TextEmail.Text & "%' and ContAddress1 like '" & TextDom.Text &
                "%' and ContZip like '" & txtCP.Text & "%' and Phone like '" & TextTel.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al buscar", Err.Number, cadena)
        End Try
    End Sub
    Sub consultarEdicionCots()
        '===============================================METODO PARA CONSULTAR ARTICULOS MEDIANTE LOS DIFERENTES PARAMETROS EN LA PARTE DE EDICION===================================================
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            dgCot.Rows.Clear()
            If dgCot.Rows.Count < 2 Then
            Else
                dgCot.Rows.RemoveAt(dgCot.CurrentRow.Index)
            End If
            R = "SELECT idContacto, x1.NumCot, PartidaNo, x1.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price, Cantidad, SrlNo, RelationItemNo, Creado from " & servidor2 & "[DetalleCotizaciones] x1
              inner join " & servidor & "[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join " & servidor & "[SetupEquipmentServiceMapping] x3
			  on x1.EquipId=x3.EquipId inner join " & servidor2 & "[Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa &
              " and ItemNumber like '" & TextSKU.Text & "%' and EquipmentName like '" & TextDescripcion.Text & "%' and Mfr like '" & TextMarca.Text & "%' and " &
              "Model like '" & TextModelo.Text & "%'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(4), lectorMetasCotizador(8), lectorMetasCotizador(11), lectorMetasCotizador(5), lectorMetasCotizador(6), lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(10), lectorMetasCotizador(12), lectorMetasCotizador(14))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al buscar las cotizaciones", Err.Number, cadena)
        End Try
    End Sub

    Private Sub TxtClave_TextChanged(sender As Object, e As EventArgs) Handles txtClave.TextChanged
        consultaempresas()
    End Sub

    Private Sub TextCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextCorreo.TextChanged
        consultaempresas()
    End Sub

    Private Sub TextEmpresa_TextChanged(sender As Object, e As EventArgs) Handles TextEmpresa.TextChanged
        consultaempresas()
    End Sub

    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub TextArticulo_TextChanged(sender As Object, e As EventArgs) Handles TextArticulo.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub TxtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub TxtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub DGCotizaciones_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizaciones.CellContentClick
        '============================================================ CODIGO PARA VALIDAR SI YA REGISTRO UN ARTICULO =======================================================================================
        Dim bandera As Boolean
        If e.ColumnIndex = DGCotizaciones.Columns.Item("s").Index Then
            For i = 0 To DgAgregar.Rows.Count - 1
                If DGCotizaciones.Rows(e.RowIndex).Cells(1).Value = DgAgregar.Rows(i).Cells(0).Value Then
                    bandera = True
                    Exit For
                End If
            Next
            If bandera = True Then
                If MessageBox.Show("Ya selecciono este artículo anteriormente, ¿Desea agregarlo a otra partida?", "Registro Duplicado", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                    DgAgregar.Rows.Add(DGCotizaciones.Rows(e.RowIndex).Cells(1).Value)
                End If
            Else
                DgAgregar.Rows.Add(DGCotizaciones.Rows(e.RowIndex).Cells(1).Value)
            End If
        End If
    End Sub

    Private Sub BtCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        '=============================================== CODIGO PARA MANDAR LOS ARTICULOS CON PRECIO A LA COTIZACION ===================================================
        origen = "LIMS"
        editar = 2
        If DgAgregar.Rows.Count < 2 Then
            MsgBox("No hay articulos para Cotizar", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            For i As Integer = DgAgregar.Rows.Count() - 2 To 0 Step -1
                MetodoLIMS()

                '===============================================SELECCION DEL ARTICULO SELECCIONADO===================================================
                comandoLIMS = conexionLIMS.CreateCommand
                R = "SELECT SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model, ServiceDescription,RelationItemNo, Price from 
                            SetUpEquipment inner join SetupEquipmentServiceMapping on  
                            SetupEquipment.EquipId=SetupEquipmentServiceMapping.EquipId where SetUpEquipment.EquipId=" & DgAgregar.Rows(i).Cells(0).Value
                comandoLIMS.CommandText = R
                lectorLIMS = comandoLIMS.ExecuteReader
                lectorLIMS.Read()
                equipo = lectorLIMS(0)
                FrmEdicionCot.DGCopia.Rows.Add(lectorLIMS(0), i + 1, lectorLIMS(2), lectorLIMS(3), lectorLIMS(4), 1, False, " ")
                lectorLIMS.Close()
                '===================== SELECCION DEL SERVICIO POR DEFAUL (CALIBRACION DEL EQUIPO SELECCIONADO) ======================================
                comandoLIMS = conexionLIMS.CreateCommand
                R = "SELECT EquipId, ServicesId, Price from SetupEquipmentServiceMapping where EquipId=" & equipo
                comandoLIMS.CommandText = R
                lectorLIMS = comandoLIMS.ExecuteReader
                lectorLIMS.Read()
                FrmEdicionCot.DGServicios.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2))
                lectorLIMS.Close()
                conexionLIMS.Close()
            Next
            '=============== LIMPIAR LOS DATAGRID POR ENVIADOS ================
            DgAgregar.Rows.Clear()
            FrmEdicionCot.ShowDialog()
            For i = 0 To DGCotizaciones.Rows.Count - 2
                DGCotizaciones.Rows(i).Cells(0).Value = False
            Next
        End If
    End Sub

    Private Sub TabConsulta_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabConsulta.SelectedIndexChanged
        '===============================================METODO PARA LLENAR EL DATAGRID CON EMPRESAS QUE TENGAN COTIZACIONES (EDITAR)===================================================
        If TabConsulta.SelectedTab Is TabPage1 Then
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            R = "select distinct idContacto, FirstName + ' ' + MiddleName as Cliente, CompanyName, ContAddress1, ContZip, Phone, x2.Email from [MetasCotizador].[dbo].[Cotizaciones] x1
             inner join " & servidor & "[SetupCustomerDetails] x2 on x1.idContacto =x2.CustomerId inner join " & servidor & "[SetupCustomerAddressDtls] x3
             on x2.Customerid=x3.CustomerId"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                dgEmpresa.Rows.Add(lectorMetasCotizador(0), lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6))
            End While
            lectorMetasCotizador.Close()
            conexionMetasCotizador.Close()
        End If
    End Sub

    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        consultarEdicion()
    End Sub

    Private Sub TextDom_TextChanged(sender As Object, e As EventArgs) Handles TextDom.TextChanged
        consultarEdicion()
    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged
        consultarEdicion()
    End Sub

    Private Sub TxtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged
        consultarEdicion()
    End Sub

    Private Sub TextTel_TextChanged(sender As Object, e As EventArgs) Handles TextTel.TextChanged
        consultarEdicion()
    End Sub

    Private Sub DgEmpresa_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgEmpresa.RowHeaderMouseClick
        '===============================================METODO PARA CONSULTAR LAS COTIZACIONES QUE HA TENIDO LA EMPRESA SELECCIONADA ===================================================
        If dgCot.Rows.Count < 2 Then
        Else
            dgCot.Rows.Clear()
        End If
        empresa = Val(dgEmpresa.Rows(e.RowIndex).Cells(0).Value)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        R = "SELECT idContacto, x1.NumCot, PartidaNo,  ItemNumber, EquipmentName, Mfr, Model, x1.identificadorInventarioCliente, ServiceDescription, Uncertainity, Cantidad, Precio
             , Creado, x1.EquipId from [DetalleCotizaciones] x1 inner join ServiciosEnCotizaciones s on x1.idListaCotizacion=s.idListaCotizacion
             inner join " & servidor & "[SetupEquipment] x2 on x1.EquipId=x2.EquipId inner join " & servidor & "[SetupEquipmentServiceMapping] x3
			 on x1.EquipId=x3.EquipId inner join [Cotizaciones] x4 on x1.NumCot=x4.NumCot where idContacto=" & empresa
        comandoMetasCotizador.CommandText = R
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            dgCot.Rows.Add(lectorMetasCotizador(1), lectorMetasCotizador(2), lectorMetasCotizador(3), lectorMetasCotizador(4), lectorMetasCotizador(5), lectorMetasCotizador(6),
                           lectorMetasCotizador(7), lectorMetasCotizador(8), lectorMetasCotizador(9), lectorMetasCotizador(10), lectorMetasCotizador(11), lectorMetasCotizador(12))
        End While
        lectorMetasCotizador.Close()
        conexionMetasCotizador.Close()
    End Sub

    Private Sub TextSKU_TextChanged(sender As Object, e As EventArgs) Handles TextSKU.TextChanged
        consultarEdicionCots()
    End Sub

    Private Sub TextDescripcion_TextChanged(sender As Object, e As EventArgs) Handles TextDescripcion.TextChanged
        consultarEdicionCots()
    End Sub

    Private Sub TextMarca_TextChanged(sender As Object, e As EventArgs) Handles TextMarca.TextChanged
        consultarEdicionCots()
    End Sub

    Private Sub TextModelo_TextChanged(sender As Object, e As EventArgs) Handles TextModelo.TextChanged
        consultarEdicionCots()
    End Sub

    Private Sub DgCot_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgCot.RowHeaderMouseClick
        imprimircot(Val(dgCot.Rows(e.RowIndex).Cells(0).Value))
    End Sub
    Sub imprimircot(ByVal COT As Integer)
        '=============================================== METODO PARA GENERAR EL PDF DE LA COTIZACION ===================================================
        Try
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            Dim desde, hasta As Date
            Dim nombre, puesto, tel, correo, emp, dom, lugar, moneda, cotizo, correoEla, depto,
                    pago, entrega, modalidad, obser, calmetho, services, domFac, rfc, origen, idCliente As String
            Dim cve As String
            Dim R As String
            R = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, isnull([SetupCustomerDetails].[Department], '-') AS Departament, isnull([SetupCustomerDetails].[Phone], '-') as Phone, isnull([SetupCustomerDetails].[Email], '-') as Email,
                    isnull([SetupCustomerDetails].[CompanyName],'-') as CompanyName, [ContAddress1] + ' '+  [ContCity] +', '+ [ContState]+'. ' + [ContCountry] +'. CP '+ [ContZip] AS DomCont, ROW_NUMBER() OVER(ORDER BY PartidaNo ASC) AS Partidad, Cantidad,[DetalleCotizaciones].[EquipId],
                    [SetUpEquipment].[EquipmentName]+', MARCA: '+[Mfr] +', MODELO: '+[Model] +'. ' + (CASE WHEN  [identificadorInventarioCliente] = '-' COLLATE SQL_Latin1_General_CP1_CI_AS  THEN [identificadorInventarioCliente]  COLLATE SQL_Latin1_General_CP1_CI_AS 
                    ELSE [identificadorInventarioCliente] COLLATE SQL_Latin1_General_CP1_CI_AS  END) AS Comparacion,[SetupServices].[ServiceName],[ServiceDescription] +', ' + [TurnAroundTime]+' dias para calibración' as Descrip, [SetupEquipmentServiceMapping].[Price], [SetupEquipmentServiceMapping].[Price] * Cantidad AS sub,
                    [UserId], [UserMaster].[UserName], [LugarCondicion].[Descripcion] AS lugar, [MonedaCondicion].[Descripcion] AS moneda, 
                    [PagoCondicion].[Descripcion] AS pago, [ModalidadCondicion].[Descripcion] AS modalidad,
                    [Cotizaciones].[Observaciones],[CalibrationMethod], [ServiceDescription], [BillAddress1] +' '+ [BillCity] +', '+ [BillState]+'. '+[BillCountry]+' CP '+[BillZip] AS domFac, [TaxIDNo],
                    [UserMaster].[Email], isnull([UserMaster].[Department], '-') as depto,[Origen],[idContacto],[IdCliente],[Contacto],[Empresa],[RFC],[Domicilio],[Cp],[Ciudad],[Estado],[Telefono],[Correo]
                    from " & servidor2 & "[Cotizaciones]
                    INNER JOIN " & servidor & "[UserMaster] ON [Cotizaciones].[idUsuarioCotizacion] COLLATE SQL_Latin1_General_CP1_CI_AS = [UserMaster].[UserID]
                    LEFT JOIN " & servidor & "[SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
                    LEFT JOIN " & servidor & "[SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                    INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
                    INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].[idListaCotizacion] = [ServiciosEnCotizaciones].[idListaCotizacion]
                    INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].[idServicio] = [SetupServices].[ServicesId]
                    INNER JOIN [LugarCondicion] ON [Cotizaciones].[idLugarCondicion] = [LugarCondicion].[idLugarCondicion]
                    INNER JOIN [MonedaCondicion] ON [Cotizaciones].[idMonedaCondicion] = [MonedaCondicion].[idMonedaCondicion]
                    INNER JOIN [PagoCondicion] ON [Cotizaciones].[idPagoCondicion] = [PagoCondicion].[idPagoCondicion]
                    INNER JOIN [TiempoEntregaCondicion] ON [Cotizaciones].[idTiempoEntregaCondicion] = [TiempoEntregaCondicion].[idTiempoEntregaCondicion]
                    INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
                    INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
                    INNER JOIN " & servidor & "[SetupEquipmentServiceMapping] ON [SetUpEquipment].[EquipId] =[SetupEquipmentServiceMapping].[EquipId]
					LEFT JOIN [ClientesInformales] ON [Cotizaciones].[idContacto] = [ClientesInformales].[IdCliente]
                    WHERE [Cotizaciones].NumCot= '" & COT & "'"
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            desde = lectorMetasCotizador(1)
            hasta = lectorMetasCotizador(2)
            origen = lectorMetasCotizador(30)
            If origen = "INFORMAL" Then
                idCliente = lectorMetasCotizador(32)
                nombre = lectorMetasCotizador(33)
                puesto = " ".ToString
                tel = lectorMetasCotizador(40)
                correo = lectorMetasCotizador(41)
                emp = lectorMetasCotizador(34)
                dom = lectorMetasCotizador(36) & " CP:" & lectorMetasCotizador(37) & " " & lectorMetasCotizador(38) & " " & lectorMetasCotizador(39)
                domFac = " ".ToString
                rfc = lectorMetasCotizador(35)
            Else
                idCliente = lectorMetasCotizador(31)
                nombre = lectorMetasCotizador(3)
                puesto = lectorMetasCotizador(4)
                tel = lectorMetasCotizador(5)
                correo = lectorMetasCotizador(6)
                emp = lectorMetasCotizador(7)
                dom = lectorMetasCotizador(8)
                domFac = lectorMetasCotizador(26)
                rfc = lectorMetasCotizador(27)
            End If
            cve = lectorMetasCotizador(17)
            cotizo = lectorMetasCotizador(18)
            lugar = lectorMetasCotizador(19)
            moneda = lectorMetasCotizador(20)
            pago = lectorMetasCotizador(21)
            modalidad = lectorMetasCotizador(22)
            obser = lectorMetasCotizador(23)
            calmetho = lectorMetasCotizador(24)
            services = lectorMetasCotizador(25)
            correoEla = lectorMetasCotizador(28)
            depto = lectorMetasCotizador(29)
            entrega = "-"
            lectorMetasCotizador.Close()
            Dim Adaptador As New SqlDataAdapter
            Adaptador.SelectCommand = New SqlCommand
            Adaptador.SelectCommand.Connection = conexionMetasCotizador
            Adaptador.SelectCommand.CommandText = "cotLIMS4"
            Adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
            Dim param1 = New SqlParameter("@numCot", SqlDbType.VarChar)
            Dim param2 = New SqlParameter("@fechaDesde", SqlDbType.Date)
            Dim param3 = New SqlParameter("@fechaHasta", SqlDbType.Date)
            Dim param4 = New SqlParameter("@nombre", SqlDbType.VarChar)
            Dim param5 = New SqlParameter("@puesto", SqlDbType.VarChar)
            Dim param6 = New SqlParameter("@telefono", SqlDbType.VarChar)
            Dim param8 = New SqlParameter("@correo", SqlDbType.VarChar)
            Dim param9 = New SqlParameter("@com", SqlDbType.VarChar)
            Dim param10 = New SqlParameter("@dom", SqlDbType.VarChar)
            Dim param11 = New SqlParameter("@cveElaboro", SqlDbType.VarChar)
            Dim param12 = New SqlParameter("@elaborocot", SqlDbType.VarChar)
            Dim param13 = New SqlParameter("@correoElaboro", SqlDbType.VarChar)
            Dim param14 = New SqlParameter("@depto", SqlDbType.VarChar)
            Dim param15 = New SqlParameter("@lugar", SqlDbType.VarChar)
            Dim param16 = New SqlParameter("@moneda", SqlDbType.VarChar)
            Dim param17 = New SqlParameter("@pago", SqlDbType.VarChar)
            Dim param19 = New SqlParameter("@modalidad", SqlDbType.VarChar)
            Dim param20 = New SqlParameter("@obser", SqlDbType.VarChar)
            Dim param21 = New SqlParameter("@calMetodo", SqlDbType.VarChar)
            Dim param22 = New SqlParameter("@serDescripcion", SqlDbType.VarChar)
            Dim param23 = New SqlParameter("@domFactura", SqlDbType.VarChar)
            Dim param24 = New SqlParameter("@rfc", SqlDbType.VarChar)
            Dim param25 = New SqlParameter("@tipo", SqlDbType.VarChar)
            param1.Direction = ParameterDirection.Input
            param2.Direction = ParameterDirection.Input
            param3.Direction = ParameterDirection.Input
            param4.Direction = ParameterDirection.Input
            param5.Direction = ParameterDirection.Input
            param6.Direction = ParameterDirection.Input
            param8.Direction = ParameterDirection.Input
            param9.Direction = ParameterDirection.Input
            param10.Direction = ParameterDirection.Input
            param11.Direction = ParameterDirection.Input
            param12.Direction = ParameterDirection.Input
            param13.Direction = ParameterDirection.Input
            param14.Direction = ParameterDirection.Input
            param15.Direction = ParameterDirection.Input
            param16.Direction = ParameterDirection.Input
            param17.Direction = ParameterDirection.Input
            param19.Direction = ParameterDirection.Input
            param20.Direction = ParameterDirection.Input
            param21.Direction = ParameterDirection.Input
            param22.Direction = ParameterDirection.Input
            param23.Direction = ParameterDirection.Input
            param24.Direction = ParameterDirection.Input
            param25.Direction = ParameterDirection.Input
            param1.Value = COT
            param2.Value = desde
            param3.Value = hasta
            param4.Value = nombre
            param5.Value = puesto
            param6.Value = tel
            param8.Value = correo
            param9.Value = emp
            param10.Value = dom
            param11.Value = cve
            param12.Value = cotizo
            param13.Value = correoEla
            param14.Value = depto
            param15.Value = lugar
            param16.Value = moneda
            param17.Value = pago
            param19.Value = modalidad
            param20.Value = obser
            param21.Value = calmetho
            param22.Value = services
            param23.Value = domFac
            param24.Value = rfc
            param25.Value = tipo
            Adaptador.SelectCommand.Parameters.Add(param1)
            Adaptador.SelectCommand.Parameters.Add(param2)
            Adaptador.SelectCommand.Parameters.Add(param3)
            Adaptador.SelectCommand.Parameters.Add(param4)
            Adaptador.SelectCommand.Parameters.Add(param5)
            Adaptador.SelectCommand.Parameters.Add(param6)
            Adaptador.SelectCommand.Parameters.Add(param8)
            Adaptador.SelectCommand.Parameters.Add(param9)
            Adaptador.SelectCommand.Parameters.Add(param10)
            Adaptador.SelectCommand.Parameters.Add(param11)
            Adaptador.SelectCommand.Parameters.Add(param12)
            Adaptador.SelectCommand.Parameters.Add(param13)
            Adaptador.SelectCommand.Parameters.Add(param14)
            Adaptador.SelectCommand.Parameters.Add(param15)
            Adaptador.SelectCommand.Parameters.Add(param16)
            Adaptador.SelectCommand.Parameters.Add(param17)
            Adaptador.SelectCommand.Parameters.Add(param19)
            Adaptador.SelectCommand.Parameters.Add(param20)
            Adaptador.SelectCommand.Parameters.Add(param21)
            Adaptador.SelectCommand.Parameters.Add(param22)
            Adaptador.SelectCommand.Parameters.Add(param23)
            Adaptador.SelectCommand.Parameters.Add(param24)
            Adaptador.SelectCommand.Parameters.Add(param25)
            Dim Data As New DataSet
            Adaptador.Fill(Data)
            Data.DataSetName = "Data1"
            Dim Datasource As New ReportDataSource("DataSet1", Data.Tables(0))
            Datasource.Name = "DataSet1"
            Datasource.Value = Data.Tables(0)
            Dim p1 As New ReportParameter("numCot", COT)
            Dim p2 As New ReportParameter("fechaDesde", desde)
            Dim p3 As New ReportParameter("fechaHasta", hasta)
            Dim p4 As New ReportParameter("nombre", nombre)
            Dim p5 As New ReportParameter("puesto", puesto)
            Dim p6 As New ReportParameter("telefono", tel)
            Dim p8 As New ReportParameter("correo", correo)
            Dim p9 As New ReportParameter("com", emp)
            Dim p10 As New ReportParameter("dom", dom)
            Dim p11 As New ReportParameter("cveElaboro", cve)
            Dim p12 As New ReportParameter("elaborocot", cotizo)
            Dim p13 As New ReportParameter("correoElaboro", correoEla)
            Dim p14 As New ReportParameter("depto", depto)
            Dim p15 As New ReportParameter("lugar", lugar)
            Dim p16 As New ReportParameter("moneda", moneda)
            Dim p17 As New ReportParameter("pago", pago)
            Dim p19 As New ReportParameter("modalidad", modalidad)
            Dim p20 As New ReportParameter("obser", obser)
            Dim p21 As New ReportParameter("calMetodo", calmetho)
            Dim p22 As New ReportParameter("serDescription", services)
            Dim p23 As New ReportParameter("domFac", domFac)
            Dim p24 As New ReportParameter("rfc", rfc)
            Dim p25 As New ReportParameter("tipo", tipo)
            Dim Reportes As New ReportDataSource("DataSet1", Data.Tables(0))
            FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
        FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software-TI\Documents\GitHub\Metas_Cotizador\Metas_Cotizador\Reportes\CotizacionModelo.rdlc"
        FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17,
                                                                     p19, p20, p21, p22, p23, p24, p25})
            FrmReportes.ReportViewer1.RefreshReport()
            FrmReportes.Show()
            conexionMetasCotizador.Close()
        Catch ex As Exception
        MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
        cadena = Err.Description
        cadena = cadena.Replace("'", "")
        Bitacora("FrmCotizacion", "Error al reimprimir cotización", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtnReImpresion_Click(sender As Object, e As EventArgs) Handles btnReImpresion.Click
        Dim C As Integer
        C = InputBox("Ingrese el número de Cotización", "Folios")
        imprimircot(C)
    End Sub

    Private Sub BtnEditarCot_Click(sender As Object, e As EventArgs) Handles btnEditarCot.Click
        Try
            COT2 = InputBox("Ingrese el número de Cotización", "Folios")
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            R = "SELECT NumCot, Creado FROM [Cotizaciones] WHERE NumCot= " & COT2
            comandoMetasCotizador.CommandText = R
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            If lectorMetasCotizador(1) = 0 Then
                editar = 1
                FrmEdicionCot.ShowDialog()
            Else
                MsgBox("La cotización ya fue convertida en ORDEN DE VENTA NUM " & lectorMetasCotizador(1))
                lectorMetasCotizador.Close()
                conexionMetasCotizador.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion", "Error al seleccionar cot para editar", Err.Number, cadena)
        End Try
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        FrmNuevoContacto.Show()
    End Sub
End Class
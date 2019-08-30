Imports System.Data.SqlClient
Public Class FrmEdicionCot
    Dim subtotal As Decimal
    Dim maximo As Integer
    Dim inventarioCliente, observaciones As String
    Dim idlista As Integer
    Dim agregar1, agregar2 As Integer
    Dim eliminar1, eliminar2 As Integer
    Private Sub FrmEdicionCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        '        If editar = True Then
        '            DGCopia.Rows.Clear()
        '            DGServicios.Rows.Clear()
        '            DGCopia.Columns(1).Width = 200
        '            DGCopia.Columns(2).Width = 100
        '            DGCopia.Columns(3).Width = 100
        '            DGCopia.Columns(7).Visible = True
        '            btGuardarInf.Text = "ACTUALIZAR COT"
        '            numCot.Visible = True
        '            btGuardarInf.Visible = True
        '            btActualizarCliente.Visible = True
        '            btnEliminar.Visible = True
        '            Button1.Visible = False
        '            btnAgregarArticulos.Visible = True
        '            Label79.Text = "Actualizar COTIZACIÓN NUM. "
        '            MetodoMetasCotizador()
        '            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '            comandoMetasCotizador.CommandText = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre,[SetupCustomerDetails].[CustomerId],[CompanyName],[TaxIDNo],
        '[ContAddress1] AS DomCont,[ContCity], [ContState],[Phone],[SetupCustomerDetails].[Email],
        'PartidaNo,[SetUpEquipment].[EquipmentName] AS Articulo, [Mfr],[Model],[SetUpEquipment].[EquipId], [DetalleCotizaciones].[Observaciones], [SetupServices].[ServicesId],
        '[SetupServices].[ServiceName],[idUsuarioCotizacion],[Referencia], [DetalleCotizaciones].[idListaCotizacion],[Subtotal],[Total]
        'from [MetasCotizador].[dbo].[Cotizaciones]
        'INNER JOIN [Usuarios] ON [Cotizaciones].[idUsuarioCotizacion] = [Usuarios].[idUsuarioAdministrador]
        'INNER JOIN " & servidor & "[SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
        'INNER JOIN " & servidor & "[SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
        '            INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
        'INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
        'INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
        'INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
        'INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
        'WHERE [Cotizaciones].NumCot = " & COT2
        '            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        '            While lectorMetasCotizador.Read()
        '                numCot.Text = lectorMetasCotizador(0)
        '                txtNombreC.Text = lectorMetasCotizador(3)
        '                txtCveContacto.Text = lectorMetasCotizador(4)
        '                txtNombreEmpresa.Text = lectorMetasCotizador(5)
        '                txtNumCond.Text = lectorMetasCotizador(6)
        '                txtDomicilio.Text = lectorMetasCotizador(7)
        '                txtCiudad.Text = lectorMetasCotizador(8)
        '                txtEstado.Text = lectorMetasCotizador(9)
        '                txtTelefono.Text = lectorMetasCotizador(10)
        '                TextCorreo.Text = lectorMetasCotizador(11)
        '                txtCotizo2019.Text = lectorMetasCotizador(20)
        '                DTPDesde.Value = lectorMetasCotizador(1)
        '                DTPHasta.Value = lectorMetasCotizador(2)
        '                txtReferencia.Text = lectorMetasCotizador(21)
        '                TextSubtotal.Text = lectorMetasCotizador(23)
        '                precio = lectorMetasCotizador(23)
        '                TextTotal.Text = lectorMetasCotizador(24)
        '                DGCopia.Rows.Add(lectorMetasCotizador(12), lectorMetasCotizador(13), lectorMetasCotizador(14), lectorMetasCotizador(15), lectorMetasCotizador(16), True, lectorMetasCotizador(17))
        '                DGServicios.Rows.Add(lectorMetasCotizador(22), lectorMetasCotizador(16), lectorMetasCotizador(18), lectorMetasCotizador(19))
        '            End While
        '            lectorMetasCotizador.Close()
        '            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '            comandoMetasCotizador.CommandText = "Select MAX(idListaCotizacion) from [DetalleCotizaciones]"
        '            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        '            lectorMetasCotizador.Read()
        '            numPartida = lectorMetasCotizador(0)
        '        Else




        btGuardarInf.Text = "Guardar cotización"
        Label79.Text = "Guardar cotización"
        numCot.Visible = False
        DTPHasta.Value.AddDays(30)
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        R = "select [SetupCustomerDetails].CustomerId, isnull(Organization,'-'), isnull(concat(FirstName, ' ' , MiddleName, ' ', LastName),'-') as Nombre, 
                isnull(ContAddress1,'-'), isnull(ContCity,'-'), isnull(ContState,'-'), isnull(Phone,'-'), isnull(Email,'-') 
                from " & servidor & "[SetupCustomerDetails] inner join  
                SetupCustomerAddressDtls on [SetupCustomerDetails].CustomerId=[SetupCustomerAddressDtls].CustomerId
                where [MetAs_Live-pruebas].[dbo].[SetupCustomerDetails].CustomerId=" & empresa
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        lectorLIMS.Read()
        txtCveContacto.Text = lectorLIMS(0)
        txtNombreEmpresa.Text = lectorLIMS(1)
        txtNombreC.Text = lectorLIMS(2)
        txtDomicilio.Text = lectorLIMS(3)
        txtCiudad.Text = lectorLIMS(4)
        txtEstado.Text = lectorLIMS(5)
        txtTelefono.Text = lectorLIMS(6)
        TextCorreo.Text = lectorLIMS(7)
        lectorLIMS.Close()
        conexionLIMS.Close()
        For Each fila In DGServicios.Rows
            subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
        Next
        iva = (subtotal * 0.16)
        Total = subtotal + iva
        TextSubtotal.Text = subtotal
        TextTotal.Text = Total
        'End If
        '-----------------Combo cuando ------------------------
        llenarcombo("select * from CuandoCondicion", Cbcuando)
        ''-----------------Combo documentps ------------------------
        llenarcombo("select * from DocumentosCondicion", ComboDocCond)
        ''-----------------Combo Leyenda ------------------------
        llenarcombo("select * from LeyendaCondicion", CboLeyenda)
        ''-----------------Combo Lugar ------------------------
        llenarcombo("select * from LugarCondicion", cboServicio)
        ''-----------------Combo modalidad ------------------------
        llenarcombo("select * from ModalidadCondicion", CbModalidad)
        ''-----------------Combo modo de contabilizar ------------------------
        llenarcombo("select * from Modo_de_Contabilizar", CboContabilizar)
        ''-----------------Combo moneda ------------------------
        llenarcombo("select * from MonedaCondicion", CboMoneda)
        ''-----------------Combo Pago------------------------
        llenarcombo2("select * from PagoCondicion", CCondPago)
        ''-----------------Combo tiempo ------------------------
        llenarcombo2("select * from TiempoEntregaCondicion", CboTiempo)
        ''-----------------Combo validez ------------------------
        llenarcombo("select * from ValidezCondicion", CboValidez)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("frmEdicionCot2018-2019", "Error al cargar el formulario", Err.Number, cadena)
        'End Try
    End Sub
    Sub llenarcombo(ByVal query As String, ByVal combo As ComboBox)
        '=============================================== METODO PARA LLENAR LOS COMBOS ===================================================
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = query
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            combo.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = query & " where id" & query.Substring(14) & "=1"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        combo.Tag = lectorMetasCotizador(0)
        combo.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
    End Sub
    Sub llenarcombo2(ByVal query As String, ByVal combo As ComboBox)
        '=============================================== METODO PARA LLENAR LOS COMBOS ===================================================
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = query
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        While lectorMetasCotizador.Read()
            combo.Items.Add(lectorMetasCotizador(1))
        End While
        lectorMetasCotizador.Close()
        comandoMetasCotizador.CommandText = query & " where id" & query.Substring(14) & "=2"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        combo.Tag = lectorMetasCotizador(0)
        combo.Text = lectorMetasCotizador(1)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
        editar = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            Dim numDetCot As Integer
            For i = 0 To dgEliminar.Rows.Count - 2
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                comandoMetasCotizador.CommandText = "SELECT COUNT (idListaCotizacion) FROM [DetalleCotizaciones]"
                lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                lectorMetasCotizador.Read()
                eliminar1 = lectorMetasCotizador(0)
                'MsgBox(eliminar1)
                lectorMetasCotizador.Close()
                comandoMetasCotizador.CommandText = "SELECT * FROM [DetalleCotizaciones] where NumCot = " & Val(numCot.Text) & "  and [EquipId] = " & Val(DGCopia.Item(4, i).Value) & ""
                lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                lectorMetasCotizador.Read()
                numDetCot = lectorMetasCotizador(0)
                'MsgBox(numDetCot)
                lectorMetasCotizador.Close()
                MetodoMetasCotizador()
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                            from [MetasCotizador].[dbo].[Cotizaciones]
                            INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				            INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				            INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				            INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				            where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [SetUpEquipment].[EquipId] =" & Val(DGCopia.Item(4, i).Value) & ")
				            begin DELETE FROM [DetalleCotizaciones] where NumCot = " & Val(numCot.Text) & " and [EquipId] =" & Val(DGCopia.Item(4, i).Value) & "
                            end else begin print 'articulo eliminado de la cot' end"
                Dim c As New SqlCommand(R, conexionMetasCotizador)
                c.ExecuteNonQuery()
                lectorMetasCotizador.Close()
                MetodoMetasCotizador()
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                comandoMetasCotizador.CommandText = "SELECT COUNT (idListaCotizacion) FROM [DetalleCotizaciones]"
                lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                lectorMetasCotizador.Read()
                eliminar2 = lectorMetasCotizador(0)
                lectorMetasCotizador.Close()
                'MsgBox(eliminar2)
                If eliminar1.ToString <> eliminar2.ToString Then
                    R = "DELETE FROM [ServiciosEnCotizaciones] WHERE [ServiciosEnCotizaciones].idListaCotizacion = " & numDetCot & ""
                    Dim a As New SqlCommand(R, conexionMetasCotizador)
                    a.ExecuteNonQuery()
                End If
                DGCopia.Rows.RemoveAt(DGCopia.CurrentRow.Index)
                DGServicios.Rows.RemoveAt(DGServicios.CurrentRow.Index)
            Next i
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("frmEdicionCot2018-2019", "Error al Eliminar partidad", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtnAgregarArticulos_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulos.Click
        FrmArticulos.Show()
    End Sub

    Private Sub DGCopia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCopia.CellContentClick
        If e.ColumnIndex = DGCopia.Columns.Item("Column4").Index Then
            ' DGServicios.Rows.Add(DGCopia.Rows(e.RowIndex).Cells(0).Value)
            'MostrarServicios
            Dim Admin As New Cotizaciones
            'Admin.txtEquipID.Text = DGCopia.Rows(e.RowIndex).Cells(0).Value
            'Admin.txtIDListaDetalle.Text = Val(DGCopia.Rows(e.RowIndex).Cells(0).Value)
            Admin.consultaServicios(DGCopia.Rows(e.RowIndex).Cells(0).Value)
            'Admin.txtIDListaDetalle.Text = DGAdicionales
            Admin.ShowDialog()
        End If
        If e.ColumnIndex = DGCopia.Columns.Item("Eliminar").Index Then
            dgEliminar.Rows.Add(DGCopia.Rows(e.RowIndex).Cells(4).Value)
        End If
    End Sub

    Private Sub BtGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        Try
            Using conexion As New SqlConnection(conexionCotizadortransac)
                conexion.Open()
                Dim transaction As SqlTransaction
                transaction = conexion.BeginTransaction("Sample")
                Dim comando As SqlCommand = conexion.CreateCommand()
                Dim lector As SqlDataReader
                comando.Connection = conexion
                comando.Transaction = transaction
                fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
                fecharecepcion = Convert.ToDateTime(DTPHasta.Text).ToShortDateString
                '================================================================== GUARDAR EN COTIZACIONES ==================================================================================================
                R = "insert into Cotizaciones (idContacto, Origen, idLugarCondicion, idCuandoCondicion, idModalidadCondicion, idTiempoEntregaCondicion, idPagoCondicion, idLeyendaCondicion,
                    idValidezCondicion,idMonedaCondicion,idDocumentoCondicion,idModoCont,Referencia,FechaDesde,FechaHasta,Observaciones,idUsuarioCotizacion,Subtotal,IVA,Total,Creado)
                    values (" & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
                    Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
                    txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "'," & Val(txtCotizo2019.Text) & "," & subtotal & "," & iva & "," & Total & ",0)"
                comando.CommandText = R
                comando.ExecuteNonQuery()
                '============================================================================================================================================================================================
                '========================================================== SACAR EL ULTIMO REGISTRO DE COTIZACION PARA EL DETALLE DE COTIZACION=============================================================
                R = "select MAX(Numcot) from [Cotizaciones]"
                comando.CommandText = R
                lector = comando.ExecuteReader
                lector.Read()
                If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
                    maximo = 1
                Else
                    maximo = lector(0)
                End If
                lector.Close()
                '============================================================================================================================================================================================
                '===================================================================== INSERTAR EN DETALLE DE COTIZACIONES===================================================================================
                For i = 0 To DGCopia.Rows.Count - 2

                    R = "insert into DetalleCotizaciones (NumCot,EquipId, PartidaNo,Cantidad, CantidadReal, identificadorInventarioCliente, Serie, Observaciones) values (" &
                         maximo & "," & DGCopia.Item(0, i).Value & "," & Val(DGCopia.Item(1, i).Value) & ",
                         " & Val(DGCopia.Item(5, i).Value) & "," & Val(DGCopia.Item(5, i).Value) & ",'" & (DGCopia.Item(8, i).Value) & "','" & (DGCopia.Item(9, i).Value) & "','" & (DGCopia.Item(7, i).Value) & "')"
                    'MsgBox(R)
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                Next i
                '============================================================================================================================================================================================
                '============================================================= INSERTAR EN DETALLE DE SERVICIOS DE DETALLE DE COTIZACIONE ===================================================================
                '////////////////////////////////////// CODIGO PARA SACAR EL IDDETALLE PARA LA TABLA DE SERVICIOS //////////////////////////////////
                For i = 0 To DGServicios.Rows.Count - 2
                    R = "select idListaCotizacion from DetalleCotizaciones where NumCot=" & maximo & " and EquipId=" & DGServicios.Item(0, i).Value
                    comando.CommandText = R
                    lector = comando.ExecuteReader
                    lector.Read()
                    idlista = lector(0)
                    lector.Close()
                    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    '/////////////////////////////////////// INSERTAR EN SERVICIOS DE DETALLE DE COTIZACION ///////////////////////////////////////////
                    R = "insert into ServiciosEnCotizaciones (idListaCotizacion, idServicio) values (" & idlista & "," & Val(DGServicios.Item(1, i).Value) & ")"
                    comando.CommandText = R
                    comando.ExecuteNonQuery()
                    '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                Next
                '============================================================================================================================================================================================
                Try
                    If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        transaction.Commit()
                        MsgBox("El Cotización se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                    Else
                        transaction.Rollback()
                        Me.Dispose()
                    End If
                Catch ex As Exception
                    MsgBox("Commit Exception type: {0} no se pudo insertar por error", MsgBoxStyle.Critical, "Error externo al Sistema")
                    Try
                        transaction.Rollback()
                    Catch ex1 As Exception
                        MsgBox("Error RollBack", MsgBoxStyle.Critical, "Error interno del Sistema")
                    End Try
                End Try
                conexion.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
End Class
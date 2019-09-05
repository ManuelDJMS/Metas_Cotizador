Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Public Class FrmEdicionCot
    Dim subtotal As Decimal
    Dim maximo As Integer
    Dim inventarioCliente, observacion As String
    Dim idlista As Integer
    Dim agregar1, agregar2 As Integer
    Dim eliminar1, eliminar2 As Integer
    Dim marcaGen, modGen As String
    Private Sub FrmEdicionCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        If editar = True Then
                DGCopia.Rows.Clear()
                DGServicios.Rows.Clear()
                DGCopia.Columns(9).Width = 80
                DGCopia.Columns(10).Width = 80
                DGCopia.Columns(8).Visible = True
                btGuardarInf.Text = "ACTUALIZAR COT"
                numCot.Visible = True
                btGuardarInf.Visible = True
                btActualizarCliente.Visible = True
                btnEliminar.Visible = True
                Button1.Visible = False
                btnAgregarArticulos.Visible = True
                Label79.Text = "Actualizar COTIZACIÓN NUM. "
                MetodoMetasCotizador()
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                comandoMetasCotizador.CommandText = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre,[SetupCustomerDetails].[CustomerId],[CompanyName],[TaxIDNo],
        [ContAddress1] AS DomCont,[ContCity], [ContState],[Phone],[SetupCustomerDetails].[Email],
        PartidaNo,[SetUpEquipment].[EquipmentName] AS Articulo, [Mfr],[Model],[SetUpEquipment].[EquipId], [DetalleCotizaciones].[Observaciones], [SetupServices].[ServicesId],
        [SetupServices].[ServiceName],[idUsuarioCotizacion],[Referencia], [DetalleCotizaciones].[idListaCotizacion],[Subtotal],[Total], [Cantidad]
        from [MetasCotizador].[dbo].[Cotizaciones]
        INNER JOIN [Usuarios] ON [Cotizaciones].[idUsuarioCotizacion] = [Usuarios].[idUsuarioAdministrador]
        INNER JOIN " & servidor & "[SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
        INNER JOIN " & servidor & "[SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                    INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
        INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
        INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
        INNER JOIN [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
        INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
        WHERE [Cotizaciones].NumCot = " & COT2
                lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                While lectorMetasCotizador.Read()
                    numCot.Text = lectorMetasCotizador(0)
                    txtNombreC.Text = lectorMetasCotizador(3)
                    txtCveContacto.Text = lectorMetasCotizador(4)
                    txtNombreEmpresa.Text = lectorMetasCotizador(5)
                    txtNumCond.Text = lectorMetasCotizador(6)
                    txtDomicilio.Text = lectorMetasCotizador(7)
                    txtCiudad.Text = lectorMetasCotizador(8)
                    txtEstado.Text = lectorMetasCotizador(9)
                    txtTelefono.Text = lectorMetasCotizador(10)
                    TextCorreo.Text = lectorMetasCotizador(11)
                    txtCotizo2019.Text = lectorMetasCotizador(20)
                    DTPDesde.Value = lectorMetasCotizador(1)
                    DTPHasta.Value = lectorMetasCotizador(2)
                    txtReferencia.Text = lectorMetasCotizador(21)
                    TextSubtotal.Text = lectorMetasCotizador(23)
                    precio = lectorMetasCotizador(23)
                    TextTotal.Text = lectorMetasCotizador(24)
                    DGCopia.Rows.Add(lectorMetasCotizador(16), lectorMetasCotizador(12), lectorMetasCotizador(13), lectorMetasCotizador(14), lectorMetasCotizador(15), lectorMetasCotizador(25), True, lectorMetasCotizador(17))
                    DGServicios.Rows.Add(lectorMetasCotizador(16), lectorMetasCotizador(18), lectorMetasCotizador(23), lectorMetasCotizador(22))
                End While
                lectorMetasCotizador.Close()
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                comandoMetasCotizador.CommandText = "Select MAX(idListaCotizacion) from [DetalleCotizaciones]"
                lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                lectorMetasCotizador.Read()
                numPartida = lectorMetasCotizador(0)
            Else




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
            End If
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
    Sub seleccioncombo(ByVal tabla As String, ByVal combo As ComboBox)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo moneda ------------------------
        comandoMetasCotizador.CommandText = "select * from " & tabla & " where Descripcion='" & combo.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        combo.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
        editar = False
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Try
        Dim numDetCot As Integer
        For i = 0 To dgEliminar.Rows.Count - 2
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            comandoMetasCotizador.CommandText = "SELECT COUNT (idListaCotizacion) FROM [DetalleCotizaciones]"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            eliminar1 = lectorMetasCotizador(0)
            'MsgBox(eliminar1)
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "SELECT * FROM [DetalleCotizaciones] where NumCot = " & Val(numCot.Text) & ""
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
				            where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [SetUpEquipment].[EquipId] =" & Val(DGCopia.Item(0, i).Value) & ")
				            begin DELETE FROM [DetalleCotizaciones] where NumCot = " & Val(numCot.Text) & " and [EquipId] =" & Val(DGCopia.Item(0, i).Value) & "
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
                R = "DELETE FROM [ServiciosEnCotizaciones] WHERE [ServiciosEnCotizaciones].idListaCotizacion = " & Val(DGServicios.Item(3, i).Value) & ""
                Dim a As New SqlCommand(R, conexionMetasCotizador)
                a.ExecuteNonQuery()
            End If
            DGCopia.Rows.RemoveAt(DGCopia.CurrentRow.Index)
            DGServicios.Rows.RemoveAt(DGServicios.CurrentRow.Index)
        Next i
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("frmEdicionCot2018-2019", "Error al Eliminar partidad", Err.Number, cadena)
        'End Try
    End Sub

    Private Sub CboValidez_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboValidez.SelectedIndexChanged
        seleccioncombo("ValidezCondicion", CboValidez)
    End Sub

    Private Sub CboTiempo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTiempo.SelectedIndexChanged
        seleccioncombo("TiempoEntregaCondicion", CboTiempo)
    End Sub

    Private Sub CboServicio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboServicio.SelectedIndexChanged
        seleccioncombo("LugarCondicion", cboServicio)
    End Sub

    Private Sub CboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboMoneda.SelectedIndexChanged
        seleccioncombo("MonedaCondicion", CboMoneda)
    End Sub

    Private Sub CbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbModalidad.SelectedIndexChanged
        seleccioncombo("ModalidadCondicion", CbModalidad)
    End Sub

    Private Sub CboLeyenda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboLeyenda.SelectedIndexChanged
        seleccioncombo("LeyendaCondicion", CboLeyenda)
    End Sub

    Private Sub CboContabilizar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboContabilizar.SelectedIndexChanged
        seleccioncombo("Modo_de_Contabilizar", CboContabilizar)
    End Sub

    Private Sub Cbcuando_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbcuando.SelectedIndexChanged
        seleccioncombo("CuandoCondicion", Cbcuando)
    End Sub

    Private Sub ComboDocCond_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboDocCond.SelectedIndexChanged
        seleccioncombo("DocumentosCondicion", ComboDocCond)
    End Sub

    Private Sub CCondPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CCondPago.SelectedIndexChanged
        seleccioncombo("PagoCondicion", CCondPago)
    End Sub

    Private Sub DGCopia_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGCopia.CellEndEdit
        '================================================================== CODIGO PARA CAMBIAR LA CANTIDAD Y SACAR PRECIOS NUEVOS ===============================================================
        Try
            If e.ColumnIndex = DGCopia.Columns.Item("Column8").Index Then
                Dim r As Integer
                Dim f As Integer
                Dim cantidad As Integer
                Dim total As Decimal
                r = DGCopia.CurrentCell.RowIndex
                f = DGCopia.Item(0, r).Value
                cantidad = DGCopia.Item(5, r).Value
                For i = 0 To DGServicios.Rows.Count - 1
                    If f = DGServicios.Rows(i).Cells(0).Value Then
                        DGServicios.Rows(i).Cells(2).Value = cantidad * DGServicios.Rows(i).Cells(2).Value
                        Exit For
                    End If
                Next
                subtotal = 0
                For Each fila In DGServicios.Rows
                    subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
                Next
                iva = (subtotal * 0.16)
                total = subtotal + iva
                TextSubtotal.Text = subtotal
                TextTotal.Text = total
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al realizar un descuento en el DataGrid", Err.Number, cadena)
        End Try
    End Sub
    'ARRASTRAR EL FORMULARIO
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel2.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BtnAgregarArticulos_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulos.Click
        FrmArticulos.Show()
    End Sub

    Private Sub DGCopia_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGCopia.CellContentClick
        If e.ColumnIndex = DGCopia.Columns.Item("Column4").Index Then
            Dim Admin As New Cotizaciones
            Admin.consultaServicios(DGCopia.Rows(e.RowIndex).Cells(0).Value)
            Admin.ShowDialog()
        End If
        If e.ColumnIndex = DGCopia.Columns.Item("Eliminar").Index Then
            dgEliminar.Rows.Add(DGCopia.Rows(e.RowIndex).Cells(4).Value)
        End If
    End Sub

    Private Sub BtGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
        'Try
        Using conexion As New SqlConnection(conexionCotizadortransac)
                conexion.Open()
                Dim transaction As SqlTransaction
                transaction = conexion.BeginTransaction("Sample")
                Dim comando As SqlCommand = conexion.CreateCommand()
                Dim lector As SqlDataReader
                comando.Connection = conexion
            comando.Transaction = transaction

            If txtCotizo2019.Text.Equals("") Or txtCotizo2019.Text = "" Or DGServicios.Rows.Count = 0 Then
                MsgBox("Falta agregar el usuario que realizo la cotización¡", MsgBoxStyle.Critical)
            Else
                observacion = ""
                'Actualizar Los datos de la cotizacion
                'Consultar la ultima cotizacion y asignarla a un LABEL para poder hacer el update conforme al LABEL
                If btGuardarInf.Text = "ACTUALIZAR COT" Then
                    MetodoMetasCotizador()
                    Dim R As String
                    R = "update Cotizaciones set FechaDesde='" & DTPDesde.Value & "', FechaHasta='" & DTPHasta.Value & "', idContacto='" & txtCveContacto.Text & "', 
                         idUsuarioCotizacion= " & Val(txtCotizo2019.Text) & ",  Referencia='" & txtReferencia.Text & "', Subtotal='" & TextSubtotal.Text & "',
                         Total='" & TextTotal.Text & "',IVA ='" & TextTotal.Text - TextSubtotal.Text & "'
                         where NumCot = " & Val(numCot.Text) & ""
                    Dim com As New SqlCommand(R, conexionMetasCotizador)
                    com.ExecuteNonQuery()

                    '-----INSERTA EN DETALLECOTIZACIONES-------
                    For i = 0 To DGCopia.Rows.Count - 2
                        R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                            from [MetasCotizador].[dbo].[Cotizaciones]
                            INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				            INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				            INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				            INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				            where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [SetUpEquipment].[EquipId] =" & Val(DGCopia.Item(0, i).Value) & ")
				            begin print 'El artículo ya esta registrado en la COT' end else begin insert into [MetasCotizador].[dbo].[DetalleCotizaciones]([NumCot],[EquipId],[PartidaNo],[Cantidad],[CantidadReal],[identificadorInventarioCliente])
				            values(" & Val(numCot.Text) & ", " & Val(DGCopia.Item(0, i).Value) & ",(select top 1 PartidaNo + 1 as partida from [MetasCotizador].[dbo].[DetalleCotizaciones] where NumCot =" & Val(numCot.Text) & " order by PartidaNo), " & Val(DGCopia.Item(5, i).Value) & ", '0'," & Val(DGCopia.Item(9, i).Value) & "); end"
                        Dim c As New SqlCommand(R, conexionMetasCotizador)
                        c.ExecuteNonQuery()
                        If DGCopia.Item(2, i).Value.ToString = "GENERICO" Then
                            observacion = DGCopia.Item(6, i).Value
                            'MsgBox(observacion)
                            marcaGen = InputBox("¿Deseas agregar la marca del articulo: """ & DGCopia.Item(1, i).Value.ToString & """?", "Marca")
                            modGen = InputBox("¿Deseas agregar el modelo del articulo: """ & DGCopia.Item(1, i).Value.ToString & """?", "Modelo")
                            observacion = observacion + "MARCA: " + marcaGen + "  MODELO:" + modGen
                        Else
                            'MsgBox("no se agrega se actualiza observaciones")
                            R = "update DetalleCotizaciones set Observaciones='" & DGCopia.Item(6, i).Value & "'
                        where idListaCotizacion =" & Val(DGCopia.Item(0, i).Value) & ""
                            Dim u As New SqlCommand(R, conexionMetasCotizador)
                            u.ExecuteNonQuery()
                        End If
                        lectorMetasCotizador.Close()
                    Next i
                    '----------------INSERTA EN SERVICIOSENCOTIZACIONES
                    For i = 0 To DGCopia.Rows.Count - 2
                        For a = 0 To DGServicios.Rows.Count - 2
                            MetodoMetasCotizador()
                            R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                        from [MetasCotizador].[dbo].[Cotizaciones]
                        INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				        INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				        INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				        INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				        where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [ServiciosEnCotizaciones].idListaCotizacion=" & Val(DGServicios.Item(0, i).Value) & ")
				        begin print 'El servicio ya esta' end else 
                        begin insert into [MetasCotizador].[dbo].[ServiciosEnCotizaciones]([idListaCotizacion],[idServicio])VALUES((select idListaCotizacion from DetalleCotizaciones where NumCot=" & Val(numCot.Text) & " and EquipId=" & Val(DGCopia.Item(0, i).Value) & ")," & Val(DGServicios.Item(a, i).Value) & "); end"
                            'MsgBox(R)
                            Dim x As New SqlCommand(R, conexionMetasCotizador)
                            x.ExecuteNonQuery()
                            conexionMetasCotizador.Close()
                        Next a
                    Next i
                    conexionMetasCotizador.Close()
                    MsgBox("Cotización " & numCot.Text & " Actualizada correctamente")
                    DGCopia.Rows.Clear()
                Else
                    '================================================================== GUARDAR EN COTIZACIONES ==================================================================================================
                    R = "insert into Cotizaciones (idContacto, Origen, idLugarCondicion, idCuandoCondicion, idModalidadCondicion, idTiempoEntregaCondicion, idPagoCondicion, idLeyendaCondicion,
                    idValidezCondicion,idMonedaCondicion,idDocumentoCondicion,idModoCont,Referencia,FechaDesde,FechaHasta,Observaciones,idUsuarioCotizacion,Subtotal,IVA,Total,Creado)
                    values (" & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
                        Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
                        txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "'," & Val(txtCotizo2019.Text) & "," & subtotal & "," & iva & "," & Total & ",0)"
                    comando.CommandText = R
                    MsgBox(R)
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
                        MsgBox("insert")
                        R = "insert into ServiciosEnCotizaciones (idListaCotizacion, idServicio) values (" & idlista & "," & Val(DGServicios.Item(1, i).Value) & ")"
                        comando.CommandText = R
                        comando.ExecuteNonQuery()
                        '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                    Next
                End If
            End If
            '============================================================================================================================================================================================
            Try
                    If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                        transaction.Commit()
                        MsgBox("La Cotización se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                        Me.Dispose()
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
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        'End Try
    End Sub
End Class
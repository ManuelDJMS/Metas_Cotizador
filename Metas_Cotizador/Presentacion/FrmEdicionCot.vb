Imports System.Data.SqlClient
Imports System.Runtime.InteropServices
Imports Microsoft.Reporting.WinForms
Imports System.Configuration
Imports System.Reflectio
Public Class FrmEdicionCot
    Dim subtotal As Decimal
    Dim maximo As Integer
    Dim inventarioCliente As String
    Dim observacion As String = ""
    Dim observacion2 As String = ""
    Dim idlista As Integer
    Dim agregar1, agregar2 As Integer
    Dim eliminar1, eliminar2 As Integer
    Dim marcaGen, modGen As String
    Private Sub FrmEdicionCot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        If editar = 1 Then
                'MsgBox("1")
                DGCopia.Rows.Clear()
                DGServicios.Rows.Clear()
                DGCopia.Columns(9).Width = 80
                DGCopia.Columns(10).Width = 80
                DGCopia.Columns(8).Visible = True
                btGuardarInf.Text = "ACTUALIZAR COT"
                lbCotizo.Visible = False
                txtCotizo2019.Visible = False
                numCot.Visible = True
                btGuardarInf.Visible = True
                btActualizarCliente.Visible = True
                btnEliminar.Visible = True
                btnAgregarArticulos.Visible = True
                Label79.Text = "ACTUALIZAR COTIZACIÓN NUM. "
                MetodoMetasCotizador()
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                comandoMetasCotizador.CommandText = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre,[SetupCustomerDetails].[CustomerId],[SetupCustomerDetails].[CompanyName],[TaxIDNo],
                [ContAddress1] AS DomCont,[ContCity], [ContState],[SetupCustomerDetails].[Phone],[SetupCustomerDetails].[Email],
                PartidaNo,[SetUpEquipment].[EquipmentName] AS Articulo, [Mfr],[Model],[SetUpEquipment].[EquipId], [DetalleCotizaciones].[Observaciones], [SetupServices].[ServicesId],
                [SetupServices].[ServiceName],[idUsuarioCotizacion],[Referencia], [DetalleCotizaciones].[idListaCotizacion],[Subtotal],[Total], [Cantidad], [SetupEquipmentServiceMapping].Price,[Serie],[identificadorInventarioCliente],[ObservacionesServicios] 
                from [MetasCotizador].[dbo].[Cotizaciones]
                LEFT JOIN " & servidor & " [UserMaster] ON [Cotizaciones].[idUsuarioCotizacion] COLLATE SQL_Latin1_General_CP1_CI_AS = [UserMaster].[UserID]
                LEFT JOIN " & servidor & "[SetupCustomerDetails] ON [Cotizaciones].idContacto = [SetupCustomerDetails].[CustomerId]
                LEFT JOIN " & servidor & "[SetupCustomerAddressDtls] ON [SetupCustomerDetails].[CustomerId] = [SetupCustomerAddressDtls].[CustomerId]
                LEFT JOIN " & servidor2 & " [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
                LEFT JOIN " & servidor2 & " [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
                LEFT JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
                LEFT JOIN " & servidor2 & " [ModalidadCondicion] ON [Cotizaciones].[idModalidadCondicion] = [ModalidadCondicion].[idModalidadCondicion]
                LEFT JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
                LEFT JOIN " & servidor & " [SetupEquipmentServiceMapping] ON [SetUpEquipment].[EquipId] =[SetupEquipmentServiceMapping].[EquipId] 	
                WHERE [Cotizaciones].NumCot = " & COT2 & "order by PartidaNo"

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
                    DGCopia.Rows.Add(lectorMetasCotizador(16), lectorMetasCotizador(12), lectorMetasCotizador(13), lectorMetasCotizador(14), lectorMetasCotizador(15), lectorMetasCotizador(25), True, lectorMetasCotizador(17), False, lectorMetasCotizador(28), lectorMetasCotizador(27), lectorMetasCotizador(29))
                    DGServicios.Rows.Add(lectorMetasCotizador(16), lectorMetasCotizador(18), lectorMetasCotizador(26), lectorMetasCotizador(22))
                    numPartida = lectorMetasCotizador(12)
                End While
            ElseIf editar = 2 Then
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
                where [SetupCustomerDetails].CustomerId=" & empresa
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
                total = subtotal + iva
                TextSubtotal.Text = subtotal
                TextTotal.Text = total
            Else
                lbTiituloClave.Visible = False
                txtCveContacto.Visible = False
                Label22.Visible = False
                For Each fila In DGServicios.Rows
                    subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
                Next
                iva = (subtotal * 0.16)
                total = subtotal + iva
                TextSubtotal.Text = subtotal
                TextTotal.Text = total
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
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmEdicionCot", "Error en el metodo de llenado de los combos", Err.Number, cadena)
        End Try
    End Sub
    Sub llenarcombo2(ByVal query As String, ByVal combo As ComboBox)
        '=============================================== METODO PARA LLENAR LOS COMBOS ===================================================
        Try
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
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmEdicionCot", "Error en el metodo de llenado de los combos 2", Err.Number, cadena)
        End Try
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
        editar = False
        Me.Dispose()
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
                lectorMetasCotizador.Close()
                comandoMetasCotizador.CommandText = "SELECT * FROM [DetalleCotizaciones] where NumCot = " & Val(numCot.Text) & ""
                lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                lectorMetasCotizador.Read()
                numDetCot = lectorMetasCotizador(0)
                lectorMetasCotizador.Close()
                MetodoMetasCotizador()
                comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                            from [Cotizaciones]
                            INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				            INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				            INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				            INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				            where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [SetUpEquipment].[EquipId] =" & Val(DGCopia.Item(0, i).Value) & ")
				            begin DELETE FROM [DetalleCotizaciones] where NumCot = " & Val(numCot.Text) & " and [idListaCotizacion] =" & Val(DGServicios.Item(3, i).Value) & "
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
                If eliminar1.ToString <> eliminar2.ToString Then
                    R = "DELETE FROM [ServiciosEnCotizaciones] WHERE [ServiciosEnCotizaciones].idListaCotizacion = " & Val(DGServicios.Item(3, i).Value) & ""
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
            Bitacora("frmEdicionCot", "Error al Eliminar partidad", Err.Number, cadena)
        End Try
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
            Bitacora("FrmEdicionCot", "Error al realizar un descuento en el DataGrid", Err.Number, cadena)
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

    Private Sub btActualizarCliente_Click(sender As Object, e As EventArgs) Handles btActualizarCliente.Click
        FrmContactos.Show()
    End Sub

    Private Sub DGServicios_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGServicios.CellEndEdit
        '================================================================== CODIGO PARA CAMBIAR LA CANTIDAD Y SACAR PRECIOS NUEVOS ===============================================================
        Try
            subtotal = 0
            For Each fila In DGServicios.Rows
                subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
            Next
            iva = (subtotal * 0.16)
            Total = subtotal + iva
            TextSubtotal.Text = subtotal
            TextTotal.Text = Total
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Ventas", "Error al realizar un descuento en el DataGrid", Err.Number, cadena)
        End Try
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
        If DGServicios.Rows.Count = 0 Then
            MsgBox("Falta agregar el usuario que realizo la cotización¡", MsgBoxStyle.Critical)
        Else
            Try
                fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
                fecharecepcion = Convert.ToDateTime(DTPHasta.Text).ToShortDateString
                Using conexion As New SqlConnection(conexionCotizadortransac)
                    conexion.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion.CreateCommand()
                    Dim lector As SqlDataReader
                    comando.Connection = conexion
                    comando.Transaction = transaction
                    'Actualizar Los datos de la cotizacion
                    'Consultar la ultima cotizacion y asignarla a un LABEL para poder hacer el update conforme al LABEL
                    If btGuardarInf.Text = "ACTUALIZAR COT" Then
                        MetodoMetasCotizador()
                        Dim R As String
                        R = "update Cotizaciones set FechaDesde='" & DTPDesde.Value & "', FechaHasta='" & DTPHasta.Value & "', idContacto='" & txtCveContacto.Text & "', 
                         idUsuarioCotizacion= " & Val(txtCotizo2019.Text) & ",  Referencia='" & txtReferencia.Text & "', Subtotal=" & TextSubtotal.Text & ",
                         Total=" & TextTotal.Text & ",IVA =" & TextTotal.Text - TextSubtotal.Text & "where NumCot = " & Val(numCot.Text) & ""
                        Dim com As New SqlCommand(R, conexionMetasCotizador)
                        com.ExecuteNonQuery()
                        '-----INSERTA EN DETALLECOTIZACIONES-------
                        For i = 0 To DGCopia.Rows.Count - 2
                            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                            comandoMetasCotizador.CommandText = "select top 1 [idListaCotizacion] from [DetalleCotizaciones] order by  [idListaCotizacion] desc"
                            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                            lectorMetasCotizador.Read()
                            agregar1 = lectorMetasCotizador(0)
                            lectorMetasCotizador.Close()
                            R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                            from [Cotizaciones]
                            INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				            INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				            INNER JOIN " & servidor & "[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				            INNER JOIN " & servidor & "[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				            where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [SetUpEquipment].[EquipId] =" & Val(DGCopia.Item(0, i).Value) & " and [DetalleCotizaciones].[PartidaNo] =" & Val(DGCopia.Item(1, i).Value) & ")
				            begin print 'El artículo ya esta registrado en la COT' end else begin insert into [MetasCotizador].[dbo].[DetalleCotizaciones]([NumCot],[EquipId],[PartidaNo],[Cantidad],[CantidadReal],[identificadorInventarioCliente],[Serie],[ObservacionesServicios])
				            values(" & Val(numCot.Text) & ", " & Val(DGCopia.Item(0, i).Value) & "," & Val(DGCopia.Item(1, i).Value) & "," & Val(DGCopia.Item(5, i).Value) & ", " & Val(DGCopia.Item(5, i).Value) & ",'" & DGCopia.Item(9, i).Value & "','" & DGCopia.Item(10, i).Value & "','" & DGCopia.Item(11, i).Value & "'); end"
                            Dim c As New SqlCommand(R, conexionMetasCotizador)
                            c.ExecuteNonQuery()
                            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                            comandoMetasCotizador.CommandText = "select top 1 [idListaCotizacion] from [MetasCotizador].[dbo].[DetalleCotizaciones] order by [idListaCotizacion] desc"
                            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                            lectorMetasCotizador.Read()
                            agregar2 = lectorMetasCotizador(0)
                            lectorMetasCotizador.Close()
                            observacion = DGCopia.Item(7, i).Value
                            observacion2 = DGCopia.Item(11, i).Value
                            If agregar1.ToString <> agregar2.ToString Then
                                If DGCopia.Item(2, i).Value.ToString = "GENERICO" Or DGCopia.Item(2, i).Value.ToString = "Generico" Then
                                    observacion = DGCopia.Item(7, i).Value
                                    marcaGen = InputBox("¿Deseas agregar la marca del articulo: """ & DGCopia.Item(2, i).Value.ToString & """?", "Marca")
                                    modGen = InputBox("¿Deseas agregar el modelo del articulo: """ & DGCopia.Item(2, i).Value.ToString & """?", "Modelo")

                                    observacion = observacion + "Marca: " + marcaGen + "  Modelo:" + modGen
                                    Dim cad As String = "update DetalleCotizaciones set  Observaciones='" & observacion & "'where idListaCotizacion =" & Val(DGServicios.Item(3, i).Value) & ""
                                    Dim v As New SqlCommand(cad, conexionMetasCotizador)
                                    'MsgBox("adshaskjdkjahdskjads")
                                    v.ExecuteNonQuery()
                                Else
                                    R = "update DetalleCotizaciones set  Observaciones='" & observacion & "'where idListaCotizacion =" & agregar2 & ""
                                    Dim v As New SqlCommand(R, conexionMetasCotizador)
                                    v.ExecuteNonQuery()
                                    R = "update DetalleCotizaciones set  [ObservacionesServicios]='" & observacion2 & "'where idListaCotizacion =" & agregar2 & ""
                                    Dim b As New SqlCommand(R, conexionMetasCotizador)
                                    b.ExecuteNonQuery()
                                    R = "insert into ServiciosEnCotizaciones (idListaCotizacion, idServicio) values (" & agregar2 & "," & Val(DGServicios.Item(1, i).Value) & ")"
                                    comando.CommandText = R
                                    comando.ExecuteNonQuery()
                                End If
                            Else
                                R = "update DetalleCotizaciones set  Observaciones='" & observacion & "'where idListaCotizacion =" & Val(DGServicios.Item(3, i).Value) & ""
                                Dim v As New SqlCommand(R, conexionMetasCotizador)
                                v.ExecuteNonQuery()
                                R = "update DetalleCotizaciones set  [ObservacionesServicios]='" & observacion2 & "'where idListaCotizacion =" & Val(DGServicios.Item(3, i).Value) & ""
                                Dim b As New SqlCommand(R, conexionMetasCotizador)
                                b.ExecuteNonQuery()
                            End If
                        Next i
                        conexionMetasCotizador.Close()
                        DGCopia.Rows.Clear()
                    Else
                        '================================================================== GUARDAR EN COTIZACIONES ==================================================================================================
                        If editar2 = True Then
                            '***************************************************** INSERTAR DATOS EN LA TABLA DE CONTACTOS **************************************************************
                            R = "insert into ClientesInformales (Contacto, Empresa, RFC, Domicilio, Cp, Ciudad, Estado, Telefono, Correo) values ('" & txtNombreC.Text & "','" & txtNombreEmpresa.Text &
                                "','" & txtNumCond.Text & "','" & txtDomicilio.Text & "','" & txtcp.Text & "','" & txtCiudad.Text & "','" & txtEstado.Text & "','" & txtTelefono.Text & "','" & TextCorreo.Text & "')"
                            comando.CommandText = R
                            comando.ExecuteNonQuery()
                            '========================================================== SACAR EL ULTIMO REGISTRO DEL CONTACTO PARA EL DETALLE DE COTIZACION=============================================================
                            R = "select MAX(idCliente) from [ClientesInformales]"
                            comando.CommandText = R
                            lector = comando.ExecuteReader
                            lector.Read()
                            If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
                                maximo = 1
                            Else
                                maximo = lector(0)
                            End If
                            lector.Close()
                            '==============================================================================================================================================================================================
                            R = "insert into Cotizaciones (idContacto, Origen, idLugarCondicion, idCuandoCondicion, idModalidadCondicion, idTiempoEntregaCondicion, idPagoCondicion, idLeyendaCondicion,
                                idValidezCondicion,idMonedaCondicion,idDocumentoCondicion,idModoCont,Referencia,FechaDesde,FechaHasta,Observaciones,idUsuarioCotizacion,Subtotal,IVA,Total,Creado)
                                values (" & maximo & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
                            Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
                            txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "','" & usuario & "'," & subtotal & "," & iva & "," & total & ",0)"
                            comando.CommandText = R
                            comando.ExecuteNonQuery()
                            '**************************************************** COTIZACION NORMAL *************************************************************************************
                        Else

                            R = "insert into Cotizaciones (idContacto, Origen, idLugarCondicion, idCuandoCondicion, idModalidadCondicion, idTiempoEntregaCondicion, idPagoCondicion, idLeyendaCondicion,
                    idValidezCondicion,idMonedaCondicion,idDocumentoCondicion,idModoCont,Referencia,FechaDesde,FechaHasta,Observaciones,idUsuarioCotizacion,Subtotal,IVA,Total,Creado)
                    values (" & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
                                Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
                                txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "','" & usuario & "'," & subtotal & "," & iva & "," & Total & ",0)"
                            comando.CommandText = R
                            comando.ExecuteNonQuery()
                        End If
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
                            If DGCopia.Item(3, i).Value.ToString = "GENERICO" Or DGCopia.Item(3, i).Value.ToString = "Generico" Or DGCopia.Item(3, i).Value.ToString = "Genérico" Then
                                marcaGen = InputBox("¿Deseas agregar la marca del articulo: """ & DGCopia.Item(2, i).Value.ToString & """?", "Marca")
                                modGen = InputBox("¿Deseas agregar el modelo del articulo: """ & DGCopia.Item(2, i).Value.ToString & """?", "Modelo")
                                If marcaGen = "" Or marcaGen = "-" Then
                                    marcaGen = ""
                                Else
                                    marcaGen = " Marca: " & marcaGen
                                End If
                                If modGen = "" Or modGen = "-" Then
                                    modGen = ""
                                Else
                                    modGen = " Modelo: " & modGen
                                End If
                                observacion = observacion + marcaGen + modGen
                            End If
                            R = "insert into DetalleCotizaciones (NumCot,EquipId, PartidaNo,Cantidad, CantidadReal, identificadorInventarioCliente, Serie, Observaciones, ObservacionesServicios) values (" &
                                     maximo & "," & DGCopia.Item(0, i).Value & "," & Val(DGCopia.Item(1, i).Value) & ",
                         " & Val(DGCopia.Item(5, i).Value) & "," & Val(DGCopia.Item(5, i).Value) & ",'" & (DGCopia.Item(9, i).Value) & "','" & (DGCopia.Item(10, i).Value) & "','" & (DGCopia.Item(7, i).Value) + observacion & "','" & (DGCopia.Item(11, i).Value) & "')"
                            comando.CommandText = R
                            comando.ExecuteNonQuery()
                            marcaGen = ""
                            modGen = ""
                            observacion = ""
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
                            R = "insert into ServiciosEnCotizaciones (idListaCotizacion, idServicio, Precio) values (" & idlista & "," & Val(DGServicios.Item(1, i).Value) & "," & CDbl(DGServicios.Item(2, i).Value) & ")"
                            comando.CommandText = R
                            comando.ExecuteNonQuery()
                            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        Next
                    End If

                    '============================================================================================================================================================================================
                    Try
                        If MessageBox.Show("¿Desea Guardar la información?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.Yes Then
                            transaction.Commit()
                            MsgBox("La Cotización " & maximo & " se guardó correctamente", MsgBoxStyle.Information, "Guardado Exitoso")
                            FrmCotizacion.DgAgregar.Rows.Clear()
                            imprimircot(maximo)
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
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            End Try
        End If
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
            Data.DataSetName = "Data2"
            Dim Datasource As New ReportDataSource("DataSet2", Data.Tables(0))
            Datasource.Name = "DataSet2"
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
            Dim Reportes As New ReportDataSource("DataSet2", Data.Tables(0))
            FrmReportes.ReportViewer1.LocalReport.DataSources.Clear()
            FrmReportes.ReportViewer1.LocalReport.DataSources.Add(Datasource)
            FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Program Files (x86)\MetAs\Cotizador\Reportes\Report2.rdlc"
            'FrmReportes.ReportViewer1.LocalReport.ReportPath = "C:\Users\Software-TI\Documents\GitHub\Metas_Cotizador\Metas_Cotizador\Reportes\Report2.rdlc"
            FrmReportes.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {p1, p2, p3, p4, p5, p6, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17,
                                                             p19, p20, p21, p22, p23, p24, p25})
            FrmReportes.ReportViewer1.RefreshReport()
            Dim nombreCot As String = "COT"
            nombreCot = nombreCot + COT.ToString
            'MsgBox(nombreCot)
            FrmReportes.Show()
            FrmReportes.ReportViewer1.LocalReport.ReportEmbeddedResource = "MyAppNamespace.Report2.rdlc"
            Dim pdfContent As Byte() = FrmReportes.ReportViewer1.LocalReport.Render("PDF")
            Dim pdfPath As String = "\\10.10.10.7\Public-2\REPORTES\COTIZACIONES\" & nombreCot & ".pdf"
            Dim pdfFile As New System.IO.FileStream(pdfPath, System.IO.FileMode.Create)
            pdfFile.Write(pdfContent, 0, pdfContent.Length)
            pdfFile.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
        cadena = Err.Description
        cadena = cadena.Replace("'", "")
        Bitacora("FrmCotizacion", "Error al reimprimir cotización", Err.Number, cadena)
        End Try
    End Sub
End Class
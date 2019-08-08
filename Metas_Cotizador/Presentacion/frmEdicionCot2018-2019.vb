Imports System.Data.SqlClient
Public Class frmEdicionCot2018_2019
    Dim R As String
    Dim subtotal As Double
    Dim total As Double
    Dim maximo As Integer
    Dim inventarioCliente, observacion As String
    Dim marcaGen, modGen As String
    Dim idContacto As Integer
    Dim agregar1, agregar2 As Integer

    Private Sub frmEdicionCot2018_2019_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Try
        If editar = True Then
            DGCopia.Rows.Clear()
            DGServicios.Rows.Clear()
            btGuardarInf.Text = "ACTUALIZAR COT"
            btGuardarInf.Visible = True
            btActualizarCliente.Visible = True
            Button1.Visible = False
            btnAgregarArticulos.Visible = True
            Label79.Text = "Actualizar COTIZACIÓN NUM. "
            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            comandoMetasCotizador.CommandText = "Select [Cotizaciones].NumCot,FechaDesde,FechaHasta,[FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre,[SetupCustomerDetails].[CustomerId],[CompanyName],[TaxIDNo],
				[ContAddress1] AS DomCont,[ContCity], [ContState],[Phone],[SetupCustomerDetails].[Email],
				PartidaNo,[SetUpEquipment].[EquipmentName] AS Articulo, [Mfr],[Model],[SetUpEquipment].[EquipId], [DetalleCotizaciones].[Observaciones], [SetupServices].[ServicesId],
				[SetupServices].[ServiceName],[idUsuarioCotizacion],[Referencia], [DetalleCotizaciones].[idListaCotizacion],[Subtotal],[Total]
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
                DGCopia.Rows.Add(lectorMetasCotizador(12), lectorMetasCotizador(13), lectorMetasCotizador(14), lectorMetasCotizador(15), lectorMetasCotizador(16), True, lectorMetasCotizador(17))
                DGServicios.Rows.Add(lectorMetasCotizador(22), lectorMetasCotizador(16), lectorMetasCotizador(18), lectorMetasCotizador(19))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            comandoMetasCotizador.CommandText = "Select MAX(idListaCotizacion) from [DetalleCotizaciones]"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            numPartida = lectorMetasCotizador(0)
        Else
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
            For Each fila In DGCotizaciones.Rows
                subtotal += Convert.ToDecimal(fila.Cells("precioUnitario").Value)
            Next
            iva = (subtotal * 0.16)
            total = subtotal + iva
            TextSubtotal.Text = subtotal
            TextTotal.Text = total
            consultaEquipos()
            Button1.PerformClick()
            consultaGeneralDeDetalles(Val(txtMaximo.Text))
            agregar_a_Res()
        End If

            MetodoMetasCotizador()
            comandoMetasCotizador = conexionMetasCotizador.CreateCommand
            '-----------------Combo cuando ------------------------
            comandoMetasCotizador.CommandText = "select * from CuandoCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                Cbcuando.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from CuandoCondicion where idCuandoCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            Cbcuando.Tag = lectorMetasCotizador(0)
            Cbcuando.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo documentps ------------------------
            comandoMetasCotizador.CommandText = "select * from DocumentosCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                ComboDocCond.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from DocumentosCondicion where idDocumentoCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            ComboDocCond.Tag = lectorMetasCotizador(0)
            ComboDocCond.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo Leyenda ------------------------
            comandoMetasCotizador.CommandText = "select * from LeyendaCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CboLeyenda.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from LeyendaCondicion where idLeyendaCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CboLeyenda.Tag = lectorMetasCotizador(0)
            CboLeyenda.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo Lugar ------------------------
            comandoMetasCotizador.CommandText = "select * from LugarCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                cboServicio.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from LugarCondicion where idLugarCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            cboServicio.Tag = lectorMetasCotizador(0)
            cboServicio.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo modalidad ------------------------
            comandoMetasCotizador.CommandText = "select * from ModalidadCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CbModalidad.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from ModalidadCondicion where idModalidadCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CbModalidad.Tag = lectorMetasCotizador(0)
            CbModalidad.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo  modo de contabilizar ------------------------
            comandoMetasCotizador.CommandText = "select * from Modo_de_Contabilizar"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CboContabilizar.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from Modo_de_Contabilizar where idModoCont=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CboContabilizar.Tag = lectorMetasCotizador(0)
            CboContabilizar.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            lectorMetasCotizador.Close()
            '-----------------Combo moneda ------------------------
            comandoMetasCotizador.CommandText = "select * from MonedaCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CboMoneda.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from MonedaCondicion where idMonedaCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CboMoneda.Tag = lectorMetasCotizador(0)
            CboMoneda.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo Pago------------------------
            comandoMetasCotizador.CommandText = "select * from PagoCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CCondPago.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from PagoCondicion where idPagoCondicion=2"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CCondPago.Tag = lectorMetasCotizador(0)
            CCondPago.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo tiempo ------------------------
            comandoMetasCotizador.CommandText = "select * from TiemposEntregaCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CboTiempo.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from TiemposEntregaCondicion where idTiempoEntregaCondicion=2"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CboTiempo.Tag = lectorMetasCotizador(0)
            CboTiempo.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
            '-----------------Combo validez ------------------------
            comandoMetasCotizador.CommandText = "select * from ValidezCondicion"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            While lectorMetasCotizador.Read()
                CboValidez.Items.Add(lectorMetasCotizador(1))
            End While
            lectorMetasCotizador.Close()
            comandoMetasCotizador.CommandText = "select * from ValidezCondicion where idValidezCondicion=1"
            lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
            lectorMetasCotizador.Read()
            CboValidez.Tag = lectorMetasCotizador(0)
            CboValidez.Text = lectorMetasCotizador(1)
            lectorMetasCotizador.Close()
        DGCotizaciones.Visible = False
        alternarColorColumnas(DGCotizaciones)
            alternarColorColumnas(DGCopia)
            alternarColorColumnas(DGServicios)
            alternarColorColumnas(DGEquipos)
            alternarColorColumnas(DGDetalles)
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("frmEdicionCot2018-2019", "Error al cargar el formulario", Err.Number, cadena)
        'End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub txtEliminar_Click(sender As Object, e As EventArgs)
        For i As Integer = DGCotizaciones.Rows.Count() - 1 To 0 Step -1
            Dim delete As Boolean
            delete = DGCotizaciones.Rows(i).Cells(0).Value
            If delete = True Then
                Dim row As DataGridViewRow
                row = DGCotizaciones.Rows(i)
                DGCotizaciones.Rows.Remove(row)
            End If
        Next
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btMinimizar_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btGuardarInf_Click(sender As Object, e As EventArgs) Handles btGuardarInf.Click
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
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()

                '-----INSERTA EN DETALLECOTIZACIONES-------
                For i = 0 To DGCopia.Rows.Count - 2
                    comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                    comandoMetasCotizador.CommandText = "select top 1 [idListaCotizacion] from [MetasCotizador].[dbo].[DetalleCotizaciones] order by  [idListaCotizacion] desc"
                    lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                    lectorMetasCotizador.Read()
                    agregar1 = lectorMetasCotizador(0)
                    lectorMetasCotizador.Close()
                    R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                            from [MetasCotizador].[dbo].[Cotizaciones]
                            INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				            INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				            INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				            INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				            where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [SetUpEquipment].[EquipId] =" & Val(DGCopia.Item(4, i).Value) & ")
				            begin print 'El artículo ya esta registrado en la COT' end else begin insert into [MetasCotizador].[dbo].[DetalleCotizaciones]([NumCot],[EquipId],[PartidaNo],[Cantidad],[CantidadReal],[identificadorInventarioCliente])
				            values(" & Val(numCot.Text) & ", " & Val(DGCopia.Item(4, i).Value) & ",(select top 1 PartidaNo + 1 as partida from [MetasCotizador].[dbo].[DetalleCotizaciones] where NumCot =" & Val(numCot.Text) & " order by PartidaNo), '1', '0','-'); end"
                    Dim c As New SqlCommand(R, conexionMetasCotizador)
                    c.ExecuteNonQuery()

                    comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                    comandoMetasCotizador.CommandText = "select top 1 [idListaCotizacion] from [MetasCotizador].[dbo].[DetalleCotizaciones] order by  [idListaCotizacion] desc"
                    lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                    lectorMetasCotizador.Read()
                    agregar2 = lectorMetasCotizador(0)
                    lectorMetasCotizador.Close()
                    If agregar1.ToString <> agregar2.ToString Then
                        observacion = DGCopia.Item(6, i).Value + ".  "
                        inventarioCliente = InputBox("¿Deseas agregar el número de inventario del articulo: """ & DGCopia.Item(1, i).Value.ToString & """ del cliente?", "No. de Inventario de cliente")
                        Dim cad As String = "update DetalleCotizaciones set identificadorInventarioCliente='" & inventarioCliente & "', Observaciones='" & observacion & "'
                        where idListaCotizacion =" & Val(DGCopia.Item(0, i).Value) & ""
                        Dim t As New SqlCommand(cad, conexionMetasCotizador)
                        t.ExecuteNonQuery()

                        If DGCopia.Item(2, i).Value.ToString = "GENERICO" Then
                            observacion = DGCopia.Item(6, i).Value
                            'MsgBox(observacion)
                            marcaGen = InputBox("¿Deseas agregar la marca del articulo: """ & DGCopia.Item(1, i).Value.ToString & """?", "Marca")
                            modGen = InputBox("¿Deseas agregar el modelo del articulo: """ & DGCopia.Item(1, i).Value.ToString & """?", "Modelo")
                            observacion = observacion + "MARCA: " + marcaGen + "  MODELO:" + modGen
                            MsgBox(observacion)
                            Dim w As String = "update DetalleCotizaciones set  Observaciones='" & observacion & "'where idListaCotizacion =" & Val(DGCopia.Item(0, i).Value) & ""
                            Dim v As New SqlCommand(cad, conexionMetasCotizador)
                            v.ExecuteNonQuery()
                        End If
                    Else
                        'MsgBox("no se agrega se actualiza observaciones")
                        Dim cad1 As String = "update DetalleCotizaciones set Observaciones='" & DGCopia.Item(6, i).Value & "'
                        where idListaCotizacion =" & Val(DGCopia.Item(0, i).Value) & ""
                        Dim u As New SqlCommand(cad1, conexionMetasCotizador)
                        u.ExecuteNonQuery()
                    End If
                    lectorMetasCotizador.Close()
                Next i
                '----------------INSERTA EN SERVICIOSENCOTIZACIONES
                For i = 0 To DGServicios.Rows.Count - 2
                    MetodoMetasCotizador()
                    R = "if exists (Select [Cotizaciones].NumCot,[SetUpEquipment].[EquipId],[SetupServices].[ServicesId]
                        from [MetasCotizador].[dbo].[Cotizaciones]
                        INNER JOIN [DetalleCotizaciones] ON [Cotizaciones].NumCot =[DetalleCotizaciones].NumCot
				        INNER JOIN [ServiciosEnCotizaciones] ON [DetalleCotizaciones].idListaCotizacion = [ServiciosEnCotizaciones].[idListaCotizacion]
				        INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupServices] ON [ServiciosEnCotizaciones].idServicio = [SetupServices].[ServicesId]
				        INNER JOIN [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetUpEquipment] ON [SetUpEquipment].[EquipId] = [DetalleCotizaciones].[EquipId]
				        where [Cotizaciones].NumCot = " & Val(numCot.Text) & " and [ServiciosEnCotizaciones].idListaCotizacion=" & Val(DGServicios.Item(0, i).Value) & ")
				        begin print 'El servicio ya esta' end else 
                        begin insert into [MetasCotizador].[dbo].[ServiciosEnCotizaciones]([idListaCotizacion],[idServicio])VALUES(" & Val(DGServicios.Item(0, i).Value) & "," & Val(DGServicios.Item(2, i).Value) & "); end"
                    Dim x As New SqlCommand(R, conexionMetasCotizador)
                    x.ExecuteNonQuery()
                    conexionMetasCotizador.Close()
                Next i
                conexionMetasCotizador.Close()
                MsgBox("Cotización " & numCot.Text & " Actualizada correctamente")
                Me.Close()
            Else
                'Try
                Dim ultimo As Integer
                'consultar ultima Cotizacion-----------------------------------------------------------------------------------------------
                MetodoMetasCotizador()
                Dim comandoo As New SqlCommand("select MAX(Numcot) from [Cotizaciones]", conexionMetasCotizador)
                Dim lectora As SqlDataReader
                lectora = comandoo.ExecuteReader
                lectora.Read()
                If ((lectora(0) Is DBNull.Value) OrElse (lectora(0) Is Nothing)) Then
                    ultimo = 1
                Else
                    ultimo = lectora(0)
                End If
                lectora.Close()
                conexionMetasCotizador.Close()

                For i = 0 To DGCopia.Rows.Count - 2
                    observacion = DGCopia.Item(6, i).Value
                    If observacion = "" Then
                        observacion = " "
                    Else
                        observacion = DGCopia.Item(6, i).Value + ".  "
                    End If
                    MetodoMetasCotizador()

                    inventarioCliente = InputBox("¿Deseas agregar el número de inventario del articulo: """ & DGCopia.Item(1, i).Value.ToString & """ del cliente?", "No. de Inventario de cliente")
                    If DGCopia.Item(2, i).Value.ToString = "GENERICO" Then
                        marcaGen = InputBox("¿Deseas agregar la marca del articulo: """ & DGCopia.Item(1, i).Value.ToString & """?", "Marca")
                        modGen = InputBox("¿Deseas agregar el modelo del articulo: """ & DGCopia.Item(1, i).Value.ToString & """?", "Modelo")
                        observacion = observacion + "MARCA: " + marcaGen + "  MODELO:" + modGen
                        Dim cad As String = "update DetalleCotizaciones set identificadorInventarioCliente='" & inventarioCliente & "', Observaciones='" & observacion & "'
                    where idListaCotizacion =" & Val(DGCopia.Item(0, i).Value) & ""
                        Dim t As New SqlCommand(cad, conexionMetasCotizador)
                        t.ExecuteNonQuery()
                        conexionMetasCotizador.Close()
                    End If
                Next i


                '---------------------------------------------------------------------------------------------------------------------------
                MetodoMetasCotizador()
                Dim R As String
                R = "update Cotizaciones set idContacto=" & txtCveContacto.Text & ", Origen = 'LIMS', idLugarCondicion=" & Val(cboServicio.Tag) & ", idCuandoCondicion=" & Val(Cbcuando.Tag) & ", idModalidadCondicion=" & Val(CbModalidad.Tag) & ", idTiempoEntregaCondicion=
                    " & Val(CboTiempo.Tag) & ", idPagoCondicion=" & Val(CCondPago.Tag) & ", idLeyendaCondicion=" & Val(CboLeyenda.Tag) & ", idValidezCondicion=" & Val(CboValidez.Tag) & ", idMonedaCondicion=" & Val(CboMoneda.Tag) & ", idDocumentoCondicion=
                    " & Val(ComboDocCond.Tag) & ", idModoCont=" & Val(CboContabilizar.Tag) & ", Referencia= '" & txtReferencia.Text & "', FechaDesde='" & fechaActual & "', FechaHasta='" & fecharecepcion & "', Observaciones='" & txtObservaciones.Text & "', idUsuarioCotizacion=
                    " & Val(txtCotizo2019.Text) & ", Subtotal=" & subtotal & ", IVA=" & iva & ", Total=" & total & " where NumCot = " & ultimo & ""
                Dim comando As New SqlCommand(R, conexionMetasCotizador)
                comando.ExecuteNonQuery()
                ' MsgBox("Actualizado")
                conexionMetasCotizador.Close()


                ''Procedimiento para guardar los detalles de servicios
                ' Try
                For i = 0 To DGServicios.Rows.Count - 2
                        MetodoMetasCotizador()
                        R = "insert into ServiciosEnCotizaciones (idListaCotizacion, idServicio) values (" & Val(DGServicios.Item(0, i).Value) & "," & Val(DGServicios.Item(2, i).Value) & ")"
                        Dim x As New SqlCommand(R, conexionMetasCotizador)
                        x.ExecuteNonQuery()
                        conexionMetasCotizador.Close()
                    Next i
                    MsgBox("Cotización guardada correctamente", MsgBoxStyle.Information)
                'Catch ex As Exception
                '    MsgBox("Error de guardado.", MsgBoxStyle.Critical)
                'End Try
                Me.Dispose()
                'Catch ex As Exception
                '    MsgBox("Error de lectura de datos de ultima COT", MsgBoxStyle.Critical)
                'End Try
            End If
        End If
    End Sub

    Private Sub CboValidez_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo validez ------------------------
        comandoMetasCotizador.CommandText = "select * from ValidezCondicion where Descripcion='" & CboValidez.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboValidez.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()

    End Sub

    Private Sub Cbcuando_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo cuando ------------------------
        comandoMetasCotizador.CommandText = "select * from CuandoCondicion where Descripcion='" & Cbcuando.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        Cbcuando.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub ComboDocCond_SelectedIndexChanged(sender As Object, e As EventArgs)
        '-----------------Combo documentps ------------------------
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = "select * from DocumentosCondicion where DescripcionDocumento='" & ComboDocCond.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        ComboDocCond.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboLeyenda_SelectedIndexChanged(sender As Object, e As EventArgs)
        '-----------------Combo Leyenda ------------------------
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        comandoMetasCotizador.CommandText = "select * from LeyendaCondicion where Descripcion='" & CboLeyenda.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboLeyenda.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboServicio_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo Lugar ------------------------
        comandoMetasCotizador.CommandText = "select * from LugarCondicion where Descripcon='" & cboServicio.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        cboServicio.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CbModalidad_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo modalidad ------------------------
        comandoMetasCotizador.CommandText = "select * from ModalidadCondicion where Descripcion='" & CbModalidad.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CbModalidad.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboContabilizar_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo  modo de contabilizar ------------------------
        comandoMetasCotizador.CommandText = "select * from Modo_de_Contabilizar where Descripcion='" & CboContabilizar.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboContabilizar.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboMoneda_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo moneda ------------------------
        comandoMetasCotizador.CommandText = "select * from MonedaCondicion where Descripcion='" & CboMoneda.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboMoneda.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CCondPago_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo Pago------------------------
        comandoMetasCotizador.CommandText = "select * from PagoCondicion where Descripcion='" & CCondPago.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CCondPago.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub CboTiempo_SelectedIndexChanged(sender As Object, e As EventArgs)
        MetodoMetasCotizador()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        '-----------------Combo tiempo ------------------------
        comandoMetasCotizador.CommandText = "select * from TiemposEntregaCondicion where Descripcion='" & CboTiempo.Text & "'"
        lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
        lectorMetasCotizador.Read()
        CboTiempo.Tag = lectorMetasCotizador(0)
        lectorMetasCotizador.Close()
    End Sub

    Private Sub DGCotizaciones_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGCotizaciones.CellEndEdit
        subtotal = 0
        For Each fila In DGCotizaciones.Rows
            subtotal += (Convert.ToDecimal(fila.Cells("precioUnitario").Value) * Convert.ToDecimal(fila.Cells("cantidad").Value))
        Next
        iva = (subtotal * 0.16)
        total = subtotal + iva
        TextSubtotal.Text = subtotal
        TextTotal.Text = total
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        ''-------------------------------------ACTIVAR SERVICIOS-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        MetodoMetasCotizador()

        Dim R As String
        Dim comando As New SqlCommand("select MAX(Numcot) from [Cotizaciones]", conexionMetasCotizador)
        Dim lector As SqlDataReader
        lector = comando.ExecuteReader
        lector.Read()
        If ((lector(0) Is DBNull.Value) OrElse (lector(0) Is Nothing)) Then
            maximo = 1
        Else
            maximo = lector(0) + 1
        End If

        lector.Close()
        comandoMetasCotizador = conexionMetasCotizador.CreateCommand
        fechaActual = Convert.ToDateTime(DTPDesde.Text).ToShortDateString
        fecharecepcion = Convert.ToDateTime(DTPHasta.Text).ToShortDateString


        R = "insert into Cotizaciones (NumCot, idContacto, Origen, idLugarCondicion, idCuandoCondicion, idModalidadCondicion, idTiempoEntregaCondicion, idPagoCondicion, idLeyendaCondicion,
        idValidezCondicion,idMonedaCondicion,idDocumentoCondicion,idModoCont,Referencia,FechaDesde,FechaHasta,Observaciones,idUsuarioCotizacion,Subtotal,IVA,Total,Creado)
             values (" & maximo & "," & Val(txtCveContacto.Text) & ",'" & origen & "'," & Val(cboServicio.Tag) & "," & Val(Cbcuando.Tag) & "," & Val(CbModalidad.Tag) & "," & Val(CboTiempo.Tag) & "," &
             Val(CCondPago.Tag) & "," & Val(CboLeyenda.Tag) & "," & Val(CboValidez.Tag) & "," & Val(CboMoneda.Tag) & "," & Val(ComboDocCond.Tag) & "," & Val(CboContabilizar.Tag) & ",'" &
             txtReferencia.Text & "','" & fechaActual & "','" & fecharecepcion & "','" & txtObservaciones.Text & "'," & Val(txtCotizo2019.Text) & "," & subtotal & "," & iva & "," & total & ",0)"
        ' MsgBox(R)
        comandoMetasCotizador.CommandText = R
        comandoMetasCotizador.ExecuteNonQuery()
        For i = 0 To DGCotizaciones.Rows.Count - 2
            R = "insert into DetalleCotizaciones (NumCot,EquipId, PartidaNo,Cantidad, CantidadReal, identificadorInventarioCliente, Observaciones) values (" & maximo & "," & DGCotizaciones.Item(10, i).Value & "," & Val(DGCotizaciones.Item(0, i).Value) & ",
                " & Val(DGCotizaciones.Item(3, i).Value) & "," & Val(DGCotizaciones.Item(9, i).Value) & ",'-','-')"
            'MsgBox(R)
            comandoMetasCotizador.CommandText = R
            comandoMetasCotizador.ExecuteNonQuery()
        Next i

        'MsgBox("Guardado correctamente.", MsgBoxStyle.Information)
        FrmCotizadorLIMS.DgAgregar.Rows.Clear()
        empresa = 0

        'MsgBox("Ultima Cot Generada: " & maximo)
        txtMaximo.Text = maximo


        'Habilitar componentes
        Button1.Visible = False
        GroupBox1.Visible = True
        DGCopia.Visible = True
        DGServicios.Visible = True
        btGuardarInf.Visible = True
        DGCotizaciones.Visible = False
    End Sub

    Public Sub agregar_a_Res()
        'Try
        For i = 0 To DGDetalles.Rows.Count - 2
                MetodoLIMS()
                Dim R As String = "select [EquipId], [EquipmentName], [Mfr], [Model], [SrlNo] from [SetUpEquipment] where EquipId=" & Val(DGDetalles.Item(2, i).Value) & ""
                Dim comando As New SqlCommand(R, conexionLIMS)
                Dim lector As SqlDataReader
                lector = comando.ExecuteReader
                lector.Read()
                DGCopia.Rows.Add(Val(DGDetalles.Item(0, i).Value), lector(1), lector(2), lector(3), lector(0))
                conexionLIMS.Close()
            Next i
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos de cotizaciones.", MsgBoxStyle.Information)
        'End Try
    End Sub

    Public Sub consultaGeneralDeDetalles(ByVal NumCot As Integer)
        'Try                      ''''Consulta de algunos campos solamente
        MetodoMetasCotizador()
            'DGOportunidades.Rows.Clear()
            Dim R As String
            R = "SELECT * FROM [MetasCotizador].[dbo].[DetalleCotizaciones] where NumCot=" & NumCot & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            'comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGDetalles.DataSource = dt
            conexionMetasCotizador.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error")
        'End Try
    End Sub

    Public Sub consultaEquipos()
        'Try
        MetodoLIMS()
            Dim R As String
            R = "select [EquipId], [EquipmentName], [Mfr], [Model], [SrlNo] from [SetUpEquipment]"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGEquipos.DataSource = dt
            conexionLIMS.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        'End Try
    End Sub
    Public Sub consultaEquipos2()
        'Try
        MetodoLIMS()
            Dim R As String
            R = "select [EquipId], [EquipmentName], [Mfr], [Model], [SrlNo] from [SetUpEquipment]"
            Dim comando As New SqlCommand(R, conexionLIMS)
            comando.CommandType = CommandType.Text
            Dim da As New SqlDataAdapter(comando)
            Dim dt As New DataTable
            da.Fill(dt)
            DGEquipos.DataSource = dt
            conexionLIMS.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos, llama al administrador general.")
        'End Try
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btActualizarCliente_Click(sender As Object, e As EventArgs) Handles btActualizarCliente.Click
        FrmContactos.Show()
    End Sub

    Private Sub btnAgregarArticulos_Click(sender As Object, e As EventArgs) Handles btnAgregarArticulos.Click
        'FrmArticulos.Show()
    End Sub

    Private Sub DGCopia_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles DGCopia.CellContentClick
        If e.ColumnIndex = DGCopia.Columns.Item("Column4").Index Then
            ' DGServicios.Rows.Add(DGCopia.Rows(e.RowIndex).Cells(0).Value)
            'MostrarServicios
            Dim Admin As New Cotizaciones
            Admin.txtEquipID.Text = DGCopia.Rows(e.RowIndex).Cells(4).Value
            Admin.txtIDListaDetalle.Text = Val(DGCopia.Rows(e.RowIndex).Cells(0).Value)
            Admin.consultaServicios(DGCopia.Rows(e.RowIndex).Cells(4).Value)
            'Admin.txtIDListaDetalle.Text = DGAdicionales
            Admin.ShowDialog()

        End If
    End Sub

    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        'Try
        With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en el diseño de la tabla, puedes llamar al administrador de sistemas.", MsgBoxStyle.Exclamation)
        'End Try
    End Sub
End Class
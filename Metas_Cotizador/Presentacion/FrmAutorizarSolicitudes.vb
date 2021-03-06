﻿Imports System.Data.SqlClient
Public Class FrmAutorizarSolicitudes
    Dim CustimerId As Integer
    Dim cotizacion As Integer
    Private Sub FrmAutorizarSolicitudes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consultaGeneralDeCotizaciones(DGRes)
        alternarColorColumnas(DGRes)
    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmHOME.PL_OrdenVenta.BackColor = Color.White
        Me.Dispose()
    End Sub

    Sub consultaContactos(ByVal CustomerId As Integer)
        Try
            MetodoLIMS()
            Dim R As String = "select isnull(CustAccountNo,'-'), isnull(FirstName,'-'), isnull(MiddleName,'-'), isnull(LastName,'-'),
                                isnull(Phone,'-'), isnull(Mobile,'-'), isnull(Email,'-'), isnull(CompanyName,'-'), isnull(KeyFiscal,'-') 
                                from [SetupCustomerDetails] where [SetupCustomerDetails].[CustomerId]=" & CustomerId & ""
            Dim comando As New SqlCommand(R, conexionLIMS)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            txtNumeroDeCuenta.Text = lector(0)
            'txtNombreDeContacto.Text = lector(1) & " " & lector(2) & " " & lector(3)
            txtTelefono.Text = lector(4)
            txtCelular.Text = lector(5)
            txtCorreo1.Text = lector(6)
            txtNombreCompania.Text = lector(7)
            txtKeyFiscal.Text = lector(8)
            lector.Close()
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error en Consulta Contactos", Err.Number, cadena)
        End Try
    End Sub

    Sub consultaCot(ByVal numCot As Integer)
        Try
            MetodoMetasCotizador()
            Dim R As String
            R = "select isnull(Referencia,'-'), isnull(Observaciones,'-'), isnull(FechaDesde,'-'), isnull(FechaHasta,'-'),
                isnull(Subtotal,'-'), isnull(IVA,'-'), isnull(Total,'-') from Cotizaciones where Cotizaciones.NumCot=" & numCot & ""
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            lector.Read()
            txtReferencia.Text = lector(0)
            txtObservaciones.Text = lector(1)
            txtFechaDesde.Text = lector(2)
            txtFechaHasta.Text = lector(3)
            txtSubtotal.Text = lector(4)
            txtIVA.Text = lector(5)
            txtTotal.Text = lector(6)
            lector.Close()
            R = "select NumCot, ItemNumber, RelationItemNo, EquipmentName, Mfr, Model, SrlNo, Accuracy, Price, CantidadReal from DetalleCotizaciones
             inner join" & servidor & "[SetupEquipment] Equipos on DetalleCotizaciones.EquipId=Equipos.EquipId
             inner join" & servidor & "[SetupEquipmentServiceMapping] Precio on Equipos.EquipId=Precio.EquipId where NumCot=" & numCot
            comando.CommandText = R
            lector = comando.ExecuteReader
            While lector.Read
                dgCot.Rows.Add(lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9))
            End While
            lector.Close()
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar la consulta de la cotización", Err.Number, cadena)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cu As Int64
        Dim correos As String
        Dim ca As String
        'Try
        Dim seleccionado As Boolean
            Dim b, RecDate, OnSite As Boolean
            RecDate = True
            OnSite = False
            '----------------------Ciclo para saber si hay articulos seleccionados-------------------------------
            For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                seleccionado = DGRes.Rows(i).Cells(0).Value
                If seleccionado = True Then
                    b = True
                    Exit For
                Else
                    b = False
                End If
            Next
            '----------------------------------------------------------------------------------------------------
            If b = True Then 'Si hay un renglon seleccionado....
                For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                    seleccionado = DGRes.Rows(i).Cells(0).Value

                    Dim fecha As String
                    If seleccionado = True Then
                        '======================================================= DECISION PARA LOS CLIENTES NUEVOS ====================================================================================================
                        '/////////////////////////////////////////////////// SI NO ESTA EL CLIENTE /////////////////////////////////////////////////////////////////
                        If (DGRes.Rows(i).Cells(13).Value.Equals("INFORMAL")) And (departamento <> "Ventas") Then
                            MsgBox("El cliente no esta dado de alta en el sistema LIMS favor de contactar a ventas", MsgBoxStyle.Exclamation, "No se encuentra el Cliente.")
                            '//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                        Else
                            '################################################# DECISION PARA SABER SI VENTAS VA A DAR DE ALTA EL CLIENTE ######################################################
                            If departamento.Equals("Ventas") And (DGRes.Rows(i).Cells(13).Value.Equals("INFORMAL")) Then
                                numcot = DGRes.Rows(i).Cells(1).Value
                                ccc = True
                                FrmNuevoContacto.Show()
                                '################################################ PROCESO NORMAL DE CREAR LA ORDEN DE VENTAS ##############################################################
                            Else
                                If departamento.Equals("Logística") Then
                                    correos = DGRes.Rows(i).Cells(4).Value
                                    Dim vColeccion() As String = correos.Split(";")
                                    If vColeccion.Length > 1 Then
                                        For j = 0 To vColeccion.Length - 1
                                            FrmFiltarCampo.dgEmpresas.Rows.Add(False, vColeccion(j))
                                        Next
                                        empresa = DGRes.Rows(i).Cells(12).Value
                                        FrmFiltarCampo.Show()
                                        '-----------------------------------
                                        bancorreo = 1
                                        correos2 = False
                                        MetodoLIMS()
                                        R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RefNo,RecDate, DataRequested, OnSite, ShipAddress1, ShipAddress2, ShipAddress3, [CreatedBy],[CreatedOn]) 
                                    values(" & Val(DGRes.Rows(i).Cells(12).Value) & ",'" & DGRes.Rows(i).Cells(13).Value & "','" & DGRes.Rows(i).Cells(1).Value & "','" & dtp.Value.ToShortDateString & "', '" & True & "','" &
                                        False & "','" & DGRes.Rows(i).Cells(5).Value & "','-','-','" & usuario & "', getdate())"
                                        'MsgBox(R & "2dassadasd")
                                        cotizacion = Val(DGRes.Rows(i).Cells(1).Value)
                                    Dim comando As New SqlCommand
                                    comando = conexionLIMS.CreateCommand
                                        comando.CommandText = R
                                        comando.ExecuteNonQuery()
                                        cotizacion = Val(DGRes.Rows(i).Cells(1).Value)
                                        cu = Val(DGRes.Rows(i).Cells(2).Value)
                                        ca = DGRes.Rows(i).Cells(13).Value
                                        cusAcount.Text = ca
                                        fecha = dtp.Value.ToShortDateString
                                        conexionLIMS.Close()
                                        MetodoLIMS()
                                        R = "SELECT top 1 [SOId], [CustomerId],[CustAccountNo],[RecDate]
                            FROM SalesOrderDetails where RefNo= " & Val(DGRes.Rows(i).Cells(1).Value) & " ORDER BY [SOId] DESC"

                                        Dim comando2 As New SqlCommand(R, conexionLIMS)
                                        Dim lector As SqlDataReader
                                        lector = comando2.ExecuteReader
                                        lector.Read()
                                        Dim numOV As Integer = lector(0)
                                        conexionLIMS.Close()

                                        MetodoMetasCotizador()
                                        R = "update Cotizaciones set Creado= '" & numOV & "' where NumCot=" & Val(DGRes.Rows(i).Cells(1).Value) & ""


                                        Dim coma As New SqlCommand(R, conexionMetasCotizador)
                                        OV.Text = numOV
                                        coma.ExecuteNonQuery()
                                        conexionMetasCotizador.Close()

                                        FrmCompletarOV.var.Text = DGRes.Rows(i).Cells(13).Value
                                        FrmCompletarOV.txtRefCot.Text = Me.cotizacion.ToString
                                        FrmCompletarOV.NumOV.Text = Me.OV.Text
                                        '----------------------------------
                                    Else
                                        bancorreo = 1
                                        correos2 = False
                                        MetodoLIMS()
                                        R = "insert into SalesOrderDetails (CustomerId, CustAccountNo, RefNo,RecDate, DataRequested, OnSite, ShipAddress1, ShipAddress2, ShipAddress3, [CreatedBy],[CreatedOn]) 
                            values(" & Val(DGRes.Rows(i).Cells(12).Value) & ",'" & DGRes.Rows(i).Cells(13).Value & "','" & DGRes.Rows(i).Cells(1).Value & "'," & dtp.Value.ToShortDateString & ", '" & True & "','" &
                                    False & "','" & DGRes.Rows(i).Cells(5).Value & "','-','-','" & usuario & "', getdate())"
                                        cotizacion = Val(DGRes.Rows(i).Cells(1).Value)
                                        Dim comando As New SqlCommand
                                        comando = conexionLIMS.CreateCommand
                                        comando.CommandText = R
                                        comando.ExecuteNonQuery()
                                        cu = Val(DGRes.Rows(i).Cells(2).Value)
                                        ca = DGRes.Rows(i).Cells(13).Value
                                    cusAcount.Text = ca
                                    fecha = dtp.Value.ToShortDateString
                                        conexionLIMS.Close()
                                        MetodoLIMS()
                                        R = "SELECT top 1 [SOId], [CustomerId],[CustAccountNo],[RecDate]
                            FROM SalesOrderDetails where RefNo= '" & DGRes.Rows(i).Cells(1).Value & "' ORDER BY [SOId] DESC"
                                        'MsgBox(R & "  hola")
                                        Dim comando2 As New SqlCommand(R, conexionLIMS)
                                        Dim lector As SqlDataReader
                                        lector = comando2.ExecuteReader
                                        lector.Read()
                                        Dim numOV As Integer = lector(0)
                                        conexionLIMS.Close()
                                        MetodoMetasCotizador()
                                        R = "update Cotizaciones set Creado= '" & numOV & "' where NumCot=" & Val(DGRes.Rows(i).Cells(1).Value) & ""


                                        Dim coma As New SqlCommand(R, conexionMetasCotizador)
                                        OV.Text = numOV
                                        coma.ExecuteNonQuery()
                                        conexionMetasCotizador.Close()
                                        MetodoMetasCotizador()
                                        bancorreo = 1
                                        FrmCompletarOV.var.Text = Me.cusAcount.Text
                                        FrmCompletarOV.NumOV.Text = Me.OV.Text
                                        FrmCompletarOV.txtRefCot.Text = Me.cotizacion.ToString
                                        FrmCompletarOV.ShowDialog()
                                    End If
                                Else
                                    MsgBox("El movimiento que intenta realizar no esta permitido para este usuario", MsgBoxStyle.Critical, "Error del sistema.")
                                End If ' DECISION DE SI ES DE LOGISTICA

                            End If
                            '##############################################################################################################################################################

                        End If 'decision de los contactos 
                    End If
                Next
                If DGRes.Rows.Count < 2 Then

                Else
                    DGRes.Rows.Clear()
                End If
                consultaGeneralDeCotizaciones(DGRes)
            Else
                MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
            End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
        '    cadena = Err.Description
        '    cadena = cadena.Replace("'", "")
        '    Bitacora("FrmAutorizarSolicitudes", "Error al guardar la OV", Err.Number, cadena)
        'End Try

    End Sub

    Private Sub txtNumeroDeCuentaB_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroDeCuentaB.TextChanged
        Try
            For Each row As DataGridViewRow In DGRes.Rows
                row.Selected = False
                If CStr(row.Cells(1).Value) = txtNumeroDeCuentaB.Text Then
                    row.Selected = True
                    Exit For
                ElseIf CStr(row.Cells(0).Value).ToLower = Nothing Then
                    row.Selected = False
                Else
                    row.Selected = False
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al buscar el numero de cuenta", Err.Number, cadena)
        End Try
    End Sub

    Private Sub BtSinCot_Click(sender As Object, e As EventArgs) Handles btSinCot.Click
        FrmFiltrar.Show()
    End Sub

    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    End Sub

    Private Sub TextDom_TextChanged(sender As Object, e As EventArgs) Handles TextDom.TextChanged
        busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged
        busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    End Sub

    Private Sub TxtCP_TextChanged(sender As Object, e As EventArgs) Handles txtCP.TextChanged
        busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    End Sub

    Private Sub TextTel_TextChanged(sender As Object, e As EventArgs) Handles TextTel.TextChanged
        busquedas(DGRes, TextEmail, txtCP, txtNombreE, TextDom, TextTel)
    End Sub

    Private Sub DGRes_RowHeaderMouseClick_1(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGRes.RowHeaderMouseClick
        Try
            Dim numCot As String
            numCot = DGRes.Rows(e.RowIndex).Cells(1).Value.ToString()
            CustimerId = DGRes.Rows(e.RowIndex).Cells(12).Value.ToString()
            txtClaveRecopilada.Text = numCot
            consultaContactos(CustimerId)
            consultaCot(numCot)
            TabConsulta.SelectTab(1)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al seleccionar una cotización", Err.Number, cadena)
        End Try
    End Sub

    Private Sub DGRes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRes.CellContentClick
        '=====================================CODIGO PARA SELECCIONAR SOLO UN CHECKBOX==========================
        If e.ColumnIndex = 0 Then
            For Each row As DataGridViewRow In CType(sender, DataGridView).Rows
                row.Cells(e.ColumnIndex).Value = False
            Next
        End If
    End Sub
End Class
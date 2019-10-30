Public Class FrmCotInformal
    Private Sub btCerrar_Click(sender As Object, e As EventArgs) Handles btCerrar.Click
        Me.Dispose()
    End Sub
    Private Sub btCargarArticulos_Click(sender As Object, e As EventArgs) Handles btCargarArticulos.Click
        '=============================================== BOTON QUE LLENA EL DATAGRID DE ARTICULOS =========================================================
        Try
            MetodoLIMS()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from SetUpEquipment"
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
            Bitacora("FrmCotizacion", "Error al cargar los Articulos", Err.Number, cadena)
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

    Private Sub TextID_TextChanged(sender As Object, e As EventArgs) Handles TextID.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub TextArticulo_TextChanged(sender As Object, e As EventArgs) Handles TextArticulo.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub txtMarca_TextChanged(sender As Object, e As EventArgs) Handles txtMarca.TextChanged
        consultasarticuloscot()
    End Sub

    Private Sub txtModelo_TextChanged(sender As Object, e As EventArgs) Handles txtModelo.TextChanged
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

    Private Sub btCotizacion_Click(sender As Object, e As EventArgs) Handles btCotizacion.Click
        '=============================================== CODIGO PARA MANDAR LOS ARTICULOS CON PRECIO A LA COTIZACION ===================================================
        origen = "INFORMAL"
        editar = 3
        editar2 = True
        If DgAgregar.Rows.Count < 2 Then
            MsgBox("No hay articulos para Cotizar", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            For i As Integer = DgAgregar.Rows.Count() - 2 To 0 Step -1
                MetodoLIMS()
                FrmEdicionCot.txtNombreC.Text = TextContacto.Text
                FrmEdicionCot.txtNombreEmpresa.Text = TextEmpresa.Text
                FrmEdicionCot.txtNumCond.Text = TextRFC.Text
                FrmEdicionCot.txtDomicilio.Text = TextDireccion.Text
                FrmEdicionCot.txtCiudad.Text = TextCiudad.Text
                FrmEdicionCot.txtEstado.Text = TextEstado.Text
                FrmEdicionCot.txtTelefono.Text = TextTelefono.Text
                FrmEdicionCot.TextCorreo.Text = TextCorreo.Text
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
End Class
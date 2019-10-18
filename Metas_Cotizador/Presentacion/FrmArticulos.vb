Public Class FrmArticulos
    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetodoLIMS()
        comandoLIMS = conexionLIMS.CreateCommand
        R = "SELECT SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from SetUpEquipment"
        comandoLIMS.CommandText = R
        lectorLIMS = comandoLIMS.ExecuteReader
        While lectorLIMS.Read()
            DGArticulos.Rows.Add(False, lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4))
        End While
        lectorLIMS.Close()
        conexionLIMS.Close()
    End Sub

    Sub consultasarticuloscot()
        Try
            MetodoLIMS()
            DGArticulos.Rows.Clear()
            comandoLIMS = conexionLIMS.CreateCommand
            R = "SELECT SetUpEquipment.EquipId, ItemNumber, EquipmentName, Mfr, Model from SetUpEquipment where ItemNumber like '" & TextID.Text & "%' and 
                 Mfr like'" & txtMarca.Text & "%' and Model like '" & txtModelo.Text & "%' and EquipmentName like '" & TextArticulo.Text & "%'"
            comandoLIMS.CommandText = R
            lectorLIMS = comandoLIMS.ExecuteReader
            While lectorLIMS.Read()
                DGArticulos.Rows.Add(False, lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), lectorLIMS(3), lectorLIMS(4))
            End While
            lectorLIMS.Close()
            conexionLIMS.Close()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del sistema.")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCotizacion2018", "Error al filtrar por empresa", Err.Number, cadena)
        End Try
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        agregarArt = False
        Me.Close()
    End Sub

    Private Sub DGArticulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGArticulos.CellContentClick
        If e.ColumnIndex = DGArticulos.Columns.Item("s").Index Then
            DgAgregar.Rows.Add(DGArticulos.Rows(e.RowIndex).Cells(1).Value)
        End If
    End Sub

    Private Sub btAgregar_Click(sender As Object, e As EventArgs) Handles btAgregar.Click
        origen = "LIMS"
        If DgAgregar.Rows.Count < 2 Then
            MsgBox("No hay articulos para Cotizar", MsgBoxStyle.Critical, "Error del sistema.")
        Else
            For i As Integer = DgAgregar.Rows.Count() - 2 To 0 Step -1
                numPartida = numPartida + 1
                MetodoLIMS()
                comandoLIMS = conexionLIMS.CreateCommand
                R = "SELECT EquipmentName, Mfr, Model,SetUpEquipment.EquipId,Price from 
                            SetUpEquipment inner join SetupEquipmentServiceMapping on  
                            SetupEquipment.EquipId=SetupEquipmentServiceMapping.EquipId where SetUpEquipment.EquipId =" & DgAgregar.Rows(i).Cells(0).Value
                comandoLIMS.CommandText = R
                lectorLIMS = comandoLIMS.ExecuteReader
                lectorLIMS.Read()
                equipo = lectorLIMS(3)
                precio = precio + lectorLIMS(4)


                FrmEdicionCot.DGCopia.Rows.Add(lectorLIMS(3), numPartida, lectorLIMS(0), lectorLIMS(1), lectorLIMS(2), "1", False)
                iva = (precio * 0.16)
                totalEdiCot = precio + iva
                FrmEdicionCot.TextSubtotal.Text = precio
                FrmEdicionCot.TextTotal.Text = totalEdiCot

                lectorLIMS.Close()


                MetodoLIMS()
                comandoLIMS = conexionLIMS.CreateCommand
                R = "SELECT EquipId, ServicesId, Price from SetupEquipmentServiceMapping where EquipId=" & equipo

                comandoLIMS.CommandText = R
                lectorLIMS = comandoLIMS.ExecuteReader
                lectorLIMS.Read()
                FrmEdicionCot.DGServicios.Rows.Add(lectorLIMS(0), lectorLIMS(1), lectorLIMS(2))
                lectorLIMS.Close()
                conexionLIMS.Close()
            Next
            'frmEdicionCot2018_2019.ShowDialog()

        End If
    End Sub
End Class
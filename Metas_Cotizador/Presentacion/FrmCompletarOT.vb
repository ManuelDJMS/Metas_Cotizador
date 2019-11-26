Imports System.Data.SqlClient
Public Class FrmCompletarOT
    Dim seleccionado, b As Boolean
    Dim salesorderId, customerid As Integer
    Dim totalcot As Decimal

    Private Sub FrmCompletarOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alternarColorColumnas(DGRes)
            MetodoMetasCotizador()
            R = "select SOid, NumCot, (FirstName + ' ' + MiddleName + ' ' + LastName) as Nombre, CompanyName, Email, Total, x2.CustomerId from Cotizaciones x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId]
                INNER JOIN " & servidor & "[SalesOrderDetails] x3 ON x1.NumCot = x3.RefNo"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmCOmpletarOt", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        FrmHOME.PL_PreFact.BackColor = Color.White
        Me.Dispose()
    End Sub


    Private Sub TxtNombreE_TextChanged(sender As Object, e As EventArgs) Handles txtNombreE.TextChanged
        busquedasOT(DGRes, TextEmail, txtCot, txtNombreE)
    End Sub

    Private Sub TextEmail_TextChanged(sender As Object, e As EventArgs) Handles TextEmail.TextChanged
        busquedasOT(DGRes, TextEmail, txtCot, txtNombreE)
    End Sub

    Private Sub DGRes_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGRes.CellContentClick
        '=====================================CODIGO PARA SELECCIONAR SOLO UN CHECKBOX==========================
        If e.ColumnIndex = 0 Then
            For Each row As DataGridViewRow In CType(sender, DataGridView).Rows
                row.Cells(e.ColumnIndex).Value = False
                '================================ CÓDIGO PARA LLENAR EL DATAGRID OCULTO QUE TIENE LOS ARTICULOS DE LA COT ==============================================
                'R = "select "
                'consultasCotizador(R, dgEquipamiento)
            Next
        End If
    End Sub


    Private Sub TxtCot_TextChanged(sender As Object, e As EventArgs) Handles txtCot.TextChanged
        busquedasOT(DGRes, TextEmail, txtCot, txtNombreE)
    End Sub

    Private Sub BtGenerarOT_Click(sender As Object, e As EventArgs) Handles btGenerarOT.Click
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
        If b = True Then
            For i As Integer = DGRes.Rows.Count() - 1 To 0 Step -1
                seleccionado = DGRes.Rows(i).Cells(0).Value
                If seleccionado = True Then
                    numcot = DGRes.Rows(i).Cells(2).Value
                    empresa = DGRes.Rows(i).Cells(7).Value
                    R = "select CustomerId, EquipId, SrlNo from [MetAs_Live-pruebas].[dbo].[SetupCustomerEquipmentMapping] where CustomerId=" & empresa
                    MsgBox(R)
                    consultasLIMS(R, dgEquipamiento)
                    FrmEquipamiento.Show()
                End If
            Next
        Else
            MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
        End If
    End Sub
End Class
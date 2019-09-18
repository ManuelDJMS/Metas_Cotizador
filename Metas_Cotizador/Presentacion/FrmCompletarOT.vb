Imports System.Data.SqlClient
Public Class FrmCompletarOT
    Dim seleccionado, b As Boolean
    Dim salesorderId, customerid As Integer
    Dim totalcot As Decimal

    Private Sub FrmCompletarOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            alternarColorColumnas(DGRes)
            MetodoMetasCotizador()
            R = "select SOid, NumCot, (FirstName + ' ' + MiddleName + ' ' + LastName) as Nombre, CompanyName, Email, Total from Cotizaciones x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId]
                INNER JOIN " & servidor & "[SalesOrderDetails] x3 ON x1.NumCot = x3.RefNo"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                DGRes.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
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
                    '----------------------------Se sacan los datos para levantar el equipamiento al cliente--------------------------------------
                    'R = "select Cotizaciones.NumCot, idContacto, x1.EquipId, isnull(Serie,'-') as Serie, isnull(IdentificadorInventarioCliente, '-') as ID, isnull(DetalleCotizaciones.Observaciones,'-') from Cotizaciones inner join DetalleCotizaciones
                    'on Cotizaciones.NumCot=DetalleCotizaciones.NumCot inner join " & servidor & "[SetupEquipment] x1 on DetalleCotizaciones.EquipId=x1.EquipId where Cotizaciones.NumCot=" & DGRes.Rows(i).Cells(2).Value
                    numcot = DGRes.Rows(i).Cells(2).Value
                    MsgBox(numcot)
                    FrmEquipamiento.Show()
                    '////////////////////////////////////////////////////////////////////////////////////////////////////

                    '----------------Sacar campos de consultas LIMS para insertar en WORKORDER---------------------
                    'MetodoMetasCotizador()
                    'R = "select SOid, CustomerId, NumCot, Total from Cotizaciones inner join " & servidor & "[SalesOrderDetails] x2 on Cotizaciones.NumCot=x2.RefNo where SOId=" & DGRes.Rows(i).Cells(1).Value
                    'comandoMetasCotizador = New SqlCommand(R, conexionMetasCotizador)
                    ''Dim lector As SqlDataReader
                    'lectorMetasCotizador = comandoMetasCotizador.ExecuteReader
                    'lectorMetasCotizador.Read()
                    'salesorderId = lectorMetasCotizador(0)
                    'customerid = lectorMetasCotizador(1)
                    'numcot = lectorMetasCotizador(2)
                    'totalcot = lectorMetasCotizador(3)
                    'conexionMetasCotizador.Close()
                    '////////////////////////////////////////////////////////////////////////////////////////////////////

                    '----------------------------------------------------Aqui se da de alta el quipamiento al cliente---------------------------------------------
                    'MetodoMetasCotizador()
                    'For ii = 0 To dgEquipamiento.Rows.Count - 2
                    '    R = "if exists(select CustomerId, x1.EquipId, x3.NumCot from [DATABASESERVER\COMPAC].[MetAs_Live-pruebas].[dbo].[SetupCustomerEquipmentMapping] x1 inner join [MetasCotizador].[dbo].[Cotizaciones] x2
                    'on x1.CustomerId=x2.idContacto inner join [MetasCotizador].[dbo].[DetalleCotizaciones] x3 on x2.NumCot=x3.NumCot where x1.CustomerId=" & Val(dgEquipamiento.Item(1, ii).Value) & " and x1.EquipId=" & Val(dgEquipamiento.Item(2, ii).Value) & "and x3.NumCot=" & Val(dgEquipamiento.Item(0, ii).Value) & ") 
                    'begin print 'El artículo ya esta equipado al cliente' end else begin insert into " & servidor & "[SetupCustomerEquipmentMapping]
                    '(CustomerId,EquipId,InstrumentId,SrlNo,Dept,Location,CALInterval,CALCycle,CALDue,IsActive,OnSite,ShortNotes,AssetNo) values(" & Val(dgEquipamiento.Item(1, ii).Value) & "," & Val(dgEquipamiento.Item(2, ii).Value) &
                    '            ",(select top 1 CustEquipMapId +1 as id from " & servidor & "[SetupCustomerEquipmentMapping] order by CustEquipMapId desc),'" & dgEquipamiento.Item(3, ii).Value &
                    '            "','" & dgEquipamiento.Item(4, ii).Value & "','" & dgEquipamiento.Item(5, ii).Value & "'," & Val(dgEquipamiento.Item(6, ii).Value) & ",'" & dgEquipamiento.Item(7, ii).Value &
                    '            "','" & dgEquipamiento.Item(8, ii).Value & "','" & dgEquipamiento.Item(9, ii).Value & "',' ','" & dgEquipamiento.Item(10, ii).Value & "','-'); end"
                    '    comandoMetasCotizador = conexionMetasCotizador.CreateCommand
                    '    comandoMetasCotizador.CommandText = R
                    '    comandoMetasCotizador.ExecuteNonQuery()
                    '    MsgBox(R)
                    '    'R = "insert into [MetAs_Live-pruebas].[dbo].[WorkOrderDetails] (WOid, SOid, CustEquipMapId, CustomerId, )"
                    'Next
                    '////////////////////////////////////////////////////////////////////////////////////////////////////

                    '---------------------------------------------------------------------------------------------------------
                    '----------------Sacar campos de consultas LIMS-Cotizador para insertar en WORKORDER---------------------
                    'MetodoMetasCotizador()
                    'R = "select NumCot, Total, EquipId, from  "
                    '////////////////////////////////////////////////////////////////////////////////////////////////////
                End If
            Next
        Else
            MsgBox("No ha seleccionado ningúna cotización", MsgBoxStyle.Critical, "Error del sistema.")
        End If
    End Sub
End Class
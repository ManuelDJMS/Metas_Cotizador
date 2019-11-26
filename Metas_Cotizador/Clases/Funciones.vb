Imports System.Data.SqlClient
Module Funciones
    Public R As String 'Variable que almacena todos los scripts de base de datos
    Public servidor As String = "[MetAs_Live].[dbo]." 'Esta variable sirve para alojar el servidor para las consultas
    Public servidor2 As String = "[MetasCotizador].[dbo]." ' Esta variable sirve para alojar el servidor del cotizador
    Public cadena As String 'VARIABLE PARA ALMACENAR LA CADENA DEL ERROR DE LA BITACORA
    '---------------------------Variables utilizadas para el uso del correo------------------------------------------------------
    Public objOutlook As Object
    Public objOutlookMsg As Object
    Public bancorreo As Integer 'Esta variable es una bandera para abrir cierto formukario
    Public correos As String
    Public correos2 As Boolean 'variable para cot sin folio
    Public empresa As Integer = 0
    '-----------------------------------------Variables para autoeizar y filtrar campo-----------------------------------------------------------------------------------
    Public origen As String
    Public fecharecepcion As Date
    Public fechaActual As Date
    Public formcorreos As Integer
    Public formcorreos2 As Integer

    '--------------------------------------EDITAR COTIZACION
    Public editar As Int16
    Public editar2 As Boolean
    Public COT2 As Integer
    Public numPartida As Integer
    Public precio As Double
    Public iva As Double
    Public totalEdiCot As Double
    Public subtotalEdiCot As Double
    Public equipo As Integer
    Public numcot As Integer
    Public tipo As String = "Generico" 'Esta variable sirve para saber si es generico o no
    Public departamento As String 'Variable para obtener el departamento del usuario que usa el sistemas
    Public ccc As Boolean '(CREAR CLIENTE COT) variable para validar si se crea un cliente por medio de una orden de venta o por proceso normal
    Public agregarArt As Boolean = False 'Esta variable es para poder usar el formulario de articulos en diferente situacion
    '--------------------------------------Llenar la WORK ORDER
    Public arreglosales()
    Public Sub consultasLIMS(ByVal script As String, ByVal dgrid As DataGridView)
        Try
            MetodoLIMS()
            comandoLIMS = New SqlCommand(script, conexionLIMS)
            comandoLIMS.CommandType = CommandType.Text
            adapterLIMS = New SqlDataAdapter(comandoLIMS)
            datatableLIMS = New DataTable
            adapterLIMS.Fill(datatableLIMS)
            dgrid.DataSource = datatableLIMS
            conexionLIMS.Close()
        Catch ex As Exception
            MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        End Try
    End Sub
    Public Sub consultasCotizador(ByVal script As String, ByVal dgrid As DataGridView)
        'Try
        MetodoMetasCotizador()
            comandoMetasCotizador = New SqlCommand(script, conexionMetasCotizador)
            comandoMetasCotizador.CommandType = CommandType.Text
            adapterMetasCotizador = New SqlDataAdapter(comandoMetasCotizador)
            datatableMetasCotizador = New DataTable
            adapterMetasCotizador.Fill(datatableMetasCotizador)
            dgrid.DataSource = datatableMetasCotizador
            conexionMetasCotizador.Close()
        'Catch ex As Exception
        '    MsgBox("Ocurrio un error en la lectura de datos, verifica nuevamente", MsgBoxStyle.Exclamation)
        'End Try
    End Sub
    Public Sub consultaGeneralDeCotizaciones(ByVal dg As DataGridView)
        Try
            MetodoMetasCotizador()
            '        R = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
            'INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
            '            inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0"
            R = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] COLLATE Latin1_General_CI_AS AS Nombre , CompanyName COLLATE Latin1_General_CI_AS, Email COLLATE Latin1_General_CI_AS, 
                 ContAddress1 COLLATE Latin1_General_CI_AS , ContZip COLLATE Latin1_General_CI_AS, Phone COLLATE Latin1_General_CI_AS, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, 
                  CustAccountNo COLLATE Latin1_General_CI_AS from [MetasCotizador].[dbo].[Cotizaciones] x1
				 INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON  x1.idContacto = x2.[CustomerId] 
                 inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0 and Origen='LIMS'
                 union
                 select x1.NumCot, Contacto, Empresa, Correo, Domicilio, Cp, Telefono, Referencia, FechaDesde, FechaHasta, Total, x2.idCliente, Origen COLLATE Latin1_General_CI_AS from [Cotizaciones] x1
				 INNER JOIN ClientesInformales x2 ON x1.idContacto = x2.IdCliente where Creado= 0 and Origen='INFORMAL'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            'cadena = Err.Description
            'cadena = cadena.Replace("'", "")
            'Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Public Sub consultaGeneralDeCotizacionesCot(ByVal dg As DataGridView)
        Try
            MetodoMetasCotizador()
            R = "select x1.NumCot, Contacto, Empresa, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
                inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            'cadena = Err.Description
            'cadena = cadena.Replace("'", "")
            'Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Public Sub busquedas(ByVal dg As DataGridView, ByVal email As TextBox, ByVal cp As TextBox, ByVal empresa As TextBox, ByVal domicilio As TextBox, ByVal telefono As TextBox)
        Try
            dg.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String = "select x1.NumCot, [FirstName] +' '+ [MiddleName] +' '+ [LastName] AS Nombre, CompanyName, Email, ContAddress1, ContZip, Phone, Referencia, FechaDesde, FechaHasta, Total, x2.CustomerId, CustAccountNo from [MetasCotizador].[dbo].[Cotizaciones] x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId] 
                inner join " & servidor & "[SetupCustomerAddressDtls] x3 on x2.[CustomerId]=x3.[CustomerId] where Creado= 0 and CompanyName like '" & empresa.Text & "%' and ContAddress1 like '" & domicilio.Text & "%'
                and Email like '" & email.Text & "%' and ContZip like '" & cp.Text & "%' and Phone like '" & telefono.Text & "%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9), lector(10), lector(11), lector(12))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            'cadena = Err.Description
            'cadena = cadena.Replace("'", "")
            'Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Public Sub busquedasOT(ByVal dg As DataGridView, ByVal email As TextBox, ByVal cot As TextBox, ByVal empresa As TextBox)
        Try
            dg.Rows.Clear()
            MetodoMetasCotizador()
            Dim R As String = "select SOid, NumCot, (FirstName + ' ' + MiddleName + ' ' + LastName) as Nombre, CompanyName, Email, Total from Cotizaciones x1
				INNER JOIN " & servidor & "[SetupCustomerDetails] x2 ON x1.idContacto = x2.[CustomerId]
                INNER JOIN " & servidor & "[SalesOrderDetails] x3 ON x1.NumCot = x3.RefNo where Creado <> 0 and CompanyName like '" & empresa.Text & "%'
                and Email like '" & email.Text & "%' and NumCot like '" & cot.Text & "%'"
            Dim comando As New SqlCommand(R, conexionMetasCotizador)
            Dim lector As SqlDataReader
            lector = comando.ExecuteReader
            While lector.Read()
                dg.Rows.Add(False, lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            conexionMetasCotizador.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al cargar el formulario", Err.Number, cadena)
        End Try
    End Sub
    Public Sub Bitacora(Formulario As String, Evento As String, error1 As String, Descripcion As String)
        Try
            Dim conexionbit As New SqlConnection("Data Source=SERVER3\COMPAC2;Initial Catalog=Bitacora; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionbit.Open()
            Dim comando As SqlCommand = conexionbit.CreateCommand()
            Dim r As String
            Dim I As Integer
            Dim x As String
            x = "'"
            For I = 1 To Len(error1)
                If Mid(error1, I, 1) = Chr(39) Then
                    x = x & "'"
                Else
                    x = x & Mid(error1, I, 1)
                End If
            Next
            error1 = x
            r = "insert into Resultados(Formulario, Evento, Error, Descripcion, Fecha) values ('" & Formulario & "','" & Evento & "'," & error1 & "','" & Descripcion & "', getdate())"
            comando.CommandText = r
            comando.ExecuteNonQuery()
            conexionbit.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
        End Try
    End Sub
    Public Sub alternarColorColumnas(ByVal DGV As DataGridView)
        Try
            With DGV
                .RowsDefaultCellStyle.BackColor = Color.WhiteSmoke
                .AlternatingRowsDefaultCellStyle.BackColor = Color.White
            End With
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error en el Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("FrmAutorizarSolicitudes", "Error al buscar cot", Err.Number, cadena)
        End Try
    End Sub
    '-------------------------CODIGO PARA LAS ALERTAS ---------------------------
    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
    End Sub
End Module

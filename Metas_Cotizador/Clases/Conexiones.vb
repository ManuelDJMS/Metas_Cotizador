Imports System.Data.SqlClient
Module Conexiones
    '-----------------------------Variables para la conexion con bases de Datos LIMS-------------------------------------------
    Public conexionLIMS As SqlConnection
    Public comandoLIMS As SqlCommand
    Public lectorLIMS As SqlDataReader
    Public adapterLIMS As SqlDataAdapter
    Public datatableLIMS As DataTable
    '--------------------------------------------------------------------------------------------------------------------------
    '-----------------------------Variables para la conexion con bases de Datos COTIZADOR-------------------------------------------
    Public conexionMetasCotizador As SqlConnection
    Public comandoMetasCotizador As SqlCommand
    Public lectorMetasCotizador As SqlDataReader
    Public adapterMetasCotizador As SqlDataAdapter
    Public datatableMetasCotizador As DataTable
    '--------------------------------------------------------------------------------------------------------------------------
    Public ban As Boolean = True
    Public banderaform As Boolean
    Public numcotfrm As Integer
    Public total As Decimal
    Public empresafrm, Contacto, Referencia, corrreofrm As String
    Public usuario As String 'Variable para almacenar el user id del login
    '================================================VARIABLE PARA UTILIZAR LA TRANSACCION DEL LIMS=========================================================================
    Public conexionLIMStransac As String = ("Data Source=185.166.213.202;Initial Catalog=MetAs_Live; User Id=sa; Password=Met99011578a;Integrated Security=False")
    '=======================================================================================================================================================================
    '================================================VARIABLE PARA UTILIZAR LA TRANSACCION DEL LIMS=========================================================================
    Public conexionCotizadortransac As String = ("Data Source=185.166.213.202;Initial Catalog=MetasCotizador; User Id=sa; Password=Met99011578a;Integrated Security=False")
    '=======================================================================================================================================================================
    '------------------------------------------------------------------------CONEXIONES A BASES DE DATOS-------------------------------------------------------------------------------------------
    Sub MetodoLIMS()
        Try
            'conexionLIMS = New SqlConnection("Data Source=107.180.70.168\METASSQLEXPRESS;Initial Catalog=MetAs_Live;Persist Security Info=False;User ID=sa;Password=Bws123bws")
            conexionLIMS = New SqlConnection("Data Source=185.166.213.202;Initial Catalog=MetAs_Live; User Id=sa; Password=Met99011578a;Integrated Security=False")
            'conexionLIMS = New SqlConnection("Data Source=185.166.213.202;Initial Catalog=MetAs_Live; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionLIMS.Open()
        Catch ex As Exception
            MsgBox("No se pudo conectar a la base de datos" + ex.ToString)
        End Try
    End Sub
    Sub MetodoMetasCotizador()
        Try
            conexionMetasCotizador = New SqlConnection("Data Source=185.166.213.202;Initial Catalog=MetasCotizador; User Id=sa; Password=Met99011578a;Integrated Security=False")
            conexionMetasCotizador.Open()
        Catch ex As Exception
        End Try
    End Sub
End Module

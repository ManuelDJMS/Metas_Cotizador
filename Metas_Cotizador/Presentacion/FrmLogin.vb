Imports System.Data.SqlClient
Public Class FrmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        GunaAnimateWindow1.Start()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Try
            If Me.ValidateChildren = True And txtUser.Text <> "" And txtpass.Text <> "" Then
                Using conexion1 As New SqlConnection(conexionLIMStransac)
                    conexion1.Open()
                    Dim transaction As SqlTransaction
                    transaction = conexion1.BeginTransaction("Sample")
                    Dim comando As SqlCommand = conexion1.CreateCommand()
                    Dim lector As SqlDataReader
                    comando.Connection = conexion1
                    comando.Transaction = transaction
                    Dim r As String = "select UserID, UserName, Password, Department from UserMaster where UserName= " & "'" & txtUser.Text & "'"
                    comando.CommandText = r
                    lector = comando.ExecuteReader()
                    lector.Read()
                    usuario = lector(0)
                    departamento = lector(3)
                    If txtUser.Text = lector(1) And txtpass.Text = lector(2) Then
                        Alert("Usuario Correcto, BIENVENIDO", frmAlert.alertTypeEnum.Success)
                        FrmHOME.lbInicio.Text = lector(1)
                        FrmHOME.Show()
                        lector.Close()
                        Me.Close()
                        conexion1.Close()
                    Else
                        Alert("Contraseña Incorrecta", frmAlert.alertTypeEnum.Error)
                        txtpass.Text = ""
                    End If
                End Using
            Else
                MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try

    End Sub

    Private Sub txtUser_LostFocus(sender As Object, e As EventArgs) Handles txtUser.LostFocus
        If (txtUser.Text = Nothing) Then
            txtUser.ForeColor = Color.Gray
            txtUser.Text = "Nombre de Usuario"
        End If
    End Sub

    Private Sub txtUser_GotFocus(sender As Object, e As EventArgs) Handles txtUser.GotFocus
        If (txtUser.Text = "Nombre de Usuario" Or txtUser.Text = "") Then
            txtUser.ForeColor = Color.Black
            txtUser.Text = ""
        End If
    End Sub

    Private Sub txtpass_LostFocus(sender As Object, e As EventArgs) Handles txtpass.LostFocus
        If (txtpass.Text = Nothing) Then
            txtpass.ForeColor = Color.Gray
            txtpass.Text = "Contraseña"
        End If
    End Sub

    Private Sub txtpass_GotFocus(sender As Object, e As EventArgs) Handles txtpass.GotFocus
        If (txtpass.Text = "Contraseña" Or txtpass.Text = "") Then
            txtpass.ForeColor = Color.Black
            txtpass.Text = ""
        End If
    End Sub

    Private Sub txtpass_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpass.KeyDown
        Try
            Select Case e.KeyData
                Case Keys.Enter
                    If Me.ValidateChildren = True And txtUser.Text <> "" And txtpass.Text <> "" Then
                        Using conexion1 As New SqlConnection(conexionLIMStransac)
                            conexion1.Open()
                            Dim transaction As SqlTransaction
                            transaction = conexion1.BeginTransaction("Sample")
                            Dim comando As SqlCommand = conexion1.CreateCommand()
                            Dim lector As SqlDataReader
                            comando.Connection = conexion1
                            comando.Transaction = transaction
                            Dim r As String = "select UserID, UserName, Password, Department from UserMaster where UserName= " & "'" & txtUser.Text & "'"
                            comando.CommandText = r
                            lector = comando.ExecuteReader()
                            lector.Read()
                            usuario = lector(0)
                            departamento = lector(3)
                            If txtUser.Text = lector(1) And txtpass.Text = lector(2) Then
                                Alert("Usuario Correcto, BIENVENIDO", frmAlert.alertTypeEnum.Success)
                                FrmHOME.lbInicio.Text = lector(1)
                                FrmHOME.Show()
                                lector.Close()
                                Me.Close()
                                conexion1.Close()
                            Else
                                Alert("Contraseña Incorrecta", frmAlert.alertTypeEnum.Error)
                                txtpass.Text = ""
                            End If
                        End Using
                    Else
                        MessageBox.Show("Faltan ingresar algunos datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
            End Select
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error del Sistema")
            cadena = Err.Description
            cadena = cadena.Replace("'", "")
            Bitacora("Sesión", "Error al iniciar el formulario", Err.Number, cadena)
        End Try

    End Sub
End Class

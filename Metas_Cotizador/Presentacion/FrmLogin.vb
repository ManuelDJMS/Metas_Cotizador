Public Class FrmLogin
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_BLEND
        GunaAnimateWindow1.Start()
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)

    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim f As FrmHOME = New FrmHOME
        f.Show()
        Me.Dispose()
    End Sub
End Class

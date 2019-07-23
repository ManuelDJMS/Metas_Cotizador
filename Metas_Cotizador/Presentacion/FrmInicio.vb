
Imports Timer = System.Windows.Forms.Timer
Public Class FrmInicio
    Public variable As String
    Dim version As String
    Public timerback As New Timer
    Public Sub New()
        InitializeComponent()
        AddHandler timerback.Tick, New EventHandler(AddressOf resorce)
        defaul()
    End Sub
    Sub defaul()
        linerocket.Height = 8
        linerocket.Width = 0
        linerocket.Left = 286
        timerback.Interval = 30
        timerback.Start()
    End Sub
    Dim wd As Integer = 0
    Sub resorce(sender As Object, e As EventArgs)
        linerocket.Width += wd
        If linerocket.Width < 1 Then
            wd = 8
        End If
        If linerocket.Width > 752 Then
            timerback.Stop()
            Timer1.Start()
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Me.Opacity > 0.0 Then
            Me.Opacity -= 0.105
        Else
            Timer1.Stop()
            FrmHOME.Show()
            Me.Dispose()
        End If
    End Sub
End Class
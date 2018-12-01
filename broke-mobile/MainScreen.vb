Public Class MainScreen
    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MainScreen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        SplashScreen.Close()
    End Sub
End Class
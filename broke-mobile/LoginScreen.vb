Public Class LoginScreen
    Private Sub LoginScreen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        SplashScreen.Close()
    End Sub

    Private Sub TryAgainBtn_Click(sender As Object, e As EventArgs) Handles TryAgainBtn.Click
        'hides the try again panel'
        WrongPassword.Visible = False
    End Sub

    Private Sub PasswordResetBtn_Click(sender As Object, e As EventArgs) Handles PasswordResetBtn.Click
        'opens reset page'
        ResetScreen.Show()
        Me.Hide()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UsernameBox.Text.Equals("john") And PasswordBox.Text.Equals("1234") Then
            'opens main window'
            MainScreen.Show()
            Me.Hide()
        Else
            'shows wrong password'
            WrongPassword.Visible = True
        End If
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        'opens register form'
        RegisterScreen.Show()
        Me.Hide()
    End Sub
End Class
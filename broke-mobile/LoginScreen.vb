Public Class LoginScreen
    Private Sub LoginScreen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Me.Hide()
        SplashScreen.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UsernameBox.Text.Equals("john") And PasswordBox.Text.Equals("1234") Then
            'open main window'
            Me.Hide()
            MainScreen.Show()
        Else
            'show wrong password'
            WrongPassword.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WrongPassword.Visible = False
    End Sub
End Class
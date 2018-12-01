Public Class ResetScreen
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginScreen.Show()
        Me.Hide()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        PasswordResetPanel.Visible = True
    End Sub
End Class
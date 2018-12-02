﻿Public Class LoginScreen
    Dim myTimer As New Timer()
    Dim randomGenerator As New Random()

    Private Sub LoginScreen_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Hide()
        SplashScreen.Close()
    End Sub

    Private Sub TryAgainBtn_Click(sender As Object, e As EventArgs) Handles TryAgainBtn.Click
        'hides the try again panel'
        WrongPassword.Visible = False
    End Sub

    Private Sub PasswordResetBtn_Click(sender As Object, e As EventArgs) Handles PasswordResetBtn.Click
        'opens reset page'
        ResetScreen.Show()
        Hide()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UsernameBox.Text.Equals("john") And PasswordBox.Text.Equals("1234") Then
            'opens main window'
            MainScreen.Show()
            Hide()
        Else
            'shows wrong password'
            WrongPassword.Visible = True
        End If
    End Sub

    Private Sub RegisterBtn_Click(sender As Object, e As EventArgs) Handles RegisterBtn.Click
        'opens register form'
        RegisterScreen.Show()
        Hide()
    End Sub

    Private Sub LoginScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        myTimer.Interval = 1000
        AddHandler myTimer.Tick, AddressOf HandleTimerTick
        myTimer.Start()
    End Sub

    Private Sub HandleTimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim totalImages As Integer = 18
        totalImages += 1

        Dim leftImage As Integer = randomGenerator.Next(1, totalImages)
        Dim rightImage As Integer = randomGenerator.Next(1, totalImages)

        While leftImage.Equals(rightImage)
            If leftImage.Equals(totalImages) Then
                rightImage = randomGenerator.Next(1, totalImages)
            Else
                rightImage += 1
            End If
        End While

        PictureBox1.Image = My.Resources.ResourceManager.GetObject("image_" & leftImage)
        PictureBox2.Image = My.Resources.ResourceManager.GetObject("image_" & rightImage)
    End Sub
End Class
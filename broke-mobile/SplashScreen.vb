﻿Public Class SplashScreen
    Dim myTimer As Timer = New Timer()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myTimer.Interval = 1500
        AddHandler myTimer.Tick, AddressOf HandleTimerTick
        myTimer.Start()
    End Sub

    Private Sub HandleTimerTick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        myTimer.Stop()

        Dim LoginScreen As New LoginScreen
        Hide()
        MainScreen.Show()
    End Sub
End Class

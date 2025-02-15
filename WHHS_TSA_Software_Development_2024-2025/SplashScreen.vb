Public Class SplashScreen
    Private t As Integer = 0
    Private connected As Boolean = False

    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick
        lblConnecting.Text += "."
        t += 1

        If t > 4 Or connected Then
            Me.Hide()
            DropletApp.Show()
            timerAnimation.Enabled = False
            If Not connected Then
                MsgBox("Please set the API key in settings.")
            End If
        End If
    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Put code in for connecting to API here
    End Sub
End Class
Public Class Home

    Private editingWidgets As Boolean = False


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub editWidgets()
        editingWidgets = True
        ' ew :(
        For Each ctl As Object In Me.Controls
            Console.WriteLine(ctl)
            If TypeOf ctl Is widgetWeather Or
                TypeOf ctl Is widgetTime Or
                TypeOf ctl Is widgetTemperature Then
                Dim tempOverlay As New WidgetOverlay()
                tempOverlay.Parent = ctl
                tempOverlay.Location = New Point(ctl.Location.X - 32, ctl.Location.Y)
                tempOverlay.Size = New Size(ctl.Size.Width + 64, ctl.Size.Height + 32)
                tempOverlay.BringToFront()
                Me.Controls.Add(tempOverlay)
            End If
        Next
    End Sub

    Private Sub timerEditing_Tick(sender As Object, e As EventArgs) Handles timerEditing.Tick
        If editingWidgets Then
        End If
    End Sub
End Class

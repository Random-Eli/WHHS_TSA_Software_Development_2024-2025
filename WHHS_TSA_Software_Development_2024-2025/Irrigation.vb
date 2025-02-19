Public Class Irrigation
    Private Sub Irrigation_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        SchedulePanel.Size = New Size(Me.Width - 145, Me.Height - SchedulePanel.Location.Y - 96)
    End Sub
End Class

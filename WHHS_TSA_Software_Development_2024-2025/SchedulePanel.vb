Public Class SchedulePanel

    Dim waterLevel As Decimal

    Private Sub picWaterStatus_Paint(sender As Object, e As PaintEventArgs) Handles picWaterStatus.Paint

        e.Graphics.FillRectangle(New SolidBrush(Color.FromArgb(255, 75, 138, 162)), New Rectangle(0, 128 - (waterLevel * 128), 128, waterLevel * 128))
        e.Graphics.DrawImage(My.Resources.drop_outline, 0, 0, 128, 128)
    End Sub

    Private Sub SchedulePanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        waterLevel = 0.5

        For i = 0 To 10
            Dim tmppb As New PictureBox
            tmppb.Dock = DockStyle.Left
            tmppb.Image = My.Resources.clock
            tmppb.SizeMode = PictureBoxSizeMode.StretchImage
            Panel.Controls.Add(tmppb)

        Next
    End Sub

    Private Sub SchedulePanel_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.Clear(Color.FromArgb(255, 37, 38, 39))
        e.Graphics.DrawRectangle(New Pen(New SolidBrush(Color.FromArgb(255, 255, 249, 251)), 3), New Rectangle(0, 0, Me.Width - 1, Me.Height - 1))
    End Sub
    ' 195, 32
    Private Sub SchedulePanel_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.Refresh()
        Panel.Size = New Size(Me.Width - 260, Me.Height - 65)

        For Each pb As PictureBox In Panel.Controls
            pb.MinimumSize = New Size(pb.Width, pb.Width)
            pb.Size = New Size(pb.Width, pb.Width)
        Next
    End Sub
End Class

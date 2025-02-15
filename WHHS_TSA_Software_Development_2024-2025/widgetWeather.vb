Public Class widgetWeather
    Private Sub widgetWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub FillRoundedRectangle(ByVal g As Drawing.Graphics, ByVal r As Rectangle, ByVal d As Integer, ByVal b As Brush)
        Dim mode As Drawing2D.SmoothingMode = g.SmoothingMode
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed
        g.FillPie(b, r.X, r.Y, d, d, 180, 90)
        g.FillPie(b, r.X + r.Width - d, r.Y, d, d, 270, 90)
        g.FillPie(b, r.X, r.Y + r.Height - d, d, d, 90, 90)
        g.FillPie(b, r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        g.FillRectangle(b, CInt(r.X + d / 2), r.Y, r.Width - d, CInt(d / 2))
        g.FillRectangle(b, r.X, CInt(r.Y + d / 2), r.Width, CInt(r.Height - d))
        g.FillRectangle(b, CInt(r.X + d / 2), CInt(r.Y + r.Height - d / 2), CInt(r.Width - d), CInt(d / 2))
        g.SmoothingMode = mode
    End Sub

    Private Sub widgetWeather_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        FillRoundedRectangle(e.Graphics, New Rectangle(0, 0, MyBase.Width, MyBase.Height), 30, New SolidBrush(Color.FromArgb(255, 47, 48, 49)))
    End Sub
End Class

Public Class Slider

    Dim sliderX As Integer = 0
    Dim sliderTarget As Integer = 0
    Dim sliderValue As Boolean = False

    Dim colorOffset As Integer = 0

    Private Sub Slider_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Function GetValue() As Boolean
        Return sliderValue
    End Function

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

    Private Sub Slider_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        e.Graphics.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
        e.Graphics.InterpolationMode = Drawing2D.InterpolationMode.Bicubic
        FillRoundedRectangle(e.Graphics, New Rectangle(0, 0, Me.Width, Me.Height), 20, New SolidBrush(Color.FromArgb(255, 47 + colorOffset, 48 + colorOffset, 49 + colorOffset)))
        e.Graphics.FillEllipse(New SolidBrush(Color.FromArgb(255, 37, 38, 39)), New RectangleF(3 + sliderX, 3, Math.Min(Me.Width, Me.Height) - 6, Math.Min(Me.Width, Me.Height) - 6))
    End Sub

    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick
        Dim distance As Integer
        distance = (Math.Abs(sliderTarget - sliderX) / 10) + 1

        If sliderValue Then
            sliderX += distance
            colorOffset = (sliderX / (sliderTarget + 1)) * 100
        Else
            sliderX -= distance
            colorOffset = (sliderTarget / (sliderX + 1)) * 100
        End If



        If sliderX = sliderTarget Then
            timerAnimation.Enabled = False
        End If
        MyBase.Refresh()
    End Sub

    Private Sub Slider_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        If sliderValue Then
            sliderValue = False
            sliderTarget = 0
        Else
            sliderValue = True
            sliderTarget = Me.Width - Math.Min(Me.Width, Me.Height)
        End If
        timerAnimation.Enabled = True
    End Sub
End Class

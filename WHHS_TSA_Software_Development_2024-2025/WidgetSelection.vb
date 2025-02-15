Public Class WidgetSelection

    Private widgetSelectionAnimation As String = "Collapse"
    Private permanentLocation As Point

    Private Sub WidgetSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(32, 32)
        icoAdd.BringToFront()
        permanentLocation = Me.Location
    End Sub

    Public Sub updateLocation(pt As Point)
        permanentLocation = pt
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

    Private Sub WidgetSelection_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        FillRoundedRectangle(e.Graphics, New Rectangle(0, 0, MyBase.Width, MyBase.Height), 100, New SolidBrush(Color.FromArgb(255, 47, 48, 49)))
    End Sub

    Private Sub icoAdd_Click(sender As Object, e As EventArgs) Handles icoAdd.Click
        If widgetSelectionAnimation = "Expand" Then
            widgetSelectionAnimation = "Collapse"
        Else
            widgetSelectionAnimation = "Expand"
        End If
    End Sub

    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick
        Dim distance As Integer = 0
        If widgetSelectionAnimation = "Expand" And Me.Width <> 160 Then
            distance = (Math.Abs(160 - Me.Width) \ 5) + 1

            Me.Width += distance
            Me.Height = Me.Width
            Me.Location = New Point(permanentLocation.X - (Me.Width / 2) + 16, permanentLocation.Y - Me.Height + 32)
        ElseIf widgetSelectionAnimation = "Collapse" And Me.Width <> 32 Then
            distance = (Math.Abs(32 - Me.Width) \ 5) + 1

            Me.Width -= distance
            Me.Height = Me.Width
            Me.Location = New Point(permanentLocation.X - (Me.Width / 2) + 16, permanentLocation.Y - Me.Height + 32)

        End If
    End Sub

    Private Sub icoTemperature_Click(sender As Object, e As EventArgs) Handles icoTemperature.Click
        CType(Me.Parent, Home).addWidget(New widgetTemperature())
        widgetSelectionAnimation = "Collapse"
    End Sub

    Private Sub icoTime_Click(sender As Object, e As EventArgs) Handles icoTime.Click
        CType(Me.Parent, Home).addWidget(New widgetTime())
        widgetSelectionAnimation = "Collapse"
    End Sub

    Private Sub icoWeather_Click(sender As Object, e As EventArgs) Handles icoWeather.Click
        CType(Me.Parent, Home).addWidget(New widgetWeather())
        widgetSelectionAnimation = "Collapse"
    End Sub
End Class

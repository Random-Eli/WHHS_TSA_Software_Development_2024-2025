Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class widgetWeather
    Dim climate As String
    Private gifPanel As Panel
    Private gifBackground As PictureBox

    Private Sub widgetWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        gifPanel = New Panel()
        gifPanel.Size = Me.Size
        gifPanel.Location = New Point(0, 0)
        gifPanel.BackColor = Color.Transparent
        gifPanel.Visible = False
        Me.Controls.Add(gifPanel)


        gifBackground = New PictureBox()
        gifBackground.Dock = DockStyle.Fill
        gifBackground.SizeMode = PictureBoxSizeMode.StretchImage
        gifPanel.Controls.Add(gifBackground)

        data()
        climateUpdate()
    End Sub
    Private Sub ApplyRoundedCorners(ByVal ctrl As Control, ByVal radius As Integer)
        Dim path As New GraphicsPath()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddArc(ctrl.Width - radius, 0, radius, radius, 270, 90)
        path.AddArc(ctrl.Width - radius, ctrl.Height - radius, radius, radius, 0, 90)
        path.AddArc(0, ctrl.Height - radius, radius, radius, 90, 90)
        path.CloseFigure()
        ctrl.Region = New Region(path)
    End Sub

    Public Sub FillRoundedRectangle(ByVal g As Graphics, ByVal r As Rectangle, ByVal d As Integer, ByVal b As Brush)
        Dim mode As SmoothingMode = g.SmoothingMode
        g.SmoothingMode = SmoothingMode.HighQuality
        Dim path As New GraphicsPath()
        path.AddArc(r.X, r.Y, d, d, 180, 90)
        path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90)
        path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d, 0, 90)
        path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90)
        path.CloseFigure()
        g.FillPath(b, path)
        g.SmoothingMode = mode
    End Sub

    Private Sub widgetWeather_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        If gifPanel.Visible = False Then
            FillRoundedRectangle(e.Graphics, New Rectangle(0, 0, MyBase.Width, MyBase.Height), 30, New SolidBrush(Color.FromArgb(255, 47, 48, 49)))
        End If
    End Sub

    Public Sub data()
        climate = "Thunder Storm"
    End Sub

    Public Sub climateUpdate()
        If climate = "Thunder Storm" Then
            gifBackground.Image = My.Resources.lightninganimation
            gifPanel.Visible = True
            ApplyRoundedCorners(gifPanel, 30)
        ElseIf climate = "Snow" Then
            'gifBackground.Image = Image.FromFile("C:\Users\bryde\Downloads\snowbg.gif")
            gifPanel.Visible = True
            ApplyRoundedCorners(gifPanel, 30)
            gifPanel.Visible = False
        End If
    End Sub
End Class

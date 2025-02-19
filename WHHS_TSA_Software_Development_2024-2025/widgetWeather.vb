Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class widgetWeather
    Dim climate As String
    Private gifPanel As Panel
    Private gifBackground As PictureBox

    Private Sub widgetWeather_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Change all items to red

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
        climate = "Sunny"
    End Sub

    Public Sub climateUpdate()
        Label1.Parent = gifBackground
        Label2.Parent = gifBackground
        Label3.Parent = gifBackground
        lblHumidity.Parent = gifBackground
        lblWind.Parent = gifBackground
        lblRain.Parent = gifBackground
        lblStatus.Parent = gifBackground
        lblWeather.Parent = gifBackground
        lblHighInput.Parent = gifBackground
        lblHigh.Parent = gifBackground
        lblLow.Parent = gifBackground
        lblLowInput.Parent = gifBackground
        If climate = "Thunder Storm" Then
            gifBackground.Image = My.Resources.lightninganimation
            gifPanel.Visible = True
            ApplyRoundedCorners(gifPanel, 30)
        ElseIf climate = "Snow" Then
            ChangeForeColor(Me, Color.DarkGray)
            gifBackground.Image = My.Resources.snowf

            gifPanel.Visible = True
            ApplyRoundedCorners(gifPanel, 30)
            gifPanel.Visible = True
        ElseIf climate = "Sunny" Then
            ChangeForeColor(Me, Color.White)
            gifBackground.Image = My.Resources.sunny
            gifPanel.Visible = True
            ApplyRoundedCorners(gifPanel, 30)
        End If
    End Sub
    Public Sub ResizeGifPanel()
        ' Thank you chat, we solute you
        ' physc this was ALL ME btw
        gifPanel.Size = Me.Size
        gifBackground.Size = Me.Size
        Dim radius As Integer = Math.Min(Me.Width, Me.Height) / 10  '
        ApplyRoundedCorners(gifPanel, radius)
        ApplyRoundedCorners(Me, radius)
    End Sub
    Public Sub ChangeForeColor(ByVal parent As Control, ByVal color As Color)
        For Each ctrl As Control In parent.Controls
            ' Change the ForeColor if the control supports it
            If TypeOf ctrl Is Label OrElse TypeOf ctrl Is Button OrElse TypeOf ctrl Is TextBox OrElse TypeOf ctrl Is CheckBox OrElse TypeOf ctrl Is RadioButton Then
                ctrl.ForeColor = color
            End If

            ' Recursively apply to child controls (if it's a container like a Panel or GroupBox)
            If ctrl.HasChildren Then
                ChangeForeColor(ctrl, color)
            End If
        Next
    End Sub


End Class

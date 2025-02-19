' Overlay for when editing the widgets on the home screen

Public Class WidgetOverlay

    Private _Widget As Object

    Private Sub WidgetOverlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Property Widget As Object
        Get
            Return _Widget
        End Get
        Set(value)
            _Widget = value
        End Set
    End Property

    Private Sub icoMove_MouseMove(sender As Object, e As MouseEventArgs) Handles icoMove.MouseMove
        Dim mousePos As Point = DropletApp.PointToClient(MyBase.MousePosition)
        If MouseButtons.HasFlag(MouseButtons.Left) Then
            Me.Location = New Point((((mousePos.X - Me.Width) \ 50) * 50) + 32, ((mousePos.Y - 16) \ 50) * 50)
            _Widget.Location = New Point((((mousePos.X - Me.Width) \ 50) * 50) + 64, ((mousePos.Y - 16) \ 50) * 50)
        End If
    End Sub

    Private Sub icoResize_MouseMove(sender As Object, e As MouseEventArgs) Handles icoResize.MouseMove
        Dim mousePos As Point = DropletApp.PointToClient(MyBase.MousePosition)
        If MouseButtons.HasFlag(MouseButtons.Left) Then
            Me.Size = New Size((((mousePos.X - 192) \ 50) * 50) + 96, (mousePos.Y \ 50) * 50)
            _Widget.Size = New Size((((mousePos.X - 192) \ 50) * 50), (mousePos.Y \ 50) * 50)
        End If
    End Sub

    Private Sub icoRemove_Click(sender As Object, e As EventArgs) Handles icoRemove.Click
        CType(Me.Parent, Home).removeWidget(Me, _Widget)
    End Sub

    Private Sub icoResize_Click(sender As Object, e As EventArgs) Handles icoResize.Click

    End Sub
End Class

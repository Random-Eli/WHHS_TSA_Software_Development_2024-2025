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
            Me.Location = New Point(mousePos.X - Me.Width - 64, mousePos.Y - 16)
            _Widget.Location = New Point(mousePos.X - Me.Width - 32, mousePos.Y - 16)
        End If
    End Sub
End Class

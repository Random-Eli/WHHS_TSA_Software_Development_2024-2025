' Overlay for when editing the widgets on the home screen

Public Class WidgetOverlay
    Private Sub WidgetOverlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub icoMove_MouseMove(sender As Object, e As MouseEventArgs) Handles icoMove.MouseMove
        Dim mousePos As Point = DropletApp.PointToClient(MyBase.MousePosition)
        If MouseButtons.HasFlag(MouseButtons.Left) Then
            Me.Parent.Location = New Point(mousePos.X - Me.Width - 32, mousePos.Y - 16)
            Console.WriteLine(Me.Parent)
        End If
    End Sub
End Class

' Color palette used: https://coolors.co/3c7660-4b88a2-bb0a21-252627-fff9fb

Public Class DropletApp

    Private Home As New Home
    Private Ui_sidebar As New ui_sidebar

    Private Sub DropletApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ui_sidebar.Dock = DockStyle.Left
        Home.Dock = DockStyle.Fill
        Me.Controls.Add(Ui_sidebar)
        Me.Controls.Add(Home)
    End Sub

    Public Sub showHomePage()
        Home.Show()
    End Sub

    Public Sub editWidgets()
        Home.editWidgets()
    End Sub

    Public Sub saveWidgets()
        Ui_sidebar.Enabled = True
    End Sub

End Class

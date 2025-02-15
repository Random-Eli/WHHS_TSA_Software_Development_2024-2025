' Color palette used: https://coolors.co/3c7660-4b88a2-bb0a21-252627-fff9fb

Public Class DropletApp

    Private Home As New Home
    Private Settings As New Settings
    Private Ui_sidebar As New ui_sidebar

    Private Sub DropletApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Ui_sidebar.Dock = DockStyle.Left
        Home.Dock = DockStyle.Fill
        Settings.Dock = DockStyle.Fill
        Settings.Hide()
        Me.Controls.Add(Ui_sidebar)
        Me.Controls.Add(Home)
        Me.Controls.Add(Settings)
    End Sub

    Public Sub showHomePage()
        Home.Show()
        Settings.Hide()
    End Sub

    Public Sub showSettingsPage()
        Home.Hide()
        Settings.Show()
    End Sub

    Public Sub editWidgets()
        Home.editWidgets()
    End Sub

    Public Sub saveWidgets()
        Ui_sidebar.Enabled = True
    End Sub

    Private Sub DropletApp_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub
End Class

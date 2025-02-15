Public Class ui_sidebar

    ' Holds which animation to do for the sidebar
    Private ui_sidebar_animation As String = "Collapse"
    Private ui_sidebar_animation_speed As Integer = 5


    Private Sub iconMouseEnter(sender As Object, e As EventArgs) Handles icoSettings.MouseEnter, icoHome.MouseEnter, icoIrrigation.MouseEnter, icoWidgets.MouseEnter
        sender.BackColor = Color.FromArgb(255, 51, 52, 53)
    End Sub

    Private Sub iconMouseLeave(sender As Object, e As EventArgs) Handles icoSettings.MouseLeave, icoHome.MouseLeave, icoIrrigation.MouseLeave, icoWidgets.MouseLeave
        sender.BackColor = Color.FromArgb(255, 21, 22, 23)
    End Sub

    Private Sub timerAnimation_Tick(sender As Object, e As EventArgs) Handles timerAnimation.Tick
        Dim distance As Integer
        Dim mousePos As Point = Me.PointToClient(MyBase.MousePosition)
        If (mousePos.X >= 0 And
            mousePos.X <= MyBase.Width And
            mousePos.Y >= 0 And
            mousePos.Y <= MyBase.Height And
            Me.Enabled) Then
            ui_sidebar_animation = "Expand"
        Else
            ui_sidebar_animation = "Collapse"
        End If

        If ui_sidebar_animation = "Expand" Then
            distance = (Math.Abs(200 - MyBase.Width) \ ui_sidebar_animation_speed) + 1
            If MyBase.Width <> 200 Then
                MyBase.Width += distance
                icoSettings.Width += distance
                icoHome.Width = icoSettings.Width
                icoWidgets.Width = icoSettings.Width
                icoIrrigation.Width = icoSettings.Width
            End If
        ElseIf ui_sidebar_animation = "Collapse" Then
            distance = (Math.Abs(52 - MyBase.Width) \ ui_sidebar_animation_speed) + 1
            If MyBase.Width <> 52 Then
                MyBase.Width -= distance
                icoSettings.Width -= distance
                icoHome.Width = icoSettings.Width
                icoWidgets.Width = icoSettings.Width
                icoIrrigation.Width = icoSettings.Width

            End If
        End If
    End Sub

    Private Sub ui_sidebar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHome.Enabled = False
        lblSettings.Enabled = False
        lblIrrigation.Enabled = False
        lblWidgets.Enabled = False
        lblHome.Parent = icoHome
        lblSettings.Parent = icoSettings
        lblIrrigation.Parent = icoIrrigation
        lblWidgets.Parent = icoWidgets
    End Sub

    Private Sub icoHome_Click(sender As Object, e As EventArgs) Handles icoHome.Click
        DropletApp.showHomePage()
    End Sub

    Private Sub icoWidgets_Click(sender As Object, e As EventArgs) Handles icoWidgets.Click
        DropletApp.showHomePage()
        DropletApp.editWidgets()
        Me.Enabled = False
    End Sub

    Private Sub icoSettings_Click(sender As Object, e As EventArgs) Handles icoSettings.Click
        DropletApp.showSettingsPage()
    End Sub
End Class

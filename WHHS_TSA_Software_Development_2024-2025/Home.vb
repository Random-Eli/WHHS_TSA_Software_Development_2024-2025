Public Class Home

    Private editingWidgets As Boolean = False
    Private saveWidgetsIcon As New PictureBox()
    Private addWidgetsIcon As New WidgetSelection()


    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        saveWidgetsIcon.Image = My.Resources.save
        saveWidgetsIcon.SizeMode = PictureBoxSizeMode.Zoom
        saveWidgetsIcon.Size = New Size(32, 32)
        saveWidgetsIcon.Visible = False
        Me.Controls.Add(saveWidgetsIcon)
        AddHandler saveWidgetsIcon.Click, AddressOf saveWidgetsIcon_Click

        addWidgetsIcon.Size = New Size(32, 32)
        addWidgetsIcon.Visible = False
        Me.Controls.Add(addWidgetsIcon)
    End Sub

    Private Sub saveWidgetsIcon_Click(sender As Object, e As MouseEventArgs)
        Dim i As Integer = 0
        timerEditing.Enabled = False
        saveWidgetsIcon.Visible = False
        addWidgetsIcon.Visible = False

        ' basically goes through all controls and removes only the widgetoverlays. must be a while loop as we are updating the list while we are iterating through it
        Do While i < Me.Controls.Count
            Console.WriteLine(i)
            If TypeOf Me.Controls(i) Is WidgetOverlay Then
                Me.Controls.Remove(Me.Controls(i))
                i -= 1
            Else
                i += 1
            End If
        Loop
        DropletApp.saveWidgets()
    End Sub

    Public Sub editWidgets()
        timerEditing.Enabled = True
        saveWidgetsIcon.Visible = True
        addWidgetsIcon.Visible = True
        addWidgetsIcon.Location = New Point(Me.Width - 100, Me.Height - 48)
        ' ew :(
        ' basically just goes through all the controls and filters only the widgets
        For Each ctl As Object In Me.Controls
            Console.WriteLine(ctl)
            If TypeOf ctl Is widgetWeather Or
                TypeOf ctl Is widgetTime Or
                TypeOf ctl Is widgetTemperature Then
                Dim tempOverlay As New WidgetOverlay()
                tempOverlay.Parent = ctl
                tempOverlay.Location = New Point(ctl.Location.X - 32, ctl.Location.Y)
                tempOverlay.Size = New Size(ctl.Size.Width + 96, ctl.Size.Height + 32)
                tempOverlay.BringToFront()
                tempOverlay.Widget = ctl
                Me.Controls.Add(tempOverlay)
            End If
        Next
    End Sub

    Public Sub removeWidget(overlay As Object, ctl As Object)
        Me.Controls.Remove(overlay)
        Me.Controls.Remove(ctl)
    End Sub

    Public Sub addWidget(widget As Object)
        Dim i As Integer = 0
        Me.Controls.Add(widget)

        ' Refresh widgets
        Do While i < Me.Controls.Count
            Console.WriteLine(i)
            If TypeOf Me.Controls(i) Is WidgetOverlay Then
                Me.Controls.Remove(Me.Controls(i))
                i -= 1
            Else
                i += 1
            End If
        Loop

        For Each ctl As Object In Me.Controls
            Console.WriteLine(ctl)
            If TypeOf ctl Is widgetWeather Or
                TypeOf ctl Is widgetTime Or
                TypeOf ctl Is widgetTemperature Then
                Dim tempOverlay As New WidgetOverlay()
                tempOverlay.Parent = ctl
                tempOverlay.Location = New Point(ctl.Location.X - 32, ctl.Location.Y)
                tempOverlay.Size = New Size(ctl.Size.Width + 96, ctl.Size.Height + 32)
                tempOverlay.BringToFront()
                tempOverlay.Widget = ctl
                Me.Controls.Add(tempOverlay)
            End If
        Next
    End Sub

    Private Sub timerEditing_Tick(sender As Object, e As EventArgs) Handles timerEditing.Tick
        saveWidgetsIcon.Location = New Point(Me.Width - 48, Me.Height - 48)
        addWidgetsIcon.updateLocation(New Point(Me.Width - 100, Me.Height - 48))
        addWidgetsIcon.BringToFront()

    End Sub

    Private Sub Home_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        addWidgetsIcon.Location = New Point(Me.Width - 100, Me.Height - 48)
    End Sub
End Class

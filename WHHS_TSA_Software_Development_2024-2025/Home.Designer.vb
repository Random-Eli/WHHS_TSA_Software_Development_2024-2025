<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.WidgetTime1 = New WHHS_TSA_Software_Development_2024_2025.widgetTime()
        Me.WidgetTemperature1 = New WHHS_TSA_Software_Development_2024_2025.widgetTemperature()
        Me.timerEditing = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'WidgetTime1
        '
        Me.WidgetTime1.BackColor = System.Drawing.Color.Transparent
        Me.WidgetTime1.Location = New System.Drawing.Point(352, 32)
        Me.WidgetTime1.Margin = New System.Windows.Forms.Padding(32)
        Me.WidgetTime1.MinimumSize = New System.Drawing.Size(256, 256)
        Me.WidgetTime1.Name = "WidgetTime1"
        Me.WidgetTime1.Size = New System.Drawing.Size(474, 256)
        Me.WidgetTime1.TabIndex = 1
        '
        'WidgetTemperature1
        '
        Me.WidgetTemperature1.BackColor = System.Drawing.Color.Transparent
        Me.WidgetTemperature1.Location = New System.Drawing.Point(32, 32)
        Me.WidgetTemperature1.Margin = New System.Windows.Forms.Padding(32)
        Me.WidgetTemperature1.MinimumSize = New System.Drawing.Size(256, 256)
        Me.WidgetTemperature1.Name = "WidgetTemperature1"
        Me.WidgetTemperature1.Size = New System.Drawing.Size(256, 256)
        Me.WidgetTemperature1.TabIndex = 0
        '
        'timerEditing
        '
        Me.timerEditing.Enabled = True
        Me.timerEditing.Interval = 1
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.WidgetTime1)
        Me.Controls.Add(Me.WidgetTemperature1)
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(802, 484)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WidgetTemperature1 As widgetTemperature
    Friend WithEvents WidgetTime1 As widgetTime
    Friend WithEvents timerEditing As Timer
End Class

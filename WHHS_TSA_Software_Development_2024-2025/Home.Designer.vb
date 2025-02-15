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
        Me.WidgetTemperature1 = New WHHS_TSA_Software_Development_2024_2025.widgetTemperature()
        Me.SuspendLayout()
        '
        'WidgetTemperature1
        '
        Me.WidgetTemperature1.BackColor = System.Drawing.Color.Transparent
        Me.WidgetTemperature1.Location = New System.Drawing.Point(44, 39)
        Me.WidgetTemperature1.Name = "WidgetTemperature1"
        Me.WidgetTemperature1.Size = New System.Drawing.Size(438, 277)
        Me.WidgetTemperature1.TabIndex = 0
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.WidgetTemperature1)
        Me.Name = "Home"
        Me.Size = New System.Drawing.Size(802, 484)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WidgetTemperature1 As widgetTemperature
End Class

﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class widgetTemperature
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTemperature = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTemperature
        '
        Me.lblTemperature.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTemperature.Font = New System.Drawing.Font("Arial", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemperature.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblTemperature.Location = New System.Drawing.Point(0, 0)
        Me.lblTemperature.Margin = New System.Windows.Forms.Padding(64)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(256, 256)
        Me.lblTemperature.TabIndex = 0
        Me.lblTemperature.Text = "78°"
        Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'widgetTemperature
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblTemperature)
        Me.MinimumSize = New System.Drawing.Size(256, 256)
        Me.Name = "widgetTemperature"
        Me.Size = New System.Drawing.Size(256, 256)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblTemperature As Label
End Class

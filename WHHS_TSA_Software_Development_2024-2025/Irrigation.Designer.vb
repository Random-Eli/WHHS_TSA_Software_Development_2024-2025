﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Irrigation
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
        Me.picWaterStatus = New System.Windows.Forms.PictureBox()
        Me.lblWaterStatus = New System.Windows.Forms.Label()
        CType(Me.picWaterStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWaterStatus
        '
        Me.picWaterStatus.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.drop
        Me.picWaterStatus.Location = New System.Drawing.Point(96, 32)
        Me.picWaterStatus.Margin = New System.Windows.Forms.Padding(96, 32, 0, 32)
        Me.picWaterStatus.Name = "picWaterStatus"
        Me.picWaterStatus.Size = New System.Drawing.Size(64, 64)
        Me.picWaterStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picWaterStatus.TabIndex = 0
        Me.picWaterStatus.TabStop = False
        '
        'lblWaterStatus
        '
        Me.lblWaterStatus.AutoSize = True
        Me.lblWaterStatus.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaterStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblWaterStatus.Location = New System.Drawing.Point(168, 55)
        Me.lblWaterStatus.Margin = New System.Windows.Forms.Padding(8)
        Me.lblWaterStatus.Name = "lblWaterStatus"
        Me.lblWaterStatus.Size = New System.Drawing.Size(97, 18)
        Me.lblWaterStatus.TabIndex = 1
        Me.lblWaterStatus.Text = "Water Status"
        '
        'Irrigation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.lblWaterStatus)
        Me.Controls.Add(Me.picWaterStatus)
        Me.Name = "Irrigation"
        Me.Size = New System.Drawing.Size(800, 400)
        CType(Me.picWaterStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picWaterStatus As PictureBox
    Friend WithEvents lblWaterStatus As Label
End Class

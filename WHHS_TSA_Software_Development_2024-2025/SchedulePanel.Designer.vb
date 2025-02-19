<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedulePanel
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
        CType(Me.picWaterStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picWaterStatus
        '
        Me.picWaterStatus.Location = New System.Drawing.Point(32, 32)
        Me.picWaterStatus.Margin = New System.Windows.Forms.Padding(32)
        Me.picWaterStatus.Name = "picWaterStatus"
        Me.picWaterStatus.Size = New System.Drawing.Size(128, 128)
        Me.picWaterStatus.TabIndex = 0
        Me.picWaterStatus.TabStop = False
        '
        'SchedulePanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Controls.Add(Me.picWaterStatus)
        Me.Name = "SchedulePanel"
        Me.Size = New System.Drawing.Size(500, 300)
        CType(Me.picWaterStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picWaterStatus As PictureBox
End Class

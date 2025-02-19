<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Settings
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
        Me.lblAPIKey = New System.Windows.Forms.Label()
        Me.txtAPIKey = New System.Windows.Forms.TextBox()
        Me.lblDegrees = New System.Windows.Forms.Label()
        Me.Slider1 = New WHHS_TSA_Software_Development_2024_2025.Slider()
        Me.SuspendLayout()
        '
        'lblAPIKey
        '
        Me.lblAPIKey.AutoSize = True
        Me.lblAPIKey.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAPIKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblAPIKey.Location = New System.Drawing.Point(96, 32)
        Me.lblAPIKey.Margin = New System.Windows.Forms.Padding(96, 16, 32, 16)
        Me.lblAPIKey.Name = "lblAPIKey"
        Me.lblAPIKey.Size = New System.Drawing.Size(66, 18)
        Me.lblAPIKey.TabIndex = 0
        Me.lblAPIKey.Text = "API Key:"
        '
        'txtAPIKey
        '
        Me.txtAPIKey.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.txtAPIKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAPIKey.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAPIKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtAPIKey.Location = New System.Drawing.Point(197, 32)
        Me.txtAPIKey.Name = "txtAPIKey"
        Me.txtAPIKey.Size = New System.Drawing.Size(300, 18)
        Me.txtAPIKey.TabIndex = 1
        Me.txtAPIKey.Text = "8e121ecd3be648fa95824416251302"
        Me.txtAPIKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAPIKey.WordWrap = False
        '
        'lblDegrees
        '
        Me.lblDegrees.AutoSize = True
        Me.lblDegrees.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDegrees.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblDegrees.Location = New System.Drawing.Point(96, 82)
        Me.lblDegrees.Margin = New System.Windows.Forms.Padding(96, 16, 32, 16)
        Me.lblDegrees.Name = "lblDegrees"
        Me.lblDegrees.Size = New System.Drawing.Size(48, 18)
        Me.lblDegrees.TabIndex = 2
        Me.lblDegrees.Text = "F°/C°:"
        '
        'Slider1
        '
        Me.Slider1.BackColor = System.Drawing.Color.Transparent
        Me.Slider1.Location = New System.Drawing.Point(197, 82)
        Me.Slider1.Name = "Slider1"
        Me.Slider1.Size = New System.Drawing.Size(50, 20)
        Me.Slider1.TabIndex = 3
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Controls.Add(Me.Slider1)
        Me.Controls.Add(Me.lblDegrees)
        Me.Controls.Add(Me.txtAPIKey)
        Me.Controls.Add(Me.lblAPIKey)
        Me.Name = "Settings"
        Me.Size = New System.Drawing.Size(800, 400)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAPIKey As Label
    Friend WithEvents txtAPIKey As TextBox
    Friend WithEvents lblDegrees As Label
    Friend WithEvents Slider1 As Slider
End Class

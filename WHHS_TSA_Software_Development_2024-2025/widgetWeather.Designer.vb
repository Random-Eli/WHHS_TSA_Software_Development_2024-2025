<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class widgetWeather
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblHumidity = New System.Windows.Forms.Label()
        Me.lblRain = New System.Windows.Forms.Label()
        Me.lblWind = New System.Windows.Forms.Label()
        Me.lblWeather = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.lblLow = New System.Windows.Forms.Label()
        Me.lblHigh = New System.Windows.Forms.Label()
        Me.lblLowInput = New System.Windows.Forms.Label()
        Me.lblHighInput = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ArcadeClassic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(3, 416)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Humidity"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ArcadeClassic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(106, 415)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Rain"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ArcadeClassic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(185, 415)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Wind"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHumidity
        '
        Me.lblHumidity.AutoSize = True
        Me.lblHumidity.Font = New System.Drawing.Font("ArcadeClassic", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHumidity.ForeColor = System.Drawing.Color.Transparent
        Me.lblHumidity.Location = New System.Drawing.Point(26, 380)
        Me.lblHumidity.Name = "lblHumidity"
        Me.lblHumidity.Size = New System.Drawing.Size(46, 27)
        Me.lblHumidity.TabIndex = 5
        Me.lblHumidity.Text = "0%"
        Me.lblHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRain
        '
        Me.lblRain.AutoSize = True
        Me.lblRain.Font = New System.Drawing.Font("ArcadeClassic", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRain.ForeColor = System.Drawing.Color.Transparent
        Me.lblRain.Location = New System.Drawing.Point(102, 380)
        Me.lblRain.Name = "lblRain"
        Me.lblRain.Size = New System.Drawing.Size(61, 27)
        Me.lblRain.TabIndex = 6
        Me.lblRain.Text = "32%"
        Me.lblRain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWind
        '
        Me.lblWind.AutoSize = True
        Me.lblWind.Font = New System.Drawing.Font("ArcadeClassic", 20.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWind.ForeColor = System.Drawing.Color.Transparent
        Me.lblWind.Location = New System.Drawing.Point(171, 381)
        Me.lblWind.Name = "lblWind"
        Me.lblWind.Size = New System.Drawing.Size(81, 27)
        Me.lblWind.TabIndex = 7
        Me.lblWind.Text = "3 Km/h"
        Me.lblWind.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblWeather
        '
        Me.lblWeather.AutoSize = True
        Me.lblWeather.Font = New System.Drawing.Font("ArcadeClassic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeather.ForeColor = System.Drawing.Color.Transparent
        Me.lblWeather.Location = New System.Drawing.Point(16, 30)
        Me.lblWeather.Name = "lblWeather"
        Me.lblWeather.Size = New System.Drawing.Size(237, 64)
        Me.lblWeather.TabIndex = 11
        Me.lblWeather.Text = "Stormy"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("ArcadeClassic", 26.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.ForeColor = System.Drawing.Color.Transparent
        Me.lblStatus.Location = New System.Drawing.Point(69, 94)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(110, 34)
        Me.lblStatus.TabIndex = 12
        Me.lblStatus.Text = "Clear"
        '
        'lblLow
        '
        Me.lblLow.AutoSize = True
        Me.lblLow.Font = New System.Drawing.Font("ArcadeClassic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLow.ForeColor = System.Drawing.Color.Transparent
        Me.lblLow.Location = New System.Drawing.Point(40, 315)
        Me.lblLow.Name = "lblLow"
        Me.lblLow.Size = New System.Drawing.Size(49, 23)
        Me.lblLow.TabIndex = 13
        Me.lblLow.Text = "LOW"
        Me.lblLow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHigh
        '
        Me.lblHigh.AutoSize = True
        Me.lblHigh.Font = New System.Drawing.Font("ArcadeClassic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHigh.ForeColor = System.Drawing.Color.Transparent
        Me.lblHigh.Location = New System.Drawing.Point(155, 315)
        Me.lblHigh.Name = "lblHigh"
        Me.lblHigh.Size = New System.Drawing.Size(62, 23)
        Me.lblHigh.TabIndex = 14
        Me.lblHigh.Text = "High"
        Me.lblHigh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblLowInput
        '
        Me.lblLowInput.AutoSize = True
        Me.lblLowInput.Font = New System.Drawing.Font("ArcadeClassic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLowInput.ForeColor = System.Drawing.Color.Transparent
        Me.lblLowInput.Location = New System.Drawing.Point(43, 275)
        Me.lblLowInput.Name = "lblLowInput"
        Me.lblLowInput.Size = New System.Drawing.Size(46, 27)
        Me.lblLowInput.TabIndex = 15
        Me.lblLowInput.Text = "0%"
        Me.lblLowInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblHighInput
        '
        Me.lblHighInput.AutoSize = True
        Me.lblHighInput.Font = New System.Drawing.Font("ArcadeClassic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighInput.ForeColor = System.Drawing.Color.Transparent
        Me.lblHighInput.Location = New System.Drawing.Point(165, 274)
        Me.lblHighInput.Name = "lblHighInput"
        Me.lblHighInput.Size = New System.Drawing.Size(46, 27)
        Me.lblHighInput.TabIndex = 16
        Me.lblHighInput.Text = "0%"
        Me.lblHighInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'widgetWeather
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.lblHighInput)
        Me.Controls.Add(Me.lblLowInput)
        Me.Controls.Add(Me.lblHigh)
        Me.Controls.Add(Me.lblLow)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblWeather)
        Me.Controls.Add(Me.lblWind)
        Me.Controls.Add(Me.lblRain)
        Me.Controls.Add(Me.lblHumidity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MinimumSize = New System.Drawing.Size(256, 448)
        Me.Name = "widgetWeather"
        Me.Size = New System.Drawing.Size(256, 448)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblHumidity As Label
    Friend WithEvents lblRain As Label
    Friend WithEvents lblWind As Label
    Friend WithEvents lblWeather As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents lblLow As Label
    Friend WithEvents lblHigh As Label
    Friend WithEvents lblLowInput As Label
    Friend WithEvents lblHighInput As Label
End Class

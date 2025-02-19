<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WidgetSelection
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
        Me.components = New System.ComponentModel.Container()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.icoTime = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.icoWeather = New System.Windows.Forms.PictureBox()
        Me.icoTemperature = New System.Windows.Forms.PictureBox()
        Me.icoAdd = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoWeather, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoTemperature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timerAnimation
        '
        Me.timerAnimation.Enabled = True
        Me.timerAnimation.Interval = 1
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.temperature
        Me.PictureBox5.Location = New System.Drawing.Point(64, 83)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(10)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'icoTime
        '
        Me.icoTime.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.clock
        Me.icoTime.Location = New System.Drawing.Point(64, 31)
        Me.icoTime.Margin = New System.Windows.Forms.Padding(10)
        Me.icoTime.Name = "icoTime"
        Me.icoTime.Size = New System.Drawing.Size(32, 32)
        Me.icoTime.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoTime.TabIndex = 5
        Me.icoTime.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.temperature
        Me.PictureBox3.Location = New System.Drawing.Point(118, 83)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(10)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.temperature
        Me.PictureBox2.Location = New System.Drawing.Point(10, 83)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(10)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'icoWeather
        '
        Me.icoWeather.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.weather
        Me.icoWeather.Location = New System.Drawing.Point(118, 31)
        Me.icoWeather.Margin = New System.Windows.Forms.Padding(10)
        Me.icoWeather.Name = "icoWeather"
        Me.icoWeather.Size = New System.Drawing.Size(32, 32)
        Me.icoWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoWeather.TabIndex = 2
        Me.icoWeather.TabStop = False
        '
        'icoTemperature
        '
        Me.icoTemperature.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.temperature
        Me.icoTemperature.Location = New System.Drawing.Point(10, 31)
        Me.icoTemperature.Margin = New System.Windows.Forms.Padding(10)
        Me.icoTemperature.Name = "icoTemperature"
        Me.icoTemperature.Size = New System.Drawing.Size(32, 32)
        Me.icoTemperature.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoTemperature.TabIndex = 1
        Me.icoTemperature.TabStop = False
        '
        'icoAdd
        '
        Me.icoAdd.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.icoAdd.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.add
        Me.icoAdd.Location = New System.Drawing.Point(0, 128)
        Me.icoAdd.Name = "icoAdd"
        Me.icoAdd.Size = New System.Drawing.Size(160, 32)
        Me.icoAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoAdd.TabIndex = 0
        Me.icoAdd.TabStop = False
        '
        'WidgetSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.icoTime)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.icoWeather)
        Me.Controls.Add(Me.icoTemperature)
        Me.Controls.Add(Me.icoAdd)
        Me.DoubleBuffered = True
        Me.Name = "WidgetSelection"
        Me.Size = New System.Drawing.Size(160, 160)
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoWeather, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoTemperature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents icoAdd As PictureBox
    Friend WithEvents timerAnimation As Timer
    Friend WithEvents icoTemperature As PictureBox
    Friend WithEvents icoWeather As PictureBox
    Friend WithEvents icoTime As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

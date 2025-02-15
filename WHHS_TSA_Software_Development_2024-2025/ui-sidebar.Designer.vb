<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ui_sidebar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ui_sidebar))
        Me.lblHome = New System.Windows.Forms.Label()
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        Me.lblIrrigation = New System.Windows.Forms.Label()
        Me.lblWidgets = New System.Windows.Forms.Label()
        Me.icoWidgets = New System.Windows.Forms.PictureBox()
        Me.icoIrrigation = New System.Windows.Forms.PictureBox()
        Me.icoHome = New System.Windows.Forms.PictureBox()
        Me.icoSettings = New System.Windows.Forms.PictureBox()
        CType(Me.icoWidgets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoIrrigation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHome
        '
        Me.lblHome.AutoSize = True
        Me.lblHome.BackColor = System.Drawing.Color.Transparent
        Me.lblHome.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblHome.Location = New System.Drawing.Point(52, 14)
        Me.lblHome.Margin = New System.Windows.Forms.Padding(0)
        Me.lblHome.Name = "lblHome"
        Me.lblHome.Size = New System.Drawing.Size(58, 24)
        Me.lblHome.TabIndex = 2
        Me.lblHome.Text = "Home"
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.BackColor = System.Drawing.Color.Transparent
        Me.lblSettings.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblSettings.Location = New System.Drawing.Point(52, 14)
        Me.lblSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(106, 24)
        Me.lblSettings.TabIndex = 3
        Me.lblSettings.Text = "Settings"
        '
        'timerAnimation
        '
        Me.timerAnimation.Enabled = True
        Me.timerAnimation.Interval = 1
        '
        'lblIrrigation
        '
        Me.lblIrrigation.AutoSize = True
        Me.lblIrrigation.BackColor = System.Drawing.Color.Transparent
        Me.lblIrrigation.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIrrigation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblIrrigation.Location = New System.Drawing.Point(52, 14)
        Me.lblIrrigation.Margin = New System.Windows.Forms.Padding(0)
        Me.lblIrrigation.Name = "lblIrrigation"
        Me.lblIrrigation.Size = New System.Drawing.Size(130, 24)
        Me.lblIrrigation.TabIndex = 6
        Me.lblIrrigation.Text = "Irrigation"
        '
        'lblWidgets
        '
        Me.lblWidgets.AutoSize = True
        Me.lblWidgets.BackColor = System.Drawing.Color.Transparent
        Me.lblWidgets.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWidgets.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblWidgets.Location = New System.Drawing.Point(52, 14)
        Me.lblWidgets.Margin = New System.Windows.Forms.Padding(0)
        Me.lblWidgets.Name = "lblWidgets"
        Me.lblWidgets.Size = New System.Drawing.Size(94, 24)
        Me.lblWidgets.TabIndex = 7
        Me.lblWidgets.Text = "Widgets"
        '
        'icoWidgets
        '
        Me.icoWidgets.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.widget_32
        Me.icoWidgets.Location = New System.Drawing.Point(0, 104)
        Me.icoWidgets.Margin = New System.Windows.Forms.Padding(0)
        Me.icoWidgets.Name = "icoWidgets"
        Me.icoWidgets.Size = New System.Drawing.Size(52, 52)
        Me.icoWidgets.TabIndex = 5
        Me.icoWidgets.TabStop = False
        '
        'icoIrrigation
        '
        Me.icoIrrigation.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.drop_32
        Me.icoIrrigation.Location = New System.Drawing.Point(0, 52)
        Me.icoIrrigation.Margin = New System.Windows.Forms.Padding(0)
        Me.icoIrrigation.Name = "icoIrrigation"
        Me.icoIrrigation.Size = New System.Drawing.Size(52, 52)
        Me.icoIrrigation.TabIndex = 4
        Me.icoIrrigation.TabStop = False
        '
        'icoHome
        '
        Me.icoHome.Image = CType(resources.GetObject("icoHome.Image"), System.Drawing.Image)
        Me.icoHome.Location = New System.Drawing.Point(0, 0)
        Me.icoHome.Margin = New System.Windows.Forms.Padding(0)
        Me.icoHome.Name = "icoHome"
        Me.icoHome.Size = New System.Drawing.Size(52, 52)
        Me.icoHome.TabIndex = 1
        Me.icoHome.TabStop = False
        '
        'icoSettings
        '
        Me.icoSettings.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.icoSettings.Image = CType(resources.GetObject("icoSettings.Image"), System.Drawing.Image)
        Me.icoSettings.Location = New System.Drawing.Point(0, 248)
        Me.icoSettings.Margin = New System.Windows.Forms.Padding(0)
        Me.icoSettings.Name = "icoSettings"
        Me.icoSettings.Size = New System.Drawing.Size(173, 52)
        Me.icoSettings.TabIndex = 0
        Me.icoSettings.TabStop = False
        '
        'ui_sidebar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Controls.Add(Me.lblWidgets)
        Me.Controls.Add(Me.lblIrrigation)
        Me.Controls.Add(Me.icoWidgets)
        Me.Controls.Add(Me.icoIrrigation)
        Me.Controls.Add(Me.lblSettings)
        Me.Controls.Add(Me.lblHome)
        Me.Controls.Add(Me.icoHome)
        Me.Controls.Add(Me.icoSettings)
        Me.DoubleBuffered = True
        Me.Name = "ui_sidebar"
        Me.Size = New System.Drawing.Size(173, 300)
        CType(Me.icoWidgets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoIrrigation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents icoSettings As PictureBox
    Friend WithEvents icoHome As PictureBox
    Friend WithEvents lblHome As Label
    Friend WithEvents lblSettings As Label
    Friend WithEvents timerAnimation As Timer
    Friend WithEvents icoIrrigation As PictureBox
    Friend WithEvents icoWidgets As PictureBox
    Friend WithEvents lblIrrigation As Label
    Friend WithEvents lblWidgets As Label
End Class

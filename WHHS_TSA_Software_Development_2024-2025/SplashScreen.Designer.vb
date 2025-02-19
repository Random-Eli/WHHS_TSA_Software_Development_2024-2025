<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SplashScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SplashScreen))
        Me.picLogo = New System.Windows.Forms.PictureBox()
        Me.lblConnecting = New System.Windows.Forms.Label()
        Me.timerAnimation = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picLogo
        '
        Me.picLogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picLogo.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.Droplet_Icon__Transparent1
        Me.picLogo.Location = New System.Drawing.Point(0, 0)
        Me.picLogo.MaximumSize = New System.Drawing.Size(300, 300)
        Me.picLogo.Name = "picLogo"
        Me.picLogo.Size = New System.Drawing.Size(300, 300)
        Me.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picLogo.TabIndex = 0
        Me.picLogo.TabStop = False
        '
        'lblConnecting
        '
        Me.lblConnecting.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblConnecting.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConnecting.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(249, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.lblConnecting.Location = New System.Drawing.Point(0, 327)
        Me.lblConnecting.Margin = New System.Windows.Forms.Padding(64)
        Me.lblConnecting.Name = "lblConnecting"
        Me.lblConnecting.Size = New System.Drawing.Size(300, 33)
        Me.lblConnecting.TabIndex = 1
        Me.lblConnecting.Text = "Connecting to API"
        Me.lblConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timerAnimation
        '
        Me.timerAnimation.Enabled = True
        Me.timerAnimation.Interval = 500
        '
        'SplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 360)
        Me.Controls.Add(Me.lblConnecting)
        Me.Controls.Add(Me.picLogo)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SplashScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Droplet"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(28, Byte), Integer), CType(CType(29, Byte), Integer))
        CType(Me.picLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogo As PictureBox
    Friend WithEvents lblConnecting As Label
    Friend WithEvents timerAnimation As Timer
End Class

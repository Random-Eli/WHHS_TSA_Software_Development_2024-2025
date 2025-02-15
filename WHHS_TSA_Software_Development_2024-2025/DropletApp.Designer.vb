<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DropletApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DropletApp))
        Me.Ui_sidebar3 = New WHHS_TSA_Software_Development_2024_2025.ui_sidebar()
        Me.Home2 = New WHHS_TSA_Software_Development_2024_2025.Home()
        Me.SuspendLayout()
        '
        'Ui_sidebar3
        '
        Me.Ui_sidebar3.BackColor = System.Drawing.Color.FromArgb(CType(CType(21, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.Ui_sidebar3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Ui_sidebar3.Location = New System.Drawing.Point(0, 0)
        Me.Ui_sidebar3.Name = "Ui_sidebar3"
        Me.Ui_sidebar3.Size = New System.Drawing.Size(52, 450)
        Me.Ui_sidebar3.TabIndex = 0
        '
        'Home2
        '
        Me.Home2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.Home2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Home2.Location = New System.Drawing.Point(52, 0)
        Me.Home2.Name = "Home2"
        Me.Home2.Size = New System.Drawing.Size(748, 450)
        Me.Home2.TabIndex = 1
        '
        'DropletApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(39, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Home2)
        Me.Controls.Add(Me.Ui_sidebar3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(800, 400)
        Me.Name = "DropletApp"
        Me.Text = "Droplet"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Ui_sidebar1 As ui_sidebar
    Friend WithEvents Ui_sidebar As ui_sidebar
    Friend WithEvents Home1 As Home
    Friend WithEvents Ui_sidebar2 As ui_sidebar
    Friend WithEvents Home As Home
    Friend WithEvents Ui_sidebar3 As ui_sidebar
    Friend WithEvents Home2 As Home
End Class

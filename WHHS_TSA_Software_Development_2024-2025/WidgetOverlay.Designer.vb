<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WidgetOverlay
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
        Me.icoRemove = New System.Windows.Forms.PictureBox()
        Me.icoMove = New System.Windows.Forms.PictureBox()
        CType(Me.icoRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.icoMove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'icoRemove
        '
        Me.icoRemove.Dock = System.Windows.Forms.DockStyle.Left
        Me.icoRemove.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.remove
        Me.icoRemove.Location = New System.Drawing.Point(0, 0)
        Me.icoRemove.MaximumSize = New System.Drawing.Size(32, 32)
        Me.icoRemove.Name = "icoRemove"
        Me.icoRemove.Size = New System.Drawing.Size(32, 32)
        Me.icoRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoRemove.TabIndex = 0
        Me.icoRemove.TabStop = False
        '
        'icoMove
        '
        Me.icoMove.Dock = System.Windows.Forms.DockStyle.Right
        Me.icoMove.Image = Global.WHHS_TSA_Software_Development_2024_2025.My.Resources.Resources.move
        Me.icoMove.Location = New System.Drawing.Point(118, 0)
        Me.icoMove.MaximumSize = New System.Drawing.Size(32, 32)
        Me.icoMove.Name = "icoMove"
        Me.icoMove.Size = New System.Drawing.Size(32, 32)
        Me.icoMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.icoMove.TabIndex = 1
        Me.icoMove.TabStop = False
        '
        'WidgetOverlay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.icoMove)
        Me.Controls.Add(Me.icoRemove)
        Me.Name = "WidgetOverlay"
        CType(Me.icoRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.icoMove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents icoRemove As PictureBox
    Friend WithEvents icoMove As PictureBox
End Class

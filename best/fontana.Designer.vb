<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fontanab
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblDescr = New System.Windows.Forms.Label()
        Me.cmdCorrompi = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(149, 97)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 260)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'lblDescr
        '
        Me.lblDescr.Location = New System.Drawing.Point(12, 9)
        Me.lblDescr.Name = "lblDescr"
        Me.lblDescr.Size = New System.Drawing.Size(363, 27)
        Me.lblDescr.TabIndex = 2
        Me.lblDescr.Text = "Fonte battesimale benedetta che hai rubato da un battesimo."
        '
        'cmdCorrompi
        '
        Me.cmdCorrompi.AutoSize = True
        Me.cmdCorrompi.Location = New System.Drawing.Point(304, 66)
        Me.cmdCorrompi.Name = "cmdCorrompi"
        Me.cmdCorrompi.Size = New System.Drawing.Size(105, 25)
        Me.cmdCorrompi.TabIndex = 3
        Me.cmdCorrompi.Text = "Corrompi (5000 B)"
        Me.cmdCorrompi.UseVisualStyleBackColor = True
        '
        'fontanab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 369)
        Me.Controls.Add(Me.cmdCorrompi)
        Me.Controls.Add(Me.lblDescr)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "fontanab"
        Me.Text = "Fontana Battesimale"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescr As System.Windows.Forms.Label
    Friend WithEvents cmdCorrompi As System.Windows.Forms.Button
End Class

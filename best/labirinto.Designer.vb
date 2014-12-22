<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class labirinto
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
        Me.cmdNord = New System.Windows.Forms.Button()
        Me.cmdOvest = New System.Windows.Forms.Button()
        Me.cmdEst = New System.Windows.Forms.Button()
        Me.cmdSud = New System.Windows.Forms.Button()
        Me.lblLab = New System.Windows.Forms.Label()
        Me.lblPosizione = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdNord
        '
        Me.cmdNord.Location = New System.Drawing.Point(449, 81)
        Me.cmdNord.Name = "cmdNord"
        Me.cmdNord.Size = New System.Drawing.Size(102, 41)
        Me.cmdNord.TabIndex = 0
        Me.cmdNord.Text = "Nord"
        Me.cmdNord.UseVisualStyleBackColor = True
        '
        'cmdOvest
        '
        Me.cmdOvest.Location = New System.Drawing.Point(362, 148)
        Me.cmdOvest.Name = "cmdOvest"
        Me.cmdOvest.Size = New System.Drawing.Size(102, 41)
        Me.cmdOvest.TabIndex = 1
        Me.cmdOvest.Text = "Ovest"
        Me.cmdOvest.UseVisualStyleBackColor = True
        '
        'cmdEst
        '
        Me.cmdEst.Location = New System.Drawing.Point(541, 148)
        Me.cmdEst.Name = "cmdEst"
        Me.cmdEst.Size = New System.Drawing.Size(102, 41)
        Me.cmdEst.TabIndex = 2
        Me.cmdEst.Text = "Est"
        Me.cmdEst.UseVisualStyleBackColor = True
        '
        'cmdSud
        '
        Me.cmdSud.Location = New System.Drawing.Point(449, 215)
        Me.cmdSud.Name = "cmdSud"
        Me.cmdSud.Size = New System.Drawing.Size(102, 41)
        Me.cmdSud.TabIndex = 3
        Me.cmdSud.Text = "Sud"
        Me.cmdSud.UseVisualStyleBackColor = True
        '
        'lblLab
        '
        Me.lblLab.Location = New System.Drawing.Point(216, 9)
        Me.lblLab.Name = "lblLab"
        Me.lblLab.Size = New System.Drawing.Size(211, 119)
        Me.lblLab.TabIndex = 4
        Me.lblLab.Text = "Label1"
        '
        'lblPosizione
        '
        Me.lblPosizione.AutoSize = True
        Me.lblPosizione.Location = New System.Drawing.Point(376, 275)
        Me.lblPosizione.Name = "lblPosizione"
        Me.lblPosizione.Size = New System.Drawing.Size(51, 13)
        Me.lblPosizione.TabIndex = 5
        Me.lblPosizione.Text = "posizione"
        '
        'labirinto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 562)
        Me.Controls.Add(Me.lblPosizione)
        Me.Controls.Add(Me.lblLab)
        Me.Controls.Add(Me.cmdSud)
        Me.Controls.Add(Me.cmdEst)
        Me.Controls.Add(Me.cmdOvest)
        Me.Controls.Add(Me.cmdNord)
        Me.Name = "labirinto"
        Me.Text = "labirinto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdNord As System.Windows.Forms.Button
    Friend WithEvents cmdOvest As System.Windows.Forms.Button
    Friend WithEvents cmdEst As System.Windows.Forms.Button
    Friend WithEvents cmdSud As System.Windows.Forms.Button
    Friend WithEvents lblLab As System.Windows.Forms.Label
    Friend WithEvents lblPosizione As System.Windows.Forms.Label
End Class

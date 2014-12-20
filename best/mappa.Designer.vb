<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mappa
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
        Me.cmdViandante = New System.Windows.Forms.Button()
        Me.cmdCripta = New System.Windows.Forms.Button()
        Me.cmdAltareMappa = New System.Windows.Forms.Button()
        Me.cmdEremita = New System.Windows.Forms.Button()
        Me.cmdRadura = New System.Windows.Forms.Button()
        Me.cmdPonte = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmdViandante
        '
        Me.cmdViandante.Location = New System.Drawing.Point(37, 42)
        Me.cmdViandante.Name = "cmdViandante"
        Me.cmdViandante.Size = New System.Drawing.Size(98, 26)
        Me.cmdViandante.TabIndex = 0
        Me.cmdViandante.Text = "Viandante"
        Me.cmdViandante.UseVisualStyleBackColor = True
        '
        'cmdCripta
        '
        Me.cmdCripta.Location = New System.Drawing.Point(37, 74)
        Me.cmdCripta.Name = "cmdCripta"
        Me.cmdCripta.Size = New System.Drawing.Size(98, 26)
        Me.cmdCripta.TabIndex = 1
        Me.cmdCripta.Text = "Cripta"
        Me.cmdCripta.UseVisualStyleBackColor = True
        '
        'cmdAltareMappa
        '
        Me.cmdAltareMappa.Location = New System.Drawing.Point(37, 138)
        Me.cmdAltareMappa.Name = "cmdAltareMappa"
        Me.cmdAltareMappa.Size = New System.Drawing.Size(98, 26)
        Me.cmdAltareMappa.TabIndex = 2
        Me.cmdAltareMappa.Text = "Altare"
        Me.cmdAltareMappa.UseVisualStyleBackColor = True
        '
        'cmdEremita
        '
        Me.cmdEremita.Location = New System.Drawing.Point(37, 106)
        Me.cmdEremita.Name = "cmdEremita"
        Me.cmdEremita.Size = New System.Drawing.Size(98, 26)
        Me.cmdEremita.TabIndex = 3
        Me.cmdEremita.Text = "Eremita"
        Me.cmdEremita.UseVisualStyleBackColor = True
        '
        'cmdRadura
        '
        Me.cmdRadura.Location = New System.Drawing.Point(37, 170)
        Me.cmdRadura.Name = "cmdRadura"
        Me.cmdRadura.Size = New System.Drawing.Size(98, 26)
        Me.cmdRadura.TabIndex = 4
        Me.cmdRadura.Text = "Radura"
        Me.cmdRadura.UseVisualStyleBackColor = True
        '
        'cmdPonte
        '
        Me.cmdPonte.Location = New System.Drawing.Point(37, 202)
        Me.cmdPonte.Name = "cmdPonte"
        Me.cmdPonte.Size = New System.Drawing.Size(98, 26)
        Me.cmdPonte.TabIndex = 5
        Me.cmdPonte.Text = "Ponte"
        Me.cmdPonte.UseVisualStyleBackColor = True
        '
        'mappa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(870, 580)
        Me.Controls.Add(Me.cmdPonte)
        Me.Controls.Add(Me.cmdRadura)
        Me.Controls.Add(Me.cmdEremita)
        Me.Controls.Add(Me.cmdAltareMappa)
        Me.Controls.Add(Me.cmdCripta)
        Me.Controls.Add(Me.cmdViandante)
        Me.Name = "mappa"
        Me.Text = "mappa"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdViandante As System.Windows.Forms.Button
    Friend WithEvents cmdCripta As System.Windows.Forms.Button
    Friend WithEvents cmdAltareMappa As System.Windows.Forms.Button
    Friend WithEvents cmdEremita As System.Windows.Forms.Button
    Friend WithEvents cmdRadura As System.Windows.Forms.Button
    Friend WithEvents cmdPonte As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class boss_templare
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
        Me.cmdAttacca = New System.Windows.Forms.Button()
        Me.cmdPara = New System.Windows.Forms.Button()
        Me.lblHp = New System.Windows.Forms.Label()
        Me.lblTemplare = New System.Windows.Forms.Label()
        Me.lblPicU = New System.Windows.Forms.Label()
        Me.lblPicTemp = New System.Windows.Forms.Label()
        Me.timer_scontro = New System.Windows.Forms.Timer(Me.components)
        Me.lblDannoTuo = New System.Windows.Forms.Label()
        Me.lblDannoTemplare = New System.Windows.Forms.Label()
        Me.timer_animazione = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'cmdAttacca
        '
        Me.cmdAttacca.Location = New System.Drawing.Point(51, 220)
        Me.cmdAttacca.Name = "cmdAttacca"
        Me.cmdAttacca.Size = New System.Drawing.Size(81, 33)
        Me.cmdAttacca.TabIndex = 0
        Me.cmdAttacca.Text = "Attacco"
        Me.cmdAttacca.UseVisualStyleBackColor = True
        '
        'cmdPara
        '
        Me.cmdPara.Location = New System.Drawing.Point(138, 220)
        Me.cmdPara.Name = "cmdPara"
        Me.cmdPara.Size = New System.Drawing.Size(81, 33)
        Me.cmdPara.TabIndex = 1
        Me.cmdPara.Text = "Parata"
        Me.cmdPara.UseVisualStyleBackColor = True
        '
        'lblHp
        '
        Me.lblHp.AutoSize = True
        Me.lblHp.Location = New System.Drawing.Point(12, 21)
        Me.lblHp.Name = "lblHp"
        Me.lblHp.Size = New System.Drawing.Size(39, 13)
        Me.lblHp.TabIndex = 2
        Me.lblHp.Text = "Label1"
        '
        'lblTemplare
        '
        Me.lblTemplare.AutoSize = True
        Me.lblTemplare.Location = New System.Drawing.Point(616, 9)
        Me.lblTemplare.Name = "lblTemplare"
        Me.lblTemplare.Size = New System.Drawing.Size(39, 13)
        Me.lblTemplare.TabIndex = 3
        Me.lblTemplare.Text = "Label2"
        '
        'lblPicU
        '
        Me.lblPicU.AutoSize = True
        Me.lblPicU.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPicU.Location = New System.Drawing.Point(50, 100)
        Me.lblPicU.Name = "lblPicU"
        Me.lblPicU.Size = New System.Drawing.Size(36, 23)
        Me.lblPicU.TabIndex = 4
        Me.lblPicU.Text = "tu"
        Me.lblPicU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPicTemp
        '
        Me.lblPicTemp.AutoSize = True
        Me.lblPicTemp.Font = New System.Drawing.Font("Courier New", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPicTemp.Location = New System.Drawing.Point(500, 100)
        Me.lblPicTemp.Name = "lblPicTemp"
        Me.lblPicTemp.Size = New System.Drawing.Size(114, 23)
        Me.lblPicTemp.TabIndex = 5
        Me.lblPicTemp.Text = "templare"
        Me.lblPicTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'timer_scontro
        '
        Me.timer_scontro.Interval = 10
        '
        'lblDannoTuo
        '
        Me.lblDannoTuo.AutoSize = True
        Me.lblDannoTuo.Location = New System.Drawing.Point(89, 84)
        Me.lblDannoTuo.Name = "lblDannoTuo"
        Me.lblDannoTuo.Size = New System.Drawing.Size(39, 13)
        Me.lblDannoTuo.TabIndex = 6
        Me.lblDannoTuo.Text = "Label2"
        '
        'lblDannoTemplare
        '
        Me.lblDannoTemplare.AutoSize = True
        Me.lblDannoTemplare.Location = New System.Drawing.Point(470, 84)
        Me.lblDannoTemplare.Name = "lblDannoTemplare"
        Me.lblDannoTemplare.Size = New System.Drawing.Size(39, 13)
        Me.lblDannoTemplare.TabIndex = 7
        Me.lblDannoTemplare.Text = "Label2"
        '
        'timer_animazione
        '
        Me.timer_animazione.Interval = 300
        '
        'boss_templare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 495)
        Me.Controls.Add(Me.lblDannoTemplare)
        Me.Controls.Add(Me.lblDannoTuo)
        Me.Controls.Add(Me.lblPicTemp)
        Me.Controls.Add(Me.lblPicU)
        Me.Controls.Add(Me.lblTemplare)
        Me.Controls.Add(Me.lblHp)
        Me.Controls.Add(Me.cmdPara)
        Me.Controls.Add(Me.cmdAttacca)
        Me.Name = "boss_templare"
        Me.Text = "boss_templare"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAttacca As System.Windows.Forms.Button
    Friend WithEvents cmdPara As System.Windows.Forms.Button
    Friend WithEvents lblHp As System.Windows.Forms.Label
    Friend WithEvents lblTemplare As System.Windows.Forms.Label
    Friend WithEvents lblPicU As System.Windows.Forms.Label
    Friend WithEvents lblPicTemp As System.Windows.Forms.Label
    Friend WithEvents timer_scontro As System.Windows.Forms.Timer
    Friend WithEvents lblDannoTuo As System.Windows.Forms.Label
    Friend WithEvents lblDannoTemplare As System.Windows.Forms.Label
    Friend WithEvents timer_animazione As System.Windows.Forms.Timer
End Class

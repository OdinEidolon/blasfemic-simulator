<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class quest
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
        Me.lstScontro = New System.Windows.Forms.ListBox()
        Me.cmboxQuest = New System.Windows.Forms.ComboBox()
        Me.lblDescQuest = New System.Windows.Forms.Label()
        Me.cmdIniziaQ = New System.Windows.Forms.Button()
        Me.lblLoot = New System.Windows.Forms.Label()
        Me.lblCooldown = New System.Windows.Forms.Label()
        Me.lblLootSpeciali = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lstScontro
        '
        Me.lstScontro.FormattingEnabled = True
        Me.lstScontro.Location = New System.Drawing.Point(12, 41)
        Me.lstScontro.Name = "lstScontro"
        Me.lstScontro.Size = New System.Drawing.Size(300, 407)
        Me.lstScontro.TabIndex = 0
        '
        'cmboxQuest
        '
        Me.cmboxQuest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmboxQuest.FormattingEnabled = True
        Me.cmboxQuest.Location = New System.Drawing.Point(12, 12)
        Me.cmboxQuest.Name = "cmboxQuest"
        Me.cmboxQuest.Size = New System.Drawing.Size(247, 21)
        Me.cmboxQuest.TabIndex = 1
        '
        'lblDescQuest
        '
        Me.lblDescQuest.AutoSize = True
        Me.lblDescQuest.Location = New System.Drawing.Point(318, 50)
        Me.lblDescQuest.Name = "lblDescQuest"
        Me.lblDescQuest.Size = New System.Drawing.Size(91, 13)
        Me.lblDescQuest.TabIndex = 2
        Me.lblDescQuest.Text = "Descrizione quest"
        '
        'cmdIniziaQ
        '
        Me.cmdIniziaQ.AutoSize = True
        Me.cmdIniziaQ.Location = New System.Drawing.Point(265, 12)
        Me.cmdIniziaQ.Name = "cmdIniziaQ"
        Me.cmdIniziaQ.Size = New System.Drawing.Size(47, 23)
        Me.cmdIniziaQ.TabIndex = 3
        Me.cmdIniziaQ.Text = "Inizia"
        Me.cmdIniziaQ.UseVisualStyleBackColor = True
        '
        'lblLoot
        '
        Me.lblLoot.AutoSize = True
        Me.lblLoot.Location = New System.Drawing.Point(318, 432)
        Me.lblLoot.Name = "lblLoot"
        Me.lblLoot.Size = New System.Drawing.Size(112, 13)
        Me.lblLoot.TabIndex = 4
        Me.lblLoot.Text = "Hai tirato 0 Bestemmie"
        '
        'lblCooldown
        '
        Me.lblCooldown.AutoSize = True
        Me.lblCooldown.Location = New System.Drawing.Point(318, 12)
        Me.lblCooldown.Name = "lblCooldown"
        Me.lblCooldown.Size = New System.Drawing.Size(142, 26)
        Me.lblCooldown.TabIndex = 5
        Me.lblCooldown.Text = "Devi aspettare 60 secondi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "per iniziare una nuova Quest"
        Me.lblCooldown.Visible = False
        '
        'lblLootSpeciali
        '
        Me.lblLootSpeciali.AutoSize = True
        Me.lblLootSpeciali.Location = New System.Drawing.Point(318, 404)
        Me.lblLootSpeciali.Name = "lblLootSpeciali"
        Me.lblLootSpeciali.Size = New System.Drawing.Size(112, 13)
        Me.lblLootSpeciali.TabIndex = 6
        Me.lblLootSpeciali.Text = "Non hai trovato niente"
        Me.lblLootSpeciali.Visible = False
        '
        'quest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 454)
        Me.Controls.Add(Me.lblLootSpeciali)
        Me.Controls.Add(Me.lblCooldown)
        Me.Controls.Add(Me.lblLoot)
        Me.Controls.Add(Me.cmdIniziaQ)
        Me.Controls.Add(Me.lblDescQuest)
        Me.Controls.Add(Me.cmboxQuest)
        Me.Controls.Add(Me.lstScontro)
        Me.Name = "quest"
        Me.Text = "Quest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstScontro As System.Windows.Forms.ListBox
    Friend WithEvents cmboxQuest As System.Windows.Forms.ComboBox
    Friend WithEvents lblDescQuest As System.Windows.Forms.Label
    Friend WithEvents cmdIniziaQ As System.Windows.Forms.Button
    Friend WithEvents lblLoot As System.Windows.Forms.Label
    Friend WithEvents lblCooldown As System.Windows.Forms.Label
    Friend WithEvents lblLootSpeciali As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.lblBestemmie = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Timer(Me.components)
        Me.lblBPS = New System.Windows.Forms.Label()
        Me.cmdBestemmia = New System.Windows.Forms.Button()
        Me.chkBestemmia = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lstLog = New System.Windows.Forms.ListView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstInventario = New System.Windows.Forms.ListBox()
        Me.grbInventario = New System.Windows.Forms.GroupBox()
        Me.lblAttacco = New System.Windows.Forms.Label()
        Me.cmdNegozio = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdLoad = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdAltare = New System.Windows.Forms.Button()
        Me.grbAltare = New System.Windows.Forms.GroupBox()
        Me.grbFabbrica = New System.Windows.Forms.GroupBox()
        Me.lblProduzione = New System.Windows.Forms.Label()
        Me.cmdMacchinari = New System.Windows.Forms.Button()
        Me.cmdOperai = New System.Windows.Forms.Button()
        Me.lblMacchinari = New System.Windows.Forms.Label()
        Me.lblOperai = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblEP = New System.Windows.Forms.Label()
        Me.cmdQuest = New System.Windows.Forms.Button()
        Me.timer_cooldown = New System.Windows.Forms.Timer(Me.components)
        Me.grbFontana = New System.Windows.Forms.GroupBox()
        Me.cmdFontana = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.cmdMappa = New System.Windows.Forms.Button()
        Me.cmdLabirinto = New System.Windows.Forms.Button()
        Me.cmdTemp = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grbInventario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbAltare.SuspendLayout()
        Me.grbFabbrica.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbFontana.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblBestemmie
        '
        Me.lblBestemmie.AutoSize = True
        Me.lblBestemmie.Location = New System.Drawing.Point(9, 47)
        Me.lblBestemmie.Name = "lblBestemmie"
        Me.lblBestemmie.Size = New System.Drawing.Size(88, 13)
        Me.lblBestemmie.TabIndex = 0
        Me.lblBestemmie.Text = "Hai 0 bestemmie."
        '
        'sec
        '
        Me.sec.Interval = 1000
        '
        'lblBPS
        '
        Me.lblBPS.AutoSize = True
        Me.lblBPS.Location = New System.Drawing.Point(9, 66)
        Me.lblBPS.Name = "lblBPS"
        Me.lblBPS.Size = New System.Drawing.Size(37, 13)
        Me.lblBPS.TabIndex = 1
        Me.lblBPS.Text = "0 BPS"
        Me.lblBPS.Visible = False
        '
        'cmdBestemmia
        '
        Me.cmdBestemmia.Location = New System.Drawing.Point(12, 12)
        Me.cmdBestemmia.Name = "cmdBestemmia"
        Me.cmdBestemmia.Size = New System.Drawing.Size(66, 23)
        Me.cmdBestemmia.TabIndex = 2
        Me.cmdBestemmia.Text = "Bestemmia"
        Me.cmdBestemmia.UseVisualStyleBackColor = True
        '
        'chkBestemmia
        '
        Me.chkBestemmia.AutoSize = True
        Me.chkBestemmia.Location = New System.Drawing.Point(84, 16)
        Me.chkBestemmia.Name = "chkBestemmia"
        Me.chkBestemmia.Size = New System.Drawing.Size(99, 17)
        Me.chkBestemmia.TabIndex = 4
        Me.chkBestemmia.Text = "AutoBestemmia"
        Me.chkBestemmia.UseVisualStyleBackColor = True
        Me.chkBestemmia.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(489, 403)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(107, 79)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CodingCheat"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(52, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 26)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "BPS+"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(16, 45)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 26)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "B+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(84, 20)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "0"
        '
        'lstLog
        '
        Me.lstLog.Alignment = System.Windows.Forms.ListViewAlignment.[Default]
        Me.lstLog.Location = New System.Drawing.Point(189, 12)
        Me.lstLog.MultiSelect = False
        Me.lstLog.Name = "lstLog"
        Me.lstLog.ShowItemToolTips = True
        Me.lstLog.Size = New System.Drawing.Size(401, 87)
        Me.lstLog.TabIndex = 10
        Me.lstLog.UseCompatibleStateImageBehavior = False
        Me.lstLog.View = System.Windows.Forms.View.List
        Me.lstLog.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 309)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Label6"
        '
        'lstInventario
        '
        Me.lstInventario.FormattingEnabled = True
        Me.lstInventario.Location = New System.Drawing.Point(6, 50)
        Me.lstInventario.Name = "lstInventario"
        Me.lstInventario.Size = New System.Drawing.Size(183, 160)
        Me.lstInventario.TabIndex = 14
        '
        'grbInventario
        '
        Me.grbInventario.Controls.Add(Me.lblAttacco)
        Me.grbInventario.Controls.Add(Me.Label6)
        Me.grbInventario.Controls.Add(Me.lstInventario)
        Me.grbInventario.Controls.Add(Me.cmdNegozio)
        Me.grbInventario.Location = New System.Drawing.Point(12, 105)
        Me.grbInventario.Name = "grbInventario"
        Me.grbInventario.Size = New System.Drawing.Size(195, 359)
        Me.grbInventario.TabIndex = 15
        Me.grbInventario.TabStop = False
        Me.grbInventario.Text = "Inventario"
        Me.grbInventario.Visible = False
        '
        'lblAttacco
        '
        Me.lblAttacco.AutoSize = True
        Me.lblAttacco.Location = New System.Drawing.Point(78, 24)
        Me.lblAttacco.Name = "lblAttacco"
        Me.lblAttacco.Size = New System.Drawing.Size(56, 13)
        Me.lblAttacco.TabIndex = 25
        Me.lblAttacco.Text = "Attacco: 0"
        '
        'cmdNegozio
        '
        Me.cmdNegozio.Location = New System.Drawing.Point(6, 19)
        Me.cmdNegozio.Name = "cmdNegozio"
        Me.cmdNegozio.Size = New System.Drawing.Size(66, 23)
        Me.cmdNegozio.TabIndex = 16
        Me.cmdNegozio.Text = "Negozio"
        Me.cmdNegozio.UseVisualStyleBackColor = True
        Me.cmdNegozio.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(214, 105)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(79, 25)
        Me.cmdSave.TabIndex = 17
        Me.cmdSave.Text = "Salva"
        Me.cmdSave.UseVisualStyleBackColor = True
        Me.cmdSave.Visible = False
        '
        'cmdLoad
        '
        Me.cmdLoad.Location = New System.Drawing.Point(299, 105)
        Me.cmdLoad.Name = "cmdLoad"
        Me.cmdLoad.Size = New System.Drawing.Size(79, 25)
        Me.cmdLoad.TabIndex = 18
        Me.cmdLoad.Text = "Carica"
        Me.cmdLoad.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(7, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(92, 87)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'cmdAltare
        '
        Me.cmdAltare.AutoSize = True
        Me.cmdAltare.Location = New System.Drawing.Point(6, 13)
        Me.cmdAltare.Name = "cmdAltare"
        Me.cmdAltare.Size = New System.Drawing.Size(93, 23)
        Me.cmdAltare.TabIndex = 20
        Me.cmdAltare.Text = "Vai all'altare"
        Me.cmdAltare.UseVisualStyleBackColor = True
        '
        'grbAltare
        '
        Me.grbAltare.Controls.Add(Me.cmdAltare)
        Me.grbAltare.Controls.Add(Me.PictureBox1)
        Me.grbAltare.Location = New System.Drawing.Point(482, 256)
        Me.grbAltare.Name = "grbAltare"
        Me.grbAltare.Size = New System.Drawing.Size(107, 137)
        Me.grbAltare.TabIndex = 21
        Me.grbAltare.TabStop = False
        Me.grbAltare.Text = "Altare del Male"
        '
        'grbFabbrica
        '
        Me.grbFabbrica.Controls.Add(Me.lblProduzione)
        Me.grbFabbrica.Controls.Add(Me.cmdMacchinari)
        Me.grbFabbrica.Controls.Add(Me.cmdOperai)
        Me.grbFabbrica.Controls.Add(Me.lblMacchinari)
        Me.grbFabbrica.Controls.Add(Me.lblOperai)
        Me.grbFabbrica.Controls.Add(Me.PictureBox2)
        Me.grbFabbrica.Location = New System.Drawing.Point(213, 356)
        Me.grbFabbrica.Name = "grbFabbrica"
        Me.grbFabbrica.Size = New System.Drawing.Size(264, 108)
        Me.grbFabbrica.TabIndex = 22
        Me.grbFabbrica.TabStop = False
        Me.grbFabbrica.Text = "Fabbrica delle Bestemmie"
        '
        'lblProduzione
        '
        Me.lblProduzione.AutoSize = True
        Me.lblProduzione.Location = New System.Drawing.Point(6, 82)
        Me.lblProduzione.Name = "lblProduzione"
        Me.lblProduzione.Size = New System.Drawing.Size(96, 13)
        Me.lblProduzione.TabIndex = 25
        Me.lblProduzione.Text = "Produzione: 0 BPS"
        '
        'cmdMacchinari
        '
        Me.cmdMacchinari.AutoSize = True
        Me.cmdMacchinari.Location = New System.Drawing.Point(6, 47)
        Me.cmdMacchinari.Name = "cmdMacchinari"
        Me.cmdMacchinari.Size = New System.Drawing.Size(23, 23)
        Me.cmdMacchinari.TabIndex = 24
        Me.cmdMacchinari.Text = "+"
        Me.cmdMacchinari.UseVisualStyleBackColor = True
        '
        'cmdOperai
        '
        Me.cmdOperai.AutoSize = True
        Me.cmdOperai.Enabled = False
        Me.cmdOperai.Location = New System.Drawing.Point(6, 19)
        Me.cmdOperai.Name = "cmdOperai"
        Me.cmdOperai.Size = New System.Drawing.Size(23, 23)
        Me.cmdOperai.TabIndex = 23
        Me.cmdOperai.Text = "+"
        Me.cmdOperai.UseVisualStyleBackColor = True
        '
        'lblMacchinari
        '
        Me.lblMacchinari.AutoSize = True
        Me.lblMacchinari.Location = New System.Drawing.Point(27, 52)
        Me.lblMacchinari.Name = "lblMacchinari"
        Me.lblMacchinari.Size = New System.Drawing.Size(71, 13)
        Me.lblMacchinari.TabIndex = 22
        Me.lblMacchinari.Text = "Macchinari: 0"
        '
        'lblOperai
        '
        Me.lblOperai.AutoSize = True
        Me.lblOperai.Location = New System.Drawing.Point(48, 24)
        Me.lblOperai.Name = "lblOperai"
        Me.lblOperai.Size = New System.Drawing.Size(50, 13)
        Me.lblOperai.TabIndex = 21
        Me.lblOperai.Text = "Operai: 0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(175, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 83)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'lblEP
        '
        Me.lblEP.AutoSize = True
        Me.lblEP.Location = New System.Drawing.Point(9, 85)
        Me.lblEP.Name = "lblEP"
        Me.lblEP.Size = New System.Drawing.Size(42, 13)
        Me.lblEP.TabIndex = 23
        Me.lblEP.Text = "EP: x/x"
        '
        'cmdQuest
        '
        Me.cmdQuest.AutoSize = True
        Me.cmdQuest.Location = New System.Drawing.Point(214, 136)
        Me.cmdQuest.Name = "cmdQuest"
        Me.cmdQuest.Size = New System.Drawing.Size(79, 24)
        Me.cmdQuest.TabIndex = 24
        Me.cmdQuest.Text = "Quest"
        Me.cmdQuest.UseVisualStyleBackColor = True
        Me.cmdQuest.Visible = False
        '
        'timer_cooldown
        '
        Me.timer_cooldown.Interval = 1000
        '
        'grbFontana
        '
        Me.grbFontana.Controls.Add(Me.cmdFontana)
        Me.grbFontana.Controls.Add(Me.PictureBox3)
        Me.grbFontana.Location = New System.Drawing.Point(482, 105)
        Me.grbFontana.Name = "grbFontana"
        Me.grbFontana.Size = New System.Drawing.Size(107, 136)
        Me.grbFontana.TabIndex = 22
        Me.grbFontana.TabStop = False
        Me.grbFontana.Text = "Fontana"
        '
        'cmdFontana
        '
        Me.cmdFontana.AutoSize = True
        Me.cmdFontana.Location = New System.Drawing.Point(6, 14)
        Me.cmdFontana.Name = "cmdFontana"
        Me.cmdFontana.Size = New System.Drawing.Size(93, 23)
        Me.cmdFontana.TabIndex = 20
        Me.cmdFontana.Text = "Vai alla Fontana"
        Me.cmdFontana.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(6, 42)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(93, 87)
        Me.PictureBox3.TabIndex = 19
        Me.PictureBox3.TabStop = False
        '
        'cmdMappa
        '
        Me.cmdMappa.AutoSize = True
        Me.cmdMappa.Location = New System.Drawing.Point(299, 136)
        Me.cmdMappa.Name = "cmdMappa"
        Me.cmdMappa.Size = New System.Drawing.Size(79, 24)
        Me.cmdMappa.TabIndex = 25
        Me.cmdMappa.Text = "Mappa"
        Me.cmdMappa.UseVisualStyleBackColor = True
        Me.cmdMappa.Visible = False
        '
        'cmdLabirinto
        '
        Me.cmdLabirinto.Location = New System.Drawing.Point(214, 166)
        Me.cmdLabirinto.Name = "cmdLabirinto"
        Me.cmdLabirinto.Size = New System.Drawing.Size(79, 25)
        Me.cmdLabirinto.TabIndex = 26
        Me.cmdLabirinto.Text = "Labirinto"
        Me.cmdLabirinto.UseVisualStyleBackColor = True
        '
        'cmdTemp
        '
        Me.cmdTemp.Location = New System.Drawing.Point(299, 166)
        Me.cmdTemp.Name = "cmdTemp"
        Me.cmdTemp.Size = New System.Drawing.Size(79, 25)
        Me.cmdTemp.TabIndex = 27
        Me.cmdTemp.Text = "Templare"
        Me.cmdTemp.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 477)
        Me.Controls.Add(Me.cmdTemp)
        Me.Controls.Add(Me.cmdLabirinto)
        Me.Controls.Add(Me.cmdMappa)
        Me.Controls.Add(Me.grbFontana)
        Me.Controls.Add(Me.cmdQuest)
        Me.Controls.Add(Me.lblEP)
        Me.Controls.Add(Me.grbFabbrica)
        Me.Controls.Add(Me.grbAltare)
        Me.Controls.Add(Me.cmdLoad)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.grbInventario)
        Me.Controls.Add(Me.lstLog)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkBestemmia)
        Me.Controls.Add(Me.cmdBestemmia)
        Me.Controls.Add(Me.lblBPS)
        Me.Controls.Add(Me.lblBestemmie)
        Me.Name = "home"
        Me.Text = "Home"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbInventario.ResumeLayout(False)
        Me.grbInventario.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbAltare.ResumeLayout(False)
        Me.grbAltare.PerformLayout()
        Me.grbFabbrica.ResumeLayout(False)
        Me.grbFabbrica.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbFontana.ResumeLayout(False)
        Me.grbFontana.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblBestemmie As System.Windows.Forms.Label
    Friend WithEvents sec As System.Windows.Forms.Timer
    Friend WithEvents lblBPS As System.Windows.Forms.Label
    Friend WithEvents cmdBestemmia As System.Windows.Forms.Button
    Friend WithEvents chkBestemmia As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lstLog As System.Windows.Forms.ListView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstInventario As System.Windows.Forms.ListBox
    Friend WithEvents grbInventario As System.Windows.Forms.GroupBox
    Friend WithEvents cmdNegozio As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdLoad As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdAltare As System.Windows.Forms.Button
    Friend WithEvents grbAltare As System.Windows.Forms.GroupBox
    Friend WithEvents grbFabbrica As System.Windows.Forms.GroupBox
    Friend WithEvents lblProduzione As System.Windows.Forms.Label
    Friend WithEvents cmdMacchinari As System.Windows.Forms.Button
    Friend WithEvents cmdOperai As System.Windows.Forms.Button
    Friend WithEvents lblMacchinari As System.Windows.Forms.Label
    Friend WithEvents lblOperai As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblEP As System.Windows.Forms.Label
    Friend WithEvents cmdQuest As System.Windows.Forms.Button
    Friend WithEvents lblAttacco As System.Windows.Forms.Label
    Friend WithEvents timer_cooldown As System.Windows.Forms.Timer
    Friend WithEvents grbFontana As System.Windows.Forms.GroupBox
    Friend WithEvents cmdFontana As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdMappa As System.Windows.Forms.Button
    Friend WithEvents cmdLabirinto As System.Windows.Forms.Button
    Friend WithEvents cmdTemp As System.Windows.Forms.Button

End Class

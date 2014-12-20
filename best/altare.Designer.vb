<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class altare
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdInfondi1 = New System.Windows.Forms.Button()
        Me.cmdInfondiAll = New System.Windows.Forms.Button()
        Me.cmdInfondi10 = New System.Windows.Forms.Button()
        Me.cmdInfondi100 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(115, 39)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(260, 260)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(363, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Un antico altare sacrificale dove potrai infondere le Bestiemmie nella tua malvag" & _
    "ia anima, aumentando la tua capacità di resistere alle forze del bene." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'cmdInfondi1
        '
        Me.cmdInfondi1.AutoSize = True
        Me.cmdInfondi1.Location = New System.Drawing.Point(6, 41)
        Me.cmdInfondi1.Name = "cmdInfondi1"
        Me.cmdInfondi1.Size = New System.Drawing.Size(103, 23)
        Me.cmdInfondi1.TabIndex = 2
        Me.cmdInfondi1.Text = "Infondi 1K B"
        Me.cmdInfondi1.UseVisualStyleBackColor = True
        '
        'cmdInfondiAll
        '
        Me.cmdInfondiAll.Location = New System.Drawing.Point(6, 128)
        Me.cmdInfondiAll.Name = "cmdInfondiAll"
        Me.cmdInfondiAll.Size = New System.Drawing.Size(103, 35)
        Me.cmdInfondiAll.TabIndex = 3
        Me.cmdInfondiAll.Text = "Infondi tutte le Bestemmie"
        Me.cmdInfondiAll.UseVisualStyleBackColor = True
        '
        'cmdInfondi10
        '
        Me.cmdInfondi10.AutoSize = True
        Me.cmdInfondi10.Location = New System.Drawing.Point(6, 70)
        Me.cmdInfondi10.Name = "cmdInfondi10"
        Me.cmdInfondi10.Size = New System.Drawing.Size(103, 23)
        Me.cmdInfondi10.TabIndex = 4
        Me.cmdInfondi10.Text = "Infondi 10K B"
        Me.cmdInfondi10.UseVisualStyleBackColor = True
        '
        'cmdInfondi100
        '
        Me.cmdInfondi100.AutoSize = True
        Me.cmdInfondi100.Location = New System.Drawing.Point(6, 99)
        Me.cmdInfondi100.Name = "cmdInfondi100"
        Me.cmdInfondi100.Size = New System.Drawing.Size(103, 23)
        Me.cmdInfondi100.TabIndex = 5
        Me.cmdInfondi100.Text = "Infondi 100K B"
        Me.cmdInfondi100.UseVisualStyleBackColor = True
        '
        'altare
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(379, 305)
        Me.Controls.Add(Me.cmdInfondi100)
        Me.Controls.Add(Me.cmdInfondi10)
        Me.Controls.Add(Me.cmdInfondiAll)
        Me.Controls.Add(Me.cmdInfondi1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "altare"
        Me.Text = "Altare del Male"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdInfondi1 As System.Windows.Forms.Button
    Friend WithEvents cmdInfondiAll As System.Windows.Forms.Button
    Friend WithEvents cmdInfondi10 As System.Windows.Forms.Button
    Friend WithEvents cmdInfondi100 As System.Windows.Forms.Button
End Class

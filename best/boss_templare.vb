Public Class boss_templare

    Dim nome_enemy As String = "Templare"
    Dim vita_enemy As Integer = 736
    Dim cap_enemy As Integer = 736
    Dim attacco_enemy As Integer = 78
    Dim parata_tua As Boolean = False
    Dim parata_enemy As Boolean = False
    Dim posizione As Integer
    Dim ms As Integer
    Dim i As Integer = 0
    Dim start As Integer 'indica quando deve iniziare l'attacco il templare

    Private Sub boss_templare_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        'attacco
        If e.KeyCode = Keys.A Then
            lblPicU.Text = "( )" & vbCrLf & " |-!---" & vbCrLf & "/ \"
            If parata_enemy = False Then
                vita_enemy -= attacco
                lblDannoTemplare.Text = attacco
                lblDannoTemplare.Visible = True
            Else
                lblDannoTemplare.Text = 0
                lblDannoTemplare.Visible = True
            End If
        End If

        'parata
        If e.KeyCode = Keys.D Then
            lblPicU.Text = "( )" & vbCrLf & " |-|" & vbCrLf & "/ \|"
            parata_tua = True
        End If

    End Sub

    Private Sub boss_templare_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp

        If e.KeyCode = Keys.A Or e.KeyCode = Keys.D Then
            lblPicU.Text = "( )" & vbCrLf & "-|-" & vbCrLf & "/ \"
        End If

    End Sub

    Private Sub boss_templare_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.KeyPreview = True 'serve per abilitare la ricezione dei tasti della tastiera (lol)

        posizione = lblPicTemp.Location.X
        MsgBox(posizione)

        lblDannoTemplare.Visible = False
        lblDannoTuo.Visible = False

        'per qualche oscuro motivo qui le classi non funziona, perchè non so un cazzo delle classi
        Randomize()

        start = CInt(Int(Rnd() * 800) + 200)

        lblTemplare.Text = nome_enemy & " " & vita_enemy & "/" & cap_enemy
        lblHp.Text = "Tu " & ep & "/" & ep_cap

        'lblPicTemp.Text = "( )" & vbCrLf & "---!-| " & vbCrLf & "/ \"

        lblPicU.Text = "( )" & vbCrLf & "-|-" & vbCrLf & "/ \"
        lblPicTemp.Text = "(†)" & vbCrLf & "-|-" & vbCrLf & "/ \"

        timer_scontro.Enabled = True

    End Sub

    Private Sub timer_scontro_Tick(sender As Object, e As EventArgs) Handles timer_scontro.Tick

        'questo timer serve per gestire l'attacco del templare

        ms += 1
        lblTemplare.Text = ms
        lblPicTemp.Text = "(†)" & vbCrLf & "|-| " & vbCrLf & "|/ \"

        If ms > start Then
            lblDannoTuo.Visible = False
            parata_enemy = False
            timer_scontro.Enabled = False
            timer_animazione.Enabled = True

        End If

    End Sub

    Private Sub timer_animazione_Tick(sender As Object, e As EventArgs) Handles timer_animazione.Tick

        i += 1

        If i = 1 Then
            lblPicTemp.Text = "(†)" & vbCrLf & "---!-| " & vbCrLf & "/ \"
        End If
        'lblPicTemp.Text = lblPicTemp.Text & " "
        lblPicTemp.Location = New Point(lblPicTemp.Location.X - 50, lblPicTemp.Location.Y)
        If i = CInt(Int(Rnd() * 6) + 1) Or i = 6 Then 'random che rende tutto più bastardo
            timer_animazione.Enabled = False
            If parata_tua = False Then 'visualizzazione della label dei danni e calcolo attacco
                ep -= attacco_enemy
                lblDannoTuo.Text = attacco_enemy
                lblDannoTuo.Visible = True
            Else
                lblDannoTuo.Text = 0
                lblDannoTuo.Visible = True
            End If
            ms = 0
            i = 0
            start = CInt(Int(Rnd() * 750) + 200)
            lblPicTemp.Location = New Point(posizione, lblPicTemp.Location.Y)
            timer_scontro.Enabled = True
        End If

    End Sub

End Class
Public Class home

    'cheat per nb
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        nb = nb + TextBox1.Text
        TextBox1.Text = "0"
        lblBestemmie.Text = "Hai " & nb & " bestemmie"

    End Sub

    'cheat per bps
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        bps = bps + TextBox1.Text
        TextBox1.Text = "0"
        lblBPS.Text = bps & " BPS"

    End Sub

    'fa restartare l'applicazione
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Application.Restart()

    End Sub

    'cuore del programma
    Private Sub sec_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sec.Tick

        nb = nb + bps
        update_bestemmie()
        'lblBestemmie.Text = "Hai " & nb & " bestemmie"
        'lblBPS.Text = bps & " BPS"
        update_bps()

        'If ep < ep_cap Then
        '    ep = ep + 1
        '    lblEP.Text = "EP: " & ep & "/" & ep_cap
        'End If

        If nb >= 100 Then
            cmdSave.Visible = True
        End If

        If nb >= 250 And shop = False Then
            grbInventario.Visible = True
            shop = "True"
            cmdNegozio.Visible = True
            lstLog.Items.Add("Il tuo continuo bestemmiare ti ha portato davanti uno strano emporio.")
        End If

    End Sub

    'clicca per aumentare le bestemmia
    Private Sub cmdBestemmia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBestemmia.Click

        nb = nb + 1
        lblBestemmie.Text = "Hai " & nb & " bestemmie"

        If nb >= 100 And autob = False Then
            chkBestemmia.Visible = True
            bps = 1
            autob = "True"
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkBestemmia.CheckedChanged

        If chkBestemmia.Checked = True Then
            sec.Enabled = True
            chkBestemmia.Enabled = False
            lblBPS.Visible = True
            lstLog.Visible = True
            lstLog.Items.Add("Hai imparato a bestemmiare continuamente, come abilità intrinseca.")
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        update_vita()
        'lblEP.Text = "EP: " & ep & "/" & ep_cap
        tooltip_roba()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

        'If ListBox1.SelectedItem = "Monile Imprecante(500 B)" Then
        'Label4.Text = "Artefatto infuso con una magia minore che aiuta il possessore nell'empio atto della bestemmia."
        'End If

    End Sub

    Private Sub cmdNegozio_Click(sender As Object, e As EventArgs) Handles cmdNegozio.Click

        negozio.Show()

    End Sub

    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        save()

    End Sub

    Private Sub cmdLoad_Click(sender As Object, e As EventArgs) Handles cmdLoad.Click

        carica()
        sec_Tick(Nothing, Nothing)

    End Sub

    Private Sub cmdAltare_Click(sender As Object, e As EventArgs) Handles cmdAltare.Click

        altare.Show()

    End Sub

    Private Sub cmdOperai_Click(sender As Object, e As EventArgs) Handles cmdOperai.Click

        If nb >= poperai And fabbrica = True Then
            noperai = noperai + 1
            nb = nb - poperai
            poperai = poperai * 2
            lblOperai.Text = "Operai: " & noperai
            tooltip1.SetToolTip(Me.cmdOperai, "(" & poperai & " B)")
            lblBestemmie.Text = "Hai " & nb & " bestemmie"
            bps = bps - prod_fabb
            prod_op = noperai * 10
            prod_fabb = prod_op * nmacchinari
            bps = bps + prod_fabb
            update_bps()
            update_bestemmie()
            lblProduzione.Text = "Produzione: " & prod_fabb & " BPS"
        End If


    End Sub

    Private Sub cmdMacchinari_Click(sender As Object, e As EventArgs) Handles cmdMacchinari.Click



        If nb >= pmacchinari And fabbrica = True Then
            nmacchinari = nmacchinari + 1
            nb = nb - pmacchinari
            pmacchinari = pmacchinari * 2
            lblMacchinari.Text = "Macchinari: " & nmacchinari
            tooltip1.SetToolTip(Me.cmdMacchinari, "(" & pmacchinari & " B)")
            lblBestemmie.Text = "Hai " & nb & " bestemmie"
            bps = bps - prod_fabb
            prod_fabb = prod_op * nmacchinari
            bps = bps + prod_fabb
            update_bps()
            update_bestemmie()
            lblProduzione.Text = "Produzione: " & prod_fabb & " BPS"

            If nmacchinari >= 1 Then
                cmdOperai.Enabled = True
            End If
        End If



    End Sub

    Private Sub cmdQuest_Click(sender As Object, e As EventArgs) Handles cmdQuest.Click

        quest.Show()

    End Sub

    Private Sub timer_cooldown_Tick(sender As Object, e As EventArgs) Handles timer_cooldown.Tick

        With quest
            .lblCooldown.Text = "Devi aspettare " & cd & " secondi " & vbCrLf & "per iniziare una nuova Quest"
            cd -= 1
            If cd = 0 Then
                cd = 59
                .cmdIniziaQ.Enabled = True
                timer_cooldown.Enabled = False
                .lblCooldown.Visible = False
            End If
        End With
    End Sub

    Private Sub cmdFontana_Click(sender As Object, e As EventArgs) Handles cmdFontana.Click

        fontanab.Show()

    End Sub
End Class


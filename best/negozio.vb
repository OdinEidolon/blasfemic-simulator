Public Class negozio

    Dim tooltip2 As New ToolTip()


    Private Sub cmdMonile_Click(sender As Object, e As EventArgs) Handles cmdMonile.Click

        If monile1 = False And nb >= 666 Then
            home.lstInventario.Items.Add("Monile Imprecante")
            nb = nb - 666
            bps = bps + 4
            update_bps()
            update_bestemmie()
            cmdMonile.Enabled = False
            monile1 = True
            cmdBretelle.Visible = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub negozio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        tooltip_roba()

        If monile1 = True Then
            cmdMonile.Enabled = False
        End If

        If bastone1 = True Then
            cmdBastone.Enabled = False
        End If
        'aggiungere le parti in cui bisogna rendere visibili i pulsanti a seconda degli acquisti precedenti

    End Sub

    Private Sub cmdBastone_Click(sender As Object, e As EventArgs) Handles cmdBastone.Click

        'da modificare per mettergli un attacco e chissàcchè
        If bastone1 = False And nb >= 1000 Then
            home.lstInventario.Items.Add("Bastone Inciso")
            nb = nb - 1000
            attacco = 3
            update_attacco()
            update_bestemmie()
            'home.lblAttacco.Text = "Attacco: " & attacco
            cmdBastone.Enabled = False
            bastone1 = True
            cmdPugnale.Visible = True
            home.cmdQuest.Visible = True
            quest1 = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdBretelle_Click(sender As Object, e As EventArgs) Handles cmdBretelle.Click

        If bretelle1 = False And nb >= 1750 Then
            home.lstInventario.Items.Add("Bretelle Corrotte")
            nb = nb - 1750
            update_bestemmie()
            bps = bps + 17
            update_bps()
            cmdBretelle.Enabled = False
            bretelle1 = True
            cmdBretelle.Visible = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdSalopette_Click(sender As Object, e As EventArgs) Handles cmdSalopette.Click

        If salopette1 = False And nb >= 3400 Then
            home.lstInventario.Items.Add("Salopette Rurale")
            nb = nb - 3400
            bps = bps + 37
            update_bps()
            ep_cap += 10
            ep = ep_cap
            update_bestemmie()
            update_vita()
            'home.lblEP.Text = ("EP: " & ep & "/" & ep_cap)
            cmdSalopette.Enabled = False
            salopette1 = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdPugnale_Click(sender As Object, e As EventArgs) Handles cmdPugnale.Click

        If pugnale1 = False And nb >= 2100 Then
            home.lstInventario.Items.Add("Pugnale Arrugginito")
            nb = nb - 2100
            attacco = 6
            update_attacco()
            update_bestemmie()
            'home.lblAttacco.Text = "Attacco: " & attacco
            cmdPugnale.Enabled = False
            pugnale1 = True
            cmdRoncola.Visible = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdTomo1_Click(sender As Object, e As EventArgs) Handles cmdTomo1.Click

        If tomo1 = False And nb >= 6666 Then
            home.lstInventario.Items.Add("Salopette Rurale")
            nb = nb - 6666
            update_bestemmie()
            bps = bps + 66
            update_bps()
            cmdTomo1.Enabled = False
            tomo1 = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdRoncola_Click(sender As Object, e As EventArgs) Handles cmdRoncola.Click

        If roncola1 = False And nb >= 5000 Then
            home.lstInventario.Items.Add("Roncola della Ruralità")
            nb = nb - 5000
            attacco = 15
            update_bestemmie()
            update_attacco()
            'home.lblAttacco.Text = "Attacco: " & attacco
            cmdRoncola.Enabled = False
            roncola1 = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdStivali1_Click_1(sender As Object, e As EventArgs) Handles cmdStivali1.Click

        If stivali1 = False And nb >= 6300 And salopette1 = True Then
            home.lstInventario.Items.Add("Stivali della Non-Fede")
            nb = nb - 6300
            ep_cap += 50
            ep = ep_cap
            update_bestemmie()
            update_vita()
            'home.lblEP.Text = ("EP: " & ep & "/" & ep_cap)
            cmdStivali1.Enabled = False
            stivali1 = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdForcone1_Click(sender As Object, e As EventArgs) Handles cmdForcone1.Click

        If forcone1 = False And nb >= 10550 Then
            home.lstInventario.Items.Add("Forcone Infernale")
            nb = nb - 10550
            attacco = 37
            update_bestemmie()
            update_attacco()
            'home.lblAttacco.Text = "Attacco: " & attacco
            cmdForcone1.Enabled = False
            forcone1 = True
        Else
            MsgBox("Non hai abbastanza bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdArmor1_Click(sender As Object, e As EventArgs) Handles cmdArmor1.Click

        If armor1 = False And nb >= 12570 Then
            home.lstInventario.Items.Add("Armatura di Ferro Maledetto")
            nb -= 12570
            ep_cap += 150
            ep = ep_cap
            update_vita()
            update_bestemmie()
            cmdArmor1.Enabled = False
            armor1 = True
        Else
            MsgBox("Non hai abbastanza Bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdTrincia1_Click(sender As Object, e As EventArgs) Handles cmdTrincia1.Click

        If trincia1 = False And nb >= 17560 Then
            home.lstInventario.Items.Add("Trinciapreti")
            nb -= 17560
            attacco = 89
            update_bestemmie()
            update_attacco()
            cmdTrincia1.Enabled = False
            trincia1 = True
        Else
            MsgBox("Non hai abbastanza Bestemmie.", vbExclamation)
        End If

    End Sub

    Private Sub cmdScudo1_Click(sender As Object, e As EventArgs) Handles cmdScudo1.Click

        If scudo1 = False And nb >= 21700 Then
            home.lstInventario.Items.Add("Scudo dell'Eresia")
            nb -= 21700
            ep_cap += 310
            ep = ep_cap
            update_bestemmie()
            update_vita()
            cmdScudo1.Enabled = False
            scudo1 = True
        Else
            MsgBox("Non hai abbastanza Bestemmie", vbExclamation)
        End If

    End Sub
End Class
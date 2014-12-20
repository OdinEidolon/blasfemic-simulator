Public Class quest

    Dim i As Integer


    'variabili relative agli scontri
    Dim playerTurn As Boolean = True
    Dim enemyTurn As Boolean = False


    Private Sub quest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblLootSpeciali.Visible = False

        If cd <> 59 Then
            lblCooldown.Visible = True
            cmdIniziaQ.Enabled = False
        End If

        With cmboxQuest.Items
            .Add("Chiesa di Paese")
            .Add("La Processione")
            .Add("Il Battesimo")
            .Add("La Cattedrale")
            .Add("Medjugorje")
            .Add("Festa del Perdono ad Assisi")
            .Add("Fabbrica delle Bibbie")
            .Add("Angelus")
        End With
        'probabilmente si aggiungerà anche la selezione automatica della prima quest

    End Sub

    Private Sub cmboxQuest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboxQuest.SelectedIndexChanged

        Select Case cmboxQuest.SelectedItem
            Case "Chiesa di Paese"
                lblDescQuest.Text = "Descrizione della chiesa di Paese"
            Case "La Processione"
                lblDescQuest.Text = "Descrizione della processione"
            Case "Il Battesimo"
                lblDescQuest.Text = "Descrzione del battesimo"
            Case "La Cattedrale"
                lblDescQuest.Text = "Descrizione cattedrale"
            Case "Medjugorje"
                lblDescQuest.Text = "Descrzione Medjugorje"
            Case "Festa del Perdono ad Assisi"
                lblDescQuest.Text = "Descrizione assisi"
            Case "Fabbrica delle Bibbie"
                lblDescQuest.Text = "Descrizione fabbrica delle bibbie"
            Case "Angelus"
                lblDescQuest.Text = "Descrizione angelus"
        End Select

    End Sub

    Private Sub cmdIniziaQ_Click(sender As Object, e As EventArgs) Handles cmdIniziaQ.Click

        Dim enemyList As New List(Of nemici)

        lblLoot.Text = "Hai tirato 0 Bestemmie"

        cmboxQuest.Enabled = False
        cmdIniziaQ.Enabled = False

        lstScontro.Items.Clear()
        Select Case cmboxQuest.SelectedItem

            Case "Chiesa di Paese"
                For Me.i = 0 To 4
                    enemyList.Add(New nemici("Panca di Legno", 0, 10, 10, 1, False, 0))
                Next
                enemyList.Add(New nemici("Crocifisso di Legno", 0, 20, 20, 2, False, 0))

                scontro(enemyList)
                If vittoria = True Then
                    quest1 = True
                End If

            Case "La Processione"
                For Me.i = 0 To 4
                    enemyList.Add(New nemici("Fedele", 1, 12, 12, 2, False, 0))
                Next

                enemyList.Add(New nemici("Chirichetto", 2, 12, 12, 4, False, 0))
                enemyList.Add(New nemici("Chirichetto", 2, 12, 12, 4, False, 0))

                enemyList.Add(New nemici("Prete", 3, 24, 24, 6, False, 0))

                enemyList.Add(New nemici("Statua della Madonna", 0, 50, 50, 10, False, 0))

                scontro(enemyList)
                If vittoria = True Then
                    quest2 = True
                End If

            Case "Il Battesimo"
                For Me.i = 0 To 5
                    enemyList.Add(New nemici("Fedele", 1, 12, 12, 2, False, 0))
                    enemyList.Add(New nemici("Panca di Legno", 0, 10, 10, 1, False, 0))
                Next

                enemyList.Add(New nemici("Madrina", 2, 24, 24, 3, False, 0))
                enemyList.Add(New nemici("Padrino", 4, 24, 24, 3, False, 0))

                enemyList.Add(New nemici("Madre", 3, 38, 38, 4, False, 0))
                enemyList.Add(New nemici("Padre", 5, 38, 38, 4, False, 0))

                enemyList.Add(New nemici("Catecumeno", 0, 1, 1, 1, False, 0))
                enemyList.Add(New nemici("Prete", 3, 33, 33, 6, False, 0))

                scontro(enemyList)
                If vittoria = True Then
                    quest3 = True
                    If fontana = False Then
                        fontana = True
                        tier = 1
                        lstScontro.Items.Add("Hai sbloccato la Fontana!")
                    End If
                End If

            Case "La Cattedrale"
                For Me.i = 0 To 15
                    enemyList.Add(New nemici("Fedele", 1, 45, 45, 6, False, 0))
                    enemyList.Add(New nemici("Panca di Legno", 0, 115, 115, 6, False, 0))
                Next

                enemyList.Add(New nemici("Parroco", 5, 60, 60, 10, False, 0))
                enemyList.Add(New nemici("Parroco", 5, 60, 60, 10, False, 0))

                enemyList.Add(New nemici("Coro Gregoriano", 1, 500, 500, 15, False, 0))

                enemyList.Add(New nemici("Vescovo", 8, 191, 191, 30, True, 90))

                scontro(enemyList)

                If vittoria = True Then
                    quest4 = True
                    If frammento1 = True Then
                        lblLootSpeciali.Visible = True
                        lblLootSpeciali.Text = "Hai trovato un frammento di una chiave"
                        home.lstInventario.Items.Add("Frammento di una chiave")
                    End If
                End If

            Case "Medjugorje"
                For Me.i = 0 To 19
                    enemyList.Add(New nemici("Pellegrino", 2, 45, 45, 6, False, 0))
                Next '40

                For Me.i = 0 To 9
                    enemyList.Add(New nemici("Storpio", 1, 20, 20, 10, False, 0))
                Next

                For Me.i = 0 To 3
                    enemyList.Add(New nemici("Suora", 5, 93, 93, 12, False, 0))
                Next '30

                enemyList.Add(New nemici("Prete", 5, 93, 93, 12, False, 0)) '10

                enemyList.Add(New nemici("Apparizione della Madonna", 10, 500, 500, 37, True, 90))

                scontro(enemyList)
                If vittoria = True Then
                    quest5 = True
                    If frammento2 = True Then
                        lblLootSpeciali.Visible = True
                        lblLootSpeciali.Text = "Hai trovato un frammento di una chiave"
                        home.lstInventario.Items.Add("Frammento di una chiave")
                    End If
                End If

            Case "Festa del Perdono ad Assisi"
                For Me.i = 0 To 19
                    enemyList.Add(New nemici("Pellegrino", 2, 45, 45, 6, False, 0))
                Next

                For Me.i = 0 To 1
                    enemyList.Add(New nemici("Suora", 6, 93, 93, 12, False, 0))
                    enemyList.Add(New nemici("Prete", 6, 93, 93, 12, False, 0))
                Next '24

                enemyList.Add(New nemici("Suora", 6, 93, 93, 12, False, 0))
                enemyList.Add(New nemici("Suora", 6, 93, 93, 12, False, 0))
                enemyList.Add(New nemici("Prete", 6, 93, 93, 12, False, 0))
                enemyList.Add(New nemici("Suora", 6, 93, 93, 12, False, 0))
                enemyList.Add(New nemici("Prete", 6, 93, 93, 12, False, 0))
                enemyList.Add(New nemici("Prete", 6, 93, 93, 12, False, 0))
                '36

                enemyList.Add(New nemici("Lupo di Gubbio", 10, 547, 547, 20, True, 95)) '60
                enemyList.Add(New nemici("Apparizione di San Francesco", 12, 889, 889, 30, False, 0))

                scontro(enemyList)

                If vittoria = True Then
                    quest6 = True
                    If frammento3 = True Then
                        lblLootSpeciali.Visible = True
                        lblLootSpeciali.Text = "Hai trovato un frammento di una chiave"
                        home.lstInventario.Items.Add("Frammento di una chiave")
                    End If
                End If

            Case "Fabbrica delle Bibbie"
                For Me.i = 0 To 9
                    enemyList.Add(New nemici("Operaio", 2, 100, 100, 8, False, 0))
                Next '20

                For Me.i = 0 To 4
                    enemyList.Add(New nemici("Prete", 6, 110, 110, 10, False, 0))
                Next '24

                For Me.i = 0 To 7
                    enemyList.Add(New nemici("Bibbia Animata", 5, 201, 201, 14, False, 0))
                Next '70

                enemyList.Add(New nemici("Prete", 6, 110, 110, 10, False, 0)) '6

                For Me.i = 0 To 4
                    enemyList.Add(New nemici("Bibbia Animata", 5, 201, 201, 14, False, 0))
                Next '40

                For Me.i = 0 To 3
                    enemyList.Add(New nemici("Prete", 6, 110, 110, 10, False, 0))
                Next

                enemyList.Add(New nemici("Cardinale", 14, 1413, 1413, 20, True, 90))

                scontro(enemyList)

                If vittoria = True Then
                    quest7 = True
                    If mapa = True Then
                        lblLootSpeciali.Visible = True
                        lblLootSpeciali.Text = "Hai trovato una mappa"
                        home.lstInventario.Items.Add("Mappa")
                    End If
                End If

        End Select

        enemyList.Clear()
        home.timer_cooldown.Enabled = True
        lblCooldown.Visible = True
        cmboxQuest.Enabled = True
        ep = ep_cap
        update_vita()
        'home.lblEP.Text = "EP: " & ep & "/" & ep_cap

    End Sub

End Class
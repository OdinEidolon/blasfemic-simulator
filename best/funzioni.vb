Public Module variabili_globali

    Public tooltip1 As New ToolTip()

    'variabili base
    Public nb As Integer = 0 'numero bestemmie
    Public bps As Integer = 0 'bestemmie per secondo
    Public ep As Integer = 20 'vita attuale
    Public ep_cap As Integer = 20 'vita massima EVIL POINT!!!
    'Public infuse As Integer = 0 'bestemmie infuse nell'altare
    Public attacco As Integer = 0 'attacco giocatore
    Public cd As Integer = 59 'cooldown fra le quest

    'sbloccabili
    Public autob As Boolean = False 'autobestemmie
    Public shop As Boolean = False 'shop del player
    Public fabbrica As Boolean = True
    Public fontana As Boolean = True
    Public mapa As Boolean = True

    'frammenti della chiave, servirà per sbloccare il sotterraneo della fontana
    Public frammento1 As Boolean = False
    Public frammento2 As Boolean = False
    Public frammento3 As Boolean = False

    'quest
    Public vittoria As Boolean = False
    Public quest1 As Boolean = False 'chiesa di paese
    Public quest2 As Boolean = False 'processione
    Public quest3 As Boolean = False 'battesimo
    Public quest4 As Boolean = False 'cattedrale
    Public quest5 As Boolean = False 'medigiourne
    Public quest6 As Boolean = False 'lourdes
    Public quest7 As Boolean = False 'fabbrica delle bibbie
    Public quest8 As Boolean = False 'angelus

    'indossabili
    Public monile1 As Boolean = False 'monile imprecante
    Public bretelle1 As Boolean = False 'bretelle corrotte
    Public salopette1 As Boolean = False 'salopette rurale
    Public stivali1 As Boolean = False 'stivali della non fede

    'armature
    Public armor1 As Boolean = False 'armatura di ferro maledetta
    Public scudo1 As Boolean = False 'scudo dell'eresia

    'armi
    Public bastone1 As Boolean = False 'bastone inciso
    Public pugnale1 As Boolean = False 'pugnale arrugginito
    Public roncola1 As Boolean = False 'roncola della ruralitòà
    Public forcone1 As Boolean = False 'forcone infernale
    Public trincia1 As Boolean = False 'IL TRINCIAPRETI

    'libri
    Public tomo1 As Boolean = False

    'fabbrica
    Public noperai As Integer = 0
    Public poperai As Integer = 10
    Public nmacchinari As Integer = 0
    Public pmacchinari As Integer = 100
    Public prod_op As Integer
    Public prod_macc As Integer
    Public prod_fabb As Integer

    'fontana
    Public tier As Integer = 0

    'labirino
    Public posizione As Integer
    'Public movimento As Boolean

    'boss del labirinto123e
    Public templare As Integer = 0

End Module


Module funzioni

    Public Class nemici
        Public n_name As String
        Public n_attacco As Integer
        Public n_vita As Integer
        Public n_cap As Integer
        Public n_loot As Integer
        Public n_dropSpec As Boolean
        Public n_probDrop As Integer

        Public Sub New(name As String, attacco As Integer, vita As Integer, cap As Integer, loot As Integer, dropSpec As Boolean, probDrop As Integer)
            Me.n_name = name
            Me.n_attacco = attacco
            Me.n_vita = vita
            Me.n_cap = cap
            Me.n_loot = loot
            Me.n_dropSpec = dropSpec
            Me.n_probDrop = probDrop
        End Sub

        'non ho capito cosa sto scrivendo ma va tutto bene
        'http://www.dotnetheaven.com/article/creating-a-list-of-objects-using-vb.net
        Public Property Name() As String
            Get
                Return n_name
            End Get
            Set(value As String)
                n_name = value
            End Set
        End Property

        'segui le istruzioni e andrà tutto bene
        Public Property Attacco() As Integer
            Get
                Return n_attacco
            End Get
            Set(value As Integer)
                n_attacco = value
            End Set
        End Property

        'questo è il diaulo
        Public Property Vita() As Integer
            Get
                Return n_vita
            End Get
            Set(value As Integer)
                n_vita = value
            End Set
        End Property

        Public Property Cap() As Integer
            Get
                Return n_cap
            End Get
            Set(value As Integer)
                n_cap = value
            End Set
        End Property

        Public Property Loot() As Integer
            Get
                Return n_loot
            End Get
            Set(value As Integer)
                n_cap = value
            End Set
        End Property

        Public Property dropSpec() As Boolean
            Get
                Return n_dropSpec
            End Get
            Set(value As Boolean)
                n_dropSpec = value
            End Set
        End Property

        Public Property probDrop() As Integer
            Get
                Return n_probDrop
            End Get
            Set(value As Integer)
                n_probDrop = value
            End Set
        End Property

    End Class

    Sub Delay(ByVal dblSecs As Double)

        Const OneSec As Double = 1.0# / (1440.0# * 60.0#)
        Dim dblWaitTil As Date
        Now.AddSeconds(OneSec)
        dblWaitTil = Now.AddSeconds(OneSec).AddSeconds(dblSecs)
        Do Until Now > dblWaitTil
            Application.DoEvents() ' Allow windows messages to be processed

        Loop

    End Sub

    Public Sub scontro(ByVal enemyList As List(Of nemici))

        'questo algoritmo è molto bello
        Dim i As Integer
        Dim loot As Integer = 0
        Dim playerTurn As Boolean = True

        Randomize()

        i = 0
        With quest
            Do While i < enemyList.Count

                If ep <= 0 Then
                    MsgBox("Hai perso, bravo coglione.")
                    Exit Do
                End If

                If playerTurn = True Then 'turno del player
                    enemyList(i).Vita = enemyList(i).Vita - attacco
                    If enemyList(i).Vita < 0 Then
                        enemyList(i).Vita = 0
                    End If

                    .lstScontro.Items.Add("Tu (" & ep & "/" & ep_cap & ") attacchi " & enemyList(i).Name & " (" & enemyList(i).Vita & "/" & enemyList(i).Cap & ") con " & attacco & " danni")
                    .lstScontro.TopIndex = .lstScontro.Items.Count - 1
                    playerTurn = False
                Else 'turno del nemico
                    ep = ep - enemyList(i).Attacco
                    If ep < 0 Then
                        ep = 0
                    End If
                    .lstScontro.Items.Add(enemyList(i).Name & " (" & enemyList(i).Vita & "/" & enemyList(i).Cap & ") ti attacca " & "(" & ep & "/" & ep_cap & ") per " & enemyList(i).Attacco & " danni")
                    update_vita()
                    'home.lblEP.Text = "EP: " & ep & "/" & ep_cap
                    .lstScontro.TopIndex = .lstScontro.Items.Count - 1
                    playerTurn = True
                End If

                If enemyList(i).Vita <= 0 Then 'se il nemico viene ucciso
                    If enemyList(i).dropSpec = True Then
                        Dim prob_spec As Integer = CInt(Int(Rnd() * 101))
                        If prob_spec >= enemyList(i).probDrop Then
                            rare_loot(enemyList(i))
                        End If
                    End If
                    loot += CInt(Int((Rnd() * 11) * enemyList(i).Loot))
                    .lblLoot.Text = "Hai tirato " & loot & " Bestemmie"
                    playerTurn = True
                    .lstScontro.Items.Add(" ")
                    i += 1
                End If
                If i = enemyList.Count Then
                    MsgBox("Hai vinto, bravo coglione.")
                    vittoria = True
                    nb += loot
                    quest1 = True
                    Exit Do 'esci quando sono finiti i nemici
                End If
                Delay(1)
            Loop
        End With

    End Sub

    Public Sub rare_loot(enemy As nemici)

        'gestisce i drop rari
        Randomize()

        Select Case quest.cmboxQuest.SelectedItem

            Case "La Cattedrale"
                If frammento1 = False And CInt(Int(Rnd() * 101)) >= enemy.probDrop Then
                    frammento1 = True
                End If

            Case "Medjugorje"
                If frammento2 = False And CInt(Int(Rnd() * 101)) >= enemy.probDrop Then
                    frammento2 = True
                End If

            Case "Festa del Perdono ad Assisi"
                If frammento3 = False And CInt(Int(Rnd() * 101)) >= enemy.probDrop Then
                    frammento3 = True
                End If

            Case "Fabbrica delle Bibbie"
                If mapa = False And CInt(Int(Rnd() * 101)) >= enemy.probDrop Then
                    mapa = True
                End If
        End Select

    End Sub

    Public Sub save()

        Dim path As String = My.Application.Info.DirectoryPath
        Dim filename As String = "sav"
        Dim objwriter As New System.IO.StreamWriter(filename, True)
        Dim lista_roba As New List(Of String)
        Dim i As Integer

        'lista contenuti da salvare
        'da aggiornare ogni volta
        With lista_roba
            .Add(nb)
            .Add(bps)
            .Add(autob)
            .Add(shop)
            .Add(monile1)
            .Add(bastone1)
        End With

        For i = 0 To lista_roba.Count - 1
            objwriter.WriteLine(lista_roba(i))
        Next

        objwriter.Close()

    End Sub

    Public Sub carica()

        Dim filename As String = "sav"
        Dim objreader As New System.IO.StreamReader(filename)
        Dim lista_roba As New List(Of String)
        Dim line As String = Nothing
        Dim lines As Integer = 0

        While (objreader.Peek() <> -1)
            line = objreader.ReadLine()
            lista_roba.Add(line)
            lines = lines + 1
        End While

        'lista contenuti da caricare
        'da aggiornare ogni volta, come per il save
        nb = lista_roba(0)
        bps = lista_roba(1)
        autob = lista_roba(2)
        shop = lista_roba(3)
        monile1 = lista_roba(4)
        bastone1 = lista_roba(5)

        If autob = True Then
            home.chkBestemmia.Visible = True
            home.chkBestemmia.Checked = True
        End If

        If shop = True Then
            home.cmdNegozio.Visible = True
            home.grbInventario.Visible = True
        End If

    End Sub

    Public Sub tooltip_roba()

        tooltip1.AutoPopDelay = 5000
        tooltip1.InitialDelay = 1000
        tooltip1.ReshowDelay = 500
        tooltip1.ShowAlways = False

        'tooltip home
        With home
            tooltip1.SetToolTip(.cmdOperai, "(" & poperai & " B)")
            tooltip1.SetToolTip(.cmdMacchinari, "(" & pmacchinari & " B)")
            tooltip1.SetToolTip(.lblOperai, "Ogni operaio aumenta la produzione della fabbrica.")
            tooltip1.SetToolTip(.lblMacchinari, "Ogni macchinario moltiplica la produzione degli operai.")
            tooltip1.SetToolTip(.lblEP, "Evil Points")
        End With

        'tooltip mercante
        With negozio
            tooltip1.SetToolTip(.cmdMonile, "Artefatto infuso con una magia minore che aiuta il possessore nell'empio atto della Bestemmia.")
            tooltip1.SetToolTip(.cmdBastone, "Semplice ramo di un albero dove qualcuno ha inciso una Bestemmia.")
            tooltip1.SetToolTip(.cmdBretelle, "Improponibili bretelle indossate solo dai veri bestemmiatori.")
            tooltip1.SetToolTip(.cmdSalopette, "Divisa da Bestemmia che un tempo fu posseduta dall'empio Maestro Nonno Fiorucci.")
            tooltip1.SetToolTip(.cmdPugnale, "Il malefico potere di quest'arma deriva dalle Bestemmie urlate da chi viene pugnalato.")
        End With

        'tooltip quest

    End Sub

    Public Sub update_attacco()
        home.lblAttacco.Text = "Attacco: " & attacco
    End Sub

    Public Sub update_bestemmie()
        home.lblBestemmie.Text = "Hai " & nb & " Bestemmie"
    End Sub

    Public Sub update_vita()
        home.lblEP.Text = ("EP: " & ep & "/" & ep_cap)
    End Sub

    Public Sub update_bps()
        home.lblBPS.Text = bps & " BPS"
    End Sub

    'funzione che regola le direzioni in cui navigare nel labirinto
    'NORD
    'SUD
    'EST
    'OVEST
    'L'ORDINE E' SEMPRE QUESTO
    Public Sub direzione(dir As String)

        With labirinto
            Select Case dir
                Case "1111"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare a nord, a sud, ad est o ad ovest."
                Case "1110"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare a nord, a sud o ad est."
                Case "1101"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare a nord, a sud o ad ovest."
                Case "1100"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare a nord o a sud."
                Case "1011"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare a nord, ad est o ad ovest."
                Case "1010"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare a nord o ad est."
                Case "1001"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare a nord o ad ovest."
                Case "1000"
                    .cmdNord.Enabled = True
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare a nord."
                Case "0111"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare a sud, ad est o ad ovest."
                Case "0110"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare a sud o ad est."
                Case "0101"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare a sud o ad ovest."
                Case "0100"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = True
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare a sud."
                Case "0011"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare ad est o ad ovest."
                Case "0010"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = True
                    .cmdOvest.Enabled = False
                    .lblLab.Text = "Puoi andare ad est."
                Case "0001"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = True
                    .lblLab.Text = "Puoi andare ad ovest."
            End Select
        End With

    End Sub
    'labirinto
    Public Sub labir()

        With labirinto
            Select Case posizione
                Case 0
                    direzione("1010")
                    'aggiungere boss
                Case 1
                    direzione("0001")
                    'aggiungere loot vuoto
                Case 2
                    direzione("1010")
                Case 3
                    direzione("0011")
                    .lblLab.Text = "Una volta scese le lunghe e buie scale che si fanno strada sottoterra, un imponente cancello sbarrato ti si para davanti." & vbCrLf & "Dopo un'attenta ricerca trovi il meccanismo di apertura, lo attivi e odi un celestiale rumore come fosse un canto di angeli." & vbCrLf & "Dopo essere entrato ti rendi conto che la cripta, in realtà, è un labirinto." & vbCrLf & .lblLab.Text
                Case 4
                    direzione("0011")
                    .lblLab.Text = "Alla tua destra e alla tua sinistra ci sono due statue di pietra raffiguranti due angeli che reggono un libro" & vbCrLf & .lblLab.Text
                Case 5
                    direzione("1011")
                Case 6
                    direzione("0001")
                    .lblLab.Text = "Sul pavimento trovi una grata di ferro dalla quale senti scorrere dell'acqua (probabilmente santa)." & vbCrLf & .lblLab.Text
                Case 7
                    direzione("1000")
                    .lblLab.Text = "Ha tutta l'aria di essere un vicolo cieco." & vbCrLf & .lblLab.Text
                Case 8
                    'non si può andare qui, c'è un muro
                Case 9
                    direzione("1000")
                    .lblLab.Text = "Sembra un vicolo cieco." & vbCrLf & .lblLab.Text
                Case 10
                    direzione("1100")
                    'aggiungere eccezione per scontro
                    .lblLab.Text = "Da qui è udibile una cantilena di quella che sembra una preghiera provenire dalla luce accecante davanti a te." & vbCrLf & .lblLab.Text
                Case 11
                    direzione("0010")
                    .lblLab.Text = "Non c'è niente qui." & vbCrLf & .lblLab.Text
                Case 12
                    direzione("1101")
                Case 13
                    'muro
                Case 14
                    'muro
                Case 15
                    direzione("1100")
                Case 16
                    direzione("1010")
                Case 17
                    direzione("0111")
                    .lblLab.Text = "Al centro della stanza c'è un'acquasantiera di marmo segnata dal tempo." & vbCrLf & .lblLab.Text
                Case 18
                    direzione("0011")
                Case 19
                    direzione("0101")
                Case 20
                    direzione("1110")
                Case 21
                    direzione("1001")
                    .lblLab.Text = "Sul soffitto è presente un affresco completamente sfigurato dalla muffa e dal tempo." & vbCrLf & .lblLab.Text
                Case 22
                    direzione("0110")
                    .lblLab.Text = "Sul muro a nord vedi un affresco raffigurante un caotico scenario di morte e distruzione, dominato dai Quattro Cavalieri dell'Apocalisse." & vbCrLf & .lblLab.Text
                Case 23
                    direzione("0011")
                Case 24
                    direzione("1011")
                    .lblLab.Text = "A terra trovi due vecchi e polverosi scheletri semidistrutti dal tempo." & vbCrLf & .lblLab.Text
                Case 25
                    direzione("0111")
                    .lblLab.Text = "C'è una maggiore presenza di muschio sulle pareti, rispetto alle altre stanze." & vbCrLf & .lblLab.Text
                Case 26
                    direzione("1101")
                Case 27
                    direzione("1010")
                    .lblLab.Text = "Il terreno qui è molto umido e soffice." & vbCrLf & .lblLab.Text
                Case 28
                    direzione("1010")
                Case 29
                    direzione("1001")
                Case 30
                    'muro
                Case 31
                    direzione("1110")
                    .lblLab.Text = "Senti una corrente d'aria provenire da nord." & vbCrLf & .lblLab.Text
                Case 32
                    direzione("0011")
                Case 33
                    direzione("0011")
                Case 34
                    direzione("1101")
                    .lblLab.Text = "Diversi crocifissi di legno marcio giacciono a terra accanto al muro." & vbCrLf & .lblLab.Text
                Case 35
                    direzione("1000")
                    .lblLab.Text = "Vedi numerose fenditure nel soffitto dalle quali scendosi copiosi rivoli d'acqua." & vbCrLf & .lblLab.Text
                Case 36
                    direzione("1100")
                    .lblLab.Text = "Ai lati della stanza ci sono due statue di pietra che brandiscono due spade che puntano verso l'alto. La testa di uno è crollata a terra." & vbCrLf & .lblLab.Text
                Case 37
                    direzione("0100")
                    .lblLab.Text = "Una volta entrato in questa stanza noti un burrone che si estende davanti a te. Non è consigliabile proseguire oltre. Anche se dall'altra parte riesci a vedere uno scettro d'oro con un rubino sulla cima che sicuramente vale molti denari." & vbCrLf & .lblLab.Text
                Case 38
                    direzione("1100")
                    .lblLab.Text = "Sembra che un tempo lungo queste pareti c'erano due statue. Ora i detriti giacciono a terra." & vbCrLf & .lblLab.Text
                Case 39
                    direzione("1100")
                Case 40
                    direzione("0010")
                    .lblLab.Text = "Sulla parente davanti a te trovi una fessura dalla quale esce dell'aria fresca. La fessura però è troppo profonda per riuscire a vedere dall'altro lato." & vbCrLf & .lblLab.Text
                Case 41
                    direzione("0101")
                    .lblLab.Text = "Senti una corrente d'aria provenire da ovest." & vbCrLf & .lblLab.Text
                Case 42
                    direzione("1000")
                    .lblLab.Text = "C'è uno scheletro appoggiato alla parete; sopra di esso c'è una scritta sbiadita fatta col sangue. '42'" & vbCrLf & .lblLab.Text
                Case 43
                    direzione("1000")
                    .lblLab.Text = "Sulla parete meridionale noti un bassorilievo rovinato di uno strano animale con dieci corna e sette teste." & vbCrLf & .lblLab.Text
                Case 44
                    direzione("0110")
                    .lblLab.Text = "Non noti nulla di insolito." & vbCrLf & .lblLab.Text
                Case 45
                    direzione("0111")
                    .lblLab.Text = "Si sente un rumore d'acqua che sgorga." & vbCrLf & .lblLab.Text
                Case 46
                    direzione("0111")
                Case 47
                    direzione("1011")
                    'aggiungere medaglione per aprire la porta
                    .lblLab.Text = "Sulla parete nord noti una fessura verticale intagliata nella pietra. Al centro di essa c'è inciso un cerchio con varie rifiniture all'interno." & vbCrLf & .lblLab.Text
                Case 48
                    direzione("0101")
                    .lblLab.Text = "Il soffitto qui è parzialmente crollato." & vbCrLf & .lblLab.Text
                Case 49
                    direzione("1100")
                    .lblLab.Text = "Molti detriti ricoprono il pavimento, il passaggio è molto difficile." & vbCrLf & .lblLab.Text
                Case 50
                    direzione("0010")
                    .lblLab.Text = "Strada sbagliata, a quanto pare." & vbCrLf & .lblLab.Text
                Case 51
                    direzione("1011")
                Case 52
                    direzione("0101")
                    .lblLab.Text = "Senti una voce che dice: Beati i puri di cuore perchè vedranno Dio." & vbCrLf & .lblLab.Text
                Case 53
                    direzione("0110")
                Case 54
                    direzione("0011")
                    .lblLab.Text = "Trovi un cadavere non del tutto decomposto con una spada arrugginita piantata nel petto." & vbCrLf & .lblLab.Text
                Case 55
                    direzione("1001")
                    .lblLab.Text = "Lungo la parete orientale si legge un'incisione: Temete Dio e dategli gloria, perché è giunta l'ora del suo giudizio." & vbCrLf & .lblLab.Text
                Case 56
                    'muro
                Case 57
                    direzione("1100")
                    .lblLab.Text = "Vedi una porta aperta verso sud" & vbCrLf & .lblLab.Text
                Case 58
                    direzione("1010")
                Case 59
                    direzione("0101")
                    .lblLab.Text = "Dal soffitto si estendono delle antiche e nodose radici che arrivano fino al suolo. Per passare dovrai farti largo tra esse." & vbCrLf & .lblLab.Text
                Case 60
                    direzione("1000")
                    .lblLab.Text = "E' molto bello qui!" & vbCrLf & .lblLab.Text
                Case 61
                    direzione("0110")
                Case 62
                    direzione("1001")
                    .lblLab.Text = "Questa stanza è insolitamente illuminata. Non riesci a capire qual è la fonte di luce." & vbCrLf & .lblLab.Text
                Case 63
                    direzione("0010")
                    .lblLab.Text = "Puoi solo tornare indietro." & vbCrLf & .lblLab.Text
                Case 64
                    direzione("1011")
                Case 65
                    direzione("0111")
                Case 66
                    direzione("1011")
                Case 67
                    direzione("0101")
                    .lblLab.Text = "Mucchi di cadaveri di roditori ti circondano." & vbCrLf & .lblLab.Text
                Case 68
                    direzione("0100")
                    'c'è il boss belluino che ti droppa il fucile belluino
                Case 69
                    direzione("1000")
                    .lblLab.Text = "La libreria prosegue anche in questa stanza fra ragnatele e polvere." & vbCrLf & .lblLab.Text
                Case 70
                    direzione("1110")
                Case 71
                    direzione("0011")
                Case 72
                    direzione("1111")
                    .lblLab.Text = "Ogni direzione è aperta." & vbCrLf & .lblLab.Text
                Case 73
                    direzione("0011")
                Case 74
                    direzione("1101")
                    .lblLab.Text = "Non noti nulla di particolare rispetto le altre stanze." & vbCrLf & .lblLab.Text
                Case 75
                    'muro
                Case 76
                    direzione("0110")
                    .lblLab.Text = "Al centro della stanza c'è un pozzo di cui non riesci a vedere il fondo." & vbCrLf & .lblLab.Text
                Case 77
                    direzione("1011")
                Case 78
                    direzione("0011")
                    .lblLab.Text = "Verso est c'è una pesante grata di ferro battuto, chiusa con un grosso lucchetto." & vbCrLf & .lblLab.Text
                    'aggiungere roba per aprire la grata di stocazzo
                Case 79
                    direzione("1101")
                    .lblLab.Text = "Lungo le pareti ci sono delle librerie, piene di tomi consumati dal tempo." & vbCrLf & .lblLab.Text
                Case 80
                    direzione("1110")
                    .lblLab.Text = "Inizi a intravedere la luce del sole." & vbCrLf & .lblLab.Text
                Case 81
                    direzione("1001")
                    '???
                Case 82
                    direzione("1100")
                Case 83
                    direzione("1010")
                Case 84
                    direzione("0101")
                Case 85
                    'muro
                Case 86
                    direzione("1010")
                    .lblLab.Text = "Sulla parete meridionale ci sono degli scaffali con degli strumenti strani, il cui uso ti è sconosciuto. Ti avvicini e scopri che sono sporchi di sangue secco." & vbCrLf & .lblLab.Text
                Case 87
                    direzione("0101")
                Case 88
                    direzione("1000")
                    .lblLab.Text = "Al centro della stanza c'è la tomba di San Giovanni." & vbCrLf & .lblLab.Text
                Case 89
                    direzione("1100")
                    'boss cattivone (probabilmente l'apparizione di san giovanni)
                Case 90
                    direzione("0100")
                    .lblLab.Text = "Ti accorgi all'ultimo momento che c'è un buco profondo davanti a te. Devi tornare indietro." & vbCrLf & .lblLab.Text
                Case 91
                    direzione("0100")
                    .lblLab.Text = "Noti subito un'enorme portale da cui penetrano fasci di luce attraverso intricate edere. Sembra essere l'uscita." & vbCrLf & .lblLab.Text
                    'USCITA
                Case 92
                    direzione("0100")
                    .lblLab.Text = "La parete davanti a te è franata." & vbCrLf & .lblLab.Text
                Case 93
                    direzione("0100")
                    .lblLab.Text = "Al centro della stanza c'è la statua di un angelo imponente, le cui ali sono sbriciolate per terra." & vbCrLf & .lblLab.Text
                Case 94
                    direzione("0010")
                    .lblLab.Text = "Nope!" & vbCrLf & .lblLab.Text
                Case 95
                    direzione("0011")
                    .lblLab.Text = "La tua attenzione viene attirata da un sarcofago semidistrutto, il cui occupante sembra esser stato chiuso dentro vivo." & vbCrLf & .lblLab.Text
                Case 96
                    direzione("0111")
                    .lblLab.Text = "Capisci di essere entrato nella vera e propria cripta, poichè lungo le pareti vi sono numerosi sarcofagi." & vbCrLf & .lblLab.Text
                Case 97
                    direzione("0011")
                Case 98
                    direzione("0101")
                    .lblLab.Text = "Lungo le pareti noti diversi compartimenti pieni di vasi, probabilmente urne cinerarie." & vbCrLf & .lblLab.Text
                Case 99
                    direzione("0100")
                    .lblLab.Text = "Al centro della stanza fra altre librerie, c'è un leggio in pietra. Sopra di esso è appoggiato un tomo talmente antico che sembra basti una leggera brezza per sbriciolarlo. La rilegatura recita 'Il libro della Rivelazione'." & vbCrLf & .lblLab.Text
                    'loot del boss cattivone
            End Select

            .lblPosizione.Text = posizione

        End With
    End Sub

End Module

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
    Public scudo1 As Boolean = False

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
    Public movimento As Boolean

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
                Case "0000"
                    .cmdNord.Enabled = False
                    .cmdSud.Enabled = False
                    .cmdEst.Enabled = False
                    .cmdOvest.Enabled = False
            End Select
        End With

    End Sub
    'labirinto
    Public Sub labir()
        Dim dir As String

        With labirinto
            Select Case posizione

            End Select
        End With
    End Sub

End Module

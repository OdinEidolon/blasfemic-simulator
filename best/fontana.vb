Public Class fontanab

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDescr.Click

    End Sub

    Private Sub cmdCorrompi_Click(sender As Object, e As EventArgs) Handles cmdCorrompi.Click

        Dim possibilita As Integer

        Randomize()

        If nb >= 5000 Then
            nb -= 5000
            home.lblBestemmie.Text = "Hai " & nb & " Bestemmie"
            possibilita = CInt(Int(Rnd() * 101))
            If possibilita >= 80 Then
                tier = 2
                cmdCorrompi.Enabled = False
                cmdCorrompi.Visible = False
                home.cmdBestemmia.Enabled = False
                lblDescr.Text = "Avvelenando la Fontana Battesimale con una scarica di invettive contro Dio, i suoi parenti ed i suoi sottoposti, hai corrotto la Fontana. Mentre bestemmiavi però, hai notato una piccola serratura sulla base."
                home.lstLog.Items.Add("Il potere della Fontata Corrotta potenzia la tua peculariare capacità di bestemmiare!")
                bps += 35
                Me.Text = "Fontana Corrotta"
            Else
                MsgBox("Le tue Bestemmie non hanno potuto nulla contro la santità di questa Fonatana! Non sei quindi riuscito a corrompere la Fontana!", vbCritical)
            End If
        Else
            MsgBox("Non hai abbastanza Bestemmie", vbExclamation)
        End If

    End Sub

    Private Sub fontana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case tier
            Case 2
                lblDescr.Text = "Avvelenando la Fontana Battesimale con una scarica di invettive contro Dio, i suoi parenti ed i suoi sottoposti, hai corrotto la Fontana. Mentre bestemmiavi però, hai notato una piccola serratura sulla base."
                cmdCorrompi.Enabled = False
                cmdCorrompi.Visible = False
                home.cmdBestemmia.Enabled = False
                Me.Text = "Fontana Corrotta"
            Case 3
        End Select

    End Sub
End Class
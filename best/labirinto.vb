Public Class labirinto

    Private Sub cmdNord_Click(sender As Object, e As EventArgs) Handles cmdNord.Click

        posizione += 10
        labir()
        If movimento = False Then
            posizione -= 10
        End If

    End Sub

    Private Sub cmdSud_Click(sender As Object, e As EventArgs) Handles cmdSud.Click

        posizione -= 10
        labir()
        If movimento = False Then
            posizione += 10
        End If

    End Sub

    Private Sub cmdEst_Click(sender As Object, e As EventArgs) Handles cmdEst.Click

        posizione += 1
        labir()
        If movimento = False Then
            posizione -= 1
        End If

    End Sub

    Private Sub cmdOvest_Click(sender As Object, e As EventArgs) Handles cmdOvest.Click

        posizione -= 1
        labir()
        If movimento = False Then
            posizione += 1
        End If

    End Sub

    Private Sub labirinto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        posizione = 3
        labir()
        lblPosizione.Text = posizione
    End Sub
End Class
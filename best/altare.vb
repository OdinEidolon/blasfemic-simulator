Public Class altare



    Private Sub cmdInfondi1_Click(sender As Object, e As EventArgs) Handles cmdInfondi1.Click

        If nb >= 1000 Then
            ep_cap = ep_cap + 1
            nb = nb - 1000
        End If

    End Sub

    Private Sub cmdInfondi10_Click(sender As Object, e As EventArgs) Handles cmdInfondi10.Click

        If nb >= 10000 Then
            ep_cap = ep_cap + 10
            nb = nb - 10000
        End If

    End Sub

    Private Sub cmdInfondi100_Click(sender As Object, e As EventArgs) Handles cmdInfondi100.Click

        If nb >= 100000 Then
            ep_cap = ep_cap + 100
            nb = nb - 100000
        End If

    End Sub

    Private Sub cmdInfondiAll_Click(sender As Object, e As EventArgs) Handles cmdInfondiAll.Click

        ep_cap = ep_cap + (nb / 1000)
        nb = 0

    End Sub

    Private Sub altare_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
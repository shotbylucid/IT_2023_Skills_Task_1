Public Class Form1
    Private Sub btnKnown_Click(sender As Object, e As EventArgs) Handles btnKnown.Click
        Dim Tempature, Known As Integer

        '--Input
        Tempature = txtInput.Text()

        '--Process/Ouput
        If Tempature < 20 Then
            Known = "Pretty Chilly"
        ElseIf Tempature < 35 Then
            Known = "Nice and Worm"
        ElseIf Tempature < 45 Then
            Known = "Abit of a sweat"
        ElseIf Tempature < 50 Then
            Known = "Fuck Thats Hot"
        End If

        '--Output
        txtOutput = Known & " - " & Tempature

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtInput.Clear()
        txtOutput.Clear()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub
End Class

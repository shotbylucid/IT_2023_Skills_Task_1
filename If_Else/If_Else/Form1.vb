Public Class Form1
    Private Sub btnKnown_Click(sender As Object, e As EventArgs) Handles btnKnown.Click
    Dim Tempature As Interge

    '--Input
    Tempature = txtInput1.Text()

    '--Process/Ouput
    If Tempature < 20 Then
        txtOutput.Text = "Pretty Chilly"
        Elsif Tempature < 35 Then
        txtOuput.Text = "Nice and Worm"
        Elsif Tempature < 45 Then
        txtOuput.Text = "Abit of a sweat"
        Elsif Tempature < 50 Then
        txtOuput.Text = "Fuck Thats Hot"

    End If

    End Sub

    Private Sub btnClear(sender As Object, e As EventArgs) Handles btnClear.Click

    txtInput1.Clear()
    txtOutput.Clear()    

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

    Close()    

    End Sub
End Class

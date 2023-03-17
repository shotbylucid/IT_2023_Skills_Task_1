Public Class Form1
    Private Sub btnKnown_Click(sender As Object, e As EventArgs) Handles btn_Known.Click, btn_Known.Click
        Dim Tempature, Known As Decimal

        '--Input
        Tempature = txt_Input.Text()

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
        txt_Output = Known & " - " & Tempature

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click, btn_Clear.Click

        txt_Input.Clear()
        txt_Output.Clear()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btn_Close.Click, btn_Close.Click

        Close()

    End Sub
End Class

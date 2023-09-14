Public Class Form1
    Private Sub btn_Known_Click(sender As Object, e As EventArgs) Handles btn_Known.Click
        Dim Temperature As Decimal
        Dim Known As String

        ' Validate user input
        If Not Decimal.TryParse(txt_Input.Text(), Temperature) Then
            MessageBox.Show("Please enter a valid decimal value for temperature.")
            Return
        End If

        '--Process/Output
        If Temperature < 20 Then
            Known = "Pretty Chilly"
        ElseIf Temperature < 35 Then
            Known = "Nice and Warm"
        ElseIf Temperature < 45 Then
            Known = "A bit of a sweat"
        Else
            Known = "F**k That's Hot"
        End If

        '--Output
        txt_Output.Text = Known & " - " & Temperature

    End Sub

    Private Sub btn_Clear_Click(sender As Object, e As EventArgs) Handles btn_Clear.Click

        txt_Input.Clear()
        txt_Output.Clear()

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click

        Close()

    End Sub
End Class
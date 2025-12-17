Public Class Form1

    Private Sub PRODUCTCALBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTCALBTN.Click
        Dim firstNumber As Double
        Dim secondNumber As Double
        Dim result As Double

        If Not IsNumeric(firstNumber_txt.Text) Or Not IsNumeric(secondNumber_txt.Text) Then
            MessageBox.Show("Please enter valid numbers",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Exit Sub
        End If

        firstNumber = CDbl(firstNumber_txt.Text)
        secondNumber = CDbl(secondNumber_txt.Text)
        result = firstNumber * secondNumber
        result_txt.Text = result.ToString()
    End Sub
End Class
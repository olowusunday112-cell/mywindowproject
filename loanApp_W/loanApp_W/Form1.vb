Public Class Form1
    Private Sub calculatebtn_Click(sender As Object, e As EventArgs) Handles calculatebtn.Click
        ' 1. Clear the grid rows
        monthlyGrid.Rows.Clear()


        Dim loanAmount As Double = Val(amount_txt.Text)
        Dim loanDuration As Integer = Val(duration_txt.Text)
        Dim fixedInterest As Double = 1.5

        Dim monthlyPrincipal As Double = loanAmount / loanDuration
        Dim balance As Double = loanAmount
        Dim totalInterestCalc As Double = 0
        Dim totalRepaymentCalc As Double = 0

        ' 3. The Loop (Calculates all 4 values for the grid)
        For i As Integer = 1 To loanDuration
            Dim interestForThisMonth As Double = balance * (fixedInterest / 100)
            Dim totalMonthlyPayment As Double = monthlyPrincipal + interestForThisMonth

            totalInterestCalc += interestForThisMonth
            totalRepaymentCalc += totalMonthlyPayment

            ' 4. Add all 4 values to the grid to match the console
            monthlyGrid.Rows.Add(i,
                                monthlyPrincipal.ToString("N2"),
                                interestForThisMonth.ToString("N2"),
                                totalMonthlyPayment.ToString("N2"))

            ' Reduce balance for the next month
            balance -= monthlyPrincipal
        Next

        ' 5. Update your summary boxes
        totalLoan_txt.Text = loanAmount.ToString("N2")
        totalInterest_txt.Text = totalInterestCalc.ToString("N2")
        totalRepay_txt.Text = totalRepaymentCalc.ToString("N2")

    End Sub
    Private Sub Guna2Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        amount_txt.Clear()
        duration_txt.Clear()
        totalInterest_txt.Clear()
        totalLoan_txt.Clear()
        totalRepay_txt.Clear()
        amount_txt.Focus()

    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        Application.Exit()

    End Sub
End Class

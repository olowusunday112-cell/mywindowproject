Public Class Form1

    Private Sub calculatebtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles calculatebtn.Click

        ' 1. Declare variables
        Dim loanAmount As Double
        Dim loanDuration As Integer   ' Duration in MONTHS
        Dim fixedInterest As Double = 1.5

        Dim monthlyRepayment As Double
        Dim monthlyInterest As Double
        Dim monthlyTotal As Double
        Dim totalInterest As Double = 0
        Dim totalRepayment As Double = 0
        Dim balance As Double

        ' 2. Validation
        If Not IsNumeric(amount_txt.Text) Or Not IsNumeric(duration_txt.Text) Then
            MessageBox.Show("Please enter valid numbers", "Input Error")
            Exit Sub
        End If

        loanAmount = CDbl(amount_txt.Text)
        loanDuration = CInt(duration_txt.Text)

        If loanAmount <= 0 Then
            MessageBox.Show("Loan amount must be greater than 0", "Input Error")
            Exit Sub
        End If

        If loanDuration <= 0 Then
            MessageBox.Show("Duration must be greater than 0", "Input Error")
            Exit Sub
        End If

        ' 3. Setup
        monthlyRepayment = loanAmount / loanDuration
        balance = loanAmount
        totalInterest = 0
        totalRepayment = 0

        ' Clear old data
        monthlyGrid.Rows.Clear()

        ' 4. Reducing Balance Loop
        For months As Integer = 1 To loanDuration

            monthlyInterest = balance * (fixedInterest / 100)
            monthlyTotal = monthlyRepayment + monthlyInterest

            totalInterest += monthlyInterest
            totalRepayment += monthlyTotal

            ' Add to grid
            monthlyGrid.Rows.Add(months, monthlyTotal.ToString("N2"))

            ' Reduce balance
            balance -= monthlyRepayment

        Next

        ' 5. Display results
        totalLoan_txt.Text = loanAmount.ToString("N2")
        totalInterest_txt.Text = totalInterest.ToString("N2")
        totalRepay_txt.Text = totalRepayment.ToString("N2")

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

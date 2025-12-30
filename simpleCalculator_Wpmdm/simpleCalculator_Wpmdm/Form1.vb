Public Class Form1

    

    Private Sub activebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles activebtn_txt.Click
        activebtn_txt.Text = "+"
    End Sub

    Dim selectedOp As String
    Private Sub addbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles addbtn.Click
        selectedOp = "+"
        activebtn_txt.Text = "+"
    End Sub

    Private Sub subbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subbtn.Click
        selectedOp = "-"
        activebtn_txt.Text = "-"
    End Sub

    Private Sub multbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles multbtn.Click
        selectedOp = "*"
        activebtn_txt.Text = "x"
    End Sub

    Private Sub divbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles divbtn.Click
        selectedOp = "/"
        activebtn_txt.Text = "/"
    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub


    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click
        myFunction.clearText()
        selectedOp = ""

    End Sub

   
    Private Sub calculatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebtn.Click
        If selectedOp = "" Then
            MessageBox.Show("Please select an operator(+, -, x, or /) before calculating!", "Operator Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim firstNumber As Double = Val(firstNumber_txt.Text)
        Dim secondNumber As Double = Val(secondNumber_txt.Text)
        Dim result As Double = 0
        If firstNumber_txt.Text = "" Or secondNumber_txt.Text = "" Then
            MessageBox.Show("Please enter numbers in both fields.", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If Not IsNumeric(firstNumber_txt.Text) Or Not IsNumeric(secondNumber_txt.Text) Then
            MessageBox.Show("Invalid input! Please enter numbers only, not letters.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            myFunction.clearText()
            Exit Sub
        End If
        Select Case selectedOp
            Case "+" : result = firstNumber + secondNumber
            Case "-" : result = firstNumber - secondNumber
            Case "*" : result = firstNumber * secondNumber
            Case "/"
                If (secondNumber <> 0) Then
                    result = firstNumber / secondNumber
                Else
                    MessageBox.Show("Error: You cannot divide a number by zero!", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                    secondNumber_txt.Clear()
                    secondNumber_txt.Focus()
                    Exit Sub
                End If
        End Select
        result_txt.Text = result.ToString
    End Sub

   
    Private Sub firstNumber_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles firstNumber_txt.TextChanged
        If firstNumber_txt.Text <> "" Then
            addbtn.Enabled = True
            multbtn.Enabled = True
            subbtn.Enabled = True
            divbtn.Enabled = True
        Else
            addbtn.Enabled = False
            multbtn.Enabled = False
            subbtn.Enabled = False
            divbtn.Enabled = False
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub result_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles result_txt.TextChanged

    End Sub
End Class

Public Class Form1

    Private Sub Guna2HtmlLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonth.Click

    End Sub

    Private Sub calculatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebtn.Click

   
        Try

            Dim currentDay, currentMonth, currentYear As Integer
            Dim birthDay, birthMonth, birthYear As Integer
            Dim resultDay, resultMonth, resultYear As Integer


            currentDay = Date.Now.Day
            currentMonth = Date.Now.Month
            currentYear = Date.Now.Year


            birthDay = Val(birthday_txt.Text)
            birthMonth = Val(birthMonth_txt.Text)
            birthYear = Val(birthYear_txt.Text)
            ' Check if Year is 4 digits and not in the future
            If birthYear.ToString().Length <> 4 Or birthYear > currentYear Then
                MessageBox.Show("Invalid Birth Year! Please enter a valid 4-digit year that is not in the future.", "Year Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Check if Month is valid
            If birthMonth < 1 Or birthMonth > 12 Then
                MessageBox.Show("Invalid Month! Please enter a month between 1 and 12.", "Month Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            ' Use the system to find max days for THAT specific month and year
            Dim maxDays As Integer = System.DateTime.DaysInMonth(birthYear, birthMonth)

            ' Check if Day is valid for that specific month
            If birthDay < 1 Or birthDay > maxDays Then
                MessageBox.Show("Invalid Day! Month " & birthMonth & " in " & birthYear & " only has " & maxDays & " days.", "Day Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If birthDay < 1 Or birthDay > 31 Or birthMonth < 1 Or birthMonth > 12 Or birthYear < 1 Then
                MessageBox.Show("Please enter a valid birth date.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If


            resultYear = currentYear - birthYear
            If (birthMonth > currentMonth) Or (birthMonth = currentMonth And birthDay > currentDay) Then
                resultYear -= 1
            End If

            resultMonth = currentMonth - birthMonth
            If birthDay > currentDay Then
                resultMonth -= 1
            End If
            If resultMonth < 0 Then
                resultMonth += 12
            End If

            If currentDay >= birthDay Then
                resultDay = currentDay - birthDay
            Else
                Dim daysInPrevMonth As Integer
                daysInPrevMonth = System.DateTime.DaysInMonth(
                    If(currentMonth = 1, currentYear - 1, currentYear),
                    If(currentMonth = 1, 12, currentMonth - 1))
                resultDay = currentDay + daysInPrevMonth - birthDay
            End If

            ' 6. DISPLAY RESULTS
            resultYear_txt.Text = resultYear.ToString()
            resultMonth_txt.Text = resultMonth.ToString()
            resultDay_txt.Text = resultDay.ToString()

        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' Using HTML tags to make "Today's Date" bold and the date itself a different color
        lblToday.Text = "<b>Today's Date:</b> <font color='#FFD700'>" & DateTime.Today.ToString("dd/MM/yyyy") & "</font>"
    End Sub

    Private Sub clearbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearbtn.Click

        birthday_txt.Clear()
        birthMonth_txt.Clear()
        birthYear_txt.Clear()

        ' Clear all results
        resultYear_txt.Clear()
        resultMonth_txt.Clear()
        resultDay_txt.Clear()
        birthday_txt.Focus()
    End Sub

    Private Sub exitbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitbtn.Click

        ' Show a message box with Yes and No buttons
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?",
                                                     "Confirm Exit",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        ' If the user clicks Yes, close the application
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    
    End Sub
End Class

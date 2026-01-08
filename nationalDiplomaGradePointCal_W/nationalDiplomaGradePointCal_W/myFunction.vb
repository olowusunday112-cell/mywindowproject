Module MyFunction

    ' 1. Logic for grading individual scores
    Function gradePoint(ByVal score As Object, ByVal courseUnit As Double) As Double
        ' If the box is empty, return 0 instead of falling into the "Else" (1.99) logic
        If score Is Nothing OrElse score.ToString() = "" Then
            Return 0
        End If

        Dim nScore As Double = Val(score)
        Dim gp As Double

        If ((nScore >= 75)) And ((nScore <= 100)) Then
            gp = 4.0 * courseUnit
        ElseIf ((nScore >= 70)) And ((nScore <= 74.9)) Then
            gp = 3.5 * courseUnit
        ElseIf ((nScore >= 60)) And ((nScore <= 69.9)) Then
            gp = 3.0 * courseUnit
        ElseIf ((nScore >= 50)) And ((nScore <= 59.9)) Then
            gp = 2.5 * courseUnit
        ElseIf ((nScore >= 40)) And ((nScore <= 49.9)) Then
            gp = 2.0 * courseUnit
        ElseIf nScore > 0 Then ' Only apply 1.99 if a score was actually entered
            gp = 1.99 * courseUnit
        Else
            gp = 0
        End If
        Return gp
    End Function

    ' 2. Logic for grade titles
    Function gradeTitle(ByVal gradePoint As Double) As String
        Dim grade As String
        If ((gradePoint >= 3.5)) And ((gradePoint <= 4.0)) Then
            grade = "DISTINCTION"
        ElseIf ((gradePoint >= 3.0)) And ((gradePoint <= 3.5)) Then
            grade = "UPPER CLASS"
        ElseIf ((gradePoint >= 2.5)) And ((gradePoint <= 3.0)) Then
            grade = "LOWER CLASS"
        ElseIf ((gradePoint >= 2.0)) And ((gradePoint < 2.5)) Then
            grade = "PASS"
        Else
            grade = "FAIL"
        End If
        Return grade
    End Function

    Public Sub CalculateSemester(ByVal textboxes As TextBox(), ByVal units As Double(), ByRef totalSP As Double, ByRef gpa As Double, ByRef gradeText As String)

        ' 1. The Message Box check you asked for
        If textboxes(0).Text = "" Then
            MessageBox.Show("Please enter your scores before calculating!", "Missing Data")
            ' We set these to empty so the old "FAIL" or "1.99" disappears
            totalSP = 0
            gpa = 0
            gradeText = ""
            Exit Sub
        End If

        Dim tempSP As Double = 0
        Dim totalU As Double = 0

        For i As Integer = 0 To textboxes.Length - 1
            tempSP += gradePoint(textboxes(i).Text, units(i))
            totalU += units(i)
        Next

        totalSP = tempSP
        gpa = If(totalU > 0, tempSP / totalU, 0)

        ' 2. The fix for "FAIL 0.00"
        ' If the GPA is 0 because no scores were processed, keep the grade label empty
        If gpa = 0 Then
            gradeText = ""
        Else
            gradeText = gradeTitle(gpa)
        End If
    End Sub
    Public Function HasEmptyBox(ByVal boxes As Guna.UI2.WinForms.Guna2TextBox()) As Boolean
        For Each t As Guna.UI2.WinForms.Guna2TextBox In boxes
            If t.Text.Trim = "" Then
                Return True
            End If
        Next
        Return False
    End Function
    Public Function HasNonNumeric(ByVal boxes As Guna.UI2.WinForms.Guna2TextBox()) As Boolean
        For Each t As Guna.UI2.WinForms.Guna2TextBox In boxes
            Dim temp As Double
            If Not Double.TryParse(t.Text.Trim, temp) Then
                Return True
            End If
        Next
        Return False
    End Function
End Module
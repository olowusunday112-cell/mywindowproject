Public Class Form1

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnND1.Click
        ' hide the main panel and show the nd1 semester panel
        pnlMainMenu.Visible = False
        pnlND1Semesters.Visible = True
        pnlND1Semesters.BringToFront()
        ' update status to communicate with  the user
        '(if you added a status label at the bottom)
        'lblStatus.Text= "choose your semeter for ND1"

    End Sub

    Private Sub Guna2Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToMain.Click
        pnlND1Semesters.Visible = False
        pnlMainMenu.Visible = True
        pnlMainMenu.BringToFront()
    End Sub

    Private Sub pnlND1_S1_Calcutor_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlND1_S1_Calculator.Paint

    End Sub

    Private Sub com115_txt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com115_txt.TextChanged

    End Sub

  Private Sub calculatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles calculatebtn.Click



        Dim boxes() As Guna.UI2.WinForms.Guna2TextBox = {
            com111_txt, com112_txt, com113_txt, com114_txt, com115_txt,
            gns101_txt, gns111_txt, mth111_txt
        }

        ' 1️⃣ Check empty boxes
        If MyFunction.HasEmptyBox(boxes) Then
            MessageBox.Show("Please enter all course scores before calculating.", "Missing Scores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 2️⃣ Check non-numeric input
        If MyFunction.HasNonNumeric(boxes) Then
            MessageBox.Show("Please enter **numbers only** in the score boxes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' 3️⃣ Check scores above 100
        For Each t As Guna.UI2.WinForms.Guna2TextBox In boxes
            If Val(t.Text) > 100 Then
                MessageBox.Show("INVALID! Score must not exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        ' 4️⃣ Now calculate normally
        Dim gpofcom111 = MyFunction.gradePoint(Val(com111_txt.Text), 3)
        Dim gpofcom112 = MyFunction.gradePoint(Val(com112_txt.Text), 3)
        Dim gpofcom113 = MyFunction.gradePoint(Val(com113_txt.Text), 3)
        Dim gpofcom114 = MyFunction.gradePoint(Val(com114_txt.Text), 2)
        Dim gpofcom115 = MyFunction.gradePoint(Val(com115_txt.Text), 3)
        Dim gpofgns101 = MyFunction.gradePoint(Val(gns101_txt.Text), 2)
        Dim gpofgns111 = MyFunction.gradePoint(Val(gns111_txt.Text), 2)
        Dim gpofmth111 = MyFunction.gradePoint(Val(mth111_txt.Text), 2)

        Dim totalUnit As Double = 20
        Dim totalScorePoint As Double = gpofcom111 + gpofcom112 + gpofcom113 + gpofcom114 + gpofcom115 + gpofgns101 + gpofgns111 + gpofmth111
        Dim gradePointResult As Double = totalScorePoint / totalUnit

        totalScorePoint_txt.Text = totalScorePoint.ToString("F2")
        gradePoint_txt.Text = Math.Round(gradePointResult, 2).ToString("N")
        grade_txt.Text = MyFunction.gradeTitle(gradePointResult)

    End Sub

    Private Sub btnFirstSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstSemester.Click

        ' 1. Hide the semester selection panel
        pnlND1Semesters.Visible = False

        ' 2. Show your new calculator panel
        ' Make sure this name matches the name of the panel you designed with all the textboxes
        pnlND1_S1_Calculator.Visible = True
        pnlND1_S1_Calculator.BringToFront()

    End Sub

    Private Sub Guna2Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click, Guna2Button20.Click

        ' Clear all score input boxes
        com111_txt.Clear()
        com112_txt.Clear()
        com113_txt.Clear()
        com114_txt.Clear()
        com115_txt.Clear()
        gns101_txt.Clear()
        gns111_txt.Clear()
        mth111_txt.Clear()

        ' Clear the result boxes too
        totalScorePoint_txt.Clear()
        gradePoint_txt.Clear()
        grade_txt.Clear()

        ' Move focus back to the first box for easy re-entry
        com111_txt.Focus()

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        ' Ask for confirmation before closing
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to close the CGPA Calculator?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnBackToSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToSemester.Click

        ' 1. Hide the current calculator panel
        pnlND1_S1_Calculator.Visible = False

        ' 2. Show the semester selection panel again
        pnlND1Semesters.Visible = True
        pnlND1Semesters.BringToFront()

    End Sub

    Private Sub btnSecondSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSecondSemester.Click

        ' Hide the selection panel
        pnlND1Semesters.Visible = False

        ' Show the Second Semester calculator
        pnlND1_S2_Calculator.Visible = True
        pnlND1_S2_Calculator.BringToFront()

    End Sub

    Private Sub Guna2Button37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click





        Dim boxes() As Guna.UI2.WinForms.Guna2TextBox = {
            com121_txt, com122_txt, com123_txt, com124_txt, com125_txt,
            com126_txt, gns228_txt, eed126_txt, gns102_txt, gns121_txt
        }

        If MyFunction.HasEmptyBox(boxes) Then
            MessageBox.Show("Please enter all course scores before calculating.", "Missing Scores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MyFunction.HasNonNumeric(boxes) Then
            MessageBox.Show("Please enter numbers only in the score boxes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each t As Guna.UI2.WinForms.Guna2TextBox In boxes
            If Val(t.Text) > 100 Then
                MessageBox.Show("INVALID! Score must not exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        Dim gp121 = MyFunction.gradePoint(Val(com121_txt.Text), 3)
        Dim gp122 = MyFunction.gradePoint(Val(com122_txt.Text), 3)
        Dim gp123 = MyFunction.gradePoint(Val(com123_txt.Text), 2)
        Dim gp124 = MyFunction.gradePoint(Val(com124_txt.Text), 3)
        Dim gp125 = MyFunction.gradePoint(Val(com125_txt.Text), 3)
        Dim gp126 = MyFunction.gradePoint(Val(com126_txt.Text), 3)
        Dim gp228 = MyFunction.gradePoint(Val(gns228_txt.Text), 2)
        Dim gpEED = MyFunction.gradePoint(Val(eed126_txt.Text), 2)
        Dim gp102 = MyFunction.gradePoint(Val(gns102_txt.Text), 2)
        Dim gp121g = MyFunction.gradePoint(Val(gns121_txt.Text), 2)

        Dim totalUnit As Double = 25
        Dim totalScorePoint As Double = gp121 + gp122 + gp123 + gp124 + gp125 + gp126 + gp228 + gpEED + gp102 + gp121g
        Dim gradePointResult As Double = totalScorePoint / totalUnit

        totalScorePoint_txt_S2.Text = totalScorePoint.ToString("F2")
        gradePoint_txt_S2.Text = Math.Round(gradePointResult, 2).ToString("N")
        grade_txt_S2.Text = MyFunction.gradeTitle(gradePointResult)

    End Sub

    Private Sub btnBackToChoice_S2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackToChoice_S2.Click

        ' 1. Hide the Second Semester calculator panel
        pnlND1_S2_Calculator.Visible = False

        ' 2. Show the Semester Selection panel
        pnlND1Semesters.Visible = True
        pnlND1Semesters.BringToFront() ' Ensures it sits on top

    End Sub

    Private Sub btnClear_S2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_S2.Click

        ' Clear all 10 course score textboxes
        com121_txt.Clear()
        com122_txt.Clear()
        com123_txt.Clear()
        com124_txt.Clear()
        com125_txt.Clear()
        com126_txt.Clear()
        gns228_txt.Clear()
        eed126_txt.Clear()
        gns102_txt.Clear()
        gns121_txt.Clear()

        ' Clear the result display textboxes
        totalScorePoint_txt_S2.Clear()
        gradePoint_txt_S2.Clear()
        grade_txt_S2.Clear()

        ' Set focus back to the first box
        com121_txt.Focus()

    End Sub

    Private Sub btnExit_S2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit_S2.Click

        ' Ask for confirmation before exiting
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to close the CGPA Calculator?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub btnND2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnND2.Click

        pnlMainMenu.Visible = False
        pnlND2Semesters.Visible = True
        pnlND2Semesters.BringToFront()

    End Sub

    Private Sub Guna2TextBox22_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sws210_txt.TextChanged

    End Sub

    Private Sub Guna2Button59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculateND2S2.Click



        Dim boxes() As Guna.UI2.WinForms.Guna2TextBox = {
            com221_txt, com222_txt, com223_txt, com224_txt, com225_txt,
            com226_txt, com229_txt, gns202_txt
        }

        If MyFunction.HasEmptyBox(boxes) Then
            MessageBox.Show("Please enter all course scores before calculating.", "Missing Scores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If MyFunction.HasNonNumeric(boxes) Then
            MessageBox.Show("Please enter numbers only in the score boxes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each t As Guna.UI2.WinForms.Guna2TextBox In boxes
            If Val(t.Text) > 100 Then
                MessageBox.Show("INVALID! Score must not exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        'Calculate grade points
        Dim gp221 = MyFunction.gradePoint(Val(com221_txt.Text), 3)
        Dim gp222 = MyFunction.gradePoint(Val(com222_txt.Text), 2)
        Dim gp223 = MyFunction.gradePoint(Val(com223_txt.Text), 2)
        Dim gp224 = MyFunction.gradePoint(Val(com224_txt.Text), 2)
        Dim gp225 = MyFunction.gradePoint(Val(com225_txt.Text), 3)
        Dim gp226 = MyFunction.gradePoint(Val(com226_txt.Text), 2)
        Dim gp229 = MyFunction.gradePoint(Val(com229_txt.Text), 4) 'Project
        Dim gp202 = MyFunction.gradePoint(Val(gns202_txt.Text), 2)

        Dim totalUnit As Double = 20
        Dim totalScorePoint As Double = gp221 + gp222 + gp223 + gp224 + gp225 + gp226 + gp229 + gp202
        Dim gradePointResult As Double = totalScorePoint / totalUnit

        totalScorePoint_txt_ND2S2.Text = totalScorePoint.ToString("F2")
        gradePoint_txt_ND2S2.Text = Math.Round(gradePointResult, 2).ToString("N")
        grade_txt_NDS2.Text = MyFunction.gradeTitle(gradePointResult)

    End Sub


    Private Sub btnCalculateND2S1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCalculateND2S1.Click

        Dim boxes() As Guna.UI2.WinForms.Guna2TextBox = {
            com211_txt, com212_txt, com213_txt, com214_txt, com215_txt,
            com216_txt, eed216_txt, gns201_txt, sws210_txt
        }

        If MyFunction.HasEmptyBox(boxes) Then
            MessageBox.Show("Please enter all course scores before calculating.", "Missing Scores", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If MyFunction.HasNonNumeric(boxes) Then
            MessageBox.Show("Please enter numbers only in the score boxes.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        For Each t As Guna.UI2.WinForms.Guna2TextBox In boxes
            If Val(t.Text) > 100 Then
                MessageBox.Show("INVALID! Score must not exceed 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Next

        'Calculate grade points
        Dim gp211 = MyFunction.gradePoint(Val(com211_txt.Text), 3)
        Dim gp212 = MyFunction.gradePoint(Val(com212_txt.Text), 2)
        Dim gp213 = MyFunction.gradePoint(Val(com213_txt.Text), 3)
        Dim gp214 = MyFunction.gradePoint(Val(com214_txt.Text), 3)
        Dim gp215 = MyFunction.gradePoint(Val(com215_txt.Text), 3)
        Dim gp216 = MyFunction.gradePoint(Val(com216_txt.Text), 2)
        Dim gpEED216 = MyFunction.gradePoint(Val(eed216_txt.Text), 2)
        Dim gpGNS201 = MyFunction.gradePoint(Val(gns201_txt.Text), 2)
        Dim gpSWS210 = MyFunction.gradePoint(Val(sws210_txt.Text), 4)

        Dim totalUnit As Double = 24
        Dim totalScorePoint As Double = gp211 + gp212 + gp213 + gp214 + gp215 + gp216 + gpEED216 + gpGNS201 + gpSWS210
        Dim gradePointResult As Double = totalScorePoint / totalUnit

        totalScorePoint_txt_ND2S1.Text = totalScorePoint.ToString("F2")
        gradePoint_txt_ND2S1.Text = Math.Round(gradePointResult, 2).ToString("N")
        grade_txt_ND2S1.Text = MyFunction.gradeTitle(gradePointResult)

    End Sub

    Private Sub btnND2FirstSemester_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnND2FirstSemester.Click

        ' Hide the selection panel
        pnlND2Semesters.Visible = False

        ' Show the ND 2 S1 calculator panel
        ' Replace 'pnlND2_S1_Calculator' with the actual name of your panel
        pnlND2_S1_Calculator.Visible = True
        pnlND2_S1_Calculator.BringToFront()

    End Sub

    Private Sub btnBack_ND2S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack_ND2S1.Click

        ' Hide the current calculator panel
        pnlND2_S1_Calculator.Visible = False

        ' Show the ND 2 selection panel
        pnlND2Semesters.Visible = True
        pnlND2Semesters.BringToFront()

    End Sub

    Private Sub btnClear_ND2S1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear_ND2S1.Click

        ' Clear input textboxes for all 9 courses
        com211_txt.Clear()
        com212_txt.Clear()
        com213_txt.Clear()
        com214_txt.Clear()
        com215_txt.Clear()
        com216_txt.Clear()
        eed216_txt.Clear()
        gns201_txt.Clear()
        sws210_txt.Clear()

        ' Clear the results
        totalScorePoint_txt_ND2S1.Clear()
        gradePoint_txt_ND2S1.Clear()
        grade_txt_ND2S1.Clear()

        ' Focus back on the first subject
        com211_txt.Focus()

    End Sub

    Private Sub btnExit_ND2S1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit_ND2S1.Click
        ' Confirmation message box for better user communication
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to close the CGPA Calculator?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub btnBackToMain_ND2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBackToMain_ND2.Click
        ' 1. Hide the ND 2 selection panel
        pnlND2Semesters.Visible = False

        ' 2. Show the Main Menu panel
        ' Make sure 'pnlMainMenu' matches the name of your first screen panel
        pnlMainMenu.Visible = True
        pnlMainMenu.BringToFront()

    End Sub

    Private Sub btnND2SecondSemester_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnND2SecondSemester.Click
        ' Hide the selection panel
        pnlND2Semesters.Visible = False

        ' Show the ND 2 S2 calculator panel
        ' Ensure the name matches your duplicated panel
        pnlND2_S2_Calculator.Visible = True
        pnlND2_S2_Calculator.BringToFront()
    End Sub

    Private Sub btnBack_ND2S2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack_ND2S2.Click

        ' 1. Hide the Second Semester calculator panel
        pnlND2_S2_Calculator.Visible = False

        ' 2. Show the ND 2 selection panel
        pnlND2Semesters.Visible = True
        pnlND2Semesters.BringToFront()

    End Sub

    Private Sub btnClear_ND2S2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnClear_ND2S2.Click
        ' Clear all score input textboxes for this semester
        com221_txt.Clear()
        com222_txt.Clear()
        com223_txt.Clear()
        com224_txt.Clear()
        com225_txt.Clear()
        com226_txt.Clear()
        com229_txt.Clear() ' Project textbox
        gns202_txt.Clear()

        ' Clear the result display textboxes
        totalScorePoint_txt_ND2S2.Clear()
        gradePoint_txt_ND2S2.Clear()
        grade_txt_NDS2.Clear()

        ' Set focus back to the first course for convenience
        com221_txt.Focus()
    End Sub

    Private Sub btnExit_ND2S2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit_ND2S2.Click

        ' Confirm before closing to prevent accidental data loss
        Dim dialog As DialogResult = MessageBox.Show("Are you sure you want to close the CGPA Calculator?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If dialog = DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Guna2Button75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button75.Click

    End Sub
End Class

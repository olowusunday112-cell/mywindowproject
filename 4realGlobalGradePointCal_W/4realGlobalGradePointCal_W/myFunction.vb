Module MyFunction
    Function gradepoint(ByVal score As Double, ByVal courseUnit As Double) As Double
        Dim gp As Double
        If score >= 75 Then : gp = 4.0 * courseUnit
        ElseIf score >= 70 Then : gp = 3.5 * courseUnit
        ElseIf score >= 60 Then : gp = 3.0 * courseUnit
        ElseIf score >= 50 Then : gp = 2.5 * courseUnit
        ElseIf score >= 40 Then : gp = 2.0 * courseUnit
        Else : gp = 1.99 * courseUnit
        End If
        Return gp
    End Function
End Module
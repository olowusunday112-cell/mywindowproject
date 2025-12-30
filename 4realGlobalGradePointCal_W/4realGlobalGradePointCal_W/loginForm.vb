Public Class loginForm

    Private Sub login_brn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_brn.Click
        If user_txt.Text = "Admin" And pass_txt.Text = "1234" Then
            MessageBox.Show("Login Successful!", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()
            form1.Show()
        Else
            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            user_txt.Clear()
            pass_txt.Clear()
            user_txt.Focus()

        End If
    End Sub
End Class
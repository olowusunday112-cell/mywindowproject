<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.user_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.login_brn = New Guna.UI2.WinForms.Guna2Button()
        Me.pass_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'user_txt
        '
        Me.user_txt.BorderRadius = 10
        Me.user_txt.BorderThickness = 0
        Me.user_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.user_txt.DefaultText = ""
        Me.user_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.user_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.user_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.user_txt.DisabledState.Parent = Me.user_txt
        Me.user_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.user_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.user_txt.FocusedState.Parent = Me.user_txt
        Me.user_txt.ForeColor = System.Drawing.Color.Black
        Me.user_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.user_txt.HoverState.Parent = Me.user_txt
        Me.user_txt.Location = New System.Drawing.Point(30, 34)
        Me.user_txt.Name = "user_txt"
        Me.user_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.user_txt.PlaceholderText = ""
        Me.user_txt.SelectedText = ""
        Me.user_txt.ShadowDecoration.Parent = Me.user_txt
        Me.user_txt.Size = New System.Drawing.Size(200, 36)
        Me.user_txt.TabIndex = 0
        '
        'login_brn
        '
        Me.login_brn.CheckedState.Parent = Me.login_brn
        Me.login_brn.CustomImages.Parent = Me.login_brn
        Me.login_brn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.login_brn.ForeColor = System.Drawing.Color.White
        Me.login_brn.HoverState.Parent = Me.login_brn
        Me.login_brn.Location = New System.Drawing.Point(50, 159)
        Me.login_brn.Name = "login_brn"
        Me.login_brn.ShadowDecoration.Parent = Me.login_brn
        Me.login_brn.Size = New System.Drawing.Size(180, 45)
        Me.login_brn.TabIndex = 1
        Me.login_brn.Text = "LOG IN"
        '
        'pass_txt
        '
        Me.pass_txt.BorderRadius = 10
        Me.pass_txt.BorderThickness = 0
        Me.pass_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pass_txt.DefaultText = ""
        Me.pass_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.pass_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.pass_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pass_txt.DisabledState.Parent = Me.pass_txt
        Me.pass_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.pass_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pass_txt.FocusedState.Parent = Me.pass_txt
        Me.pass_txt.ForeColor = System.Drawing.Color.Black
        Me.pass_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.pass_txt.HoverState.Parent = Me.pass_txt
        Me.pass_txt.Location = New System.Drawing.Point(30, 91)
        Me.pass_txt.Name = "pass_txt"
        Me.pass_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.pass_txt.PlaceholderText = ""
        Me.pass_txt.SelectedText = ""
        Me.pass_txt.ShadowDecoration.Parent = Me.pass_txt
        Me.pass_txt.Size = New System.Drawing.Size(200, 36)
        Me.pass_txt.TabIndex = 2
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.pass_txt)
        Me.Controls.Add(Me.login_brn)
        Me.Controls.Add(Me.user_txt)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents user_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents login_brn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents pass_txt As Guna.UI2.WinForms.Guna2TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.TitleLabel = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.firstNumber_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Calculatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblfirst = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.lblsecond = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.secondNumber_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.result_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.BackColor = System.Drawing.Color.Transparent
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TitleLabel.Location = New System.Drawing.Point(73, 12)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(211, 18)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "FRACTION OF TWO NUMBER"
        '
        'firstNumber_txt
        '
        Me.firstNumber_txt.BackColor = System.Drawing.Color.Black
        Me.firstNumber_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNumber_txt.DefaultText = ""
        Me.firstNumber_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstNumber_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstNumber_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNumber_txt.DisabledState.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNumber_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNumber_txt.FocusedState.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumber_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.firstNumber_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNumber_txt.HoverState.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Location = New System.Drawing.Point(93, 71)
        Me.firstNumber_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.firstNumber_txt.Name = "firstNumber_txt"
        Me.firstNumber_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNumber_txt.PlaceholderText = ""
        Me.firstNumber_txt.SelectedText = ""
        Me.firstNumber_txt.ShadowDecoration.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Size = New System.Drawing.Size(150, 30)
        Me.firstNumber_txt.TabIndex = 1
        '
        'Calculatebtn
        '
        Me.Calculatebtn.CheckedState.Parent = Me.Calculatebtn
        Me.Calculatebtn.CustomImages.Parent = Me.Calculatebtn
        Me.Calculatebtn.FillColor = System.Drawing.Color.Green
        Me.Calculatebtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Calculatebtn.ForeColor = System.Drawing.Color.White
        Me.Calculatebtn.HoverState.Parent = Me.Calculatebtn
        Me.Calculatebtn.Location = New System.Drawing.Point(84, 212)
        Me.Calculatebtn.Name = "Calculatebtn"
        Me.Calculatebtn.ShadowDecoration.Parent = Me.Calculatebtn
        Me.Calculatebtn.Size = New System.Drawing.Size(180, 45)
        Me.Calculatebtn.TabIndex = 2
        Me.Calculatebtn.Text = "CALCULATE"
        '
        'lblfirst
        '
        Me.lblfirst.BackColor = System.Drawing.Color.Transparent
        Me.lblfirst.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfirst.Location = New System.Drawing.Point(82, 47)
        Me.lblfirst.Name = "lblfirst"
        Me.lblfirst.Size = New System.Drawing.Size(172, 18)
        Me.lblfirst.TabIndex = 3
        Me.lblfirst.Text = "ENTER FIRST NUMBER"
        '
        'lblsecond
        '
        Me.lblsecond.BackColor = System.Drawing.Color.Transparent
        Me.lblsecond.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsecond.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblsecond.Location = New System.Drawing.Point(73, 122)
        Me.lblsecond.Name = "lblsecond"
        Me.lblsecond.Size = New System.Drawing.Size(191, 18)
        Me.lblsecond.TabIndex = 4
        Me.lblsecond.Text = "ENTER SECOND NUMBER"
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(134, 263)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(63, 18)
        Me.Guna2HtmlLabel4.TabIndex = 5
        Me.Guna2HtmlLabel4.Text = "RESULT"
        '
        'secondNumber_txt
        '
        Me.secondNumber_txt.BackColor = System.Drawing.Color.Black
        Me.secondNumber_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.secondNumber_txt.DefaultText = ""
        Me.secondNumber_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.secondNumber_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.secondNumber_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.secondNumber_txt.DisabledState.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.secondNumber_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.secondNumber_txt.FocusedState.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondNumber_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.secondNumber_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.secondNumber_txt.HoverState.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.Location = New System.Drawing.Point(93, 158)
        Me.secondNumber_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.secondNumber_txt.Name = "secondNumber_txt"
        Me.secondNumber_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.secondNumber_txt.PlaceholderText = ""
        Me.secondNumber_txt.SelectedText = ""
        Me.secondNumber_txt.ShadowDecoration.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.Size = New System.Drawing.Size(150, 30)
        Me.secondNumber_txt.TabIndex = 6
        '
        'result_txt
        '
        Me.result_txt.BackColor = System.Drawing.Color.Black
        Me.result_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.result_txt.DefaultText = ""
        Me.result_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.result_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.result_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.result_txt.DisabledState.Parent = Me.result_txt
        Me.result_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.result_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.result_txt.FocusedState.Parent = Me.result_txt
        Me.result_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.ForeColor = System.Drawing.SystemColors.Desktop
        Me.result_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.result_txt.HoverState.Parent = Me.result_txt
        Me.result_txt.Location = New System.Drawing.Point(93, 304)
        Me.result_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.result_txt.Name = "result_txt"
        Me.result_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.result_txt.PlaceholderText = ""
        Me.result_txt.SelectedText = ""
        Me.result_txt.ShadowDecoration.Parent = Me.result_txt
        Me.result_txt.Size = New System.Drawing.Size(150, 30)
        Me.result_txt.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(364, 361)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.secondNumber_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.lblsecond)
        Me.Controls.Add(Me.lblfirst)
        Me.Controls.Add(Me.Calculatebtn)
        Me.Controls.Add(Me.firstNumber_txt)
        Me.Controls.Add(Me.TitleLabel)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRACTION2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents firstNumber_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Calculatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblfirst As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblsecond As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents secondNumber_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents result_txt As Guna.UI2.WinForms.Guna2TextBox

    Private Sub Calculatebtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Calculatebtn.Click
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
        result = firstNumber / secondNumber
        result_txt.Text = result.ToString()
    End Sub
End Class


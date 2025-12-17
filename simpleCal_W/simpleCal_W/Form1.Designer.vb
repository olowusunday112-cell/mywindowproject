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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.sumCalculateBtm = New Guna.UI2.WinForms.Guna2Button()
        Me.firstNumber_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.guna = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.aa = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.secondNumber_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.bbb = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.result_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Navy
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(92, 23)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(168, 18)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "SUM OF TWO NUMBER"
        '
        'sumCalculateBtm
        '
        Me.sumCalculateBtm.CheckedState.Parent = Me.sumCalculateBtm
        Me.sumCalculateBtm.CustomImages.Parent = Me.sumCalculateBtm
        Me.sumCalculateBtm.FillColor = System.Drawing.Color.Navy
        Me.sumCalculateBtm.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.sumCalculateBtm.ForeColor = System.Drawing.Color.White
        Me.sumCalculateBtm.HoverState.Parent = Me.sumCalculateBtm
        Me.sumCalculateBtm.Location = New System.Drawing.Point(100, 241)
        Me.sumCalculateBtm.Name = "sumCalculateBtm"
        Me.sumCalculateBtm.ShadowDecoration.Parent = Me.sumCalculateBtm
        Me.sumCalculateBtm.Size = New System.Drawing.Size(150, 30)
        Me.sumCalculateBtm.TabIndex = 1
        Me.sumCalculateBtm.Text = "CALCULATE"
        '
        'firstNumber_txt
        '
        Me.firstNumber_txt.BackColor = System.Drawing.SystemColors.WindowText
        Me.firstNumber_txt.BorderColor = System.Drawing.SystemColors.Control
        Me.firstNumber_txt.BorderThickness = 0
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
        Me.firstNumber_txt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.firstNumber_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNumber_txt.HoverState.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Location = New System.Drawing.Point(100, 103)
        Me.firstNumber_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.firstNumber_txt.Name = "firstNumber_txt"
        Me.firstNumber_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNumber_txt.PlaceholderText = ""
        Me.firstNumber_txt.SelectedText = ""
        Me.firstNumber_txt.ShadowDecoration.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Size = New System.Drawing.Size(150, 30)
        Me.firstNumber_txt.TabIndex = 2
        '
        'guna
        '
        Me.guna.BackColor = System.Drawing.Color.Transparent
        Me.guna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guna.Location = New System.Drawing.Point(100, 69)
        Me.guna.Name = "guna"
        Me.guna.Size = New System.Drawing.Size(156, 17)
        Me.guna.TabIndex = 3
        Me.guna.Text = "ENTER FIRST NUMBER"
        '
        'aa
        '
        Me.aa.BackColor = System.Drawing.Color.Transparent
        Me.aa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aa.Location = New System.Drawing.Point(88, 152)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(174, 17)
        Me.aa.TabIndex = 4
        Me.aa.Text = "ENTER SECOND NUMBER"
        '
        'secondNumber_txt
        '
        Me.secondNumber_txt.BackColor = System.Drawing.SystemColors.WindowText
        Me.secondNumber_txt.BorderThickness = 0
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
        Me.secondNumber_txt.ForeColor = System.Drawing.Color.Black
        Me.secondNumber_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.secondNumber_txt.HoverState.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.Location = New System.Drawing.Point(100, 186)
        Me.secondNumber_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.secondNumber_txt.Name = "secondNumber_txt"
        Me.secondNumber_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.secondNumber_txt.PlaceholderText = ""
        Me.secondNumber_txt.SelectedText = ""
        Me.secondNumber_txt.ShadowDecoration.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.Size = New System.Drawing.Size(150, 30)
        Me.secondNumber_txt.TabIndex = 5
        '
        'bbb
        '
        Me.bbb.BackColor = System.Drawing.Color.Transparent
        Me.bbb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bbb.Location = New System.Drawing.Point(133, 282)
        Me.bbb.Name = "bbb"
        Me.bbb.Size = New System.Drawing.Size(66, 17)
        Me.bbb.TabIndex = 6
        Me.bbb.Text = "RESULTS"
        '
        'result_txt
        '
        Me.result_txt.BackColor = System.Drawing.SystemColors.WindowText
        Me.result_txt.BorderThickness = 0
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
        Me.result_txt.ForeColor = System.Drawing.Color.Black
        Me.result_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.result_txt.HoverState.Parent = Me.result_txt
        Me.result_txt.Location = New System.Drawing.Point(100, 305)
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
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(364, 361)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.bbb)
        Me.Controls.Add(Me.secondNumber_txt)
        Me.Controls.Add(Me.aa)
        Me.Controls.Add(Me.guna)
        Me.Controls.Add(Me.firstNumber_txt)
        Me.Controls.Add(Me.sumCalculateBtm)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sum1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents sumCalculateBtm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents firstNumber_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents guna As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents aa As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents secondNumber_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents bbb As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents result_txt As Guna.UI2.WinForms.Guna2TextBox

End Class

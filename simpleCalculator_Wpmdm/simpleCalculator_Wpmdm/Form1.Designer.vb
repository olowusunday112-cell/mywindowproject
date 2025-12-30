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
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.firstNumber_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.secondNumber_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.result_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.calculatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.addbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.subbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.multbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.divbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.activebtn_txt = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.exitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clearbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.Green
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(45, 21)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(190, 22)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "SIMPLE CALCULATOR"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(47, 70)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(163, 20)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Enter First Number: <font color=""red"">*</font color>"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(45, 180)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(186, 20)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "Enter Second Number: <font color=""red"">*</font color>"
        '
        'firstNumber_txt
        '
        Me.firstNumber_txt.BorderRadius = 10
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
        Me.firstNumber_txt.ForeColor = System.Drawing.Color.Black
        Me.firstNumber_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNumber_txt.HoverState.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Location = New System.Drawing.Point(45, 102)
        Me.firstNumber_txt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.firstNumber_txt.Name = "firstNumber_txt"
        Me.firstNumber_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNumber_txt.PlaceholderText = ""
        Me.firstNumber_txt.SelectedText = ""
        Me.firstNumber_txt.ShadowDecoration.Parent = Me.firstNumber_txt
        Me.firstNumber_txt.Size = New System.Drawing.Size(175, 30)
        Me.firstNumber_txt.TabIndex = 5
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(55, 273)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(51, 20)
        Me.Guna2HtmlLabel4.TabIndex = 6
        Me.Guna2HtmlLabel4.Text = "Result"
        '
        'secondNumber_txt
        '
        Me.secondNumber_txt.BorderRadius = 10
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
        Me.secondNumber_txt.Location = New System.Drawing.Point(48, 213)
        Me.secondNumber_txt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.secondNumber_txt.Name = "secondNumber_txt"
        Me.secondNumber_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.secondNumber_txt.PlaceholderText = ""
        Me.secondNumber_txt.SelectedText = ""
        Me.secondNumber_txt.ShadowDecoration.Parent = Me.secondNumber_txt
        Me.secondNumber_txt.Size = New System.Drawing.Size(175, 30)
        Me.secondNumber_txt.TabIndex = 7
        '
        'result_txt
        '
        Me.result_txt.BorderRadius = 10
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
        Me.result_txt.Location = New System.Drawing.Point(47, 303)
        Me.result_txt.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.result_txt.Name = "result_txt"
        Me.result_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.result_txt.PlaceholderText = ""
        Me.result_txt.ReadOnly = True
        Me.result_txt.SelectedText = ""
        Me.result_txt.ShadowDecoration.Parent = Me.result_txt
        Me.result_txt.Size = New System.Drawing.Size(175, 30)
        Me.result_txt.TabIndex = 8
        '
        'calculatebtn
        '
        Me.calculatebtn.AllowDrop = True
        Me.calculatebtn.BorderRadius = 10
        Me.calculatebtn.CheckedState.Parent = Me.calculatebtn
        Me.calculatebtn.CustomImages.Parent = Me.calculatebtn
        Me.calculatebtn.FillColor = System.Drawing.Color.White
        Me.calculatebtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatebtn.ForeColor = System.Drawing.Color.Black
        Me.calculatebtn.HoverState.Parent = Me.calculatebtn
        Me.calculatebtn.Location = New System.Drawing.Point(28, 197)
        Me.calculatebtn.Name = "calculatebtn"
        Me.calculatebtn.ShadowDecoration.Parent = Me.calculatebtn
        Me.calculatebtn.Size = New System.Drawing.Size(191, 45)
        Me.calculatebtn.TabIndex = 9
        Me.calculatebtn.Text = "="
        '
        'addbtn
        '
        Me.addbtn.BorderRadius = 10
        Me.addbtn.CheckedState.Parent = Me.addbtn
        Me.addbtn.CustomImages.Parent = Me.addbtn
        Me.addbtn.Enabled = False
        Me.addbtn.FillColor = System.Drawing.Color.White
        Me.addbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addbtn.ForeColor = System.Drawing.Color.Black
        Me.addbtn.HoverState.Parent = Me.addbtn
        Me.addbtn.Location = New System.Drawing.Point(28, 16)
        Me.addbtn.Name = "addbtn"
        Me.addbtn.ShadowDecoration.Parent = Me.addbtn
        Me.addbtn.Size = New System.Drawing.Size(70, 60)
        Me.addbtn.TabIndex = 0
        Me.addbtn.Text = "+"
        '
        'subbtn
        '
        Me.subbtn.BorderRadius = 10
        Me.subbtn.CheckedState.Parent = Me.subbtn
        Me.subbtn.CustomImages.Parent = Me.subbtn
        Me.subbtn.Enabled = False
        Me.subbtn.FillColor = System.Drawing.Color.White
        Me.subbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subbtn.ForeColor = System.Drawing.Color.Black
        Me.subbtn.HoverState.Parent = Me.subbtn
        Me.subbtn.Location = New System.Drawing.Point(140, 16)
        Me.subbtn.Name = "subbtn"
        Me.subbtn.ShadowDecoration.Parent = Me.subbtn
        Me.subbtn.Size = New System.Drawing.Size(70, 60)
        Me.subbtn.TabIndex = 1
        Me.subbtn.Text = "-"
        '
        'multbtn
        '
        Me.multbtn.BorderRadius = 10
        Me.multbtn.CheckedState.Parent = Me.multbtn
        Me.multbtn.CustomImages.Parent = Me.multbtn
        Me.multbtn.Enabled = False
        Me.multbtn.FillColor = System.Drawing.Color.White
        Me.multbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.multbtn.ForeColor = System.Drawing.Color.Black
        Me.multbtn.HoverState.Parent = Me.multbtn
        Me.multbtn.Location = New System.Drawing.Point(28, 120)
        Me.multbtn.Name = "multbtn"
        Me.multbtn.ShadowDecoration.Parent = Me.multbtn
        Me.multbtn.Size = New System.Drawing.Size(70, 60)
        Me.multbtn.TabIndex = 2
        Me.multbtn.Text = "x"
        '
        'divbtn
        '
        Me.divbtn.BorderRadius = 10
        Me.divbtn.CheckedState.Parent = Me.divbtn
        Me.divbtn.CustomImages.Parent = Me.divbtn
        Me.divbtn.Enabled = False
        Me.divbtn.FillColor = System.Drawing.Color.White
        Me.divbtn.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.divbtn.ForeColor = System.Drawing.Color.Black
        Me.divbtn.HoverState.Parent = Me.divbtn
        Me.divbtn.Location = New System.Drawing.Point(140, 120)
        Me.divbtn.Name = "divbtn"
        Me.divbtn.ShadowDecoration.Parent = Me.divbtn
        Me.divbtn.Size = New System.Drawing.Size(70, 60)
        Me.divbtn.TabIndex = 3
        Me.divbtn.Text = "/"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.activebtn_txt)
        Me.Guna2Panel1.Controls.Add(Me.addbtn)
        Me.Guna2Panel1.Controls.Add(Me.divbtn)
        Me.Guna2Panel1.Controls.Add(Me.calculatebtn)
        Me.Guna2Panel1.Controls.Add(Me.multbtn)
        Me.Guna2Panel1.Controls.Add(Me.subbtn)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.Gainsboro
        Me.Guna2Panel1.Location = New System.Drawing.Point(263, 29)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(233, 257)
        Me.Guna2Panel1.TabIndex = 10
        '
        'activebtn_txt
        '
        Me.activebtn_txt.BackColor = System.Drawing.Color.Transparent
        Me.activebtn_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.activebtn_txt.Location = New System.Drawing.Point(106, 87)
        Me.activebtn_txt.Name = "activebtn_txt"
        Me.activebtn_txt.Size = New System.Drawing.Size(3, 2)
        Me.activebtn_txt.TabIndex = 4
        Me.activebtn_txt.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'exitbtn
        '
        Me.exitbtn.BorderRadius = 10
        Me.exitbtn.CheckedState.Parent = Me.exitbtn
        Me.exitbtn.CustomImages.Parent = Me.exitbtn
        Me.exitbtn.FillColor = System.Drawing.Color.DarkRed
        Me.exitbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.White
        Me.exitbtn.HoverState.Parent = Me.exitbtn
        Me.exitbtn.Location = New System.Drawing.Point(416, 312)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.ShadowDecoration.Parent = Me.exitbtn
        Me.exitbtn.Size = New System.Drawing.Size(80, 40)
        Me.exitbtn.TabIndex = 11
        Me.exitbtn.Text = "Exit"
        '
        'clearbtn
        '
        Me.clearbtn.BorderRadius = 10
        Me.clearbtn.CheckedState.Parent = Me.clearbtn
        Me.clearbtn.CustomImages.Parent = Me.clearbtn
        Me.clearbtn.FillColor = System.Drawing.Color.Black
        Me.clearbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.HoverState.Parent = Me.clearbtn
        Me.clearbtn.Location = New System.Drawing.Point(263, 313)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.ShadowDecoration.Parent = Me.clearbtn
        Me.clearbtn.Size = New System.Drawing.Size(80, 40)
        Me.clearbtn.TabIndex = 12
        Me.clearbtn.Text = "Clear"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(534, 361)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.secondNumber_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.firstNumber_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIMPLE CALCULATOR4"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents firstNumber_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents secondNumber_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents result_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents calculatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents addbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents subbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents multbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents divbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents activebtn_txt As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents exitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clearbtn As Guna.UI2.WinForms.Guna2Button

End Class

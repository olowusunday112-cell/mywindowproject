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
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtYear = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtMonth = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.txtDay = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.birthday_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.birthMonth_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.birthYear_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.calculatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.resultYear_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.resultMonth_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.resultDay_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.exitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clearbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.lblToday = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.YellowGreen
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(323, 35)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(163, 22)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "AGE CALCULATOR"
        Me.Guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(39, 104)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(190, 18)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "ENTER  BIRTH DAY (DD): <font color= ""red"">*</font color>"
        Me.Guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(39, 178)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(216, 18)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "ENTER  BIRTH MONTH (MM): <font color= ""red"">*</font color>"
        Me.Guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(39, 261)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(218, 18)
        Me.Guna2HtmlLabel4.TabIndex = 3
        Me.Guna2HtmlLabel4.Text = "ENTER  BIRTH YEAR (YYYY): <font color= ""red"">*</font color>"
        Me.Guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(362, 315)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(48, 18)
        Me.Guna2HtmlLabel5.TabIndex = 4
        Me.Guna2HtmlLabel5.Text = "AGE: <font color= ""red"">*</font color>"
        Me.Guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'txtYear
        '
        Me.txtYear.BackColor = System.Drawing.Color.Transparent
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtYear.Location = New System.Drawing.Point(59, 358)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(68, 18)
        Me.txtYear.TabIndex = 5
        Me.txtYear.Text = "YEARS: <font color= ""red"">*</font color>"
        Me.txtYear.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMonth
        '
        Me.txtMonth.BackColor = System.Drawing.Color.Transparent
        Me.txtMonth.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonth.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtMonth.Location = New System.Drawing.Point(299, 358)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.Size = New System.Drawing.Size(82, 18)
        Me.txtMonth.TabIndex = 6
        Me.txtMonth.Text = "MONTHS: <font color= ""red"">*</font color>"
        Me.txtMonth.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDay
        '
        Me.txtDay.BackColor = System.Drawing.Color.Transparent
        Me.txtDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDay.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDay.Location = New System.Drawing.Point(557, 358)
        Me.txtDay.Name = "txtDay"
        Me.txtDay.Size = New System.Drawing.Size(58, 18)
        Me.txtDay.TabIndex = 7
        Me.txtDay.Text = "DAYS: <font color= ""red"">*</font color>"
        Me.txtDay.TextAlignment = System.Drawing.ContentAlignment.TopCenter
        '
        'birthday_txt
        '
        Me.birthday_txt.BorderRadius = 10
        Me.birthday_txt.BorderThickness = 0
        Me.birthday_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.birthday_txt.DefaultText = ""
        Me.birthday_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.birthday_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.birthday_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthday_txt.DisabledState.Parent = Me.birthday_txt
        Me.birthday_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthday_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthday_txt.FocusedState.Parent = Me.birthday_txt
        Me.birthday_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthday_txt.ForeColor = System.Drawing.Color.Black
        Me.birthday_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthday_txt.HoverState.Parent = Me.birthday_txt
        Me.birthday_txt.Location = New System.Drawing.Point(277, 104)
        Me.birthday_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.birthday_txt.Name = "birthday_txt"
        Me.birthday_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.birthday_txt.PlaceholderText = ""
        Me.birthday_txt.SelectedText = ""
        Me.birthday_txt.ShadowDecoration.Parent = Me.birthday_txt
        Me.birthday_txt.Size = New System.Drawing.Size(150, 30)
        Me.birthday_txt.TabIndex = 8
        '
        'birthMonth_txt
        '
        Me.birthMonth_txt.BorderRadius = 10
        Me.birthMonth_txt.BorderThickness = 0
        Me.birthMonth_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.birthMonth_txt.DefaultText = ""
        Me.birthMonth_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.birthMonth_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.birthMonth_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthMonth_txt.DisabledState.Parent = Me.birthMonth_txt
        Me.birthMonth_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthMonth_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthMonth_txt.FocusedState.Parent = Me.birthMonth_txt
        Me.birthMonth_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthMonth_txt.ForeColor = System.Drawing.Color.Black
        Me.birthMonth_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthMonth_txt.HoverState.Parent = Me.birthMonth_txt
        Me.birthMonth_txt.Location = New System.Drawing.Point(277, 178)
        Me.birthMonth_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.birthMonth_txt.Name = "birthMonth_txt"
        Me.birthMonth_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.birthMonth_txt.PlaceholderText = ""
        Me.birthMonth_txt.SelectedText = ""
        Me.birthMonth_txt.ShadowDecoration.Parent = Me.birthMonth_txt
        Me.birthMonth_txt.Size = New System.Drawing.Size(150, 30)
        Me.birthMonth_txt.TabIndex = 9
        '
        'birthYear_txt
        '
        Me.birthYear_txt.BorderRadius = 10
        Me.birthYear_txt.BorderThickness = 0
        Me.birthYear_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.birthYear_txt.DefaultText = ""
        Me.birthYear_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.birthYear_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.birthYear_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthYear_txt.DisabledState.Parent = Me.birthYear_txt
        Me.birthYear_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.birthYear_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthYear_txt.FocusedState.Parent = Me.birthYear_txt
        Me.birthYear_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.birthYear_txt.ForeColor = System.Drawing.Color.Black
        Me.birthYear_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.birthYear_txt.HoverState.Parent = Me.birthYear_txt
        Me.birthYear_txt.Location = New System.Drawing.Point(277, 249)
        Me.birthYear_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.birthYear_txt.Name = "birthYear_txt"
        Me.birthYear_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.birthYear_txt.PlaceholderText = ""
        Me.birthYear_txt.SelectedText = ""
        Me.birthYear_txt.ShadowDecoration.Parent = Me.birthYear_txt
        Me.birthYear_txt.Size = New System.Drawing.Size(150, 30)
        Me.birthYear_txt.TabIndex = 10
        '
        'calculatebtn
        '
        Me.calculatebtn.BorderRadius = 10
        Me.calculatebtn.CheckedState.Parent = Me.calculatebtn
        Me.calculatebtn.CustomImages.Parent = Me.calculatebtn
        Me.calculatebtn.FillColor = System.Drawing.Color.YellowGreen
        Me.calculatebtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatebtn.ForeColor = System.Drawing.Color.White
        Me.calculatebtn.HoverState.Parent = Me.calculatebtn
        Me.calculatebtn.Location = New System.Drawing.Point(543, 166)
        Me.calculatebtn.Name = "calculatebtn"
        Me.calculatebtn.ShadowDecoration.Parent = Me.calculatebtn
        Me.calculatebtn.Size = New System.Drawing.Size(180, 45)
        Me.calculatebtn.TabIndex = 11
        Me.calculatebtn.Text = "CALCULATE"
        '
        'resultYear_txt
        '
        Me.resultYear_txt.BorderRadius = 10
        Me.resultYear_txt.BorderThickness = 0
        Me.resultYear_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.resultYear_txt.DefaultText = ""
        Me.resultYear_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.resultYear_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.resultYear_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultYear_txt.DisabledState.Parent = Me.resultYear_txt
        Me.resultYear_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultYear_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultYear_txt.FocusedState.Parent = Me.resultYear_txt
        Me.resultYear_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultYear_txt.ForeColor = System.Drawing.Color.Black
        Me.resultYear_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultYear_txt.HoverState.Parent = Me.resultYear_txt
        Me.resultYear_txt.Location = New System.Drawing.Point(136, 349)
        Me.resultYear_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.resultYear_txt.Name = "resultYear_txt"
        Me.resultYear_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.resultYear_txt.PlaceholderText = ""
        Me.resultYear_txt.SelectedText = ""
        Me.resultYear_txt.ShadowDecoration.Parent = Me.resultYear_txt
        Me.resultYear_txt.Size = New System.Drawing.Size(150, 30)
        Me.resultYear_txt.TabIndex = 12
        '
        'resultMonth_txt
        '
        Me.resultMonth_txt.BorderRadius = 10
        Me.resultMonth_txt.BorderThickness = 0
        Me.resultMonth_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.resultMonth_txt.DefaultText = ""
        Me.resultMonth_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.resultMonth_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.resultMonth_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultMonth_txt.DisabledState.Parent = Me.resultMonth_txt
        Me.resultMonth_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultMonth_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultMonth_txt.FocusedState.Parent = Me.resultMonth_txt
        Me.resultMonth_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultMonth_txt.ForeColor = System.Drawing.Color.Black
        Me.resultMonth_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultMonth_txt.HoverState.Parent = Me.resultMonth_txt
        Me.resultMonth_txt.Location = New System.Drawing.Point(391, 350)
        Me.resultMonth_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.resultMonth_txt.Name = "resultMonth_txt"
        Me.resultMonth_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.resultMonth_txt.PlaceholderText = ""
        Me.resultMonth_txt.SelectedText = ""
        Me.resultMonth_txt.ShadowDecoration.Parent = Me.resultMonth_txt
        Me.resultMonth_txt.Size = New System.Drawing.Size(150, 30)
        Me.resultMonth_txt.TabIndex = 13
        '
        'resultDay_txt
        '
        Me.resultDay_txt.BorderRadius = 10
        Me.resultDay_txt.BorderThickness = 0
        Me.resultDay_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.resultDay_txt.DefaultText = ""
        Me.resultDay_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.resultDay_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.resultDay_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultDay_txt.DisabledState.Parent = Me.resultDay_txt
        Me.resultDay_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.resultDay_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultDay_txt.FocusedState.Parent = Me.resultDay_txt
        Me.resultDay_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.resultDay_txt.ForeColor = System.Drawing.Color.Black
        Me.resultDay_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.resultDay_txt.HoverState.Parent = Me.resultDay_txt
        Me.resultDay_txt.Location = New System.Drawing.Point(638, 349)
        Me.resultDay_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.resultDay_txt.Name = "resultDay_txt"
        Me.resultDay_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.resultDay_txt.PlaceholderText = ""
        Me.resultDay_txt.SelectedText = ""
        Me.resultDay_txt.ShadowDecoration.Parent = Me.resultDay_txt
        Me.resultDay_txt.Size = New System.Drawing.Size(150, 30)
        Me.resultDay_txt.TabIndex = 14
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
        Me.exitbtn.Location = New System.Drawing.Point(475, 433)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.ShadowDecoration.Parent = Me.exitbtn
        Me.exitbtn.Size = New System.Drawing.Size(99, 45)
        Me.exitbtn.TabIndex = 15
        Me.exitbtn.Text = "EXIT"
        '
        'clearbtn
        '
        Me.clearbtn.BorderRadius = 10
        Me.clearbtn.CheckedState.Parent = Me.clearbtn
        Me.clearbtn.CustomImages.Parent = Me.clearbtn
        Me.clearbtn.FillColor = System.Drawing.Color.DarkOrange
        Me.clearbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.HoverState.Parent = Me.clearbtn
        Me.clearbtn.Location = New System.Drawing.Point(643, 433)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.ShadowDecoration.Parent = Me.clearbtn
        Me.clearbtn.Size = New System.Drawing.Size(99, 45)
        Me.clearbtn.TabIndex = 16
        Me.clearbtn.Text = "CLEAR"
        '
        'lblToday
        '
        Me.lblToday.BackColor = System.Drawing.Color.Transparent
        Me.lblToday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToday.Location = New System.Drawing.Point(617, 58)
        Me.lblToday.Name = "lblToday"
        Me.lblToday.Size = New System.Drawing.Size(3, 2)
        Me.lblToday.TabIndex = 17
        Me.lblToday.Text = Nothing
        Me.lblToday.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(834, 511)
        Me.Controls.Add(Me.lblToday)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.resultDay_txt)
        Me.Controls.Add(Me.resultMonth_txt)
        Me.Controls.Add(Me.resultYear_txt)
        Me.Controls.Add(Me.calculatebtn)
        Me.Controls.Add(Me.birthYear_txt)
        Me.Controls.Add(Me.birthMonth_txt)
        Me.Controls.Add(Me.birthday_txt)
        Me.Controls.Add(Me.txtDay)
        Me.Controls.Add(Me.txtMonth)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Age Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtYear As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtMonth As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtDay As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents birthday_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents birthMonth_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents birthYear_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents calculatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents resultYear_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents resultMonth_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents resultDay_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents exitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clearbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblToday As Guna.UI2.WinForms.Guna2HtmlLabel

End Class

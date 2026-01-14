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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.amount_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.duration_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.calculatebtn = New Guna.UI2.WinForms.Guna2Button()
        Me.totalLoan_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.totalInterest_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.totalRepay_txt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.monthlyGrid = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.exitbtn = New Guna.UI2.WinForms.Guna2Button()
        Me.clearbtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.monthlyGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(357, 27)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(216, 22)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "LOAN APP CALCULATION"
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(28, 85)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(225, 18)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "ENTER YOUR LOAN AMOUNT <font color = ""red>*</font color>"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(28, 198)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(239, 18)
        Me.Guna2HtmlLabel3.TabIndex = 2
        Me.Guna2HtmlLabel3.Text = "ENTER YOUR LOAN DURATION <font color = ""red>*</font color>"
        '
        'amount_txt
        '
        Me.amount_txt.BorderRadius = 10
        Me.amount_txt.BorderThickness = 0
        Me.amount_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amount_txt.DefaultText = ""
        Me.amount_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.amount_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.amount_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amount_txt.DisabledState.Parent = Me.amount_txt
        Me.amount_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.amount_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.amount_txt.FocusedState.Parent = Me.amount_txt
        Me.amount_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amount_txt.ForeColor = System.Drawing.Color.Black
        Me.amount_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.amount_txt.HoverState.Parent = Me.amount_txt
        Me.amount_txt.Location = New System.Drawing.Point(28, 124)
        Me.amount_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.amount_txt.Name = "amount_txt"
        Me.amount_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.amount_txt.PlaceholderText = ""
        Me.amount_txt.SelectedText = ""
        Me.amount_txt.ShadowDecoration.Parent = Me.amount_txt
        Me.amount_txt.Size = New System.Drawing.Size(150, 30)
        Me.amount_txt.TabIndex = 3
        '
        'duration_txt
        '
        Me.duration_txt.BorderRadius = 10
        Me.duration_txt.BorderThickness = 0
        Me.duration_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.duration_txt.DefaultText = ""
        Me.duration_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.duration_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.duration_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.duration_txt.DisabledState.Parent = Me.duration_txt
        Me.duration_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.duration_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.duration_txt.FocusedState.Parent = Me.duration_txt
        Me.duration_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.duration_txt.ForeColor = System.Drawing.Color.Black
        Me.duration_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.duration_txt.HoverState.Parent = Me.duration_txt
        Me.duration_txt.Location = New System.Drawing.Point(28, 241)
        Me.duration_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.duration_txt.Name = "duration_txt"
        Me.duration_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.duration_txt.PlaceholderText = ""
        Me.duration_txt.SelectedText = ""
        Me.duration_txt.ShadowDecoration.Parent = Me.duration_txt
        Me.duration_txt.Size = New System.Drawing.Size(150, 30)
        Me.duration_txt.TabIndex = 4
        '
        'calculatebtn
        '
        Me.calculatebtn.CheckedState.Parent = Me.calculatebtn
        Me.calculatebtn.CustomImages.Parent = Me.calculatebtn
        Me.calculatebtn.FillColor = System.Drawing.Color.Green
        Me.calculatebtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculatebtn.ForeColor = System.Drawing.Color.White
        Me.calculatebtn.HoverState.Parent = Me.calculatebtn
        Me.calculatebtn.Location = New System.Drawing.Point(339, 226)
        Me.calculatebtn.Name = "calculatebtn"
        Me.calculatebtn.ShadowDecoration.Parent = Me.calculatebtn
        Me.calculatebtn.Size = New System.Drawing.Size(180, 45)
        Me.calculatebtn.TabIndex = 5
        Me.calculatebtn.Text = "CALCULATE"
        '
        'totalLoan_txt
        '
        Me.totalLoan_txt.BorderRadius = 10
        Me.totalLoan_txt.BorderThickness = 0
        Me.totalLoan_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalLoan_txt.DefaultText = ""
        Me.totalLoan_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalLoan_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalLoan_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalLoan_txt.DisabledState.Parent = Me.totalLoan_txt
        Me.totalLoan_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalLoan_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalLoan_txt.FocusedState.Parent = Me.totalLoan_txt
        Me.totalLoan_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLoan_txt.ForeColor = System.Drawing.Color.Black
        Me.totalLoan_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalLoan_txt.HoverState.Parent = Me.totalLoan_txt
        Me.totalLoan_txt.Location = New System.Drawing.Point(28, 375)
        Me.totalLoan_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalLoan_txt.Name = "totalLoan_txt"
        Me.totalLoan_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalLoan_txt.PlaceholderText = ""
        Me.totalLoan_txt.SelectedText = ""
        Me.totalLoan_txt.ShadowDecoration.Parent = Me.totalLoan_txt
        Me.totalLoan_txt.Size = New System.Drawing.Size(150, 30)
        Me.totalLoan_txt.TabIndex = 8
        '
        'totalInterest_txt
        '
        Me.totalInterest_txt.BorderRadius = 10
        Me.totalInterest_txt.BorderThickness = 0
        Me.totalInterest_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalInterest_txt.DefaultText = ""
        Me.totalInterest_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalInterest_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalInterest_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalInterest_txt.DisabledState.Parent = Me.totalInterest_txt
        Me.totalInterest_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalInterest_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalInterest_txt.FocusedState.Parent = Me.totalInterest_txt
        Me.totalInterest_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalInterest_txt.ForeColor = System.Drawing.Color.Black
        Me.totalInterest_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalInterest_txt.HoverState.Parent = Me.totalInterest_txt
        Me.totalInterest_txt.Location = New System.Drawing.Point(219, 375)
        Me.totalInterest_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalInterest_txt.Name = "totalInterest_txt"
        Me.totalInterest_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalInterest_txt.PlaceholderText = ""
        Me.totalInterest_txt.SelectedText = ""
        Me.totalInterest_txt.ShadowDecoration.Parent = Me.totalInterest_txt
        Me.totalInterest_txt.Size = New System.Drawing.Size(150, 30)
        Me.totalInterest_txt.TabIndex = 9
        '
        'totalRepay_txt
        '
        Me.totalRepay_txt.BorderRadius = 10
        Me.totalRepay_txt.BorderThickness = 0
        Me.totalRepay_txt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.totalRepay_txt.DefaultText = ""
        Me.totalRepay_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.totalRepay_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.totalRepay_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalRepay_txt.DisabledState.Parent = Me.totalRepay_txt
        Me.totalRepay_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.totalRepay_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalRepay_txt.FocusedState.Parent = Me.totalRepay_txt
        Me.totalRepay_txt.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalRepay_txt.ForeColor = System.Drawing.Color.Black
        Me.totalRepay_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.totalRepay_txt.HoverState.Parent = Me.totalRepay_txt
        Me.totalRepay_txt.Location = New System.Drawing.Point(447, 375)
        Me.totalRepay_txt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.totalRepay_txt.Name = "totalRepay_txt"
        Me.totalRepay_txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.totalRepay_txt.PlaceholderText = ""
        Me.totalRepay_txt.SelectedText = ""
        Me.totalRepay_txt.ShadowDecoration.Parent = Me.totalRepay_txt
        Me.totalRepay_txt.Size = New System.Drawing.Size(150, 30)
        Me.totalRepay_txt.TabIndex = 10
        '
        'monthlyGrid
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.monthlyGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.monthlyGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.monthlyGrid.BackgroundColor = System.Drawing.SystemColors.Control
        Me.monthlyGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.monthlyGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.monthlyGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.monthlyGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.monthlyGrid.ColumnHeadersHeight = 50
        Me.monthlyGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.monthlyGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.monthlyGrid.EnableHeadersVisualStyles = False
        Me.monthlyGrid.GridColor = System.Drawing.Color.Gray
        Me.monthlyGrid.Location = New System.Drawing.Point(619, 47)
        Me.monthlyGrid.Name = "monthlyGrid"
        Me.monthlyGrid.RowHeadersVisible = False
        Me.monthlyGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.monthlyGrid.Size = New System.Drawing.Size(553, 336)
        Me.monthlyGrid.TabIndex = 11
        Me.monthlyGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.monthlyGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.monthlyGrid.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.monthlyGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.monthlyGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.monthlyGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.monthlyGrid.ThemeStyle.BackColor = System.Drawing.SystemColors.Control
        Me.monthlyGrid.ThemeStyle.GridColor = System.Drawing.Color.Gray
        Me.monthlyGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.monthlyGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.monthlyGrid.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthlyGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.monthlyGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.monthlyGrid.ThemeStyle.HeaderStyle.Height = 50
        Me.monthlyGrid.ThemeStyle.ReadOnly = False
        Me.monthlyGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.monthlyGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.monthlyGrid.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.monthlyGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.monthlyGrid.ThemeStyle.RowsStyle.Height = 22
        Me.monthlyGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.monthlyGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "MONTH"
        Me.Column1.Name = "Column1"
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "MONTHLY REPAYMENT"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "MONTHLY INTEREST"
        Me.Column4.Name = "Column4"
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column2.HeaderText = "TOTAL MONTHLY REPAYMENT"
        Me.Column2.Name = "Column2"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(40, 344)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(96, 18)
        Me.Guna2HtmlLabel5.TabIndex = 12
        Me.Guna2HtmlLabel5.Text = "TOTAL LOAN "
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(219, 344)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(132, 18)
        Me.Guna2HtmlLabel6.TabIndex = 13
        Me.Guna2HtmlLabel6.Text = "TOTAL INTEREST "
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.ForeColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(447, 344)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(150, 18)
        Me.Guna2HtmlLabel7.TabIndex = 14
        Me.Guna2HtmlLabel7.Text = "TOTAL REPAYMENT "
        '
        'exitbtn
        '
        Me.exitbtn.CheckedState.Parent = Me.exitbtn
        Me.exitbtn.CustomImages.Parent = Me.exitbtn
        Me.exitbtn.FillColor = System.Drawing.Color.DarkRed
        Me.exitbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitbtn.ForeColor = System.Drawing.Color.White
        Me.exitbtn.HoverState.Parent = Me.exitbtn
        Me.exitbtn.Location = New System.Drawing.Point(28, 454)
        Me.exitbtn.Name = "exitbtn"
        Me.exitbtn.ShadowDecoration.Parent = Me.exitbtn
        Me.exitbtn.Size = New System.Drawing.Size(101, 45)
        Me.exitbtn.TabIndex = 15
        Me.exitbtn.Text = "EXIT"
        '
        'clearbtn
        '
        Me.clearbtn.CheckedState.Parent = Me.clearbtn
        Me.clearbtn.CustomImages.Parent = Me.clearbtn
        Me.clearbtn.FillColor = System.Drawing.Color.DarkOrange
        Me.clearbtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.HoverState.Parent = Me.clearbtn
        Me.clearbtn.Location = New System.Drawing.Point(561, 454)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.ShadowDecoration.Parent = Me.clearbtn
        Me.clearbtn.Size = New System.Drawing.Size(101, 45)
        Me.clearbtn.TabIndex = 16
        Me.clearbtn.Text = "CLEAR"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1184, 511)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.exitbtn)
        Me.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Controls.Add(Me.monthlyGrid)
        Me.Controls.Add(Me.totalRepay_txt)
        Me.Controls.Add(Me.totalInterest_txt)
        Me.Controls.Add(Me.totalLoan_txt)
        Me.Controls.Add(Me.calculatebtn)
        Me.Controls.Add(Me.duration_txt)
        Me.Controls.Add(Me.amount_txt)
        Me.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.monthlyGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents amount_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents duration_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents calculatebtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents totalLoan_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents totalInterest_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents totalRepay_txt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents monthlyGrid As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents exitbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents clearbtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn

End Class

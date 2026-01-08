<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class jobCard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.JobTitlelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CompanyNamelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.JobType = New Guna.UI2.WinForms.Guna2Chip()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderRadius = 15
        Me.Guna2Panel1.Controls.Add(Me.JobType)
        Me.Guna2Panel1.Controls.Add(Me.CompanyNamelbl)
        Me.Guna2Panel1.Controls.Add(Me.JobTitlelbl)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.FillColor = System.Drawing.Color.White
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(330, 130)
        Me.Guna2Panel1.TabIndex = 0
        '
        'JobTitlelbl
        '
        Me.JobTitlelbl.BackColor = System.Drawing.Color.Transparent
        Me.JobTitlelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JobTitlelbl.Location = New System.Drawing.Point(13, 19)
        Me.JobTitlelbl.Name = "JobTitlelbl"
        Me.JobTitlelbl.Size = New System.Drawing.Size(107, 15)
        Me.JobTitlelbl.TabIndex = 0
        Me.JobTitlelbl.Text = "Software Engineer"
        '
        'CompanyNamelbl
        '
        Me.CompanyNamelbl.BackColor = System.Drawing.Color.Transparent
        Me.CompanyNamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompanyNamelbl.ForeColor = System.Drawing.Color.DarkGray
        Me.CompanyNamelbl.Location = New System.Drawing.Point(13, 44)
        Me.CompanyNamelbl.Name = "CompanyNamelbl"
        Me.CompanyNamelbl.Size = New System.Drawing.Size(107, 15)
        Me.CompanyNamelbl.TabIndex = 1
        Me.CompanyNamelbl.Text = "Tech Solution inc."
        '
        'JobType
        '
        Me.JobType.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.JobType.ForeColor = System.Drawing.Color.White
        Me.JobType.Location = New System.Drawing.Point(242, 94)
        Me.JobType.Name = "JobType"
        Me.JobType.ShadowDecoration.Parent = Me.JobType
        Me.JobType.Size = New System.Drawing.Size(75, 23)
        Me.JobType.TabIndex = 2
        Me.JobType.Text = "Full Time"
        Me.JobType.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'jobCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Name = "jobCard"
        Me.Size = New System.Drawing.Size(330, 130)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents JobType As Guna.UI2.WinForms.Guna2Chip
    Friend WithEvents CompanyNamelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents JobTitlelbl As Guna.UI2.WinForms.Guna2HtmlLabel

End Class

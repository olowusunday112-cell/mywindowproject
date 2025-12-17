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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.firstNumber_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.secondNumber_txt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.result_txt = New System.Windows.Forms.TextBox()
        Me.sumCalculateBtm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(99, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SUM OF TWO NUMBER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter First Number"
        '
        'firstNumber_txt
        '
        Me.firstNumber_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstNumber_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstNumber_txt.Location = New System.Drawing.Point(108, 105)
        Me.firstNumber_txt.Multiline = True
        Me.firstNumber_txt.Name = "firstNumber_txt"
        Me.firstNumber_txt.Size = New System.Drawing.Size(150, 30)
        Me.firstNumber_txt.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Enter Second Number"
        '
        'secondNumber_txt
        '
        Me.secondNumber_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.secondNumber_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.secondNumber_txt.Location = New System.Drawing.Point(107, 186)
        Me.secondNumber_txt.Multiline = True
        Me.secondNumber_txt.Name = "secondNumber_txt"
        Me.secondNumber_txt.Size = New System.Drawing.Size(150, 30)
        Me.secondNumber_txt.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(148, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Result"
        '
        'result_txt
        '
        Me.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.result_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.result_txt.Location = New System.Drawing.Point(107, 319)
        Me.result_txt.Multiline = True
        Me.result_txt.Name = "result_txt"
        Me.result_txt.Size = New System.Drawing.Size(150, 30)
        Me.result_txt.TabIndex = 6
        '
        'sumCalculateBtm
        '
        Me.sumCalculateBtm.BackColor = System.Drawing.Color.Navy
        Me.sumCalculateBtm.FlatAppearance.BorderSize = 0
        Me.sumCalculateBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.sumCalculateBtm.ForeColor = System.Drawing.Color.White
        Me.sumCalculateBtm.Location = New System.Drawing.Point(107, 241)
        Me.sumCalculateBtm.Name = "sumCalculateBtm"
        Me.sumCalculateBtm.Size = New System.Drawing.Size(150, 30)
        Me.sumCalculateBtm.TabIndex = 7
        Me.sumCalculateBtm.Text = "Calculate"
        Me.sumCalculateBtm.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(364, 361)
        Me.Controls.Add(Me.sumCalculateBtm)
        Me.Controls.Add(Me.result_txt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.secondNumber_txt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.firstNumber_txt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUM 2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents firstNumber_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents secondNumber_txt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents result_txt As System.Windows.Forms.TextBox
    Friend WithEvents sumCalculateBtm As System.Windows.Forms.Button

End Class

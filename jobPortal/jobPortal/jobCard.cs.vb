Public Class jobCard
    ' This allows you to change the Title from Form1
    Public Property JobTitle As String
        Get
            Return JobTitlelbl.Text ' Replace Guna2HtmlLabel1 with your actual label name
        End Get
        Set(ByVal value As String)
            JobTitlelbl.Text = value
        End Set
    End Property

    ' This allows you to change the Company Name
    Public Property SetCompanyName As String
        Get
            Return CompanyNamelbl.Text
        End Get
        Set(ByVal value As String)
            CompanyNamelbl.Text = value
        End Set
    End Property
End Class

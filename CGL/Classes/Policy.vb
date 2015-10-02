Public Class Policy
    Private Shared db As Database = New Database("cgl")
    
    Public Shared Function GetNextCompany()
        Return db.Query("SELECT c.company_id, COUNT(p.company_id) AS policies FROM companies as c LEFT JOIN policies as p USING(company_id) GROUP BY c.company_id HAVING policies < 10 ORDER BY policies DESC").Tables(0).Rows(0)("company_id")
    End Function
    Public Shared Function GetCompaniesAvailable()
        Return db.Query("SELECT c.company_id, c.company_name, COUNT(p.company_id) AS policies FROM companies as c LEFT JOIN policies as p USING(company_id) GROUP BY c.company_id HAVING policies < 10 ORDER BY policies DESC").Tables(0)
    End Function
End Class

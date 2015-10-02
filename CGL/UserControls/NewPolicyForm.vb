Public Class NewPolicyForm
    Dim db As Database = New Database("cgl")
    Dim current_policy_count As Integer = 0
    Dim current_policy_number As String = 0
    Dim policy_id As String
    Public Sub calculate()
        If Not (txtArea.Text.Equals("")) AndAlso IsNumeric(txtArea.Text) Then
            Dim values As String() = Floor.GetValues(Integer.Parse(txtArea.Text))
            Dim dbl_values As New List(Of Double)
            Dim evat As String = Double.Parse(txtEVAT.Text)
            For i = 0 To values.Count - 1
                If Not i = 2 Then
                    dbl_values.Add(Double.Parse(values(i)))
                Else
                    dbl_values.Add(evat)
                End If
            Next
            Dim sum = dbl_values.Item(1) + dbl_values.Item(2) + dbl_values.Item(3) + dbl_values.Item(4) + dbl_values.Item(5)
            txtTotal.Text = FormatNumber(CDbl(sum), 2)
        End If
    End Sub
    Private Sub txtArea_TextChanged(sender As Object, e As EventArgs) Handles txtArea.TextChanged
        If Not (txtArea.Text.Equals("")) AndAlso IsNumeric(txtArea.Text) Then
            Dim values As String() = Floor.GetValues(Integer.Parse(txtArea.Text))
            '{ sum insured, net premium, vat, doc stamp, lgt, conn fee }
            txtLiability.Text = FormatNumber(CDbl(values(0)), 2)
            txtPremium.Text = FormatNumber(CDbl(values(1)), 2)
            txtStamp.Text = FormatNumber(CDbl(values(3)), 2)
            txtEVAT.Text = FormatNumber(CDbl(values(2)), 2)
            txtLGT.Text = FormatNumber(CDbl(values(4)), 2)
            txtFee.Text = FormatNumber(CDbl(values(5)), 2)
        End If
    End Sub
    Private Sub txtEVAT_TextChanged(sender As Object, e As EventArgs) Handles txtEVAT.TextChanged
        calculate()
    End Sub
    Public Function GetPolicyNumber(ByVal company_id As String)
        'get all policies from this company
        Dim where_clause = String.Format("company_id='{0}'", company_id)
        Dim policy_count = db.SelectCommand("policies", True, where_clause).Tables(0).Rows.Count + 1
        Dim policy_begin = db.SelectCommand("companies", True, where_clause).Tables(0).Rows(0)("company_begin")
        Dim contains_zero = False
        If Not policy_count = Nothing Or Not policy_count.Equals("") Then
            If policy_count > 10 Then
                Return False
                Exit Function
            End If
        End If
        If Not policy_begin Is Nothing Or Not policy_begin.Equals("") Then
            'check if policy begins with zero and remove it
            If policy_begin(0) = "0" Then
                contains_zero = True
            End If


            If contains_zero Then
                current_policy_number = "0" & (Integer.Parse(policy_begin) + policy_count)
            Else
                current_policy_number = (Integer.Parse(policy_begin) + policy_count)
            End If
            current_policy_count = policy_count
            If (current_policy_count < 10) Then
                lblPolicyNumber.Text = "0" & current_policy_count
            Else
                lblPolicyNumber.Text = current_policy_count
            End If

        End If
        Return current_policy_number
    End Function
    Dim company_id As String = "1"
    Public Sub loadOR(ByVal policy_id As String)
        Dim frm As New MainForm
        With frm
            .Text = "Payment Form"
            .LoadControl(New ORForm(policy_id))
            .ShowDialog()
        End With
    End Sub
    Public Sub PopulateDropDown()
        Dim dd As ComboBox = txtCompany
        With dd
            .DataSource = Policy.GetCompaniesAvailable()
            .ValueMember = "company_id"
            .DisplayMember = "company_name"
        End With

    End Sub
    Public Sub LoadForm()
        Dim policy_number = GetPolicyNumber(company_id)
        If (policy_number) Then
            Dim company = db.SelectCommand("companies", True, String.Format("company_id='{0}'", company_id)).Tables(0).Rows(0)
            txtCompany.Text = company("company_name")
            txtPolicy.Text = policy_number
        End If
    End Sub
    Public Sub SaveForm()
        'get all necessary details from form
        Dim cust_name = txtName.Text 'search for new customer for now assumes all customers are unique
        Dim inception = Format(dtInception.Value, "yyyy-MM-dd")
        Dim expiration = Format(dtExpiration.Value, "yyyy-MM-dd")
        Dim street = txtStreet.Text
        Dim barangay = cbBarangay.SelectedValue
        Dim line = txtLine.Text
        Dim area = txtArea.Text
        Dim evat = txtEVAT.Text
        Dim total = txtTotal.Text
        'create sql
        'create customer row
        Dim customer_fields = Database.CreateFields({"customer_name", "customer_inception", "customer_expiration", "customer_street", "customer_barangay", "customer_city", "customer_business"})
        Dim customer_values = Database.CreateValues({cust_name, inception, expiration, street, barangay, txtCity.Text, line})

        Dim customer_id = db.InsertToDatabase("customers", customer_fields, customer_values)

        'create policy using customer_id
        Dim policy_fields = Database.CreateFields({"company_id", "customer_id", "policy_number", "policy_area", "policy_evat", "policy_total"})
        Dim policy_values = Database.CreateValues({company_id, customer_id, current_policy_number, area, evat, total})
        policy_id = db.InsertToDatabase("policies", policy_fields, policy_values)
        MsgBox("Policy Created!")
        loadOR(policy_id)
        ParentForm.Close()
    End Sub
    Private Sub NewPolicyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        company_id = Policy.GetNextCompany()
        PopulateDropDown()
        LoadForm() '1 is company_id
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveForm()
    End Sub


    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Dim policy_number = GetPolicyNumber(txtCompany.SelectedValue)
        If (policy_number) Then
            Dim company = db.SelectCommand("companies", True, String.Format("company_id='{0}'", txtCompany.SelectedValue)).Tables(0).Rows(0)
            txtCompany.Text = company("company_name")
            txtPolicy.Text = policy_number
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ParentForm.Close()
    End Sub

    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        If Not policy_id Is Nothing Then
            loadOR(policy_id)
        End If
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click, btnPrintOR.Click
        MsgBox("Implementation on next update")
    End Sub

    
End Class

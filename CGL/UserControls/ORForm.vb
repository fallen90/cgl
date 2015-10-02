Public Class ORForm
    Dim db As Database = New Database("cgl")
    Private policy_id As String
    Public Sub New(Optional ByVal policy_id As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If Not (policy_id.Equals("")) Then
            Me.policy_id = policy_id
        End If
    End Sub

    Private Sub ORForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim policy = db.SelectCommand("policies", True, String.Format("policy_id='{0}'", Me.policy_id)).Tables(0).Rows(0)
        Dim customer = db.SelectCommand("customers", True, String.Format("customer_id='{0}'", policy("customer_id"))).Tables(0).Rows(0)
        Dim company = db.SelectCommand("companies", True, String.Format("company_id='{0}'", policy("company_id"))).Tables(0).Rows(0)

        txtCompany.Text = company("company_name")
        txtPolicy.Text = policy("policy_number")
        txtName.Text = customer("customer_name")
        dtInception.Value = customer("customer_inception")
        dtExpiration.Value = customer("customer_expiration")
        txtStreet.Text = customer("customer_street")
        cbBarangay.Text = customer("customer_barangay")
        txtCity.Text = customer("customer_city")
        txtLine.Text = customer("customer_business")

        txtArea.Text = policy("policy_area")
        txtEVAT.Text = policy("policy_evat")

        Dim values As String() = Floor.GetValues(Integer.Parse(txtArea.Text))
        '{ sum insured, net premium, vat, doc stamp, lgt, conn fee }
        txtLiability.Text = FormatNumber(CDbl(values(0)), 2)
        txtPremium.Text = FormatNumber(CDbl(values(1)), 2)
        txtStamp.Text = FormatNumber(CDbl(values(3)), 2)
        txtLGT.Text = FormatNumber(CDbl(values(4)), 2)
        txtFee.Text = FormatNumber(CDbl(values(5)), 2)

        calculate()
    End Sub
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
            txtAmount.Text = txtTotal.Text
        End If
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles cbCheck.CheckedChanged
        pnlCheck.Enabled = cbCheck.Checked
    End Sub

    Private Sub txtTendered_TextChanged(sender As Object, e As EventArgs) Handles txtTendered.TextChanged
        Try
            Dim amount = txtAmount.Text
            Dim tendered = txtTendered.Text
            Dim change = Double.Parse(tendered) - Double.Parse(amount)
            txtChange.Text = change
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPrintOR_Click(sender As Object, e As EventArgs) Handles btnPrintOR.Click
        'get all data
        Dim ornum = txtORNumber.Text
        Dim ordate = Format(dtDate.Value, "yyyy-MM-dd")
        Dim ischeck = cbCheck.Checked
        Dim bank = txtBank.Text
        Dim checknum = txtCheckNumber.Text
        Dim documents = txtDocuments.Text
        Dim except = txtException.Text
        Dim amount = txtAmount.Text
        'save
        Dim fields As String = Database.CreateFields({"reciept_number", "reciept_date", "reciept_ischeck", "reciept_bank", "reciept_checknumber", "reciept_documents", "reciept_exception", "reciept_amount", "policy_id"})
        Dim values As String = Database.CreateValues({ornum, ordate, ischeck, bank, checknum, documents, except, amount, policy_id})
        Dim reciept_id = db.InsertToDatabase("reciepts", fields, values)
        MsgBox("Reciept has been saved, for the mean time, this is the message, but it should show the report printer")
    End Sub
End Class

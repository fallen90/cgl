Public Class PolicyForm
    Dim db As Database = New Database("cgl")
    Public Sub populate()
        Try
            ListView1.Items.Clear()
            Dim ds As DataSet = db.SelectCommand("policies", True, "1=1 ORDER BY company_id ASC")
            ParentForm.Text = ds.Tables(0).Rows.Count & " policies available"
            For Each dr As DataRow In ds.Tables(0).Rows
                Dim lv As New ListViewItem

                With ds.Tables(0)
                    Dim policy = dr
                    Dim company = db.SelectCommand("companies", True, String.Format("company_id='{0}'", policy("company_id"))).Tables(0).Rows(0)
                    Dim customer = db.SelectCommand("customers", True, String.Format("customer_id='{0}'", policy("customer_id"))).Tables(0).Rows(0)
                    With lv
                        .Text = policy("policy_id")
                        .SubItems.Add(policy("company_id"))
                        .SubItems.Add(policy("customer_id"))
                        .SubItems.Add(company("company_name"))
                        .SubItems.Add(policy("policy_number"))
                        .SubItems.Add(customer("customer_name"))
                        .SubItems.Add(policy("policy_timestamp").ToString())
                    End With
                    ListView1.Items.Add(lv)
                End With
            Next
            
        Catch ex As Exception

        End Try
    End Sub
    Private Sub PolicyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        'show policy form
    End Sub

    Private Sub btnRenew_Click(sender As Object, e As EventArgs) Handles btnRenew.Click
        'renew?
        Dim result As Integer = MessageBox.Show("Renew " & ListView1.FocusedItem.SubItems(5).Text & "?", "Delete Company", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            db.UpdateTimestamp("policies", "policy_timestamp", String.Format("policy_id='{0}'", ListView1.FocusedItem.SubItems(0).Text))
            MsgBox("Policy renewed !")
            populate()
        End If

    End Sub


    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        populate()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        MsgBox("Search will be on next update")
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        Dim frm As MainForm = New MainForm

        With frm
            .LoadControl(New NewPolicyForm)
            .ShowDialog()
        End With
    End Sub
End Class

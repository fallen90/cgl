Public Class CompanyForm
    Dim db As Database = New Database("cgl")
    Dim isEditMode As Boolean = False
    Private Sub CompanyForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not (txtCode.Text.Equals("") Or txtName.Text.Equals("") Or txtBegin.Text.Equals("") Or txtEnd.Text.Equals("") Or txtLast.Text.Equals("")) Then
            Dim values() As String = {txtCode.Text, txtName.Text, txtBegin.Text, txtEnd.Text, txtLast.Text}
            Dim fields() As String = {"company_code", "company_name", "company_begin", "company_end", "company_last"}

            If Not isEditMode Then
                db.InsertToDatabase("companies", Database.CreateFields(fields), Database.CreateValues(values))
                MsgBox("Added to List !")
            Else
                Dim where = String.Format("company_id='{0}'", txtId.Text)
                db.UpdateRecords("companies", fields, values, where)
                MsgBox("Company Updated with details given!")
                isEditMode = False
            End If
            populate()
            clearItems()
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        populate()
    End Sub
    Public Sub populate()
        'Populate
        ListView1.Items.Clear()

        Dim ds As DataSet = db.SelectCommand("companies")
        Dim lv As ListViewItem
        Dim i As Int16
        For i = 0 To ds.Tables(0).Rows.Count - 1 'Dataset have multiple tables, here I am reffering the first table
            lv = New ListViewItem

            With ds.Tables(0)
                lv.Text = .Rows(i)("company_id")
                lv.SubItems.Add(.Rows(i)("company_code"))
                lv.SubItems.Add(.Rows(i)("company_name"))
            End With

            ListView1.Items.Add(lv)
        Next
    End Sub
    Public Sub clearItems()
        txtCode.Text = ""
        txtName.Text = ""
        txtBegin.Text = ""
        txtEnd.Text = ""
        txtLast.Text = ""
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        isEditMode = True
        Dim id As String = ListView1.FocusedItem.SubItems(0).Text
        If Not id Is Nothing Then
            Dim ds As DataSet = db.SelectCommand("companies", True, String.Format("company_id='{0}'", id))
            With ds.Tables(0)
                txtId.Text = .Rows(0)("company_id")
                txtCode.Text = .Rows(0)("company_code")
                txtName.Text = .Rows(0)("company_name")
                txtBegin.Text = .Rows(0)("company_begin")
                txtEnd.Text = .Rows(0)("company_end")
                txtLast.Text = .Rows(0)("company_last")
            End With
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim result As Integer = MessageBox.Show("Delete " & ListView1.FocusedItem.SubItems(2).Text & "?", "Delete Company", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                db.DeleteRecord("companies", "company_id", ListView1.FocusedItem.SubItems(0).Text)
                MsgBox("Company Deleted from the list!")
                populate()
                clearItems()
                isEditMode = False
            End If
        Catch ex As Exception
            MsgBox("Nothing to delete, Select item")
        End Try
    End Sub
End Class

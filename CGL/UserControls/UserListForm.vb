Public Class UserListForm
    Dim db As Database = New Database("cgl")
    Private Sub UserListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    Public Sub populate()
        ListView1.Items.Clear()
        Dim users = db.SelectCommand("users").Tables(0)
        For Each user As DataRow In users.Rows
            Dim lv As New ListViewItem

            With lv
                .Text = user("user_id")
                .SubItems.Add(user("user_name"))
                .SubItems.Add(user("user_lastlogged"))
            End With

            ListView1.Items.Add(lv)
        Next
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'gather
        Dim id = txtID.Text
        Dim username = txtUsername.Text
        Dim password = txtPassword.Text
        Dim cpassword = txtCPassword.Text
        If (password.Equals(cpassword)) Then
            If id.Equals("") Then
                Dim count = db.SelectCommand("users", True, String.Format("user_name='{0}'", username)).Tables(0).Rows.Count
                If Not count >= 1 Then
                    'create
                    db.InsertToDatabase("users", Database.CreateFields({"user_name", "user_pass"}), Database.CreateValues({username, password}))
                    MsgBox("User Added!")
                Else
                    MsgBox("Username already taken!")
                End If
            Else
                db.UpdateRecords("users", {"user_name", "user_pass"}, {username, password}, String.Format("user_id='{0}'", id))
                MsgBox("Information Updated!")
            End If
            populate()
            reset()
        Else
            MsgBox("Passwords not matched")
        End If
    End Sub

    Private Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        Dim item As ListViewItem = ListView1.FocusedItem
        'place data
        txtID.Text = item.Text
        txtUsername.Text = item.SubItems(1).Text
    End Sub
    Public Sub reset()
        txtID.Text = ""
        txtUsername.Text = ""
        txtPassword.Text = ""
        txtCPassword.Text = ""
    End Sub
    Private Sub btnNEw_Click(sender As Object, e As EventArgs) Handles btnNEw.Click
        reset()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            Dim item As ListViewItem = ListView1.FocusedItem
            Dim result As Integer = MessageBox.Show("Delete " & ListView1.FocusedItem.SubItems(1).Text & "?", "Delete User", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                db.DeleteRecord("users", "user_id", item.Text)
                MsgBox("Deleted!")
                reset()
                populate()
            End If

        Catch ex As Exception
            MsgBox("Select an item")
        End Try
    End Sub
End Class

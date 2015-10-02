Public Class Home
    Public LoggedIn As Boolean = False
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim frm As MainForm = New MainForm

        With frm
            .LoadControl(New CompanyForm)
            .ShowDialog()
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As MainForm = New MainForm
        With frm
            .LoadControl(New PolicyForm)
            .ShowDialog()
        End With
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Implemented on next update")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm As MainForm = New MainForm
        With frm
            .LoadControl(New UserListForm)
            .ShowDialog()
        End With
    End Sub

    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim frm As MainForm = New MainForm
        With frm
            .LoadControl(New LoginForm)
            .ShowDialog()
        End With
    End Sub
End Class

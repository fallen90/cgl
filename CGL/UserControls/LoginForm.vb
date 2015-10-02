Imports System.Threading
Imports Newtonsoft.Json

Public Class LoginForm
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim db As Database = New Database("cgl")
        Dim username As String = txtUser.Text
        Dim password As String = txtPass.Text

        Dim count = db.SelectCommand("users", True, String.Format("user_name='{0}' AND user_pass='{1}'", username, password)).Tables(0).Rows.Count
        If count >= 1 Then
            MsgBox("Logged In successful!")
            MainForm.Home1.LoggedIn = True
            ParentForm.Close()
        Else
            MsgBox("Invalid Account !")
        End If
    End Sub
End Class



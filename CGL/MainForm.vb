Imports MySql.Data.MySqlClient

Public Class MainForm
    Public isDialog As Boolean = False
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LoadControl(control As UserControl)
        'make parent resize as needed
        MyBase.Size = control.Size
        MyBase.MaximumSize = control.Size
        Dim LocationX As Integer = (Me.ClientSize.Width / 2) - (control.Size.Width / 2)
        Dim LocationY As Integer = (Me.ClientSize.Height / 2) - (control.Size.Height / 2)
        control.Location = New Point(LocationX, LocationY)
        With ContentContainer
            .BackColor = control.BackColor
            .Controls.Clear()
            .Controls.Add(control)
        End With
    End Sub
    Public Sub ReCenter() Handles MyBase.Resize
        For Each control As Control In ContentContainer.Controls
            If TypeOf control Is UserControl Then
                Dim LocationX As Integer = (Me.ClientSize.Width / 2) - (control.Size.Width / 2)
                Dim LocationY As Integer = (Me.ClientSize.Height / 2) - (control.Size.Height / 2)
                control.Location = New Point(LocationX, LocationY)
            End If
        Next
    End Sub

   
End Class

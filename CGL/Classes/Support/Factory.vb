Public Class Factory
    Private Shared db As Database = New Database(Config.DatabaseName)
    Public Shared Function GetObject(Of T)(Optional ByVal where As String = "")
        Dim table As String = GetType(T).ToString.ToLower
        Dim ds As DataSet = Nothing
        If where.Equals("") Then
            ds = db.SelectCommand(table, False)
        Else
            ds = db.SelectCommand(table, True, where)
        End If
        Dim result = JSON.Deserialize(Of T)(ds)
        Return result
    End Function
    Public Shared Function CreateObject(Of T)(ByRef log As Logs, Optional ByVal where As String = "")
        Dim table As String = GetType(T).ToString.ToLower
        Dim ds As DataSet = Nothing
        If where.Equals("") Then
            ds = db.SelectCommand(table, False)
        Else
            ds = db.SelectCommand(table, True, where)
        End If
        Dim result = JSON.Deserialize(Of T)(ds)
        Return result
    End Function
End Class

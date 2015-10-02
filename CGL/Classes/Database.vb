Imports MySql.Data.MySqlClient
Public Class Database
    ''' <summary>
    ''' CREATED BY FALLEN ^_^
    ''' </summary>
    ''' <remarks></remarks>
    ''' 
    Dim ds As DataSet
    Dim sqlcon As MySqlConnection
    Dim da As MySqlDataAdapter
    Dim dr As MySqlDataReader
    Dim cmd As New MySqlCommand
    ''' <summary>
    ''' Flag for database connectivity
    ''' </summary>
    ''' <remarks></remarks>
    Public isOpen As Boolean = False
    ''' <summary>
    ''' Creates new Database Object
    ''' </summary>
    ''' <param name="database_name">Name of the Database to connect to</param>
    ''' <remarks></remarks>
    ''' p
    ''' 

    Public Sub New(ByVal database_name As String)
        sqlcon = New MySqlConnection("Server=localhost;database=" & database_name & ";uid=root;pwd=;Convert Zero Datetime=True")
        cmd.Connection = sqlcon
        sqlcon.Open()
        If sqlcon.State = ConnectionState.Open Then
            isOpen = True
        Else
            isOpen = False
            MsgBox("Error Connecting to MySQL Server")
        End If
    End Sub
    Public Sub New()
        Me.New("seis.net")
    End Sub
    Private Function CreateAdapter(ByVal query As String, ByVal name As String)
        Try
            ds = New DataSet
            da = New MySqlDataAdapter(query, sqlcon)
            da.Fill(ds, name)
            If query.Contains("INSERT") Then
                Return ds
            ElseIf query.Contains("SELECT") Then
                Return ds
            ElseIf query.Contains("DELETE") Then
                Return True
            ElseIf query.Contains("UPDATE") Then
                Return True
            End If
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            MsgBox(stackframe.GetMethod.ToString & vbCrLf & ex.Message & vbCrLf & query)
        End Try

    End Function

    Public Function CreateUpdate(ByVal fields As String(), ByVal field_values As String())
        Dim str As String = ""
        For i As Integer = 0 To (fields.Length - 1)
            If Not i = (fields.Length - 1) Then
                str &= "`" & fields(i) & "`='" & field_values(i) & "', "
            Else
                str &= "`" & fields(i) & "`='" & field_values(i) & "'"
            End If
        Next
        Return str

    End Function
    Public Function CreateSearch(ByVal fields As String(), ByVal field_values As String())
        Dim str As String = ""
        For i As Integer = 0 To (fields.Length - 1)
            If Not i = (fields.Length - 1) Then
                str &= "`" & fields(i) & "` LIKE '%" & field_values(i) & "%' OR "
            Else
                str &= "`" & fields(i) & "` LIKE '%" & field_values(i) & "%'"
            End If
        Next
        Return str

    End Function
    Public Shared Function CreateFields(ByVal fields As Array)

        Dim str As String = ""
        For i As Integer = 0 To (fields.Length - 1)
            If i = (fields.Length - 1) Then
                str &= "`" & fields(i) & "`"
            Else
                str &= "`" & fields(i) & "`,"
            End If
        Next
        Return str
    End Function
    Public Shared Function CreateValues(ByVal field_values As Array)
        Dim str As String = ""
        For i As Integer = 0 To (field_values.Length - 1)
            If i = (field_values.Length - 1) Then
                str &= "'" & field_values(i) & "'"
            Else
                str &= "'" & field_values(i) & "',"
            End If
        Next
        Return str
    End Function
    ''' <summary>
    ''' Inserts data to database
    ''' </summary>
    ''' <param name="table_name">table name in the database</param>
    ''' <param name="fields">fields array</param>
    ''' <param name="fields_value">fields value array</param>
    ''' <param name="include_where">OPTIONAL: if you want to include a WHERE clause in the SQL string</param>
    ''' <param name="where_clause">OPTIONAL: if include_where is true, </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function InsertToDatabase(ByVal table_name As String, ByVal fields As String, ByVal fields_value As String, Optional ByVal include_where As Boolean = False, Optional ByVal where_clause As String = "")
        Dim sqlString = ""
        If include_where = True Then
            sqlString = "INSERT INTO `{0}` ({1}) VALUES ({2}) WHERE " & where_clause
        Else
            sqlString = "INSERT INTO `{0}` ({1}) VALUES ({2})"
        End If

        sqlString = String.Format(sqlString, table_name, (fields), (fields_value)) & " ; SELECT LAST_INSERT_ID() as last_id"
        Dim ds As String = CreateAdapter(sqlString, table_name).Tables(0).Rows(0)("last_id")
        sqlcon.Close()
        Return ds
    End Function
    Public Function AddLog(ByVal user_id As String, ByVal log_type As String)
        Dim sqlString = "INSERT INTO `{0}` ({1}) VALUES ({2})"
        sqlString = String.Format(sqlString, "logs", ("`user_id`,`log_type`"), ("'" & user_id & "','" & log_type & "'"))
        Dim ds = CreateAdapter(sqlString, "logs")
        sqlcon.Close()
        Return ds
    End Function
    Public Function UpdateRecords(ByVal table_name As String, ByVal fields As String(), ByVal fields_value As String(), ByVal where_clause As String)
        Dim sqlString = "UPDATE `{0}` SET " & CreateUpdate(fields, fields_value) & " WHERE " & where_clause
        sqlString = String.Format(sqlString, table_name)
        Dim ds = CreateAdapter(sqlString, table_name)
        'LogContainer.Log(sqlString)
        sqlcon.Close()
        Return ds
    End Function
    Public Sub UpdateTimestamp(ByVal table_name As String, ByVal timestamp As String, where_clause As String)
        Dim sql = "UPDATE `{0}` SET `{1}`=CURRENT_TIMESTAMP WHERE {2}"
        sql = String.Format(sql, table_name, timestamp, where_clause)
        CreateAdapter(sql, table_name)
        sqlcon.Close()
    End Sub
    Public Function SelectCommand(ByVal table_name As String, Optional ByVal include_where As Boolean = False, Optional ByVal where_clause As String = "") As DataSet
        Dim sqlString = ""
        If include_where = True Then
            sqlString = "SELECT * FROM `{0}` WHERE " & where_clause
        Else
            sqlString = "SELECT * FROM `{0}`"
        End If

        sqlString = String.Format(sqlString, table_name)
        Dim stackframe As New Diagnostics.StackFrame(1)

        'LogContainer.Log(stackframe.GetMethod.ToString & " (line " & stackframe.GetFileLineNumber.ToString & " ) : " & sqlString)
        '(stackframe.GetMethod.ToString & " (line " & stackframe.GetFileLineNumber.ToString & " ) : " & sqlString)
        Dim ds = CreateAdapter(sqlString, table_name)
        sqlcon.Close()
        Return ds

    End Function
    Public Function Query(ByVal sql)
        Dim ds = CreateAdapter(sql, "query")
        sqlcon.Close()
        Return ds
    End Function
    
    Public Function DeleteRecord(ByVal table_name As String, ByVal id As String)
        Dim sqlString = "DELETE FROM `{0}` WHERE id='" & id & "'"
        sqlString = String.Format(sqlString, table_name)
        Dim ds = CreateAdapter(sqlString, table_name)
        sqlcon.Close()
        Return ds
    End Function
    Public Function DeleteRecord(ByVal table_name As String, ByVal idRef As String, ByVal idVal As String)
        Dim sqlString = "DELETE FROM `{0}` WHERE " & idRef & "='" & idVal & "'"
        sqlString = String.Format(sqlString, table_name)
        Dim ds = CreateAdapter(sqlString, table_name)
        sqlcon.Close()
        Return ds
    End Function
    Public Function doLogin(ByVal username As String, ByVal password As String) As Boolean
        cmd.CommandText = "SELECT user_name,user_pass FROM users WHERE user_name = '" & username & "'and user_pass = '" & password & "'"
        dr = cmd.ExecuteReader
        If dr.HasRows Then : Return True
        Else : Return False
        End If
        sqlcon.Close()
    End Function

    Public Function GetColumnHeaders(ByVal table_name As String)
        Dim rs = SelectCommand(table_name)
        Dim list As New List(Of String)
        For Each dCol As DataColumn In rs.Tables(0).Columns
            list.Add(dCol.ColumnName)
        Next
        Return list
    End Function
End Class

Imports System
Imports System.Collections.Generic
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class Logger
    ''' Logs all actions of users using the system. 
    ''' All SQL connections created,
    '''  buttons clicked,items deleted,
    '''  created and editted
    '''

    Public Sub Create(ByVal remarks As String, Optional type As String = "NORMAL_LOG")
        'Factory.CreateObject(Of Logs)()

    End Sub
End Class

Public Class Logs

    <JsonProperty("log_id")>
    Public Property LogId As Integer

    <JsonProperty("user_id")>
    Public Property UserId As Integer

    <JsonProperty("log_type")>
    Public Property LogType As String

    <JsonProperty("log_remarks")>
    Public Property LogRemarks As String

    <JsonProperty("log_pc")>
    Public Property LogPc As String

    <JsonProperty("log_ip")>
    Public Property LogIp As String

    <JsonProperty("log_timestamp")>
    Public Property LogTimestamp As String
End Class

Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Public Class JSON
    Public Shared Function Convert(ByVal rs As DataSet)
        Dim serializerSettings As JsonSerializerSettings = New JsonSerializerSettings()
        serializerSettings.Converters.Add(New DataSetConverter())
        Dim jsonData As String = JsonConvert.SerializeObject(rs, Formatting.None, serializerSettings)
        Return jsonData
    End Function
    Public Shared Function Deserialize(Of T)(ByVal rs As DataSet)
        Dim obj = JsonConvert.DeserializeObject(Of T)(JSON.Convert(rs))
        Return obj
    End Function
    Public Shared Function Deserialize(Of T)(ByVal json As String)
        Dim obj = JsonConvert.DeserializeObject(Of T)(json)
        Return obj
    End Function
End Class

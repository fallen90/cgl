Public Class Floor
    Public Shared Function GetValues(ByVal floorarea As Integer) As String()
        Dim result_list As String() '= ' {300000, 1140, 136.8, 142.5, 1.17, 148.99, 1570}
        '{ sum insured, net premium, vat, doc stamp, lgt, conn fee, premium }
        If (floorarea <= 20) Then
            result_list = {300000, 1140, 136.8, 142.5, 1.17, 148.99}
        ElseIf (floorarea > 20 Or floorarea <= 50) Then
            result_list = {400000, 1305, 156.6, 163.13, 1.96, 173.32}
        Else
            result_list = {0, 0, 0, 0, 0, 0}
        End If


        Return result_list
    End Function

End Class

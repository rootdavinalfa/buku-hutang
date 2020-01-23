Public Class datee
    Public Function Countdifferent2date(date1 As String, date2 As String) As Integer
        Dim dateA = Convert.ToDateTime(date1)
        Dim dateB = Convert.ToDateTime(date2)
        Dim diff = DateDiff(DateInterval.Day, dateA, dateB)

        Return Convert.ToInt32(diff)
    End Function
    Public Function IsDateAfter(dateNow As String, dateCompare As String) As Boolean
        Dim dateA = Convert.ToDateTime(dateNow)
        Dim dateB = Convert.ToDateTime(dateCompare)
        Dim ll = DateTime.Compare(dateA, dateB)
        If ll > 0 Then
            Return True
        ElseIf ll < 0 Then
            Return False
        End If
        Return False
    End Function
End Class

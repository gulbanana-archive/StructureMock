Imports [Lib].Common

Public Class QuoteFormatter
    Implements IFormatter

    Public Function Format(number As Integer) As String Implements IFormatter.Format
        Return $"'{number}'"
    End Function
End Class

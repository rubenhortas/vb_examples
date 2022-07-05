Public Class StringToDecimal

    Public Shared Sub Parse(value As Object)
        Dim d As Decimal

        Try
            d = Decimal.Parse(value)

            Console.WriteLine($"d: {d}")
        Catch ex As Exception
            Console.WriteLine($"Unable to convert: {value}")
        End Try
    End Sub

    Public Shared Sub TryParse(value As Object)
        Dim d As Decimal

        If Decimal.TryParse(value, d) Then
            Console.WriteLine($"d: {d}")
        Else
            Console.WriteLine($"Unable to convert: {value}")
        End If
    End Sub

End Class

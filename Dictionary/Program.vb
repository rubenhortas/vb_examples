Module Program
    Sub Main()
        Dim d As New Dictionary(Of Integer, String) From {
            {1, "One"},
            {2, "Two"},
            {3, "Three"}
        }

        'Iterate dictionary
        For Each kvp As KeyValuePair(Of Integer, String) In d
            Dim k As Integer = kvp.Key
            Dim v As String = kvp.Value

            Console.WriteLine(String.Format("Key: {0}\tValue: {1}", k, v).Replace("\t", vbTab))
        Next
    End Sub
End Module

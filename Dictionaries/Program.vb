Module Program
    Sub Main()
        Dim d As Dictionary(Of Integer, String) = New Dictionary(Of Integer, String)

        d.Add(1, "One")
        d.Add(2, "Two")
        d.Add(3, "Three")

        'Iterate dictionary
        For Each kvp As KeyValuePair(Of Integer, String) In d
            Dim k As Integer = kvp.Key
            Dim v As String = kvp.Value

            Console.WriteLine(String.Format("Key: {0}\tValue: {1}", k, v).Replace("\t", vbTab))
        Next

        Console.ReadLine()
    End Sub
End Module

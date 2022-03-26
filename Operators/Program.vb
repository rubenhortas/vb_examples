Module Program
    Sub Main()
        ' Ternary operator
        Dim isAnExample As Boolean = True
        Dim exampleMessage = If(isAnExample = True, "This is an example", "This is NOT an example")

        Console.WriteLine(exampleMessage)
    End Sub
End Module

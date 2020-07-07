Module Program
    Sub Main(args As String())

        ' Join
        Dim helloWorldArray As Array = {"Hello", "World!"}
        Dim joinedString As String = String.Join(",", helloWorldArray)
        Console.WriteLine(joinedString) ' Hello World!

        ' Split
        Dim str As String = "one, two, three"
        Dim splittedString As String() = str.Split()

        For Each s As String In splittedString
            Console.WriteLine(s)
            ' one
            ' two
            'three
        Next

        ' Contains
        Dim numbers = "1234513370000"

        If numbers.Contains("1337") Then
            Console.WriteLine("Y0u'r3 1337!")
        End If

        'Remove
        Dim helloWorld As String = "Hello World!!"
        Dim cleanHelloWorld As String = helloWorld.Remove(helloWorld.Length - 1)

        Console.WriteLine(cleanHelloWorld) ' Hello World!

        Console.ReadLine()
    End Sub
End Module

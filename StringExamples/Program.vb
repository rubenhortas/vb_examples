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

        'Compare
        Dim str1 As String = Nothing
        Dim str2 As String = Nothing

        Console.WriteLine(String.Format("String.Compare(Nothing, Nothing): {0}", String.Compare(str1, str2))) '0

        str2 = String.Empty
        Console.WriteLine(String.Format("String.Compare(Nothing, String.Empty): {0}", String.Compare(str1, str2))) '-1
        Console.WriteLine(String.Format("Nothing = String.Empty: {0}", String.Compare(str1, str2))) '-1

        str1 = "a"
        str2 = "a"
        Console.WriteLine(String.Format("String.Compare(""a"", ""a""): {0}", String.Compare(str1, str2))) '0
        Console.WriteLine(String.Format("""a"" = ""a"": {0}", String.Compare(str1, str2))) '0

        Console.ReadLine()
    End Sub
End Module

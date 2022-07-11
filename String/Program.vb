Module Program

    Private Const oneTwoThree As String = "one, two, three"
    Private Const numbers As String = "1234513370000"
    Private Const leet As String = "1337"
    Private Const helloWorld As String = "Hello World!!"
    Private Const nothing1 As String = Nothing
    Private Const nothing2 As String = Nothing
    Private Const abc1 As String = "abc"
    Private Const abc2 As String = "abc"

    Sub Main()
        Join()
        Split()
        Contains()
        Remove()
        Compare()
    End Sub

    Private Sub Join()
        Dim helloWorld As New List(Of String) From {"hello", "world!"}
        Dim imHere() As String = {"I'm", "here!"}

        Console.WriteLine($"Join list of strings helloWorld: {String.Join(",", helloWorld)}") ' hello,world!
        Console.WriteLine($"Join array of strings imHere: {String.Join(" ", imHere)}") 'I'm here!
        Console.WriteLine()
    End Sub

    Private Sub Split()
        Dim splittedString As String() = oneTwoThree.Split()

        Console.WriteLine($"Splitting {oneTwoThree}:")

        For Each s As String In splittedString
            Console.WriteLine($"{vbTab}{s}")
        Next

        Console.WriteLine()
    End Sub

    Private Sub Contains()
        If numbers.Contains(leet) Then
            Console.WriteLine($"{numbers} contains {leet}. Y0u'r3 1337!")
        End If

        Console.WriteLine()
    End Sub

    Private Sub Remove()
        Dim cleanHelloWorld As String = helloWorld.Remove(helloWorld.Length - 1)

        Console.WriteLine($"Removing ""!"" from ""{helloWorld}"": {cleanHelloWorld}") ' Hello world!
        Console.WriteLine()
    End Sub

    Private Sub Compare()
        Console.WriteLine($"String.Compare(Nothing1, Nothing2): {String.Compare(nothing1, nothing2)}") ' 0
        Console.WriteLine($"Nothing1 = Nothing2: {nothing1 = nothing2}") ' True
        Console.WriteLine()

        Console.WriteLine($"String.Compare(Nothing, String.Empty): {String.Compare(Nothing, String.Empty)}") ' -1
        Console.WriteLine($"Nothing = String.Empty: {Nothing = String.Empty}") ' True
        Console.WriteLine()

        Console.WriteLine($"String.Compare({abc1}, {abc2}): {String.Compare(abc1, abc2)}") ' 0
        Console.WriteLine($"{abc1} = {abc2}: {abc1 = abc2}") ' True
        Console.WriteLine()
    End Sub

End Module

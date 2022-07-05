Module Program

    Private Const OneTwoThree As String = "one, two, three"
    Private Const Numbers As String = "1234513370000"
    Private Const HelloWorld As String = "Hello World!!"
    Private Const Nothing1 As String = Nothing
    Private Const Nothing2 As String = Nothing
    Private Const Abc1 As String = "abc"
    Private Const Abc2 As String = "abc"

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
        Dim splittedString As String() = OneTwoThree.Split()

        Console.WriteLine("Split:")

        For Each s As String In splittedString
            Console.WriteLine(s)
        Next

        Console.WriteLine()
    End Sub

    Private Sub Contains()
        Console.WriteLine("Contains:")

        If Numbers.Contains("1337") Then
            Console.WriteLine("Y0u'r3 1337!")
        End If

        Console.WriteLine()
    End Sub

    Private Sub Remove()
        Dim cleanHelloWorld As String = HelloWorld.Remove(HelloWorld.Length - 1)

        Console.WriteLine("Remove:")
        Console.WriteLine(cleanHelloWorld) ' Hello World!
        Console.WriteLine()
    End Sub

    Private Sub Compare()
        Console.WriteLine("Compare Nothing:")
        Console.WriteLine($"String.Compare(Nothing, Nothing): {String.Compare(Nothing1, Nothing2)}") '0
        Console.WriteLine()

        Console.WriteLine("Compare Nothing and String.Empty:")
        Console.WriteLine($"String.Compare(Nothing, String.Empty): {String.Compare(Nothing, String.Empty)}") '-1
        Console.WriteLine($"Nothing = String.Empty: {Nothing = String.Empty}") 'True
        Console.WriteLine()

        Console.WriteLine("Compare two equal strings:")
        Console.WriteLine($"String.Compare({Abc1}, {Abc2}): {String.Compare(Abc1, Abc2)}") '0
        Console.WriteLine($"{Abc1} = {Abc2}: {Abc1 = Abc2}") 'True
        Console.WriteLine()
    End Sub

End Module

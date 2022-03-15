Module Program
    Sub Main(args As String())
        Dim base As Base = New Base()
        Dim derived As Derived = New Derived()

        base.WriteInfo()
        derived.WriteInfo()

        Console.ReadLine()
    End Sub
End Module

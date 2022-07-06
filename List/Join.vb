Public Class Join

    Public Shared Sub JoinLists()
        Dim lst As New List(Of String) From {"a", "b", "c"}

        ' Framework 3.5
        ' String.Join(" ", lst.Cast(Of String))

        'Framework >=4
        Console.WriteLine($"Joined list as String: { String.Join(",", lst)}")
        Console.WriteLine()
    End Sub

End Class

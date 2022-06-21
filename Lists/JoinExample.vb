Public Class JoinExample
    Public Shared Sub JoinLists()
        Dim lstJoined As String
        Dim lst As New List(Of String) From {"a", "b", "c"}

        ' Framework 3.5 with linq
        ' lst = String.Join(" ", lst.Cast(Of String))

        'Framework >=4
        lstJoined = String.Join(",", lst)

        Console.WriteLine(String.Format("List joined: {0}", lstJoined))
    End Sub
End Class

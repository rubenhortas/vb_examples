Public Class Order

    Public Shared Sub OrderLists()
        Dim simpleObject As SimpleObject
        Dim simpleObjects As List(Of SimpleObject) = New List(Of SimpleObject)
        Dim orderedObjects As List(Of SimpleObject)

        simpleObject = New SimpleObject("a", "b", "c")
        simpleObjects.Add(simpleObject)

        simpleObject = New SimpleObject("a", "f", "g")
        simpleObjects.Add(simpleObject)

        simpleObject = New SimpleObject("a", "d", "e")
        simpleObjects.Add(simpleObject)

        orderedObjects = simpleObjects.OrderBy(Function(o) o.FirstField).OrderBy(Function(o) o.SecondField).ToList()

        Console.WriteLine("Disordered list:")
        PrintList(simpleObjects)

        Console.WriteLine()

        Console.WriteLine("Ordered list:")
        PrintList(orderedObjects)
    End Sub
    Private Shared Sub PrintList(l As List(Of SimpleObject))
        For i As Integer = 0 To l.Count - 1
            Console.WriteLine(vbTab + String.Format("{0}) {1}", i.ToString, l(i).ToString()))
        Next
    End Sub

End Class

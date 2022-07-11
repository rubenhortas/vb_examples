Public Class SimpleObject

#Region "Attributes"

    Private firstField As String
    Private secondField As String
    Private thirdField As String

#End Region

#Region "Properties"

    Public ReadOnly Property FirstField As String
        Get
            Return FirstField
        End Get
    End Property

    Public ReadOnly Property SecondField As String
        Get
            Return SecondField
        End Get
    End Property

    Public ReadOnly Property ThirdField As String
        Get
            Return ThirdField
        End Get
    End Property

#End Region

#Region "Constructors"

    Public Sub New(firstField As String, secondField As String, thirdField As String)
        firstField = firstField
        secondField = secondField
        thirdField = thirdField
    End Sub

#End Region

#Region "Methods"

    Public Overrides Function ToString() As String
        Return String.Format("{0},{1},{2}", firstField, secondField, thirdField)
    End Function

#End Region

End Class

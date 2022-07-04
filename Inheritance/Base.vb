Public Class Base

    'Const can't be overridable
    Public Const PUBLIC_CONST As String = "Base public const"
    Protected Const PROTECTED_CONST As String = "Base protected const"
    Private Const PRIVATE_CONST As String = "Base private const"

    'Attributes can't be overridable
    Protected _protectedAttributte As String
    Private ReadOnly _privateAttribute As String

    Public Property PublicProperty As String

    'This is the way to override values in derived classes as if they were constants
    'without using the constructor or methods to override protected values.
    Protected Overridable ReadOnly Property ProtectedOverridableProperty As String
        Get
            Return "Base protected overridable property"
        End Get
    End Property

    Protected Property ProtectedProperty As String

    Private ReadOnly Property PrivateProperty As String

    'Constructor can't be overridable
    Public Sub New()
        _protectedAttributte = "Base protected attribute"
        _privateAttribute = "Base private attribute"

        PublicProperty = "Base public property"
        ProtectedProperty = "Base protected property"
        PrivateProperty = "Base private property"
    End Sub

    Public Sub WriteInfo()
        PrintClassName()
        PrintConstsValues()
        PrintAttributesValues()
        PrintPropertiesValues()
    End Sub

    Protected Overridable Sub PrintClassName()
        Console.WriteLine("Base class:")
    End Sub

    Private Sub PrintConstsValues()
        Console.WriteLine($"{vbTab}Consts:")
        Console.WriteLine($"{vbTab}{vbTab}{PUBLIC_CONST}")
        Console.WriteLine($"{vbTab}{vbTab}{PROTECTED_CONST}")
        Console.WriteLine($"{vbTab}{vbTab}{PRIVATE_CONST}")
    End Sub

    Private Sub PrintAttributesValues()
        Console.WriteLine($"{vbTab}Attributes:")
        Console.WriteLine($"{vbTab}{vbTab}{_protectedAttributte}")
        Console.WriteLine($"{vbTab}{vbTab}{_privateAttribute}")
    End Sub

    Private Sub PrintPropertiesValues()
        Console.WriteLine($"{vbTab}Properties:")
        Console.WriteLine($"{vbTab}{vbTab}{PublicProperty}")
        Console.WriteLine($"{vbTab}{vbTab}{ProtectedOverridableProperty}")
        Console.WriteLine($"{vbTab}{vbTab}{PrivateProperty}")
    End Sub

End Class

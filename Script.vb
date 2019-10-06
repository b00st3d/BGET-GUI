Public Class Script
    Private _number As Integer
    Private _name As String
    Private _category As String
    Private _description As String
    Private _author As String
    Private _modified As String

    'Constructor
    Public Sub New(ByVal number As Integer, ByVal name As String, ByVal category As String, ByVal description As String,
                   ByVal author As String, ByVal modified As String)
        _number = number
        _name = name
        _category = category
        _description = description
        _author = author
        _modified = modified
    End Sub

    Public Property Number As Integer
        Get
            Return _number
        End Get
        Set(ByVal value As Integer)
            _number = value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Category As String
        Get
            Return _category
        End Get
        Set(ByVal value As String)
            _category = value
        End Set
    End Property
    Public Property Description As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)
            _description = value
        End Set
    End Property
    Public Property Author As String
        Get
            Return _author
        End Get
        Set(ByVal value As String)
            _author = value
        End Set
    End Property
    Public Property Modified As String
        Get
            Return _modified
        End Get
        Set(ByVal value As String)
            _modified = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return _name & " - " & _category & " - " & _description & " - " & _author & " - " & _modified
    End Function
End Class

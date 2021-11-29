Public Class Parametros
    Private _campo As String
    Private _valor As Object

    Public Sub New(campo As String, valor As Object)
        _campo = campo
        _valor = valor
    End Sub

    Public Property campo As String
        Get
            Return _campo
        End Get
        Set(value As String)
            _campo = value
        End Set
    End Property

    Public Property valor As Object
        Get
            Return _valor
        End Get
        Set(value As Object)
            _valor = value
        End Set
    End Property
End Class

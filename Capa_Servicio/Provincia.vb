Imports Capa_Datos
Imports System.Windows.forms

Public Class Provincia
    Private _codigo As String
    Private _provincia As String
    Dim obj_BD As BD

    Public Sub New()
        obj_BD = New BD()
        _codigo = ""
        _provincia = ""
    End Sub

    Public Property codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property provincia As String
        Get
            Return _provincia
        End Get
        Set(value As String)
            _provincia = value
        End Set
    End Property

    Public Function cargar() As DataTable
        Return obj_BD.SP_Reader("sp_Provincia_Select").Tables(0)
    End Function

    Public Sub cargar(ByRef cb As ComboBox)
        cb.DataSource = obj_BD.SP_Reader("sp_Provincia_Select").Tables(0)
        cb.DisplayMember = "provincia"
        cb.ValueMember = "codigo"
    End Sub

End Class

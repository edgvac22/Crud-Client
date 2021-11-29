Imports System.Data.SqlClient
Imports Capa_Datos
Public Class Cliente

    Dim obj_BD As BD
    Dim lista_parametros As List(Of Parametros)
    Dim connection As SqlConnection

    Private _cedula, _nombre, _apellido, _cod_provincia As String

    Public Sub New()
        obj_BD = New BD()
        lista_parametros = New List(Of Parametros)
        connection = obj_BD.conexion()
        _cedula = ""
        _nombre = ""
        _apellido = ""
        _cod_provincia = ""
    End Sub

    Public Property cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property apellido As String
        Get
            Return _apellido
        End Get
        Set(value As String)
            _apellido = value
        End Set
    End Property

    Public Property cod_provincia As String
        Get
            Return _cod_provincia
        End Get
        Set(value As String)
            _cod_provincia = value
        End Set
    End Property

    Public Function listar() As DataSet
        Dim ds As New DataSet()

        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@orden", "cedula"))
        ds = obj_BD.SP_Reader("sp_Cliente_Select", lista_parametros)

        ds.Tables(0).Columns.Remove("id")
        ds.Tables(0).Columns.Remove("id1")
        ds.Tables(0).Columns.Remove("cod_provincia")
        ds.Tables(0).Columns.Remove("codigo")
        Return ds
    End Function

    Public Function buscar(cedula As String) As Boolean
        Dim ds As New DataSet()
        Dim encontrado As Boolean
        encontrado = False
        _cedula = cedula
        Try
            lista_parametros.Clear()
            lista_parametros.Add(New Parametros("@cedula", _cedula))

            ds = obj_BD.SP_Reader("sp_Cliente_Select", lista_parametros)

            If ds.Tables(0).Rows.Count() > 0 Then
                encontrado = True
                _nombre = ds.Tables(0).Rows(0).Item("nombre")
                _apellido = ds.Tables(0).Rows(0).Item("apellido")
                _cod_provincia = ds.Tables(0).Rows(0).Item("cod_provincia")
            Else
                encontrado = False
                _nombre = ""
                _apellido = ""
                _cod_provincia = ""
            End If

            Return encontrado

        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function agregar() As Boolean

        asignar_parametros()
        Return obj_BD.SP_NoQuery("sp_Cliente_Insertar", lista_parametros)

    End Function

    Public Function eliminar() As Boolean
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        Return obj_BD.SP_NoQuery("sp_Cliente_Delete", lista_parametros)
    End Function

    Public Function actualizar() As Boolean
        asignar_parametros()
        Return obj_BD.SP_NoQuery("sp_Cliente_Update", lista_parametros)
    End Function

    Private Sub asignar_parametros()
        lista_parametros.Clear()
        lista_parametros.Add(New Parametros("@cedula", _cedula))
        lista_parametros.Add(New Parametros("@nombre", _nombre))
        lista_parametros.Add(New Parametros("@apellido", _apellido))
        lista_parametros.Add(New Parametros("@cod_provincia", _cod_provincia))
    End Sub

End Class

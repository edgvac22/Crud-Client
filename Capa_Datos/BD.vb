Imports System.Data.SqlClient

Public Class BD
    Dim connectionString As String
    Dim connection As SqlConnection
    Dim command As SqlCommand
    Dim sqlAdapter As SqlDataAdapter

    Public Sub New()
        connectionString = "Data Source=127.0.0.1; Initial Catalog=2020_DS8; User id= usuarioSql; password=321"
        connection = New SqlConnection(connectionString)
    End Sub

    Public Function conexion() As SqlConnection
        Return connection
    End Function

    Public Function SP_Reader(nombre_sp As String) As DataSet
        Dim ds As New DataSet()
        Try
            connection.Open()
            command = New SqlCommand(nombre_sp, connection)
            command.CommandType = CommandType.StoredProcedure
            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds
        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function SP_Reader(nombre_sp As String, lista_parametro As List(Of Parametros)) As DataSet
        Dim ds As New DataSet()
        Try
            connection.Open()
            command = New SqlCommand(nombre_sp, connection)
            command.CommandType = CommandType.StoredProcedure

            For Each p As Parametros In lista_parametro
                command.Parameters.AddWithValue(p.campo, p.valor)
            Next

            sqlAdapter = New SqlDataAdapter(command)
            sqlAdapter.Fill(ds)
            Return ds

        Catch ex As Exception
            MsgBox("error" & ex.ToString)
        Finally
            connection.Close()
        End Try
    End Function

    Public Function SP_NoQuery(nombre_sp As String, lista_parametro As List(Of Parametros)) As Boolean

        Try
            connection.Open()
            command = New SqlCommand(nombre_sp, connection)
            command.CommandType = CommandType.StoredProcedure

            For Each p As Parametros In lista_parametro
                command.Parameters.AddWithValue(p.campo, p.valor)
            Next

            command.ExecuteNonQuery()
            Return True
        Catch ex As Exception
            MsgBox("error" & ex.ToString)
            Return False
        Finally
            connection.Close()
        End Try
    End Function

End Class

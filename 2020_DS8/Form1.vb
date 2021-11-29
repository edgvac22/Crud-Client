'Imports System.Data.SqlClient
Imports Capa_Servicio

Public Class cb_1
    Dim obj_Cliente As Cliente = New Cliente()
    Dim obj_Provincia As Provincia = New Provincia()
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        'cb_Provincia.DataSource = obj_Provincia.cargar()
        'cb_Provincia.DisplayMember = "provincia"
        'cb_Provincia.ValueMember = "codigo"

        obj_Provincia.cargar(cb_Provincia)
        cb_Provincia.SelectedValue = "00"
    End Sub

    Private Sub btn_Listar_Click(sender As Object, e As EventArgs) Handles btn_Listar.Click
        dgv_Datos.DataSource = obj_Cliente.listar().Tables(0)
    End Sub

    Private Sub btn_Buscar_Click(sender As Object, e As EventArgs) Handles btn_Buscar.Click

        If obj_Cliente.buscar(txt_Cedula.Text) Then
            txt_Nombre.Text = obj_Cliente.nombre
            txt_Apellido.Text = obj_Cliente.apellido
            cb_Provincia.SelectedValue = obj_Cliente.cod_provincia
            btn_Actualizar.Enabled = True
            btn_Eliminar.Enabled = True
            btn_Agregar.Enabled = False
        Else
            txt_Nombre.Text = ""
            txt_Apellido.Text = ""
            cb_Provincia.SelectedValue = "00"
            btn_Agregar.Enabled = True
            btn_Actualizar.Enabled = False
            btn_Eliminar.Enabled = False
        End If
    End Sub

    Private Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click

        obj_Cliente.nombre = txt_Nombre.Text
        obj_Cliente.apellido = txt_Apellido.Text
        obj_Cliente.cod_provincia = cb_Provincia.SelectedValue

        If obj_Cliente.agregar() Then
            MsgBox("Cliente agregado")
        Else
            MsgBox("Error al agregar al cliente")
        End If
    End Sub

    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click

        obj_Cliente.nombre = txt_Nombre.Text
        obj_Cliente.apellido = txt_Apellido.Text
        obj_Cliente.cod_provincia = cb_Provincia.SelectedValue


        If obj_Cliente.actualizar() Then
            MsgBox("Cliente actualizado")
        Else
            MsgBox("Error al actualizar al cliente")
        End If
    End Sub

    Private Sub btn_Eliminar_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click

        If obj_Cliente.eliminar() Then
            MsgBox("Cliente eliminado")
        Else
            MsgBox("Error al eliminar cliente")
        End If
    End Sub
End Class

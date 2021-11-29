<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cb_1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_Listar = New System.Windows.Forms.Button()
        Me.list_Recibir = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_Cedula = New System.Windows.Forms.TextBox()
        Me.txt_Nombre = New System.Windows.Forms.TextBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        Me.dgv_Datos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_Provincia = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Listar
        '
        Me.btn_Listar.Location = New System.Drawing.Point(226, 48)
        Me.btn_Listar.Name = "btn_Listar"
        Me.btn_Listar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Listar.TabIndex = 0
        Me.btn_Listar.Text = "Listar"
        Me.btn_Listar.UseVisualStyleBackColor = True
        '
        'list_Recibir
        '
        Me.list_Recibir.FormattingEnabled = True
        Me.list_Recibir.ItemHeight = 15
        Me.list_Recibir.Location = New System.Drawing.Point(12, 22)
        Me.list_Recibir.Name = "list_Recibir"
        Me.list_Recibir.Size = New System.Drawing.Size(194, 184)
        Me.list_Recibir.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(336, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Cédula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(336, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(336, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Apellido:"
        '
        'txt_Cedula
        '
        Me.txt_Cedula.Location = New System.Drawing.Point(411, 45)
        Me.txt_Cedula.Name = "txt_Cedula"
        Me.txt_Cedula.Size = New System.Drawing.Size(121, 23)
        Me.txt_Cedula.TabIndex = 5
        '
        'txt_Nombre
        '
        Me.txt_Nombre.Location = New System.Drawing.Point(411, 77)
        Me.txt_Nombre.Name = "txt_Nombre"
        Me.txt_Nombre.Size = New System.Drawing.Size(121, 23)
        Me.txt_Nombre.TabIndex = 6
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Location = New System.Drawing.Point(411, 107)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(121, 23)
        Me.txt_Apellido.TabIndex = 7
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Location = New System.Drawing.Point(565, 47)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 8
        Me.btn_Buscar.Text = "Buscar"
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Location = New System.Drawing.Point(565, 79)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Agregar.TabIndex = 9
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Enabled = False
        Me.btn_Actualizar.Location = New System.Drawing.Point(565, 109)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Actualizar.TabIndex = 10
        Me.btn_Actualizar.Text = "Actualizar"
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Location = New System.Drawing.Point(565, 138)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Eliminar.TabIndex = 11
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'dgv_Datos
        '
        Me.dgv_Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Datos.Location = New System.Drawing.Point(33, 240)
        Me.dgv_Datos.Name = "dgv_Datos"
        Me.dgv_Datos.RowTemplate.Height = 25
        Me.dgv_Datos.Size = New System.Drawing.Size(357, 150)
        Me.dgv_Datos.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Provincia"
        '
        'cb_Provincia
        '
        Me.cb_Provincia.FormattingEnabled = True
        Me.cb_Provincia.Location = New System.Drawing.Point(411, 143)
        Me.cb_Provincia.Name = "cb_Provincia"
        Me.cb_Provincia.Size = New System.Drawing.Size(121, 23)
        Me.cb_Provincia.TabIndex = 14
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(411, 182)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 15
        '
        'cb_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 486)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.cb_Provincia)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_Datos)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.btn_Agregar)
        Me.Controls.Add(Me.btn_Buscar)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_Nombre)
        Me.Controls.Add(Me.txt_Cedula)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.list_Recibir)
        Me.Controls.Add(Me.btn_Listar)
        Me.Name = "cb_1"
        Me.Text = "Form1"
        CType(Me.dgv_Datos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_Listar As Button
    Friend WithEvents list_Recibir As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_Cedula As TextBox
    Friend WithEvents txt_Nombre As TextBox
    Friend WithEvents txt_Apellido As TextBox
    Friend WithEvents btn_Buscar As Button
    Friend WithEvents btn_Agregar As Button
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents btn_Eliminar As Button
    Friend WithEvents dgv_Datos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_Provincia As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
End Class

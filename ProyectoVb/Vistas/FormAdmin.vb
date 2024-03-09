Public Class FormAdmin
    Dim manager As New manager
    Dim dsUser As New DataSet
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        dsUser = manager.obtenerUsuarios()
        pintarUsuarios(dsUser)

    End Sub
    Private Sub consultaUsuario()

    End Sub
    'Private Sub altaUsuario()
    '    Dim name As String = tbNameAddUser.Text
    '    Dim psw As String = tbPswAddUser.Text
    '    Dim res As Integer = manager.login_reg(name, psw, 2)
    '    If res > 0 Then
    '        MessageBox.Show("Usuario creado con exito")
    '    Else
    '        MessageBox.Show("Fallo en la creación")
    '    End If
    'End Sub
    Private Sub bajaUsuario()

    End Sub

    Private Sub pintarUsuarios(dsUser)
        DataGridView1.Columns.Add("ID", "ID USER")
        DataGridView1.Columns.Add("Nombre", "Nombre")
        DataGridView1.Columns.Add("Contraseña", "Contraseña")
        DataGridView1.Columns.Add("Status", "Status")
        DataGridView1.Columns.Add("Ult_Conex", "Última Conexion")
        DataGridView1.Columns.Add("Idrol", "ID ROL")
        DataGridView1.Columns("ID").Width = 50
        DataGridView1.Columns("Nombre").Width = 100
        DataGridView1.Columns("Contraseña").Width = 100
        DataGridView1.Columns("Status").Width = 100
        DataGridView1.Columns("Ult_Conex").Width = 100
        DataGridView1.Columns("Idrol").Width = 100
        For Each row As DataRow In dsUser.Tables(0).Rows
            Dim id As Integer = row("id_user").ToString()
            Dim nombre As String = row("name").ToString()
            Dim contraseña As String = row("password").ToString()
            Dim estado As String = row("status").ToString()
            Dim ultConex As DateTime = DirectCast(row("last_login"), DateTime)
            Dim idRol As Integer = row("id_rol").ToString()
            DataGridView1.Rows.Add(id, nombre, contraseña, estado, ultConex, idRol)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub
End Class
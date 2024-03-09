Public Class FormAdmin
    Dim manager As New manager
    Private Sub consultaUsuario()

    End Sub
    Private Sub altaUsuario()
        Dim name As String = tbNameAddUser.Text
        Dim psw As String = tbPswAddUser.Text
        Dim res As Integer = manager.login_reg(name, psw, 2)
        If res > 0 Then
            MessageBox.Show("Usuario creado con exito")
        Else
            MessageBox.Show("Fallo en la creación")
        End If
    End Sub
    Private Sub bajaUsuario()

    End Sub
End Class
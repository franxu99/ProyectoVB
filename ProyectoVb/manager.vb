Public Class Manager
    Dim dtac As New DataAccess
    Public user As New User
    Public Function login(name As String, pasw As String)
        Dim id As Integer = dtac.login_reg(name, pasw)
        Dim role As Integer
        If id > 0 Then
            user.accessName = name.ToString()
            user.accessPsw = pasw.ToString()
            user.accessId = id
            role = dtac.getUserRol(id)
            user.accessRol = role.ToString()
            Return role
        Else
            MessageBox.Show("User no encontrado")
            Return 0
        End If

    End Function
    Public Function registro(name As String, pasw As String, email As String)
        Dim res As Integer = dtac.registro(name, pasw, email)
        If res > 0 Then
            Return res
            MessageBox.Show("Usuario introducido con exito")
        Else
            MessageBox.Show("Error al introducir el usuario")
            Return 0
        End If

    End Function
    Public Sub recovery(correo As String)
        dtac.recuperarContraseña(correo)
    End Sub
    Public Sub recovPassword(correo As String, code As String, npass As String)
        dtac.recoverPassword(correo, code, npass)
    End Sub
    Public Function showUsers() As DataSet
        Return dtac.obtenerUsuarios()
    End Function
    Public Sub upgradeUser(id_master As Integer, id_user As Integer)
        Dim res As Integer = dtac.upgradeUser(id_master, id_user)
        If res > 0 Then
            MessageBox.Show("Usuario actualizado con exito")
        Else
            MessageBox.Show("Error al actualizar el usuario")
        End If
    End Sub
    Public Sub downgradeUser(id_master As Integer, id_user As Integer)
        Dim res As Integer = dtac.downgradeUser(id_master, id_user)
        If res > 0 Then
            MessageBox.Show("Usuario actualizado con exito")
        Else
            MessageBox.Show("Error al actualizar el usuario")
        End If
    End Sub
    Public Sub toggleActivate(id_master As Integer, id_user As Integer)
        If id_master < id_user Then
            dtac.alterStatus(id_user)
        End If
    End Sub
    Public Sub changeOwnership(id_master As Integer, id_user As Integer)
        If id_master < id_user Then
            dtac.changeOwnership(id_master, id_user)
        End If
    End Sub
    Public Function getUsersByStatus(value As String) As DataSet
        Return dtac.obtenerUsuariosPorEstado(value)
    End Function
    Public Function getUsersByDatetime(value As DateTime) As DataSet
        Return dtac.obtenerUsuariosPorFecha(value)
    End Function
    Public Function getUsersByDAtetimeAndStatus(value As DateTime, status As String) As DataSet
        Return dtac.obtenerUsuariosPorFechayEstado(value, status)
    End Function
End Class

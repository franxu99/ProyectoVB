Imports MySql.Data.MySqlClient

Public Class Form1


    Dim s As New conexion

    Sub Main()

        s.Probarconexion()

    End Sub

    Private Sub iniciarSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        Dim manager As New manager
        Dim name_user As String = "Owner"
        Dim psw As String = "1234"
        If manager.login_reg(name_user, psw, 1) > 0 Then
            MessageBox.Show("Has iniciado sesion")
        End If
    End Sub

End Class

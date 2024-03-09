Imports MySql.Data.MySqlClient


Public Class Form1

    Dim manager As New manager
    Dim s As New conexion

    Sub New()
        InitializeComponent()
        s.Probarconexion()

    End Sub

    Private Sub iniciarSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click

        Dim name_user As String = tbNameLog.Text
        Dim psw As String = tbPswLog.Text
        Dim res As Integer = manager.login_reg(name_user, psw, 1)
        If res > 0 Then
            Dim user As New User(name_user, psw, res)
            Select Case res
                Case 1
                    FormOwner.Show()
                Case 2
                    FormAdmin.Show()
                Case 3
                    FormUser.Show()
            End Select
            Me.Hide()
            limpiarCampos()

        Else
            MessageBox.Show("User no encontrado")
        End If
    End Sub
    Private Sub limpiarCampos()
        tbNameLog.Text = ""
        tbPswLog.Text = ""
    End Sub

    Private Sub btnRecPsw_Click(sender As Object, e As EventArgs) Handles btnRecPsw.Click
        Dim email As String = tbRecPsw.Text
        manager.recuperarContraseña(email)
    End Sub
End Class

Imports System.Text.RegularExpressions
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
        Dim correo As String = tbRecPsw.Text
        If Not ValidarFormatoCorreo(correo) Then
            MessageBox.Show("El formato del correo no es correcto")
            Return
        End If
        manager.recuperarContraseña(correo)

    End Sub

    Function ValidarFormatoCorreo(ByVal correo As String) As Boolean
        Dim patron As String = "^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"
        Dim coincidencia As Match = Regex.Match(correo, patron)

        If coincidencia.Success Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        habilitarCamposReg()
    End Sub

    Private Sub btnCompletarReg_Click(sender As Object, e As EventArgs) Handles btnCompletarReg.Click
        Dim name_user As String = tbNameReg.Text
        Dim psw As String = tbPswReg.Text
        Dim email As String = tbEmailReg.Text
        If Not ValidarFormatoCorreo(email) Then
            MessageBox.Show("El formato del correo no es correcto")
            Return
        End If
        Dim res As Integer = manager.registro(name_user, psw, email)
        If res > 0 Then
            MessageBox.Show("Usuario introducido con exito")
            habilitarCamposLog()
            Return
        End If
        MessageBox.Show("Error al introducir el usuario")
    End Sub

    Sub habilitarCamposReg()
        tbNameLog.Visible = False
        tbPswLog.Visible = False
        tbRecPsw.Visible = False
        btnRecPsw.Visible = False
        lblTitle.Text = "Registro"
        lblEmailReg.Visible = True
        tbNameReg.Visible = True
        tbPswReg.Visible = True
        tbEmailReg.Visible = True
        btnCompletarReg.Visible = True
        limpiarCampos()
    End Sub
    Sub habilitarCamposLog()
        tbNameLog.Visible = True
        tbPswLog.Visible = True
        tbRecPsw.Visible = True
        btnRecPsw.Visible = True
        lblTitle.Text = "Iniciar Sesion"
        lblEmailReg.Visible = False
        tbNameReg.Visible = False
        tbPswReg.Visible = False
        tbEmailReg.Visible = False
        btnCompletarReg.Visible = False
        limpiarCampos()
    End Sub
End Class

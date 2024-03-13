Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient


Public Class Form1

    Dim manager As New Manager
    Dim s As New conexion

    Sub New()
        InitializeComponent()
        s.Probarconexion()

    End Sub

    Private Sub iniciarSesion_Click(sender As Object, e As EventArgs) Handles btnInicioSesion.Click
        If tbNameLog.Text = "" And tbPswLog.Text = "" Then
            MessageBox.Show("Rellene los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim name_user As String = tbNameLog.Text
        Dim psw As String = tbPswLog.Text
        Dim Val As Integer = manager.login(name_user, psw)
        If Val > 0 Then

            Dim page As New FormApp(manager)
            page.Text = "App Page"
            AddHandler page.FormClosed, AddressOf FrmAppClose
            Call page.Show()
            Me.Hide()
            limpiarCampos()


        End If
    End Sub
    Private Sub FrmAppClose(sender As Object, e As FormClosedEventArgs)
        Me.Show()
    End Sub
    Private Sub limpiarCampos()
        tbNameLog.Text = ""
        tbPswLog.Text = ""
        tbNameReg.Text = ""
        tbPswReg.Text = ""
        tbEmailReg.Text = ""
        tbRecPsw.Text = ""
    End Sub

    Private Sub btnRecPsw_Click(sender As Object, e As EventArgs) Handles btnRecPsw.Click
        Dim correo As String = tbRecPsw.Text
        If Not ValidarFormatoCorreo(correo) Then
            MessageBox.Show("El formato del correo no es correcto")
            Return
        End If
        manager.recovery(correo)
        FormRecover.Show()
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
        If tbNameReg.Text = "" And tbPswReg.Text = "" Then
            MessageBox.Show("Rellene todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim name_user As String = tbNameReg.Text
        Dim psw As String = tbPswReg.Text
        Dim email As String = tbEmailReg.Text
        If Not ValidarFormatoCorreo(email) Then
            MessageBox.Show("El formato del correo no es correcto")
            Return
        End If
        Dim res As Integer = manager.registro(name_user, psw, email)
        If res > 0 Then
            MessageBox.Show("Registrado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            habilitarCamposLog()
            Return
        End If

    End Sub

    Sub habilitarCamposReg()
        tbNameLog.Visible = False
        tbPswLog.Visible = False
        tbRecPsw.Visible = False
        btnRecPsw.Visible = False
        btnInicioSesion.Visible = False
        btnRegistro.Visible = False
        lblTitle.Text = "REGISTRO"
        btnVolverReg.Visible = True
        lblEmailReg.Visible = True
        tbNameReg.Visible = True
        tbPswReg.Visible = True
        tbEmailReg.Visible = True
        imgGmail.Visible = True
        'imgUser.Visible = True
        btnCompletarReg.Visible = True
        limpiarCampos()
    End Sub
    Sub habilitarCamposLog()
        tbNameLog.Visible = True
        tbPswLog.Visible = True
        tbRecPsw.Visible = True
        btnRecPsw.Visible = True
        btnInicioSesion.Visible = True
        btnRegistro.Visible = True
        lblTitle.Text = "LOG IN"
        lblEmailReg.Visible = False
        btnVolverReg.Visible = False
        tbNameReg.Visible = False
        tbPswReg.Visible = False
        tbEmailReg.Visible = False
        imgGmail.Visible = False
        'imgUser.Visible = False
        btnCompletarReg.Visible = False
        limpiarCampos()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbNameLog.Text = "Nombre"
        tbNameLog.ForeColor = Color.DarkGray

        tbPswLog.Text = "Contraseña"
        tbPswLog.ForeColor = Color.DarkGray
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbNameLog.TextChanged

    End Sub

    '########### log ##########

    Private Sub tbNameLog_GotFocus(sender As Object, e As EventArgs) Handles tbNameLog.GotFocus
        If tbNameLog.Text = "Nombre" Then
            tbNameLog.Text = ""
            tbNameLog.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbNameLog_LostFocus(sender As Object, e As EventArgs) Handles tbNameLog.LostFocus
        If tbNameLog.Text = "" Then
            tbNameLog.Text = "Nombre"
            tbNameLog.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbPswLog_GotFocus(sender As Object, e As EventArgs) Handles tbPswLog.GotFocus
        If tbPswLog.Text = "Contraseña" Then
            tbPswLog.Text = ""
            tbPswLog.PasswordChar = "•"
            tbPswLog.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbPswLog_LostFocus(sender As Object, e As EventArgs) Handles tbPswLog.LostFocus
        If tbPswLog.Text = "" Then
            tbPswLog.Text = "Contraseña"
            tbPswLog.PasswordChar = ""
            tbPswLog.ForeColor = Color.Black
        End If
    End Sub

    '########### reg ##########

    Private Sub tbNameReg_GotFocus(sender As Object, e As EventArgs)
        If tbNameReg.Text = "Nombre" Then
            tbNameReg.Text = ""
            tbNameReg.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbNameReg_LostFocus(sender As Object, e As EventArgs)
        If tbNameReg.Text = "" Then
            tbNameReg.Text = "Nombre"
            tbNameReg.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub tbPswReg_GotFocus(sender As Object, e As EventArgs)
        If tbPswReg.Text = "Contraseña" Then
            tbPswReg.Text = ""
            tbPswReg.PasswordChar = "•"
            tbPswReg.ForeColor = Color.Black
        End If
    End Sub

    Private Sub tbPswReg_LostFocus(sender As Object, e As EventArgs)
        If tbPswReg.Text = "" Then
            tbPswReg.Text = "Contraseña"
            tbPswReg.PasswordChar = "•"
            tbPswReg.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub btnVolverReg_Click(sender As Object, e As EventArgs) Handles btnVolverReg.Click
        limpiarCampos()
        habilitarCamposLog()
    End Sub
End Class

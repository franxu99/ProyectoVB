Imports MySql.Data.MySqlClient
Imports MimeKit
Imports MailKit.Net.Smtp
Imports MailKit.Security
Imports System.Text.RegularExpressions
Public Class manager

    Dim connectionString As String = "server=localhost;port=3306;database=vbdatabase;user=root; password=1234"

    Public Function login_reg(ByVal name_user As String, ByVal psw As String, ByVal opc As Integer) As Integer

        Dim parametro1 As New MySqlParameter("@_name", name_user)
        Dim parametro2 As New MySqlParameter("@_pass", psw)
        Dim parametroResultado As New MySqlParameter("@_res", MySqlDbType.Int32)
        Dim resultado As Integer
        parametroResultado.Direction = ParameterDirection.Output
        Try
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()

                Using comando As New MySqlCommand("findUser", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.Add(parametro1)
                    comando.Parameters.Add(parametro2)
                    comando.Parameters.Add(parametroResultado)

                    comando.ExecuteNonQuery()

                    resultado = Convert.ToInt32(parametroResultado.Value)

                    Console.WriteLine("Resultado del procedimiento: " & resultado.ToString())
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " & ex.Message)
        End Try
        Return resultado

    End Function

    Public Function registro(ByVal name_user As String, ByVal psw As String, ByVal email As String) As Integer
        Dim last_login As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        Dim _name As New MySqlParameter("@_name", name_user)
        Dim _psw As New MySqlParameter("@_pass", psw)
        Dim _email As New MySqlParameter("@_email", email)
        Dim _status As New MySqlParameter("@_status", "Activated")
        Dim _last_login As New MySqlParameter("@_last_login", last_login)
        Dim _id_rol As New MySqlParameter("@_id_rol", 3)
        Dim parametroResultado As New MySqlParameter("@_res", MySqlDbType.Int32)
        Dim resultado As Integer
        parametroResultado.Direction = ParameterDirection.Output
        Try
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()

                Using comando As New MySqlCommand("addUser", conexion)
                    comando.CommandType = CommandType.StoredProcedure

                    comando.Parameters.Add(_name)
                    comando.Parameters.Add(_psw)
                    comando.Parameters.Add(_email)
                    comando.Parameters.Add(_status)
                    comando.Parameters.Add(_last_login)
                    comando.Parameters.Add(_id_rol)
                    comando.Parameters.Add(parametroResultado)

                    comando.ExecuteNonQuery()

                    resultado = Convert.ToInt32(parametroResultado.Value)

                    Console.WriteLine("Resultado del procedimiento: " & resultado.ToString())
                End Using
            End Using
        Catch ex As Exception
            Console.WriteLine("Error al ejecutar el procedimiento almacenado: " & ex.Message)
        End Try
        Return 1
    End Function

    Public Function obtenerUsuarios() As DataSet
        Try
            Using conexion As New MySqlConnection(connectionString)
                ' Abre la conexión
                conexion.Open()

                ' Crea un comando para ejecutar el procedimiento almacenado
                Using command As New MySqlCommand("getAllUsers", conexion)
                    command.CommandType = CommandType.StoredProcedure
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataSet As New DataSet()
                        adapter.Fill(dataSet)
                        Return dataSet
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error: {ex.Message}")
            Return Nothing
        End Try
    End Function

    Public Sub recuperarContraseña(ByVal correoDestino As String)
        Dim message As New MimeMessage()

        Try

            message.From.Add(New MailboxAddress("ProyectoVB", correoDestino))
            message.To.Add(New MailboxAddress("proyectovb343@gmail.com", correoDestino))
            message.Subject = "Cambio contraseña"
            Dim fechaHoraActual As DateTime = DateTime.Now
            Dim formatoFechaHora As String = fechaHoraActual.ToString("yyyyMMddHHmmss")
            message.Body = New TextPart("plain") With {.Text = "La nueva contraseña es: " + formatoFechaHora}


            Using client As New SmtpClient()
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls)
                client.Authenticate("proyectovb343@gmail.com", "xgep sjez rjld nvan")

                client.Send(message)
                client.Disconnect(True)
            End Using

            MessageBox.Show("Correo enviado.", "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al enviar el correo: " & ex.Message,
 "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub





End Class

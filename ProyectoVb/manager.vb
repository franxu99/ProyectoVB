Imports MySql.Data.MySqlClient
Imports MimeKit
Imports MailKit.Net.Smtp
Imports MailKit.Security
Public Class manager

    Dim connectionString As String = "server=localhost;port=3306;database=vbdatabase;user=root; password=1234"

    Public Function login_reg(ByVal name_user As String, ByVal psw As String, ByVal opc As Integer) As Integer
        Dim nombreProcedimiento As String = ""
        If opc = 1 Then
            nombreProcedimiento = "findUser"
        ElseIf opc = 2 Then
            nombreProcedimiento = "addUser"
        End If

        Dim parametro1 As New MySqlParameter("@_name", name_user)
        Dim parametro2 As New MySqlParameter("@_pass", psw)
        Dim parametroResultado As New MySqlParameter("@_res", MySqlDbType.Int32)
        Dim resultado As Integer
        parametroResultado.Direction = ParameterDirection.Output
        Try
            Using conexion As New MySqlConnection(connectionString)
                conexion.Open()

                Using comando As New MySqlCommand(nombreProcedimiento, conexion)
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

    Public Sub recuperarContraseña(ByVal emailDestino As String)
        Dim message As New MimeMessage()

        Try

            message.From.Add(New MailboxAddress("ProyectoVB", emailDestino))
            message.To.Add(New MailboxAddress("proyectovb343@gmail.com", emailDestino))
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

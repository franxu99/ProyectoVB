Imports MySql.Data.MySqlClient
Public Class manager

    Dim connectionString As String = "server=localhost;port=3309;database=vbdatabase;user=root; password=joyfe"

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

End Class

Imports Microsoft.VisualBasic

Public Class conexion
    Private MySqlCommand As New MySqlCommand
    Dim MySqlConnString As String = "server=localhost:3309;Database=vbdatabase;user id = root; password=joyfe"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(MySqlConnString)
    Public Sub Probarconexion()
        Try
            MysqlConexion.Open()
            MsgBox("la conexión fue exitosa")
            MysqlConexion.Close()
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub
End Class

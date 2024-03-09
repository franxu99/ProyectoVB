Imports System.IO
Imports Google.Protobuf.Collections
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class conexion
    Private MySqlCommand As New MySqlCommand
    Dim MySqlConnString As String = "server=localhost;port=3306;database=vbdatabase;user=root; password=1234"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(MySqlConnString)
    Public Sub Probarconexion()
        Try
            MysqlConexion.Open()
            MsgBox("la conexión fue exitosa")
            MysqlConexion.Close()
        Catch ex As Exception
            Dim appDirectory As String = Application.StartupPath
            Dim parentDirectory As DirectoryInfo = Directory.GetParent(appDirectory)
            parentDirectory = Directory.GetParent(parentDirectory.FullName)
            parentDirectory = Directory.GetParent(parentDirectory.FullName)
            parentDirectory = Directory.GetParent(parentDirectory.FullName)
            Dim scriptFilePath As String = Path.Combine(parentDirectory.FullName, "scriptSql\vbdatabase.sql")
            MySqlConnString = "server=localhost;port=3306;user=root; password=1234"
            MysqlConexion = New MySqlConnection(MySqlConnString)
            MysqlConexion.Open()
            Dim script As String = File.ReadAllText(scriptFilePath)
            Dim command As New MySqlCommand(script, MysqlConexion)
            command.ExecuteNonQuery()
            MsgBox("Se creó la BBDD")
        End Try
    End Sub
End Class

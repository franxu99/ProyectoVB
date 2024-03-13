Imports System.IO
Imports Google.Protobuf.Collections
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class conexion
    Private MySqlCommand As New MySqlCommand
    Dim server As String = "localhost"
    Dim port As String = "3309"
    Dim database As String = "vbdatabase"
    Dim user As String = "root"
    Dim password As String = "joyfe"
    Dim MySqlConnString As String = "server=" + server + ";port=" + port + ";database=" + database + ";user=" + user + "; password=" + password
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
            MySqlConnString = "server=" + server + ";port=" + port + ";user=" + user + "; password=" + password
            MysqlConexion = New MySqlConnection(MySqlConnString)
            MysqlConexion.Open()
            Dim script As String = File.ReadAllText(scriptFilePath)
            Dim command As New MySqlCommand(script, MysqlConexion)
            command.ExecuteNonQuery()
            MsgBox("Se creó la BBDD")
        End Try
    End Sub
End Class

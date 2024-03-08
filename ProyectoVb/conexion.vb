Imports System.IO
Imports Google.Protobuf.Collections
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class conexion
    Private MySqlCommand As New MySqlCommand
    Dim MySqlConnString As String = "server=localhost;port=3309;database=vbdatabase;user=root; password=joyfe"
    Public MysqlConexion As MySqlConnection = New MySqlConnection(MySqlConnString)
    Public Sub Probarconexion()
        Try
            MysqlConexion.Open()
            MsgBox("la conexión fue exitosa")
            MysqlConexion.Close()
        Catch ex As Exception
            Dim scriptFilePath As String = "C:\Users\DAM2B-09\source\repos\ProyectoVb\ProyectoVb\scriptSql\vbdatabase.sql"
            MySqlConnString = "server=localhost;port=3309;user=root; password=joyfe"
            MysqlConexion = New MySqlConnection(MySqlConnString)
            MysqlConexion.Open()
            Dim script As String = File.ReadAllText(scriptFilePath)
            Dim command As New MySqlCommand(script, MysqlConexion)
            command.ExecuteNonQuery()
            MsgBox("Se creó la BBDD")
        End Try
    End Sub
End Class

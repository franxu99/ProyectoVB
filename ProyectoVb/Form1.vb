Imports MySql.Data.MySqlClient

Public Class Form1


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim s As New conexion
        s.Probarconexion

    End Sub
End Class

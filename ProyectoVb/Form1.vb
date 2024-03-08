Imports MySql.Data.MySqlClient

Public Class Form1


    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click

        Dim s As New conexion
        s.Probarconexion

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class

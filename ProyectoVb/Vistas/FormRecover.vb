﻿Public Class FormRecover
    Dim manager As New Manager
    Private Sub BtnAction_Click(sender As Object, e As EventArgs) Handles BtnAction.Click
        If TxtPass1.Text.ToString() = TxtPass2.Text.ToString() Then
            Try
                manager.recovPassword(TxtEmail.Text.ToString(), TxtCode.Text.ToString(), TxtPass1.Text.ToString())
                MessageBox.Show("La contraseña ha sido restablecida")
                Me.Close()
            Catch ex As Exception

            End Try
        Else
            MessageBox.Show("Las contraseñas no coinciden")
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class
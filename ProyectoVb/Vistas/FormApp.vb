Public Class FormApp
    Dim manager As New Manager
    Dim dsUser As New DataSet
    Dim selectedID As New Integer
    Dim selectedRol As New Integer

    Sub New(man As Manager)
        manager = man
        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        LblName.Text = manager.user.accessName
        If manager.user.accessRol < 3 Then
            DataGridView1.Visible = True
            GbFilters.Visible = True
            dsUser = manager.showUsers()
            pintarUsuarios(dsUser)
        End If
    End Sub

    Private Sub pintarUsuarios(dsUser)
        DataGridView1.Columns.Add("ID", "ID USER")
        DataGridView1.Columns.Add("Nombre", "Nombre")
        DataGridView1.Columns.Add("Contraseña", "Contraseña")
        DataGridView1.Columns.Add("Status", "Status")
        DataGridView1.Columns.Add("Ult_Conex", "Última Conexion")
        DataGridView1.Columns.Add("Idrol", "ID ROL")
        DataGridView1.Columns("ID").Width = 50
        DataGridView1.Columns("Nombre").Width = 100
        DataGridView1.Columns("Contraseña").Width = 100
        DataGridView1.Columns("Status").Width = 100
        DataGridView1.Columns("Ult_Conex").Width = 100
        DataGridView1.Columns("Idrol").Width = 100
        For Each row As DataRow In dsUser.Tables(0).Rows
            Dim id As Integer = row("id_user").ToString()
            Dim nombre As String = row("name").ToString()
            Dim contraseña As String = row("password").ToString()
            Dim estado As String = row("status").ToString()
            Dim ultConex As DateTime = DirectCast(row("last_login"), DateTime)
            Dim idRol As Integer = row("id_rol").ToString()
            DataGridView1.Rows.Add(id, nombre, contraseña, estado, ultConex, idRol)
        Next
    End Sub
    Private Sub recharge()
        DataGridView1.Rows.Clear()
        DataGridView1.Columns.Clear()
        pintarUsuarios(dsUser)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        For Each row As DataGridViewRow In DataGridView1.SelectedRows
            selectedID = Int32.Parse(row.Cells("ID").Value().ToString())
            selectedRol = Int32.Parse(row.Cells("Idrol").Value().ToString())
        Next
        LblSelectedID.Text = selectedID.ToString()
        If manager.user.accessRol = 1 Then
            BtnChangeOwnership.Visible = True
            If selectedRol = 2 Then
                BtnChangeOwnership.Enabled = True
            ElseIf selectedRol = 3 Then
                BtnChangeOwnership.Enabled = False
            End If
        Else
            BtnChangeOwnership.Visible = False
        End If

        If selectedRol > manager.user.accessRol Then
            GB1.Visible = True
        Else
            GB1.Visible = False
        End If
    End Sub

    Private Sub BtnUpgrade_Click(sender As Object, e As EventArgs) Handles BtnUpgrade.Click
        manager.upgradeUser(manager.user.accessId, selectedID)
        dsUser = manager.showUsers()
        recharge()
    End Sub

    Private Sub BtnDowngrade_Click(sender As Object, e As EventArgs) Handles BtnDowngrade.Click
        manager.downgradeUser(manager.user.accessId, selectedID)
        dsUser = manager.showUsers()
        recharge()
    End Sub

    Private Sub BtnDeactivate_Click(sender As Object, e As EventArgs) Handles BtnDeactivate.Click
        manager.toggleActivate(manager.user.accessId, selectedID)
        dsUser = manager.showUsers()
        recharge()
    End Sub

    Private Sub BtnChangeOwnership_Click(sender As Object, e As EventArgs) Handles BtnChangeOwnership.Click
        manager.changeOwnership(manager.user.accessId, selectedID)
        dsUser = manager.showUsers()
        recharge()
    End Sub

    Private Sub BtnAplicarFiltros_Click(sender As Object, e As EventArgs) Handles BtnAplicarFiltros.Click
        Dim bool As Boolean = False
        Dim checkedItem As String = ""
        If CBDatetime.Checked Then
            dsUser = manager.getUsersByDatetime(DateTime.Value().Date())
            bool = True
        End If
        For i As Integer = 0 To ClbActivated.Items.Count - 1
            If ClbActivated.GetItemChecked(i) Then
                If CBDatetime.Checked Then
                    dsUser = manager.getUsersByDAtetimeAndStatus(DateTime.Value().Date(), ClbActivated.Items(i).ToString())
                    bool = True
                Else
                    dsUser = manager.getUsersByStatus(ClbActivated.Items(i).ToString())
                    bool = True
                End If

                Exit For
            End If
        Next
        If bool = False Then
            dsUser = manager.showUsers()
        End If
        recharge()
    End Sub

    Private Sub ClbActivated_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClbActivated.SelectedIndexChanged
        If ClbActivated.SelectedIndex >= 0 Then
            ' Loop through all items in the CheckBoxList
            For i As Integer = 0 To ClbActivated.Items.Count - 1
                ' If the item is not the selected one, deselect it
                If i <> ClbActivated.SelectedIndex Then
                    ClbActivated.SetItemChecked(i, False)
                End If
            Next
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
    End Sub

    Private Sub LblName_Click(sender As Object, e As EventArgs) Handles LblName.Click
        LblName.Parent = PictureBox1
        LblName.BackColor = Color.Transparent
    End Sub
End Class
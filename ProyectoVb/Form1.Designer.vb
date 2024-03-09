<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn = New Button()
        Button1 = New Button()
        btnInicioSesion = New Button()
        GroupBox1 = New GroupBox()
        Label2 = New Label()
        Label1 = New Label()
        tbPswLog = New TextBox()
        tbNameLog = New TextBox()
        GroupBox2 = New GroupBox()
        btnRecPsw = New Button()
        tbRecPsw = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' btn
        ' 
        btn.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btn.Cursor = Cursors.Hand
        btn.ForeColor = SystemColors.ButtonFace
        btn.Location = New Point(664, 12)
        btn.Name = "btn"
        btn.Size = New Size(124, 37)
        btn.TabIndex = 0
        btn.Text = "Conexion BBDD"
        btn.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = Color.Black
        Button1.Location = New Point(177, 345)
        Button1.Name = "Button1"
        Button1.Size = New Size(134, 44)
        Button1.TabIndex = 1
        Button1.Text = "REGISTRARSE"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btnInicioSesion
        ' 
        btnInicioSesion.BackColor = Color.FromArgb(CByte(255), CByte(192), CByte(128))
        btnInicioSesion.Cursor = Cursors.Hand
        btnInicioSesion.Font = New Font("Palatino Linotype", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInicioSesion.ForeColor = SystemColors.ActiveCaptionText
        btnInicioSesion.Location = New Point(20, 345)
        btnInicioSesion.Name = "btnInicioSesion"
        btnInicioSesion.Size = New Size(138, 44)
        btnInicioSesion.TabIndex = 2
        btnInicioSesion.Text = "LOG IN"
        btnInicioSesion.TextImageRelation = TextImageRelation.ImageAboveText
        btnInicioSesion.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.SandyBrown
        GroupBox1.Controls.Add(tbRecPsw)
        GroupBox1.Controls.Add(btnRecPsw)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(tbPswLog)
        GroupBox1.Controls.Add(tbNameLog)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(btnInicioSesion)
        GroupBox1.Location = New Point(218, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 409)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(63, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 15)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(63, 72)
        Label1.Name = "Label1"
        Label1.Size = New Size(47, 15)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' tbPswLog
        ' 
        tbPswLog.Location = New Point(157, 156)
        tbPswLog.Name = "tbPswLog"
        tbPswLog.Size = New Size(130, 23)
        tbPswLog.TabIndex = 4
        ' 
        ' tbNameLog
        ' 
        tbNameLog.Location = New Point(157, 69)
        tbNameLog.Name = "tbNameLog"
        tbNameLog.Size = New Size(130, 23)
        tbNameLog.TabIndex = 3
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(128), CByte(64), CByte(0))
        GroupBox2.Location = New Point(207, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(357, 432)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' btnRecPsw
        ' 
        btnRecPsw.Location = New Point(88, 268)
        btnRecPsw.Name = "btnRecPsw"
        btnRecPsw.Size = New Size(156, 23)
        btnRecPsw.TabIndex = 7
        btnRecPsw.Text = "Recuperar Contraseña"
        btnRecPsw.UseVisualStyleBackColor = True
        ' 
        ' tbRecPsw
        ' 
        tbRecPsw.Location = New Point(88, 223)
        tbRecPsw.Name = "tbRecPsw"
        tbRecPsw.Size = New Size(156, 23)
        tbRecPsw.TabIndex = 8
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SandyBrown
        ClientSize = New Size(800, 450)
        Controls.Add(btn)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPswLog As TextBox
    Friend WithEvents tbNameLog As TextBox
    Friend WithEvents btnRecPsw As Button
    Friend WithEvents tbRecPsw As TextBox

End Class

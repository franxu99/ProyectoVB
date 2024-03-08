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
        GroupBox2 = New GroupBox()
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
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(btnInicioSesion)
        GroupBox1.Location = New Point(218, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 409)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox

End Class

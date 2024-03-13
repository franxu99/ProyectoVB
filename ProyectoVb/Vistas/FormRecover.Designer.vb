<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRecover
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRecover))
        TxtEmail = New TextBox()
        TxtCode = New TextBox()
        TxtPass1 = New TextBox()
        TxtPass2 = New TextBox()
        BtnAction = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        imgPass = New PictureBox()
        PictureBox4 = New PictureBox()
        imgGmail = New PictureBox()
        PictureBox3 = New PictureBox()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        GroupBox1 = New GroupBox()
        GroupBox2 = New GroupBox()
        PictureBox2 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPass, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgGmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' TxtEmail
        ' 
        TxtEmail.BackColor = Color.AliceBlue
        TxtEmail.Location = New Point(76, 128)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(205, 23)
        TxtEmail.TabIndex = 0
        ' 
        ' TxtCode
        ' 
        TxtCode.BackColor = Color.AliceBlue
        TxtCode.Location = New Point(42, 153)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(205, 23)
        TxtCode.TabIndex = 1
        ' 
        ' TxtPass1
        ' 
        TxtPass1.BackColor = Color.AliceBlue
        TxtPass1.Location = New Point(76, 227)
        TxtPass1.Name = "TxtPass1"
        TxtPass1.PasswordChar = "*"c
        TxtPass1.Size = New Size(205, 23)
        TxtPass1.TabIndex = 2
        ' 
        ' TxtPass2
        ' 
        TxtPass2.BackColor = Color.AliceBlue
        TxtPass2.Location = New Point(76, 276)
        TxtPass2.Name = "TxtPass2"
        TxtPass2.PasswordChar = "*"c
        TxtPass2.Size = New Size(205, 23)
        TxtPass2.TabIndex = 3
        ' 
        ' BtnAction
        ' 
        BtnAction.BackColor = Color.DarkSlateGray
        BtnAction.Cursor = Cursors.Hand
        BtnAction.Font = New Font("Century Gothic", 11.0F, FontStyle.Bold)
        BtnAction.ForeColor = Color.White
        BtnAction.Location = New Point(20, 282)
        BtnAction.Name = "BtnAction"
        BtnAction.Size = New Size(230, 54)
        BtnAction.TabIndex = 4
        BtnAction.Text = "RESTABLECER CONTRASEÑA"
        BtnAction.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonFace
        Label1.Font = New Font("Century Gothic", 9.0F)
        Label1.Location = New Point(54, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 17)
        Label1.TabIndex = 5
        Label1.Text = "Correo Electronico"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 9.0F)
        Label2.Location = New Point(20, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(176, 17)
        Label2.TabIndex = 6
        Label2.Text = "Codigo de restablecimiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Century Gothic", 9.0F)
        Label3.Location = New Point(53, 208)
        Label3.Name = "Label3"
        Label3.Size = New Size(77, 17)
        Label3.TabIndex = 7
        Label3.Text = "Contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Century Gothic", 9.0F)
        Label4.Location = New Point(54, 257)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 17)
        Label4.TabIndex = 8
        Label4.Text = "Contraseña Repetida"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(imgPass)
        Panel1.Controls.Add(PictureBox4)
        Panel1.Controls.Add(imgGmail)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(TxtCode)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(BtnAction)
        Panel1.Location = New Point(34, 24)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(263, 345)
        Panel1.TabIndex = 10
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(20, 254)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(20, 19)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 22
        PictureBox5.TabStop = False
        ' 
        ' imgPass
        ' 
        imgPass.Image = CType(resources.GetObject("imgPass.Image"), Image)
        imgPass.Location = New Point(20, 206)
        imgPass.Name = "imgPass"
        imgPass.Size = New Size(20, 19)
        imgPass.SizeMode = PictureBoxSizeMode.StretchImage
        imgPass.TabIndex = 21
        imgPass.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(20, 155)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(20, 20)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 20
        PictureBox4.TabStop = False
        ' 
        ' imgGmail
        ' 
        imgGmail.Image = CType(resources.GetObject("imgGmail.Image"), Image)
        imgGmail.Location = New Point(20, 107)
        imgGmail.Name = "imgGmail"
        imgGmail.Size = New Size(20, 19)
        imgGmail.SizeMode = PictureBoxSizeMode.StretchImage
        imgGmail.TabIndex = 18
        imgGmail.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-6, -12)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(51, 59)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 19
        PictureBox3.TabStop = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonFace
        Label5.Font = New Font("Century Gothic", 12.0F, FontStyle.Bold)
        Label5.ForeColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        Label5.Location = New Point(19, 52)
        Label5.Name = "Label5"
        Label5.Size = New Size(204, 19)
        Label5.TabIndex = 13
        Label5.Text = "RECUPERAR CONTRASEÑA"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(199, -8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(73, 64)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Location = New Point(-11, -4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(286, 359)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.Controls.Add(GroupBox1)
        GroupBox2.Location = New Point(24, 11)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(283, 369)
        GroupBox2.TabIndex = 11
        GroupBox2.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(337, 389)
        PictureBox2.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox2.TabIndex = 12
        PictureBox2.TabStop = False
        ' 
        ' FormRecover
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(337, 389)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(TxtPass2)
        Controls.Add(TxtPass1)
        Controls.Add(TxtEmail)
        Controls.Add(Panel1)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox2)
        Name = "FormRecover"
        Text = "FormRecover"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPass, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(imgGmail, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtCode As TextBox
    Friend WithEvents TxtPass1 As TextBox
    Friend WithEvents TxtPass2 As TextBox
    Friend WithEvents BtnAction As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents imgGmail As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents imgPass As PictureBox
End Class

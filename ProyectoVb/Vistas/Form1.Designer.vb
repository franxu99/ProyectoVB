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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btn = New Button()
        btnRegistro = New Button()
        btnInicioSesion = New Button()
        GroupBox1 = New GroupBox()
        PictureBox4 = New PictureBox()
        btnCompletarReg = New Button()
        tbNameReg = New TextBox()
        imgUser = New PictureBox()
        tbNameLog = New TextBox()
        imgGmail = New PictureBox()
        imgPass = New PictureBox()
        lblEmailReg = New Label()
        tbEmailReg = New TextBox()
        PictureBox1 = New PictureBox()
        tbPswLog = New TextBox()
        tbPswReg = New TextBox()
        Label1 = New Label()
        lblTitle = New Label()
        Label2 = New Label()
        tbRecPsw = New TextBox()
        btnRecPsw = New Button()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        GroupBox2 = New GroupBox()
        btnVolverReg = New Button()
        GroupBox1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgUser, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgGmail, ComponentModel.ISupportInitialize).BeginInit()
        CType(imgPass, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
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
        ' btnRegistro
        ' 
        btnRegistro.BackColor = Color.DarkSlateGray
        btnRegistro.Cursor = Cursors.Hand
        btnRegistro.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRegistro.ForeColor = Color.White
        btnRegistro.Location = New Point(167, 308)
        btnRegistro.Name = "btnRegistro"
        btnRegistro.Size = New Size(145, 36)
        btnRegistro.TabIndex = 1
        btnRegistro.Text = "REGISTRARSE"
        btnRegistro.UseVisualStyleBackColor = False
        ' 
        ' btnInicioSesion
        ' 
        btnInicioSesion.BackColor = Color.DarkSlateGray
        btnInicioSesion.Cursor = Cursors.Hand
        btnInicioSesion.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnInicioSesion.ForeColor = Color.White
        btnInicioSesion.Location = New Point(24, 308)
        btnInicioSesion.Name = "btnInicioSesion"
        btnInicioSesion.Size = New Size(134, 36)
        btnInicioSesion.TabIndex = 2
        btnInicioSesion.Text = "LOG IN"
        btnInicioSesion.TextImageRelation = TextImageRelation.ImageAboveText
        btnInicioSesion.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ButtonFace
        GroupBox1.Controls.Add(btnVolverReg)
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Controls.Add(btnCompletarReg)
        GroupBox1.Controls.Add(tbNameReg)
        GroupBox1.Controls.Add(imgUser)
        GroupBox1.Controls.Add(tbNameLog)
        GroupBox1.Controls.Add(imgGmail)
        GroupBox1.Controls.Add(btnInicioSesion)
        GroupBox1.Controls.Add(imgPass)
        GroupBox1.Controls.Add(btnRegistro)
        GroupBox1.Controls.Add(lblEmailReg)
        GroupBox1.Controls.Add(tbEmailReg)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(tbPswLog)
        GroupBox1.Controls.Add(tbPswReg)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(lblTitle)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(tbRecPsw)
        GroupBox1.Controls.Add(btnRecPsw)
        GroupBox1.Controls.Add(PictureBox3)
        GroupBox1.Location = New Point(218, 23)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(334, 409)
        GroupBox1.TabIndex = 3
        GroupBox1.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = SystemColors.ButtonHighlight
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(269, -7)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(70, 81)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 18
        PictureBox4.TabStop = False
        ' 
        ' btnCompletarReg
        ' 
        btnCompletarReg.BackColor = Color.DarkSlateGray
        btnCompletarReg.Font = New Font("Century Gothic", 11F, FontStyle.Bold)
        btnCompletarReg.ForeColor = Color.White
        btnCompletarReg.Location = New Point(60, 350)
        btnCompletarReg.Name = "btnCompletarReg"
        btnCompletarReg.Size = New Size(226, 44)
        btnCompletarReg.TabIndex = 14
        btnCompletarReg.Text = "COMPLETAR REGISTRO"
        btnCompletarReg.UseVisualStyleBackColor = False
        btnCompletarReg.Visible = False
        ' 
        ' tbNameReg
        ' 
        tbNameReg.BackColor = Color.AliceBlue
        tbNameReg.Location = New Point(139, 174)
        tbNameReg.Name = "tbNameReg"
        tbNameReg.Size = New Size(130, 23)
        tbNameReg.TabIndex = 10
        tbNameReg.Visible = False
        ' 
        ' imgUser
        ' 
        imgUser.Image = CType(resources.GetObject("imgUser.Image"), Image)
        imgUser.Location = New Point(39, 174)
        imgUser.Name = "imgUser"
        imgUser.Size = New Size(20, 19)
        imgUser.SizeMode = PictureBoxSizeMode.StretchImage
        imgUser.TabIndex = 15
        imgUser.TabStop = False
        ' 
        ' tbNameLog
        ' 
        tbNameLog.BackColor = Color.AliceBlue
        tbNameLog.Location = New Point(139, 174)
        tbNameLog.Name = "tbNameLog"
        tbNameLog.Size = New Size(130, 23)
        tbNameLog.TabIndex = 3
        ' 
        ' imgGmail
        ' 
        imgGmail.Image = CType(resources.GetObject("imgGmail.Image"), Image)
        imgGmail.Location = New Point(39, 265)
        imgGmail.Name = "imgGmail"
        imgGmail.Size = New Size(20, 19)
        imgGmail.SizeMode = PictureBoxSizeMode.StretchImage
        imgGmail.TabIndex = 17
        imgGmail.TabStop = False
        imgGmail.Visible = False
        ' 
        ' imgPass
        ' 
        imgPass.Image = CType(resources.GetObject("imgPass.Image"), Image)
        imgPass.Location = New Point(39, 222)
        imgPass.Name = "imgPass"
        imgPass.Size = New Size(20, 19)
        imgPass.SizeMode = PictureBoxSizeMode.StretchImage
        imgPass.TabIndex = 16
        imgPass.TabStop = False
        ' 
        ' lblEmailReg
        ' 
        lblEmailReg.AutoSize = True
        lblEmailReg.Font = New Font("Century Gothic", 11F)
        lblEmailReg.Location = New Point(66, 264)
        lblEmailReg.Name = "lblEmailReg"
        lblEmailReg.Size = New Size(46, 20)
        lblEmailReg.TabIndex = 13
        lblEmailReg.Text = "Email"
        lblEmailReg.Visible = False
        ' 
        ' tbEmailReg
        ' 
        tbEmailReg.BackColor = Color.AliceBlue
        tbEmailReg.Location = New Point(118, 264)
        tbEmailReg.Name = "tbEmailReg"
        tbEmailReg.Size = New Size(130, 23)
        tbEmailReg.TabIndex = 12
        tbEmailReg.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(118, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(103, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' tbPswLog
        ' 
        tbPswLog.BackColor = Color.AliceBlue
        tbPswLog.Location = New Point(161, 218)
        tbPswLog.Name = "tbPswLog"
        tbPswLog.PasswordChar = ChrW(&H25CF)
        tbPswLog.Size = New Size(130, 23)
        tbPswLog.TabIndex = 4
        ' 
        ' tbPswReg
        ' 
        tbPswReg.BackColor = Color.AliceBlue
        tbPswReg.Location = New Point(161, 218)
        tbPswReg.Name = "tbPswReg"
        tbPswReg.PasswordChar = ChrW(&H25CF)
        tbPswReg.Size = New Size(130, 23)
        tbPswReg.TabIndex = 11
        tbPswReg.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(66, 174)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 5
        Label1.Text = "Usuario"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Century Gothic", 14F)
        lblTitle.Location = New Point(130, 143)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(77, 22)
        lblTitle.TabIndex = 9
        lblTitle.Text = "LOG IN"
        lblTitle.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(60, 221)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 20)
        Label2.TabIndex = 6
        Label2.Text = "Contraseña"
        ' 
        ' tbRecPsw
        ' 
        tbRecPsw.BackColor = Color.White
        tbRecPsw.Location = New Point(198, 371)
        tbRecPsw.Name = "tbRecPsw"
        tbRecPsw.Size = New Size(114, 23)
        tbRecPsw.TabIndex = 8
        ' 
        ' btnRecPsw
        ' 
        btnRecPsw.BackColor = Color.DarkSlateGray
        btnRecPsw.Font = New Font("Century Gothic", 10F)
        btnRecPsw.ForeColor = Color.White
        btnRecPsw.Location = New Point(6, 361)
        btnRecPsw.Name = "btnRecPsw"
        btnRecPsw.Size = New Size(322, 42)
        btnRecPsw.TabIndex = 7
        btnRecPsw.Text = " Recuperar Contraseña : "
        btnRecPsw.TextAlign = ContentAlignment.MiddleLeft
        btnRecPsw.UseVisualStyleBackColor = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ButtonHighlight
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(-19, -3)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(70, 81)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Dock = DockStyle.Fill
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(0, 0)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(800, 552)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.Location = New Point(207, 12)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(357, 432)
        GroupBox2.TabIndex = 4
        GroupBox2.TabStop = False
        ' 
        ' btnVolverReg
        ' 
        btnVolverReg.BackColor = Color.DarkSlateGray
        btnVolverReg.Cursor = Cursors.Hand
        btnVolverReg.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnVolverReg.ForeColor = Color.White
        btnVolverReg.Location = New Point(6, 11)
        btnVolverReg.Name = "btnVolverReg"
        btnVolverReg.Size = New Size(85, 36)
        btnVolverReg.TabIndex = 20
        btnVolverReg.Text = "VOLVER"
        btnVolverReg.TextImageRelation = TextImageRelation.ImageAboveText
        btnVolverReg.UseVisualStyleBackColor = False
        btnVolverReg.Visible = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkSlateGray
        ClientSize = New Size(800, 552)
        Controls.Add(btn)
        Controls.Add(GroupBox1)
        Controls.Add(GroupBox2)
        Controls.Add(PictureBox2)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(imgUser, ComponentModel.ISupportInitialize).EndInit()
        CType(imgGmail, ComponentModel.ISupportInitialize).EndInit()
        CType(imgPass, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn As Button
    Friend WithEvents btnRegistro As Button
    Friend WithEvents btnInicioSesion As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPswLog As TextBox
    Friend WithEvents btnRecPsw As Button
    Friend WithEvents tbRecPsw As TextBox
    Friend WithEvents tbEmailReg As TextBox
    Friend WithEvents tbPswReg As TextBox
    Friend WithEvents lblEmailReg As Label
    Friend WithEvents btnCompletarReg As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents imgUser As PictureBox
    Friend WithEvents imgPass As PictureBox
    Friend WithEvents imgGmail As PictureBox
    Friend WithEvents tbNameReg As TextBox
    Friend WithEvents tbNameLog As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents btnVolverReg As Button

End Class

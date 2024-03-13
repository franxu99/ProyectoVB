<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormApp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormApp))
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Label1 = New Label()
        LblName = New Label()
        Label2 = New Label()
        BtnUpgrade = New Button()
        BtnDowngrade = New Button()
        BtnDeactivate = New Button()
        GB1 = New GroupBox()
        PictureBox2 = New PictureBox()
        BtnChangeOwnership = New Button()
        LblSelectedID = New Label()
        DateTime = New DateTimePicker()
        GbFilters = New GroupBox()
        CBDatetime = New CheckBox()
        BtnAplicarFiltros = New Button()
        ClbActivated = New CheckedListBox()
        GroupBox2 = New GroupBox()
        GroupBox1 = New GroupBox()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GB1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GbFilters.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(66, 238)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(598, 261)
        DataGridView1.TabIndex = 0
        DataGridView1.Visible = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.DarkSlateGray
        Button1.Cursor = Cursors.Hand
        Button1.Font = New Font("Century Gothic", 12.75F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(47, 146)
        Button1.Name = "Button1"
        Button1.Size = New Size(133, 71)
        Button1.TabIndex = 1
        Button1.Text = "CERRAR SESIÓN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(30, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 33)
        Label1.TabIndex = 2
        Label1.Text = "Bienvenido"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.BackColor = Color.Transparent
        LblName.Font = New Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LblName.ForeColor = SystemColors.ActiveCaptionText
        LblName.Location = New Point(47, 88)
        LblName.Name = "LblName"
        LblName.Size = New Size(133, 33)
        LblName.TabIndex = 3
        LblName.Text = "LblName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(61, 159)
        Label2.Name = "Label2"
        Label2.Size = New Size(131, 20)
        Label2.TabIndex = 4
        Label2.Text = "ID Seleccionado"
        ' 
        ' BtnUpgrade
        ' 
        BtnUpgrade.BackColor = Color.DarkSlateGray
        BtnUpgrade.Cursor = Cursors.Hand
        BtnUpgrade.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        BtnUpgrade.ForeColor = SystemColors.ButtonFace
        BtnUpgrade.Location = New Point(21, 211)
        BtnUpgrade.Name = "BtnUpgrade"
        BtnUpgrade.Size = New Size(213, 50)
        BtnUpgrade.TabIndex = 5
        BtnUpgrade.Text = "UPGRADE USER"
        BtnUpgrade.UseVisualStyleBackColor = False
        ' 
        ' BtnDowngrade
        ' 
        BtnDowngrade.BackColor = Color.DarkSlateGray
        BtnDowngrade.Cursor = Cursors.Hand
        BtnDowngrade.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        BtnDowngrade.ForeColor = SystemColors.ButtonFace
        BtnDowngrade.Location = New Point(21, 267)
        BtnDowngrade.Name = "BtnDowngrade"
        BtnDowngrade.Size = New Size(213, 50)
        BtnDowngrade.TabIndex = 6
        BtnDowngrade.Text = "DOWNGRADE USER"
        BtnDowngrade.UseVisualStyleBackColor = False
        ' 
        ' BtnDeactivate
        ' 
        BtnDeactivate.BackColor = Color.DarkSlateGray
        BtnDeactivate.Cursor = Cursors.Hand
        BtnDeactivate.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        BtnDeactivate.ForeColor = SystemColors.ButtonFace
        BtnDeactivate.Location = New Point(21, 323)
        BtnDeactivate.Name = "BtnDeactivate"
        BtnDeactivate.Size = New Size(213, 54)
        BtnDeactivate.TabIndex = 7
        BtnDeactivate.Text = "DESACTIVATE / ACTIVATE USER"
        BtnDeactivate.UseVisualStyleBackColor = False
        ' 
        ' GB1
        ' 
        GB1.Controls.Add(PictureBox2)
        GB1.Controls.Add(BtnChangeOwnership)
        GB1.Controls.Add(LblSelectedID)
        GB1.Controls.Add(Label2)
        GB1.Controls.Add(BtnDeactivate)
        GB1.Controls.Add(BtnUpgrade)
        GB1.Controls.Add(BtnDowngrade)
        GB1.Font = New Font("Century Gothic", 11F)
        GB1.Location = New Point(701, 25)
        GB1.Name = "GB1"
        GB1.Size = New Size(252, 467)
        GB1.TabIndex = 8
        GB1.TabStop = False
        GB1.Text = "Funciones de Administracion"
        GB1.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(61, 24)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(130, 125)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' BtnChangeOwnership
        ' 
        BtnChangeOwnership.BackColor = Color.DarkSlateGray
        BtnChangeOwnership.Cursor = Cursors.Hand
        BtnChangeOwnership.Font = New Font("Century Gothic", 11.25F, FontStyle.Bold)
        BtnChangeOwnership.ForeColor = SystemColors.ButtonFace
        BtnChangeOwnership.Location = New Point(21, 383)
        BtnChangeOwnership.Name = "BtnChangeOwnership"
        BtnChangeOwnership.Size = New Size(213, 54)
        BtnChangeOwnership.TabIndex = 10
        BtnChangeOwnership.Text = "CHANGE OWNERSHIP"
        BtnChangeOwnership.UseVisualStyleBackColor = False
        BtnChangeOwnership.Visible = False
        ' 
        ' LblSelectedID
        ' 
        LblSelectedID.AutoSize = True
        LblSelectedID.Location = New Point(99, 179)
        LblSelectedID.Name = "LblSelectedID"
        LblSelectedID.Size = New Size(57, 20)
        LblSelectedID.TabIndex = 9
        LblSelectedID.Text = "Label3"
        ' 
        ' DateTime
        ' 
        DateTime.CalendarFont = New Font("Century Gothic", 11F)
        DateTime.Location = New Point(80, 85)
        DateTime.Name = "DateTime"
        DateTime.Size = New Size(227, 23)
        DateTime.TabIndex = 10
        ' 
        ' GbFilters
        ' 
        GbFilters.Controls.Add(CBDatetime)
        GbFilters.Controls.Add(BtnAplicarFiltros)
        GbFilters.Controls.Add(ClbActivated)
        GbFilters.Controls.Add(DateTime)
        GbFilters.Location = New Point(243, 27)
        GbFilters.Name = "GbFilters"
        GbFilters.Size = New Size(408, 190)
        GbFilters.TabIndex = 11
        GbFilters.TabStop = False
        GbFilters.Text = "Filtros"
        GbFilters.Visible = False
        ' 
        ' CBDatetime
        ' 
        CBDatetime.AutoSize = True
        CBDatetime.Font = New Font("Century Gothic", 11F)
        CBDatetime.Location = New Point(47, 59)
        CBDatetime.Name = "CBDatetime"
        CBDatetime.Size = New Size(304, 24)
        CBDatetime.TabIndex = 12
        CBDatetime.Text = "Buscar registros posteriores a la fecha"
        CBDatetime.UseVisualStyleBackColor = True
        ' 
        ' BtnAplicarFiltros
        ' 
        BtnAplicarFiltros.BackColor = Color.DarkSlateGray
        BtnAplicarFiltros.Cursor = Cursors.Hand
        BtnAplicarFiltros.Font = New Font("Century Gothic", 14.75F, FontStyle.Bold)
        BtnAplicarFiltros.ForeColor = SystemColors.ButtonFace
        BtnAplicarFiltros.Location = New Point(85, 119)
        BtnAplicarFiltros.Name = "BtnAplicarFiltros"
        BtnAplicarFiltros.Size = New Size(222, 58)
        BtnAplicarFiltros.TabIndex = 11
        BtnAplicarFiltros.Text = "APLICAR FILTROS"
        BtnAplicarFiltros.UseVisualStyleBackColor = False
        ' 
        ' ClbActivated
        ' 
        ClbActivated.CheckOnClick = True
        ClbActivated.Font = New Font("Century Gothic", 11F)
        ClbActivated.FormattingEnabled = True
        ClbActivated.Items.AddRange(New Object() {"Activated", "Deactivated"})
        ClbActivated.Location = New Point(136, 9)
        ClbActivated.Name = "ClbActivated"
        ClbActivated.Size = New Size(126, 44)
        ClbActivated.TabIndex = 9
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), Image)
        GroupBox2.Location = New Point(231, 14)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(431, 213)
        GroupBox2.TabIndex = 13
        GroupBox2.TabStop = False
        GroupBox2.Visible = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), Image)
        GroupBox1.Location = New Point(692, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(270, 487)
        GroupBox1.TabIndex = 14
        GroupBox1.TabStop = False
        GroupBox1.Visible = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(0, 0)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1003, 524)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        PictureBox1.Visible = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Transparent
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(101, 206)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(21, 18)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' FormApp
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1003, 524)
        Controls.Add(PictureBox3)
        Controls.Add(GbFilters)
        Controls.Add(GB1)
        Controls.Add(LblName)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(PictureBox1)
        Name = "FormApp"
        Text = "FormAdmin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GB1.ResumeLayout(False)
        GB1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GbFilters.ResumeLayout(False)
        GbFilters.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnUpgrade As Button
    Friend WithEvents BtnDowngrade As Button
    Friend WithEvents BtnDeactivate As Button
    Friend WithEvents GB1 As GroupBox
    Friend WithEvents LblSelectedID As Label
    Friend WithEvents BtnChangeOwnership As Button
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents GbFilters As GroupBox
    Friend WithEvents BtnAplicarFiltros As Button
    Friend WithEvents ClbActivated As CheckedListBox
    Friend WithEvents CBDatetime As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class

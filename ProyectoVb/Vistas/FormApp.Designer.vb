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
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Label1 = New Label()
        LblName = New Label()
        Label2 = New Label()
        BtnUpgrade = New Button()
        BtnDowngrade = New Button()
        BtnDeactivate = New Button()
        GB1 = New GroupBox()
        BtnChangeOwnership = New Button()
        LblSelectedID = New Label()
        DateTime = New DateTimePicker()
        GbFilters = New GroupBox()
        CBDatetime = New CheckBox()
        BtnAplicarFiltros = New Button()
        ClbActivated = New CheckedListBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GB1.SuspendLayout()
        GbFilters.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(76, 218)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(567, 229)
        DataGridView1.TabIndex = 0
        DataGridView1.Visible = False
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(53, 35)
        Button1.Name = "Button1"
        Button1.Size = New Size(97, 25)
        Button1.TabIndex = 1
        Button1.Text = "Cerrar Sesión"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(262, 35)
        Label1.Name = "Label1"
        Label1.Size = New Size(69, 15)
        Label1.TabIndex = 2
        Label1.Text = "Bienvenido:"
        ' 
        ' LblName
        ' 
        LblName.AutoSize = True
        LblName.Location = New Point(337, 35)
        LblName.Name = "LblName"
        LblName.Size = New Size(55, 15)
        LblName.TabIndex = 3
        LblName.Text = "LblName"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 15)
        Label2.TabIndex = 4
        Label2.Text = "ID Seleccionado"
        ' 
        ' BtnUpgrade
        ' 
        BtnUpgrade.Location = New Point(6, 65)
        BtnUpgrade.Name = "BtnUpgrade"
        BtnUpgrade.Size = New Size(188, 23)
        BtnUpgrade.TabIndex = 5
        BtnUpgrade.Text = "Upgrade User"
        BtnUpgrade.UseVisualStyleBackColor = True
        ' 
        ' BtnDowngrade
        ' 
        BtnDowngrade.Location = New Point(6, 94)
        BtnDowngrade.Name = "BtnDowngrade"
        BtnDowngrade.Size = New Size(188, 23)
        BtnDowngrade.TabIndex = 6
        BtnDowngrade.Text = "Downgrade User"
        BtnDowngrade.UseVisualStyleBackColor = True
        ' 
        ' BtnDeactivate
        ' 
        BtnDeactivate.Location = New Point(6, 123)
        BtnDeactivate.Name = "BtnDeactivate"
        BtnDeactivate.Size = New Size(188, 23)
        BtnDeactivate.TabIndex = 7
        BtnDeactivate.Text = "Deactivate/Activate User"
        BtnDeactivate.UseVisualStyleBackColor = True
        ' 
        ' GB1
        ' 
        GB1.Controls.Add(BtnChangeOwnership)
        GB1.Controls.Add(LblSelectedID)
        GB1.Controls.Add(Label2)
        GB1.Controls.Add(BtnDeactivate)
        GB1.Controls.Add(BtnUpgrade)
        GB1.Controls.Add(BtnDowngrade)
        GB1.Location = New Point(773, 218)
        GB1.Name = "GB1"
        GB1.Size = New Size(200, 183)
        GB1.TabIndex = 8
        GB1.TabStop = False
        GB1.Text = "Funciones de Administracion"
        GB1.Visible = False
        ' 
        ' BtnChangeOwnership
        ' 
        BtnChangeOwnership.Location = New Point(6, 152)
        BtnChangeOwnership.Name = "BtnChangeOwnership"
        BtnChangeOwnership.Size = New Size(188, 23)
        BtnChangeOwnership.TabIndex = 10
        BtnChangeOwnership.Text = "Change Ownership"
        BtnChangeOwnership.UseVisualStyleBackColor = True
        BtnChangeOwnership.Visible = False
        ' 
        ' LblSelectedID
        ' 
        LblSelectedID.AutoSize = True
        LblSelectedID.Location = New Point(113, 38)
        LblSelectedID.Name = "LblSelectedID"
        LblSelectedID.Size = New Size(41, 15)
        LblSelectedID.TabIndex = 9
        LblSelectedID.Text = "Label3"
        ' 
        ' DateTime
        ' 
        DateTime.Location = New Point(145, 22)
        DateTime.Name = "DateTime"
        DateTime.Size = New Size(240, 23)
        DateTime.TabIndex = 10
        ' 
        ' GbFilters
        ' 
        GbFilters.Controls.Add(CBDatetime)
        GbFilters.Controls.Add(BtnAplicarFiltros)
        GbFilters.Controls.Add(ClbActivated)
        GbFilters.Controls.Add(DateTime)
        GbFilters.Location = New Point(76, 102)
        GbFilters.Name = "GbFilters"
        GbFilters.Size = New Size(402, 100)
        GbFilters.TabIndex = 11
        GbFilters.TabStop = False
        GbFilters.Text = "Filtros"
        GbFilters.Visible = False
        ' 
        ' CBDatetime
        ' 
        CBDatetime.AutoSize = True
        CBDatetime.Location = New Point(145, 46)
        CBDatetime.Name = "CBDatetime"
        CBDatetime.Size = New Size(223, 19)
        CBDatetime.TabIndex = 12
        CBDatetime.Text = "Buscar registros posteriores a la fecha"
        CBDatetime.UseVisualStyleBackColor = True
        ' 
        ' BtnAplicarFiltros
        ' 
        BtnAplicarFiltros.Location = New Point(321, 71)
        BtnAplicarFiltros.Name = "BtnAplicarFiltros"
        BtnAplicarFiltros.Size = New Size(75, 23)
        BtnAplicarFiltros.TabIndex = 11
        BtnAplicarFiltros.Text = "Aplicar Filtros"
        BtnAplicarFiltros.UseVisualStyleBackColor = True
        ' 
        ' ClbActivated
        ' 
        ClbActivated.CheckOnClick = True
        ClbActivated.FormattingEnabled = True
        ClbActivated.Items.AddRange(New Object() {"Activated", "Deactivated"})
        ClbActivated.Location = New Point(6, 19)
        ClbActivated.Name = "ClbActivated"
        ClbActivated.Size = New Size(95, 40)
        ClbActivated.TabIndex = 9
        ' 
        ' FormApp
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1003, 524)
        Controls.Add(GbFilters)
        Controls.Add(GB1)
        Controls.Add(LblName)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Name = "FormApp"
        Text = "FormAdmin"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GB1.ResumeLayout(False)
        GB1.PerformLayout()
        GbFilters.ResumeLayout(False)
        GbFilters.PerformLayout()
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
End Class

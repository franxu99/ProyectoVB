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
        TxtEmail = New TextBox()
        TxtCode = New TextBox()
        TxtPass1 = New TextBox()
        TxtPass2 = New TextBox()
        BtnAction = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' TxtEmail
        ' 
        TxtEmail.Location = New Point(44, 60)
        TxtEmail.Name = "TxtEmail"
        TxtEmail.Size = New Size(235, 23)
        TxtEmail.TabIndex = 0
        ' 
        ' TxtCode
        ' 
        TxtCode.Location = New Point(44, 115)
        TxtCode.Name = "TxtCode"
        TxtCode.Size = New Size(235, 23)
        TxtCode.TabIndex = 1
        ' 
        ' TxtPass1
        ' 
        TxtPass1.Location = New Point(44, 174)
        TxtPass1.Name = "TxtPass1"
        TxtPass1.PasswordChar = "*"c
        TxtPass1.Size = New Size(235, 23)
        TxtPass1.TabIndex = 2
        ' 
        ' TxtPass2
        ' 
        TxtPass2.Location = New Point(44, 232)
        TxtPass2.Name = "TxtPass2"
        TxtPass2.PasswordChar = "*"c
        TxtPass2.Size = New Size(235, 23)
        TxtPass2.TabIndex = 3
        ' 
        ' BtnAction
        ' 
        BtnAction.Location = New Point(91, 300)
        BtnAction.Name = "BtnAction"
        BtnAction.Size = New Size(138, 48)
        BtnAction.TabIndex = 4
        BtnAction.Text = "Restablecer Contraseña"
        BtnAction.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(44, 42)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 15)
        Label1.TabIndex = 5
        Label1.Text = "Correo Electronico"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(44, 97)
        Label2.Name = "Label2"
        Label2.Size = New Size(153, 15)
        Label2.TabIndex = 6
        Label2.Text = "Codigo de restablecimiento"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(44, 156)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 7
        Label3.Text = "Contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(44, 214)
        Label4.Name = "Label4"
        Label4.Size = New Size(116, 15)
        Label4.TabIndex = 8
        Label4.Text = "Contraseña Repetida"
        ' 
        ' FormRecover
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(337, 389)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(BtnAction)
        Controls.Add(TxtPass2)
        Controls.Add(TxtPass1)
        Controls.Add(TxtCode)
        Controls.Add(TxtEmail)
        Name = "FormRecover"
        Text = "FormRecover"
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
End Class

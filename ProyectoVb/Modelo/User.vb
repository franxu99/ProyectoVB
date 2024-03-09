Public Class User
    ' Propiedades públicas para el nombre, la contraseña y el rol del usuario
    Public Property Name As String
    Public Property Psw As String
    Public Property Rol As String

    ' Constructor de la clase User que permite inicializar las propiedades
    Public Sub New(name As String, psw As String, rol As String)
        Me.Name = name
        Me.Psw = psw
        Me.Rol = rol
    End Sub
End Class
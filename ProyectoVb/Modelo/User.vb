Public Class User
    ' Propiedades públicas para el nombre, la contraseña y el rol del usuario
    Private id As Integer
    Private name As String
    Private psw As String
    Private rol As String

    Public Property accessId As Integer
        Get
            Return id

        End Get
        Set(value As Integer)
            id = value
        End Set
    End Property
    Public Property accessName As String
        Get
            Return name

        End Get
        Set(value As String)
            name = value
        End Set
    End Property
    Public Property accessPsw As String
        Get
            Return psw

        End Get
        Set(value As String)
            psw = value
        End Set
    End Property
    Public Property accessRol As String
        Get
            Return rol

        End Get
        Set(value As String)
            rol = value
        End Set
    End Property
    ' Constructor de la clase User que permite inicializar las propiedades
    Public Sub New()

    End Sub
    Public Sub New(name As String, psw As String, rol As String)
        Me.Name = name
        Me.Psw = psw
        Me.Rol = rol
    End Sub
End Class
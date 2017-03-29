Public Class Persona
    Private _DNI As String
    Private _Nombre As String
    Private _dao As DAOPersona

    Public Sub New(ByVal dni As String)
        Me._DNI = dni
        Me._dao = New DAOPersona
    End Sub

    Public Sub New()
        Me._dao = New DAOPersona
    End Sub

    Public Property DNI() As String
        Get
            Return Me._DNI
        End Get
        Set(value As String)
            Me._DNI = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me._Nombre
        End Get
        Set(value As String)
            Me._Nombre = value
        End Set
    End Property

    Public Property Dao() As DAOPersona
        Get
            Return Me._dao
        End Get
        Set(value As DAOPersona)
            Me._dao = value
        End Set
    End Property

    Public Sub readPersona()
        Me._dao.read(Me)
    End Sub

    Public Sub readAll()
        Me._dao.readAll()
    End Sub

    Public Sub insertPersona()
        Me._dao.insert(Me)
    End Sub

    Public Sub updatePersona()
        Me._dao.update(Me)
    End Sub

    Public Sub deletePersona()
        Me._dao.delete(Me)
    End Sub
End Class

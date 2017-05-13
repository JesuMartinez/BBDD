Public Class Conferencia
    Private _idConferencia As Integer
    Private _siglas As String
    Private _nombre As String
    Private _lugar As String
    Private _fechIni As String
    Private _fechFin As String
    Private _articulo As Articulo
    Private _daoConferencia As DAOConferencia

    Public Sub New(ByVal idConferencia As Integer)
        Me._idConferencia = idConferencia
        Me._daoConferencia = New DAOConferencia
    End Sub

    Public Sub New()
        Me._daoConferencia = New DAOConferencia
    End Sub

    Public Property IDConferencia() As Integer
        Get
            Return Me._idConferencia
        End Get
        Set(value As Integer)
            Me._idConferencia = value
        End Set
    End Property

    Public Property Siglas() As String
        Get
            Return Me._siglas
        End Get
        Set(value As String)
            Me._siglas = value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            Return Me._nombre
        End Get
        Set(value As String)
            Me._nombre = value
        End Set
    End Property

    Public Property Lugar() As String
        Get
            Return Me._lugar
        End Get
        Set(value As String)
            Me._lugar = value
        End Set
    End Property

    Public Property FechaInicio() As String
        Get
            Return Me._fechIni
        End Get
        Set(value As String)
            Me._fechIni = value
        End Set
    End Property

    Public Property FechaFin() As String
        Get
            Return Me._fechFin
        End Get
        Set(value As String)
            Me._fechFin = value
        End Set
    End Property

    Public Property Articulo() As Articulo
        Get
            Return Me._articulo
        End Get
        Set(value As Articulo)
            Me._articulo = value
        End Set
    End Property

    Public Property DAOConferencia() As DAOConferencia
        Get
            Return Me._daoConferencia
        End Get
        Set(value As DAOConferencia)
            Me._daoConferencia = value
        End Set
    End Property

    Public Sub readConferencia()
        Me._daoConferencia.read(Me)
    End Sub

    Public Sub readAll()
        Me._daoConferencia.readAll()
    End Sub

    Public Sub insertConferencia()
        Me._daoConferencia.insert(Me)
    End Sub

    Public Sub updateConferencia()
        Me._daoConferencia.update(Me)
    End Sub

    Public Sub deleteConferencia()
        Me._daoConferencia.delete(Me)
    End Sub
    'Método para gestionar las asistencias
    Public Sub readConfAsiste()
        Me._daoConferencia.readConfAsiste()
    End Sub
End Class

Public Class Articulo
    Private _idArticulo As Integer
    Private _titulo As String
    Private _conferencia As Conferencia
    Private _pagInicio As Integer
    Private _pagFin As Integer
    Private _daoArticulo As DAOArticulo
    Private _investigador As Investigador

    Public Sub New(ByVal idArticulo As Integer)
        Me._idArticulo = idArticulo
        Me._daoArticulo = New DAOArticulo
        Me._conferencia = New Conferencia
    End Sub

    Public Sub New(ByVal idArticulo As Integer, ByVal idInvest As Integer, ByVal orden As Integer)
        Me._idArticulo = idArticulo
        Me._daoArticulo = New DAOArticulo
        Me._investigador = New Investigador
        Me._investigador.IDInvestigador = idInvest
        Me._investigador.Orden = orden
    End Sub

    Public Sub New()
        Me._daoArticulo = New DAOArticulo
    End Sub

    Public Property Investigador As Investigador
        Get
            Return Me._investigador
        End Get
        Set(value As Investigador)
            Me._investigador = value
        End Set
    End Property
    Public Property IDArticulo() As Integer
        Get
            Return Me._idArticulo
        End Get
        Set(value As Integer)
            Me._idArticulo = value
        End Set
    End Property

    Public Property Conferencia() As Conferencia
        Get
            Return Me._conferencia
        End Get
        Set(value As Conferencia)
            Me._conferencia = value
        End Set
    End Property

    Public Property Titulo() As String
        Get
            Return Me._titulo
        End Get
        Set(value As String)
            Me._titulo = value
        End Set
    End Property

    Public Property PagInicio() As Integer
        Get
            Return Me._pagInicio
        End Get
        Set(value As Integer)
            Me._pagInicio = value
        End Set
    End Property

    Public Property PagFin() As Integer
        Get
            Return Me._pagFin
        End Get
        Set(value As Integer)
            Me._pagFin = value
        End Set
    End Property

    Public Property DAOArticulo() As DAOArticulo
        Get
            Return Me._daoArticulo
        End Get
        Set(value As DAOArticulo)
            Me._daoArticulo = value
        End Set
    End Property

    Public Sub readArticulo()
        Me._daoArticulo.read(Me)
    End Sub

    Public Sub readAll()
        Me._daoArticulo.readAll()
    End Sub

    Public Sub insertArticulo()
        Me._daoArticulo.insert(Me)
    End Sub

    Public Sub updateArticulo()
        Me._daoArticulo.update(Me)
    End Sub

    Public Sub autor()
        Me._daoArticulo.autor(Me, Me._investigador)
    End Sub

    Public Sub deleteArticulo()
        Me._daoArticulo.delete(Me)
    End Sub

End Class

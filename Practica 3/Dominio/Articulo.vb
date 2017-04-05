Public Class Articulo
    Private _idArticulo As Integer
    Private _titulo As String
    Private _conferencia As Conferencia
    Private _pagInicio As Integer
    Private _pagFin As Integer
    Private _daoArticulo As DAOArticulo

    Public Sub New(ByVal idArticulo As Integer)
        Me._idArticulo = idArticulo
        Me._daoArticulo = New DAOArticulo
    End Sub

    Public Sub New()
        Me._daoArticulo = New DAOArticulo
    End Sub

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

    Public Sub deleteArticulo()
        Me._daoArticulo.delete(Me)
    End Sub
End Class

Public Class DAOArticulo
    Private _listaArticulos As Collection

    Public Sub New()
        Me._listaArticulos = New Collection
    End Sub

    Public Property ListaArticulos As Collection
        Get
            Return Me._listaArticulos
        End Get
        Set(value As Collection)
            value = Me._listaArticulos
        End Set
    End Property

    Public Sub read(ByRef art As Articulo)
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM ARTICULOS WHERE idArticulo=" & art.IDArticulo & ";")
        While leer.Read
            art.IDArticulo = Convert.ToInt32(leer.GetValue(0))
            art.Titulo = leer.GetValue(1).ToString
            art.Conferencia.IDConferencia = Convert.ToInt32(leer.GetValue(2))
            art.PagInicio = Convert.ToInt32(leer.GetValue(3).ToString)
            art.PagFin = Convert.ToInt32(leer.GetValue(4).ToString)
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM ARTICULOS ORDER BY idArticulo;")
        While leer.Read
            Me.ListaArticulos.Add(New Articulo(Convert.ToInt32(leer.GetValue(0).ToString)))
        End While
    End Sub

    Public Function insert(ByVal art As Articulo) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO ARTICULOS VALUES ('" & art.IDArticulo & "','" & art.Titulo & "','" & art.Conferencia.IDConferencia & "','" & art.PagInicio & "','" & art.PagFin & "');")
    End Function

    Public Function update(ByVal art As Articulo) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE ARTICULOS SET Titulo='" & art.Titulo & "', Conferencia='" & art.Conferencia.IDConferencia & "', pag_inicio='" & art.PagInicio & "', pag_fin='" & art.PagFin & "'WHERE idArticulo=" & art.IDArticulo & ";")
    End Function

    Public Function delete(ByVal art As Articulo) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM ARTICULOS WHERE idArticulo=" & art.IDArticulo & ";")
    End Function

    Public Function autores(ByVal art As Articulo) As Integer
        Return AgenteBD.getAgente.modificar("SELECT investigadores.Nombre
                                             FROM investigadores 
                                             JOIN autor
                                             ON investigadores.idInvest = autor.Invest
                                             WHERE (autor.articulo = articulos.idArticulo) AND WHERE (articulos.idArticulo =" & art.IDArticulo & ")
                                             ORDER BY autor.Orden ;")
    End Function
End Class

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
        leer = AgenteBD.getAgente.leer("SELECT * FROM ARTICULOS WHERE idArticulo='" & art. & "';")
        While leer.Read
            per.DNI = leer.GetValue(0).ToString
            per.Nombre = leer.GetValue(1).ToString
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM ARTICULOS ORDER BY idArticulo;")
        While leer.Read
            Me.ListaArticulos.Add(New Articulo(leer.GetValue(0).ToString))
        End While
    End Sub

    Public Function insert(ByVal per As Articulo) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO ARTICULOS VALUES ('" & per.DNI & "','" & per.Nombre & "');")
    End Function

    Public Function update(ByVal per As Articulo) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE ARTICULOS SET Titulo='" & per.Nombre & "'WHERE idArticulo='" & per.DNI & "';")
    End Function

    Public Function delete(ByVal per As Articulo) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM ARTICULOS WHERE idArticulo='" & per.DNI & "';")
    End Function

End Class

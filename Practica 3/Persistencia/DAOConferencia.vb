Public Class DAOConferencia
    Private _listaConferencias As Collection

    Public Sub New()
        Me._listaConferencias = New Collection
    End Sub

    Public Property ListaConferencias As Collection
        Get
            Return Me._listaConferencias
        End Get
        Set(value As Collection)
            value = Me._listaConferencias
        End Set
    End Property

    Public Sub read(ByRef per As Conferencia)
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM CONFERENCIAS WHERE idConferencia='" & per.DNI & "';")
        While leer.Read
            per.DNI = leer.GetValue(0).ToString
            per.Nombre = leer.GetValue(1).ToString
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM CONFERENCIAS ORDER BY idConferencia;")
        While leer.Read
            Me.ListaConferencias.Add(New Conferencia(leer.GetValue(0).ToString))
        End While
    End Sub

    Public Function insert(ByVal per As Conferencia) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO CONFERENCIAS VALUES ('" & per.DNI & "','" & per.Nombre & "');")
    End Function

    Public Function update(ByVal per As Conferencia) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE CONFERENCIAS SET Nombre='" & per.Nombre & "'WHERE idConferencia='" & per.DNI & "';")
    End Function

    Public Function delete(ByVal per As Conferencia) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM CONFERENCIAS WHERE idConferencia='" & per.DNI & "';")
    End Function

End Class

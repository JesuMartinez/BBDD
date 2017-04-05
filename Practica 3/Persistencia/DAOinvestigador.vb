Public Class DAOInvestigador
    Private _listaInvestigadores As Collection

    Public Sub New()
        Me._listaInvestigadores = New Collection
    End Sub

    Public Property ListaPersonas As Collection
        Get
            Return Me._listaInvestigadores
        End Get
        Set(value As Collection)
            value = Me._listaInvestigadores
        End Set
    End Property

    Public Sub read(ByRef per As Investigador)
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM INVESTIGADORES WHERE idInvest='" & per.DNI & "';")
        While leer.Read
            per.DNI = leer.GetValue(0).ToString
            per.Nombre = leer.GetValue(1).ToString
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM INVESTIGADORES ORDER BY idInvest;")
        While leer.Read
            Me.ListaPersonas.Add(New Investigador(leer.GetValue(0).ToString))
        End While
    End Sub

    Public Function insert(ByVal per As Investigador) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO INVESTIGADORES VALUES ('" & per.DNI & "','" & per.Nombre & "');")
    End Function

    Public Function update(ByVal per As Investigador) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE INVESTIGADORES SET Nombre='" & per.Nombre & "'WHERE idInvest='" & per.DNI & "';")
    End Function

    Public Function delete(ByVal per As Investigador) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM INVESTIGADORES WHERE idInvest='" & per.DNI & "';")
    End Function

End Class

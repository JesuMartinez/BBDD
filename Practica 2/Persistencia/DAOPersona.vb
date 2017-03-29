Public Class DAOPersona
    Private _listaPersonas As Collection

    Public Sub New()
        Me._listaPersonas = New Collection
    End Sub

    Public Property ListaPersonas As Collection
        Get
            Return Me._listaPersonas
        End Get
        Set(value As Collection)
            value = Me._listaPersonas
        End Set
    End Property

    Public Sub read(ByRef per As Persona)
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM Personas WHERE dni='" & per.DNI & "';")
        While leer.Read
            per.DNI = leer.GetValue(0).ToString
            per.Nombre = leer.GetValue(1).ToString
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM Personas ORDER BY DNI;")
        While leer.Read
            Me.ListaPersonas.Add(New Persona(leer.GetValue(0).ToString))
        End While
    End Sub

    Public Function insert(ByVal per As Persona) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO Personas VALUES ('" & per.DNI & "','" & per.Nombre & "');")
    End Function

    Public Function update(ByVal per As Persona) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE Personas SET Nombre='" & per.Nombre & "'WHERE DNI='" & per.DNI & "';")
    End Function

    Public Function delete(ByVal per As Persona) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM Personas WHERE DNI='" & per.DNI & "';")
    End Function

End Class

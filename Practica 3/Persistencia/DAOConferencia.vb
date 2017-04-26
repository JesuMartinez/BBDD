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

    Public Sub read(ByRef con As Conferencia)
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM CONFERENCIAS WHERE idConferencia=" & con.IDConferencia & ";")
        While leer.Read
            con.IDConferencia = leer.GetInt32(0)
            con.Siglas = leer.GetValue(1).ToString
            con.Nombre = leer.GetValue(2).ToString
            con.Lugar = leer.GetValue(3).ToString
            con.FechaInicio = leer.GetValue(4).ToString
            con.FechaFin = leer.GetValue(5).ToString
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM CONFERENCIAS ORDER BY idConferencia;")
        While leer.Read
            Me.ListaConferencias.Add(New Conferencia(leer.GetInt32(0)))
        End While
    End Sub

    Public Function insert(ByVal con As Conferencia) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO CONFERENCIAS VALUES ('" & con.IDConferencia & "','" & con.Siglas & "','" & con.Nombre & "','" & con.Lugar & "',#" & con.FechaInicio & "#,#" & con.FechaFin & "#);")
    End Function

    Public Function update(ByVal con As Conferencia) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE CONFERENCIAS SET Siglas='" & con.Siglas & "', Nombre='" & con.Nombre & "', Lugar='" & con.Lugar & "', Fecha_inicio=#" & con.FechaInicio & "#, Fecha_fin=#" & con.FechaFin & "# WHERE idConferencia=" & con.IDConferencia & ";")
    End Function

    Public Function delete(ByVal con As Conferencia) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM CONFERENCIAS WHERE idConferencia=" & con.IDConferencia & ";")
    End Function

    'Public Function asiste(ByVal conf As Conferencia, ByVal inv As Investigador) As Integer
    'Return AgenteBD.getAgente.modificar("INSERT INTO ASISTE VALUES ('" & conf.IDConferencia & "','" & inv.IDInvestigador & "')" & "WHERE Conferencia='" & conf.IDConferencia & "' AND Invest='" & inv.IDInvestigador & "';")
    'End Function

End Class

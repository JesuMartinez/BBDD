Public Class DAOInvestigador
    Private _listaInvestigadores As Collection

    Public Sub New()
        Me._listaInvestigadores = New Collection
    End Sub

    Public Property ListaInvestigadores As Collection
        Get
            Return Me._listaInvestigadores
        End Get
        Set(value As Collection)
            value = Me._listaInvestigadores
        End Set
    End Property

    Public Sub read(ByRef inv As Investigador)
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM INVESTIGADORES WHERE idInvest=" & inv.IDInvestigador & ";")
        While leer.Read
            inv.IDInvestigador = leer.GetInt32(0)
            inv.Nombre = leer.GetValue(1).ToString
            inv.Apellidos = leer.GetValue(2).ToString
            inv.Despacho = leer.GetValue(3).ToString
            inv.Edificio = leer.GetValue(4).ToString
            inv.Departamento = leer.GetValue(5).ToString
            inv.Telefono = leer.GetValue(6).ToString
            inv.Email = leer.GetValue(7).ToString
        End While
    End Sub

    Public Sub readAll()
        Dim leer As OleDb.OleDbDataReader
        leer = AgenteBD.getAgente.leer("SELECT * FROM INVESTIGADORES ORDER BY idInvest;")
        While leer.Read
            Me.ListaInvestigadores.Add(New Investigador(leer.GetInt32(0)))
        End While
    End Sub

    Public Function insert(ByVal inv As Investigador) As Integer
        Return AgenteBD.getAgente().modificar("INSERT INTO INVESTIGADORES VALUES ('" & inv.IDInvestigador & "','" & inv.Nombre & "','" & inv.Apellidos & "','" & inv.Despacho & "','" & inv.Edificio & "','" & inv.Departamento & "','" & inv.Telefono & "','" & inv.Email & "');")
    End Function

    Public Function update(ByVal inv As Investigador) As Integer
        Return AgenteBD.getAgente.modificar("UPDATE INVESTIGADORES Set Nombre='" & inv.Nombre & "', Apellidos='" & inv.Apellidos & "', Despacho='" & inv.Despacho & "', Edificio='" & inv.Edificio & "', Departamento='" & inv.Departamento & "', Teléfono='" & inv.Telefono & "', Email='" & inv.Email & "' WHERE idInvest=" & inv.IDInvestigador & ";")
    End Function

    Public Function delete(ByVal inv As Investigador) As Integer
        Return AgenteBD.getAgente.modificar("DELETE FROM INVESTIGADORES WHERE idInvest=" & inv.IDInvestigador & ";")
    End Function
End Class

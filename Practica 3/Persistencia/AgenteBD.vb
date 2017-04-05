Imports System.Data.OleDb
Public Class AgenteBD
    Public Shared rutaBD As String = FrmInvestigadores.OpenFileDialog1.FileName
    Private Shared cadConexion As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & rutaBD
    Private Shared mConexion As OleDbConnection
    Private Shared mInstancia As AgenteBD

    Private Sub New()
        AgenteBD.mConexion = New OleDbConnection(cadConexion)
        AgenteBD.mConexion.Open()
    End Sub

    Public Shared Function getAgente() As AgenteBD
        If mInstancia Is Nothing Then
            mInstancia = New AgenteBD
        End If
        Return mInstancia
    End Function
    Public Function leer(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteReader()
    End Function
    Public Function modificar(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, mConexion)
        Return com.ExecuteNonQuery()
    End Function

End Class

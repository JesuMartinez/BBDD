Public Class FrmAutores
    Public Sub cargarInvestigadores()
        Dim inv As Investigador
        inv = New Investigador
        Try
            inv.readAll()
            For Each inv In inv.DAOInvestigador.ListaInvestigadores
                ListbxAutores.Items.Add(inv.IDInvestigador)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FrmAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInvestigadores()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        If ListbxAutores.SelectedIndex >= 0 Then
            ListbxAutoresArticulos.Items.Add(ListbxAutores.SelectedItem)
            ListbxAutores.Items.Remove(ListbxAutores.SelectedItem)
        Else
            MessageBox.Show("Por favor, seleccione un investigador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim inv As Investigador, ar As Articulo
        inv = New Investigador(Convert.ToInt32(ListbxAutoresArticulos.SelectedItem))
        ar = New Articulo
        Try
            'inv.insertAutores()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
End Class
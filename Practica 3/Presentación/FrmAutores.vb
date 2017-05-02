Public Class FrmAutores
    Private Sub cargarInvestigadores()
        Dim inv As New Investigador
        Try
            inv.readAll()
            For Each inv In inv.DAOInvestigador.ListaInvestigadores
                ListbxInvestigadores.Items.Add(inv.IDInvestigador)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub cargarArticulos()
        Dim art As New Articulo
        Try
            art.readAll()
            For Each art In art.DAOArticulo.ListaArticulos
                lstbxArticulos.Items.Add(art.IDArticulo)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarAutores()
        Dim art As New Articulo(Convert.ToInt32(lstbxArticulos.SelectedItem))
        'Dim conf As New Conferencia
        'For Each conf In inv.ListaConferencias
        'ListbxConferenciasAsiste.Items.Add(inv.ListaConferencias)
        'Next
    End Sub

    Private Sub FrmAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarArticulos()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        ListbxAutores.Items.Add(ListbxInvestigadores.SelectedItem)
        ListbxInvestigadores.Items.Remove(ListbxInvestigadores.SelectedItem)
            btnAplicarGuardar.Enabled = True
    End Sub

    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim art As Articulo
        art = New Articulo(Convert.ToInt32(lstbxArticulos.SelectedItem), Convert.ToInt32(ListbxInvestigadores.SelectedItem))
        Try
            art.autor()
            ListbxAutores.Items.Remove(ListbxAutores.SelectedItems)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub lstbxArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxArticulos.SelectedIndexChanged
        ListbxInvestigadores.Items.Clear()
        ListbxAutores.Items.Clear()
        cargarInvestigadores()
        cargarAutores()
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ListbxInvestigadores.Items.Add(ListbxAutores.SelectedItem)
        ListbxAutores.Items.Remove(ListbxAutores.SelectedItem)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ListbxInvestigadores.Items.Clear()
        ListbxAutores.Items.Clear()
        Me.Close()
        FrmArticulos.Show()
    End Sub

    Private Sub ListbxAutores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxAutores.SelectedIndexChanged
        If (ListbxAutores.SelectedIndex > -1) Then
            Eliminar.Enabled = True
            btnAplicarGuardar.Enabled = True
        Else
            Eliminar.Enabled = False
            btnAplicarGuardar.Enabled = False
        End If
    End Sub

    Private Sub ListbxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxInvestigadores.SelectedIndexChanged
        If (ListbxInvestigadores.SelectedIndex > -1) Then
            Añadir.Enabled = True
        Else
            Añadir.Enabled = False
        End If
    End Sub
End Class
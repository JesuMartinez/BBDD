Public Class FrmAsistencias
    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim inv As Investigador
        inv = New Investigador(Convert.ToInt32(lstbxInvestigadores.SelectedItem), Convert.ToInt32(ListbxConferenciasAsiste.SelectedItem))
        Try
            inv.asiste()
            ListbxConferenciasAsiste.Items.Remove(ListbxConferenciasAsiste.SelectedItem)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarAsistencias()
        Dim conf As New Conferencia
        Try
            conf.readAll()
            For Each conf In conf.DAOConferencia.ListaConferencias
                ListbxConferencias.Items.Add(conf.IDConferencia)

            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarInvestigadores()
        Dim inv As New Investigador
        Try
            inv.readAll()
            For Each inv In inv.DAOInvestigador.ListaInvestigadores
                lstbxInvestigadores.Items.Add(inv.IDInvestigador)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAsistencias()
        cargarInvestigadores()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        ListbxConferenciasAsiste.Items.Add(ListbxConferencias.SelectedItem)
        ListbxConferencias.Items.Remove(ListbxConferencias.SelectedItem)
    End Sub

    Private Sub lstConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxConferencias.SelectedIndexChanged
        If (ListbxConferencias.SelectedIndex > -1) Then
            Añadir.Enabled = True
        Else
            Añadir.Enabled = False
        End If
    End Sub

    Private Sub lstConferenciasAsiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxConferenciasAsiste.SelectedIndexChanged
        If (ListbxConferenciasAsiste.SelectedIndex > -1) Then
            Eliminar.Enabled = True
            btnAplicarGuardar.Enabled = True
        Else
            Eliminar.Enabled = False
            btnAplicarGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ListbxConferencias.Items.Add(ListbxConferenciasAsiste.SelectedItem)
        ListbxConferenciasAsiste.Items.Remove(ListbxConferenciasAsiste.SelectedItem)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub
End Class
Public Class FrmAsistencias
    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click

        Me.Hide()
        FrmInvestigadores.Show()
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

    Private Sub FrmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAsistencias()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        ListbxConferenciasAsiste.Items.Add(ListbxConferencias.SelectedItem)
        ListbxConferencias.Items.Remove(ListbxConferencias.SelectedItem)
    End Sub

    Private Sub lstConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxConferencias.SelectedIndexChanged
        If (ListbxConferencias.SelectedIndex > -1) Then
            ListbxConferenciasAsiste.SelectedIndex = -1
            Añadir.Enabled = True
        Else
            Añadir.Enabled = False

        End If

    End Sub

    Private Sub lstConferenciasAsiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxConferenciasAsiste.SelectedIndexChanged
        If (ListbxConferenciasAsiste.SelectedIndex > -1) Then
            ListbxConferencias.SelectedIndex = -1
            Eliminar.Enabled = True
        Else
            Eliminar.Enabled = False

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ListbxConferencias.Items.Add(ListbxConferenciasAsiste.SelectedItem)
        ListbxConferenciasAsiste.Items.Remove(ListbxConferenciasAsiste.SelectedItem)

    End Sub


End Class
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
                lstConferencias.Items.Add(conf.IDConferencia)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarAsistencias()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        lstConferenciasAsiste.Items.Add(lstConferencias.SelectedItem)
        lstConferencias.Items.Remove(lstConferencias.SelectedItem)
    End Sub

    Private Sub lstConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConferencias.SelectedIndexChanged
        If (lstConferencias.SelectedIndex > -1) Then
            lstConferenciasAsiste.SelectedIndex = -1
            btnAñadir.Enabled = True
        Else
            btnAñadir.Enabled = False

        End If

    End Sub

    Private Sub lstConferenciasAsiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstConferenciasAsiste.SelectedIndexChanged
        If (lstConferenciasAsiste.SelectedIndex > -1) Then
            lstConferencias.SelectedIndex = -1
            btnEliminar.Enabled = True
        Else
            btnEliminar.Enabled = False

        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        lstConferencias.Items.Add(lstConferenciasAsiste.SelectedItem)
        lstConferenciasAsiste.Items.Remove(lstConferenciasAsiste.SelectedItem)
    End Sub
End Class
﻿Public Class FrmConferencias
    Private Sub lstbxConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxConferencias.SelectedIndexChanged
        Dim con As Conferencia
        'De esta forma controlamos que al borrar un objeto "con" no nos salte una excepción de referencia a null
        If (lstbxConferencias.SelectedIndex > -1) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            con = New Conferencia(Convert.ToInt32(lstbxConferencias.SelectedItem))
            Try
                con.readConferencia()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxIDConferencia.Text = con.IDConferencia.ToString
            txtbxSiglas.Text = con.Siglas
            txtbxNombreConferencia.Text = con.Nombre
            txtbxLugar.Text = con.Lugar
            txtbxFecha_inicio.Text = con.FechaInicio
            txtbxFecha_fin.Text = con.FechaFin
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim con As Conferencia
        If (Convert.ToDateTime(txtbxFecha_inicio.Text) <= Convert.ToDateTime(txtbxFecha_fin.Text)) Then
            con = New Conferencia(Convert.ToInt32(txtbxIDConferencia.Text))
            con.Siglas = txtbxSiglas.Text
            con.Nombre = txtbxNombreConferencia.Text
            con.Lugar = txtbxLugar.Text
            con.FechaInicio = txtbxFecha_inicio.Text
            con.FechaFin = txtbxFecha_fin.Text
            Try
                con.insertConferencia()
                lstbxConferencias.Items.Add(con.IDConferencia)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Fechas de las conferencias inválidas. Por favor compruebe que la fecha de inicio es menor o igual que la fecha de finalización.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim con As New Conferencia(Convert.ToInt32(lstbxConferencias.SelectedItem.ToString))
        If MessageBox.Show("¿Desea eliminar la conferencia con ID: " + con.IDConferencia.ToString + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                con.deleteConferencia()
                lstbxConferencias.Items.Remove(lstbxConferencias.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim con As Conferencia
        If (txtbxIDConferencia.Modified = False) Then
            If (Convert.ToDateTime(txtbxFecha_inicio.Text) <= Convert.ToDateTime(txtbxFecha_fin.Text)) Then
                con = New Conferencia(Convert.ToInt32(lstbxConferencias.SelectedItem))
                con.Siglas = txtbxSiglas.Text
                con.Nombre = txtbxNombreConferencia.Text
                con.Lugar = txtbxLugar.Text
                con.FechaInicio = txtbxFecha_inicio.Text
                con.FechaFin = txtbxFecha_fin.Text
                If MessageBox.Show("¿Desea modificar la conferencia seleccionada?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                    Try
                        con.updateConferencia()
                        MessageBox.Show("La conferencia ha sido modificada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Exit Sub
                    End Try
                End If
            Else
                MessageBox.Show("Introduzca un período entre fechas válida.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Else
            MessageBox.Show("Error al intentar cambiar de ID, ya que corresponde con la clave primaria de nuestra base de datos.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If


    End Sub

    Public Sub cargarConferencias()
        Dim con As New Conferencia
        Try
            con.readAll()
            For Each con In con.DAOConferencia.ListaConferencias
                lstbxConferencias.Items.Add(con.IDConferencia)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmConferencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarConferencias()
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Me.Hide()
        FrmArticulos.Show()
    End Sub

    Private Sub btnInvestigadores_Click(sender As Object, e As EventArgs) Handles btnInvestigadores.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub

    Private Sub txtbxIDConferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxIDConferencia.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtbxFecha_inicio_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtbxFecha_inicio.Validating, txtbxFecha_fin.Validating
        Dim fecha As DateTime
        If Not DateTime.TryParse(txtbxFecha_inicio.Text, fecha) And Not DateTime.TryParse(txtbxFecha_fin.Text, fecha) Then
            MessageBox.Show("Error en el formato de la fecha. Por favor introduzca un formato de fecha válido.")
        End If
    End Sub

    Private Sub FrmConferencias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
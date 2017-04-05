Public Class FrmConferencias
    Private Sub listbxConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxConferencias.SelectedIndexChanged
        Dim con As Conferencia
        'De esta forma controlamos que al borrar un objeto "per" no nos salte una excepción de referencia a null
        If (lstbxConferencias.SelectedIndex > -1) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            con = New Conferencia(Convert.ToInt16(lstbxConferencias.SelectedItem.ToString))
            Try
                con.readConferencia()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxIDConferencia.Text = con.IDConferencia.ToString
            txtbxNombreConferencia.Text = con.Nombre.ToString
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim con As Conferencia
        If txtbxNombreConferencia.TextLength > 0 Then
            con = New Conferencia(Convert.ToInt16(txtbxIDConferencia.Text))
            con.Nombre = txtbxNombreConferencia.Text
            Try
                con.insertConferencia()
                lstbxConferencias.Items.Add(con.IDConferencia)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        Else
            MessageBox.Show("BIZCO", "BIZCO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim con As New Conferencia(Convert.ToInt16(lstbxConferencias.SelectedItem.ToString))
        If MessageBox.Show("¿Desea eliminar la conferencia con ID: " + con.IDConferencia.ToString + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                con.deleteConferencia()
                lstbxConferencias.Items.Remove(lstbxConferencias.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxIDConferencia.Clear()
            txtbxNombreConferencia.Clear()
        End If
    End Sub


    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim con As Conferencia
        If (txtbxIDConferencia.Modified = False And txtbxNombreConferencia.Modified = True) Then
            con = New Conferencia(Convert.ToInt16(txtbxIDConferencia.Text))
            con.Nombre = txtbxNombreConferencia.Text
            If MessageBox.Show("¿Desea modificar la conferencia seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    con.updateConferencia()
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End If
        Else
            MessageBox.Show("Modificación de ID inválida ya que corresponde con la clave primaria de nuestra base de datos o modificación del nombre de conferencia no permitida al tratarse de la misma. " & vbNewLine & "Por favor modifique únicamente el nombre de la conferencia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
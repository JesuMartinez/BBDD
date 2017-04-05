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
        If MessageBox.Show("¿Desea eliminar la conferencia con ID: " + con.IDConferencia + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                per.deletePersona()
                listbxPersonas.Items.Remove(listbxPersonas.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxDNI.Clear()
            txtbxNombre.Clear()
        End If
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtbxDNI.Clear()
        txtbxNombre.Clear()
        listbxPersonas.ClearSelected()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim per As Persona
        If (txtbxDNI.Modified = False And txtbxNombre.Modified = True) Then
            per = New Persona(txtbxDNI.Text)
            per.Nombre = txtbxNombre.Text
            If MessageBox.Show("¿Desea modificar al usuario seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    per.updatePersona()
                    MessageBox.Show("El usuario ha sido modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End If
        Else
            MessageBox.Show("Modificación de DNI inválida ya que corresponde con la clave primaria de nuestra base de datos o modificación del nombre de usuario no permitida al tratarse del mismo. " & vbNewLine & "Por favor modifique únicamente el nombre de usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
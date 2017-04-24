Public Class FrmPrincipal
    Private Sub btnRutaBD_Click(sender As Object, e As EventArgs) Handles btnRutaBD.Click
        OpenFileDialog1.ShowDialog()
        If txtRuta.TextLength > 0 Then
            btnconectarBD.Enabled = True
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        txtRuta.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnconectarBD_Click(sender As Object, e As EventArgs) Handles btnconectarBD.Click
        Dim per As New Persona
        Try
            per.readAll()
            For Each per In per.Dao.ListaPersonas
                listbxPersonas.Items.Add(per.DNI)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        lblEstadoBD.Text = "¡Conectado!"
        lblEstadoBD.ForeColor = Color.Green
        lblEstadoBD.Visible = True
        btnRutaBD.Enabled = False
        btnconectarBD.Enabled = False
        btnAñadir.Enabled = True
        btnLimpiarCampos.Enabled = True
        txtbxDNI.Enabled = True
        txtbxNombre.Enabled = True
    End Sub

    Private Sub listbxPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listbxPersonas.SelectedIndexChanged
        Dim per As Persona
        'De esta forma controlamos que al borrar un objeto "per" no nos salte una excepción de referencia a null
        If (listbxPersonas.SelectedIndex > -1) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            per = New Persona(listbxPersonas.SelectedItem.ToString)
            Try
                per.readPersona()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxDNI.Text = per.DNI
            txtbxNombre.Text = per.Nombre
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim per As Persona
        If DNIesCorrecto(txtbxDNI.Text) And txtbxNombre.TextLength > 0 Then
            per = New Persona(txtbxDNI.Text)
            per.Nombre = txtbxNombre.Text
            Try
                per.insertPersona()
                listbxPersonas.Items.Add(per.DNI)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Asegúrese de que el DNI esté formado por 8 dígitos y una letra." & vbNewLine & "Por favor introduzca valores en las campos: ""DNI"" y ""Nombre"" para añadir un nuevo usuario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim per As New Persona(listbxPersonas.SelectedItem.ToString)
        If MessageBox.Show("¿Desea eliminar al usuario con DNI: " + per.DNI + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
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
        If (txtbxDNI.Modified = False) Then
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
    'Método para comprobar que el DNI esté compuesto de 8 números y una letra
    Public Function DNIesCorrecto(ByRef cadena As String) As Boolean
        Dim sol As Boolean = False
        Dim caracter As Integer = 0
        Dim num As Integer = 0
        For i As Integer = 0 To (cadena.Length - 1)
            If (Char.IsDigit(cadena(i))) Then
                num += 1
            Else
                caracter += 1
            End If
        Next
        If (num = 8 And caracter = 1) Then
            sol = True
        End If
        Return sol
    End Function

    Private Sub txtbxNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class


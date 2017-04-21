Public Class FrmInvestigadores
    Private Sub lstbxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxInvestigadores.SelectedIndexChanged
        Dim inv As Investigador
        'De esta forma controlamos que al borrar un objeto "inv" no nos salte una excepción de referencia a null
        If (lstbxInvestigadores.SelectedIndex > -1) Then
            btnModificar.Enabled = True
            btnEliminar.Enabled = True
            inv = New Investigador(Convert.ToInt32(lstbxInvestigadores.SelectedItem))
            Try
                inv.readInvestigador()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxIDInvestigador.Text = inv.IDInvestigador.ToString
            txtbxNombreInvestigador.Text = inv.Nombre
            txtbxApellidosInvestigador.Text = inv.Apellidos
            txtbxDespacho.Text = inv.Despacho
            txtbxEdificio.Text = inv.Edificio
            txtbxDepartamento.Text = inv.Departamento
            txtbxTelefono.Text = inv.Telefono
            txtbxEmail.Text = inv.Email
        Else
            btnModificar.Enabled = False
            btnEliminar.Enabled = False
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
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

    Private Sub FrmInvestigadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim inv As Investigador
        If (txtbxApellidosInvestigador.TextLength > 0 And txtbxDepartamento.TextLength > 0 And txtbxDespacho.TextLength > 0 And
        txtbxEdificio.TextLength > 0 And txtbxEmail.TextLength > 0 And txtbxNombreInvestigador.TextLength > 0 And txtbxTelefono.TextLength > 0) And
        txtbxIDInvestigador.TextLength > 0 Then
            inv = New Investigador(Convert.ToInt32(txtbxIDInvestigador.Text))
            inv.Nombre = txtbxNombreInvestigador.Text
            inv.Apellidos = txtbxApellidosInvestigador.Text
            inv.Despacho = txtbxDespacho.Text
            inv.Edificio = txtbxEdificio.Text
            inv.Departamento = txtbxDepartamento.Text
            inv.Telefono = txtbxTelefono.Text
            inv.Email = txtbxEmail.Text
            Try
                inv.insertInvestigador()
                lstbxInvestigadores.Items.Add(inv.IDInvestigador)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Por favor introduzca información en los campos vacíos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim inv As Investigador
        If (txtbxIDInvestigador.Modified = False) Then
            inv = New Investigador(Convert.ToInt32(txtbxIDInvestigador.Text))
            inv.Nombre = txtbxNombreInvestigador.Text
            inv.Apellidos = txtbxApellidosInvestigador.Text
            inv.Despacho = txtbxDespacho.Text
            inv.Edificio = txtbxEdificio.Text
            inv.Departamento = txtbxDepartamento.Text
            inv.Telefono = txtbxTelefono.Text
            inv.Email = txtbxEmail.Text
            If MessageBox.Show("¿Desea modificar al investigador seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    inv.updateInvestigador()
                    MessageBox.Show("El investigador ha sido modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End If
        Else
            MessageBox.Show("Modificación de ID de investigador inválida ya que corresponde con la clave primaria de nuestra base de datos" & vbNewLine & "Por favor modifique cualquier campo excepto el ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim inv As New Investigador(Convert.ToInt32(lstbxInvestigadores.SelectedItem))
        If MessageBox.Show("¿Desea eliminar al investigador con ID: " + inv.IDInvestigador.ToString + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                inv.deleteInvestigador()
                lstbxInvestigadores.Items.Remove(lstbxInvestigadores.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        FrmConferencias.Show()
    End Sub

    Private Sub btnArticulos_Click(sender As Object, e As EventArgs) Handles btnArticulos.Click
        Me.Hide()
        FrmArticulos.Show()
    End Sub

    Private Sub btnGestionarAsistencias_Click(sender As Object, e As EventArgs) Handles btnGestionarAsistencias.Click
        Me.Hide()
        FrmAsistencias.Show()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxArticulosInvestigadores.SelectedIndexChanged

    End Sub
End Class

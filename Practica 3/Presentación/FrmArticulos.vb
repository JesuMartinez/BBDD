﻿Public Class FrmArticulos
    Public Sub cargarArticulos()
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

    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarArticulos()
    End Sub

    Private Sub btnAñadirArticulo_Click(sender As Object, e As EventArgs) Handles btnAñadirArticulo.Click
        Dim ar As Articulo
        ar = New Articulo(Convert.ToInt32(txtbxIDArticulo.Text))
            ar.Titulo = txtbxTituloArticulo.Text
            ar.Conferencia.IDConferencia = Convert.ToInt32(txtbxConferencia.Text)
            ar.PagInicio = Convert.ToInt32(txtbxPag_inicio.Text)
            ar.PagFin = Convert.ToInt32(txtbxPag_fin.Text)
        Try
            ar.insertArticulo()
            lstbxArticulos.Items.Add(ar.IDArticulo)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnModificarArticulo_Click(sender As Object, e As EventArgs) Handles btnModificarArticulo.Click
        Dim ar As Articulo
        If (txtbxIDArticulo.Modified = False) Then
            ar = New Articulo(Convert.ToInt32(lstbxArticulos.SelectedItem))
            ar.Titulo = txtbxTituloArticulo.Text
            ar.Conferencia.IDConferencia = Convert.ToInt32(txtbxConferencia.Text)
            ar.PagInicio = Convert.ToInt32(txtbxPag_inicio.Text)
            ar.PagFin = Convert.ToInt32(txtbxPag_fin.Text)
            If MessageBox.Show("¿Desea modificar el artículo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    ar.updateArticulo()
                    MessageBox.Show("El artículo ha sido modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Exit Sub
                End Try
            End If
        Else
            MessageBox.Show("Modificación de ID de artículo inválida ya que corresponde con la clave primaria de nuestra base de datos. " & vbNewLine & "Por favor modifique cualquier campo excepto el ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminarArticulo_Click(sender As Object, e As EventArgs) Handles btnEliminarArticulo.Click
        Dim ar As New Articulo(Convert.ToInt32(lstbxArticulos.SelectedItem))
        If MessageBox.Show("¿Desea eliminar el articulo con ID: " + ar.IDArticulo.ToString + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ar.deleteArticulo()
                lstbxArticulos.Items.Remove(lstbxArticulos.SelectedItem)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub btnConferencias_Click(sender As Object, e As EventArgs) Handles btnConferencias.Click
        Me.Hide()
        FrmConferencias.Show()
    End Sub

    Private Sub btnInvestigadores_Click(sender As Object, e As EventArgs) Handles btnInvestigadores.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub

    Private Sub lstbxArticulos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxArticulos.SelectedIndexChanged
        Dim art As Articulo
        'De esta forma controlamos que al borrar un objeto art" no nos salte una excepción de referencia a null
        If (lstbxArticulos.SelectedIndex > -1) Then
            btnModificarArticulo.Enabled = True
            btnEliminarArticulo.Enabled = True
            btnGestionarAutores.Enabled = True
            art = New Articulo(Convert.ToInt32(lstbxArticulos.SelectedItem))
            Try
                art.readArticulo()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Exit Sub
            End Try
            txtbxIDArticulo.Text = art.IDArticulo.ToString
            txtbxTituloArticulo.Text = art.Titulo
            txtbxPag_inicio.Text = art.PagInicio.ToString
            txtbxPag_fin.Text = art.PagFin.ToString
            txtbxConferencia.Text = art.Conferencia.IDConferencia.ToString
        Else
            btnModificarArticulo.Enabled = False
            btnEliminarArticulo.Enabled = False
            btnGestionarAutores.Enabled = False
        End If
    End Sub

    Private Sub txtbxConferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtbxConferencia.KeyPress, txtbxPag_inicio.KeyPress, txtbxPag_fin.KeyPress, txtbxIDArticulo.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub btnGestionarAutores_Click(sender As Object, e As EventArgs) Handles btnGestionarAutores.Click
        Dim frmautores As New FrmAutores
        frmautores.IDArticulo = Convert.ToInt32(lstbxArticulos.SelectedItem)
        Me.Hide()
        frmautores.Show()
    End Sub

    Private Sub FrmArticulos_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
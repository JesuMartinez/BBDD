Public Class FrmArticulos
    Public Sub cargarInvestigadores()
        Dim inv As New Investigador
        Try
            inv.readAll()
            For Each inv In inv.DAOInvestigador.ListaInvestigadores
                lstbxInvestigadores.Items.Add(inv.IDInvestigador)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub
    Public Sub cargarConferencias()
        Dim con As New Conferencia
        Try
            con.readAll()
            For Each con In con.DAOConferencia.ListaConferencias
                lstbxConferencias.Items.Add(con.IDConferencia)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub
    Private Sub FrmArticulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInvestigadores()
        cargarConferencias()
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
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub btnModificarArticulo_Click(sender As Object, e As EventArgs) Handles btnModificarArticulo.Click
        Dim ar As Articulo
        If (txtbxIDArticulo.Modified = False) Then
            ar = New Articulo(Convert.ToInt32(txtbxIDArticulo.Text))
            ar.Titulo = txtbxTituloArticulo.Text
            ar.Conferencia.IDConferencia = Convert.ToInt32(txtbxConferencia.Text)
            ar.PagInicio = Convert.ToInt32(txtbxPag_inicio.Text)
            ar.PagFin = Convert.ToInt32(txtbxPag_fin.Text)
            If MessageBox.Show("¿Desea modificar el artículo seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                Try
                    ar.updateArticulo()
                    MessageBox.Show("El artículo ha sido modificado correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    Exit Sub
                End Try
            End If
        Else
            MessageBox.Show("Modificación de ID de artículo inválida ya que corresponde con la clave primaria de nuestra base de datos. " & vbNewLine & "Por favor modifique cualquier campo excepto el ID.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEliminarArticulo_Click(sender As Object, e As EventArgs) Handles btnEliminarArticulo.Click
        Dim ar As New Articulo(Convert.ToInt32(txtbxIDArticulo.Text))
        If MessageBox.Show("¿Desea eliminar el articulo con ID: " + ar.IDArticulo.ToString + " de la base de datos?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Try
                ar.deleteArticulo()
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                Exit Sub
            End Try
        End If
    End Sub
End Class
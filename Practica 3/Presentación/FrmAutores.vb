Public Class FrmAutores
    Private _idArticulo As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property IDArticulo As Integer
        Get
            Return Me._idArticulo
        End Get
        Set(value As Integer)
            Me._idArticulo = value
        End Set
    End Property

    Private Sub cargarInvestigadores()
        Dim inv As New Investigador
        Try
            inv.readAll()
            For Each inv In inv.DAOInvestigador.ListaInvestigadores
                ListbxInvestigadores.Items.Add(inv.IDInvestigador)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarAutores()
        Dim art As New Articulo(Me._idArticulo)
        Try
            art.readAutores()
            For Each inv As Investigador In art.ListaInvestigadores
                ListbxAutores.Items.Add(inv.IDInvestigador)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInvestigadores()
        cargarAutores()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        ListbxAutores.Items.Add(ListbxInvestigadores.SelectedItem)
        ListbxInvestigadores.Items.Remove(ListbxInvestigadores.SelectedItem)
    End Sub

    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim art As Articulo
        Dim inv As New Investigador
        Dim lista_autores As New Collection
        inv.IDInvestigador = Convert.ToInt32(ListbxAutores.SelectedItem)
        inv.Orden = ListbxAutores.SelectedIndex
        lista_autores.Add(inv)
        art = New Articulo(Me._idArticulo, lista_autores)
        Try
            art.autor()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ListbxAutores.Items.Remove(ListbxAutores.SelectedItem)
            Exit Sub
        End Try
        btnAplicarGuardar.Enabled = False
        Eliminar.Enabled = False
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim art As Articulo
        Dim inv As New Investigador
        Dim lista_autores As New Collection
        inv.IDInvestigador = Convert.ToInt32(ListbxAutores.SelectedItem)
        lista_autores.Add(inv)
        art = New Articulo(Me._idArticulo, lista_autores)
        Try
            art.deleteAutor()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            ListbxAutores.Items.Remove(ListbxAutores.SelectedItem)
            Exit Sub
        End Try
        ListbxAutores.Items.Remove(ListbxAutores.SelectedItem)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ListbxInvestigadores.Items.Clear()
        ListbxAutores.Items.Clear()
        Me.Hide()
        FrmArticulos.Show()
    End Sub

    Private Sub ListbxAutores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxAutores.SelectedIndexChanged
        If (ListbxAutores.SelectedIndex > -1) Then
            Eliminar.Enabled = True
            btnAplicarGuardar.Enabled = True
        Else
            btnAplicarGuardar.Enabled = False
            Eliminar.Enabled = False
        End If
    End Sub

    Private Sub ListbxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxInvestigadores.SelectedIndexChanged
        If (ListbxInvestigadores.SelectedIndex > -1) Then
            Añadir.Enabled = True
        Else
            Añadir.Enabled = False
        End If
    End Sub

    Private Sub FrmAutores_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
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

    Private Sub FrmAutores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInvestigadores()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        ListbxAutores.Items.Add(ListbxInvestigadores.SelectedItem)
        ListbxInvestigadores.Items.Remove(ListbxInvestigadores.SelectedItem)
    End Sub

    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim art As Articulo
        Dim orden As Integer = 0
        For autor = 0 To ListbxAutores.Items.Count - 1
            orden += 1
            art = New Articulo(Me._idArticulo, Convert.ToInt32(ListbxAutores.Items(autor)), orden)
            Try
                art.autor()
            Catch ex As Exception
                MessageBox.Show("El investigador " & Convert.ToInt32(ListbxAutores.Items(autor)) & " ya es autor de dicho articulo.", "Advertencia", MessageBoxButtons.OK)
            End Try
        Next
        ListbxAutores.Items.Clear()
        btnAplicarGuardar.Enabled = False
        Eliminar.Enabled = False
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ListbxInvestigadores.Items.Add(ListbxAutores.SelectedItem)
        ListbxAutores.Items.Remove(ListbxAutores.SelectedItem)
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        ListbxInvestigadores.Items.Clear()
        ListbxAutores.Items.Clear()
        Me.Close()
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
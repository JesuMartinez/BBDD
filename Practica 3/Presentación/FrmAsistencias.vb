﻿Public Class FrmAsistencias
    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim inv As Investigador
        Dim conf As New Conferencia
        inv = New Investigador(Convert.ToInt32(lstbxInvestigadores.SelectedItem))
        Try


            For Each conf In ListbxConferenciasAsiste.Items
                inv.ListaConferencias.Add(conf)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarConferencias()
        Dim conf, item As New Conferencia
        Dim inv As New Investigador(Convert.ToInt32(lstbxInvestigadores.SelectedItem))
        Try
            conf.readAll()
            item.readAll()

            For Each conf In conf.DAOConferencia.ListaConferencias
                For Each item In inv.ListaConferencias
                    If conf.IDConferencia <> item.IDConferencia Then
                        'faltaria poder cargar solo as conferencias que no asiste el investigador seleccionado'
                        ListbxConferencias.Items.Add(conf.IDConferencia)
                    End If
                Next
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarInvestigadores()
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

    Private Sub FrmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarInvestigadores()
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        ListbxConferenciasAsiste.Items.Add(ListbxConferencias.SelectedItem)
        ListbxConferencias.Items.Remove(ListbxConferencias.SelectedItem)
        btnAplicarGuardar.Enabled = True
    End Sub

    Private Sub lstConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxConferencias.SelectedIndexChanged
        If (ListbxConferencias.SelectedIndex > -1) Then
            Añadir.Enabled = True
        Else
            Añadir.Enabled = False
        End If
    End Sub

    Private Sub lstConferenciasAsiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListbxConferenciasAsiste.SelectedIndexChanged
        If (ListbxConferenciasAsiste.SelectedIndex > -1) Then
            Eliminar.Enabled = True
            btnAplicarGuardar.Enabled = True
        Else
            Eliminar.Enabled = False
            btnAplicarGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        ListbxConferencias.Items.Add(ListbxConferenciasAsiste.SelectedItem)
        ListbxConferenciasAsiste.Items.Remove(ListbxConferenciasAsiste.SelectedItem)

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub


    Private Sub lstbxInvestigadores_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxInvestigadores.SelectedIndexChanged
        ListbxConferencias.Items.Clear()
        cargarConferencias()
        Dim conf As New Conferencia
        'cargamos la coleccion de conferencias de cada investiador en Conferencias Asiste'
        Dim inv As New Investigador(Convert.ToInt32(lstbxInvestigadores.SelectedItem))
        For Each conf In inv.ListaConferencias
            ListbxConferenciasAsiste.Items.Add(conf)
        Next
    End Sub
End Class
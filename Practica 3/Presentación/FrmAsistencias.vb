﻿Public Class FrmAsistencias
    Private _idInvestigador As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property IDInvestigador As Integer
        Get
            Return Me._idInvestigador
        End Get
        Set(value As Integer)
            Me._idInvestigador = value
        End Set
    End Property

    Private Sub cargarConferencias()
        Dim conf As New Conferencia
        Try
            conf.readAll()
            For Each conf In conf.DAOConferencia.ListaConferencias
                lstbxConferencias.Items.Add(conf.IDConferencia)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarAsistencias()
        Dim inv As New Investigador(Me._idInvestigador)
        Try
            inv.readAsistencias()
            For Each conf As Conferencia In inv.ListaConferencias
                lstbxAsistencias.Items.Add(conf.IDConferencia)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub FrmAsistencias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarConferencias()
        cargarAsistencias()
    End Sub

    Private Sub btnAplicarGuardar_Click(sender As Object, e As EventArgs) Handles btnAplicarGuardar.Click
        Dim inv As Investigador
        Dim conf As New Conferencia
        Dim lista_conf As New Collection
        conf.IDConferencia = Convert.ToInt32(lstbxAsistencias.SelectedItem)
        lista_conf.Add(conf)
        inv = New Investigador(Me._idInvestigador, lista_conf)
        Try
            inv.asiste()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            lstbxAsistencias.Items.Remove(lstbxAsistencias.SelectedItem)
            Exit Sub
        End Try
        btnAplicarGuardar.Enabled = False
        Eliminar.Enabled = False
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        Dim inv As Investigador
        Dim conf As New Conferencia
        Dim lista_conf As New Collection
        conf.IDConferencia = Convert.ToInt32(lstbxAsistencias.SelectedItem)
        lista_conf.Add(conf)
        inv = New Investigador(Me._idInvestigador, lista_conf)
        Try
            inv.deleteAsistencia()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            lstbxAsistencias.Items.Remove(lstbxAsistencias.SelectedItem)
            Exit Sub
        End Try
        lstbxAsistencias.Items.Remove(lstbxAsistencias.SelectedItem)
    End Sub

    Private Sub Añadir_Click(sender As Object, e As EventArgs) Handles Añadir.Click
        lstbxAsistencias.Items.Add(lstbxConferencias.SelectedItem)
        lstbxConferencias.Items.Remove(lstbxConferencias.SelectedItem)
    End Sub

    Private Sub lstConferencias_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxConferencias.SelectedIndexChanged
        If (lstbxConferencias.SelectedIndex > -1) Then
            Añadir.Enabled = True
        Else
            Añadir.Enabled = False
        End If
    End Sub

    Private Sub lstConferenciasAsiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstbxAsistencias.SelectedIndexChanged
        If (lstbxAsistencias.SelectedIndex > -1) Then
            Eliminar.Enabled = True
            btnAplicarGuardar.Enabled = True
        Else
            Eliminar.Enabled = False
            btnAplicarGuardar.Enabled = False
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        lstbxConferencias.Items.Clear()
        lstbxAsistencias.Items.Clear()
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub

    Private Sub FrmAsistencias_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
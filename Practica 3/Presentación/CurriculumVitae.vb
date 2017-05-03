Public Class Curriculum_Vitae
    Private _idinvestigador As Integer

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Property IDInvestigador As Integer
        Get
            Return Me._idinvestigador
        End Get
        Set(value As Integer)
            Me._idinvestigador = value
        End Set
    End Property

    Private Sub Curriculum_Vitae_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAutor.Visible = True
        lblAutor.Text = "CURRICULUM DEL AUTOR CON ID (" & _idinvestigador.ToString & ")"
        Dim inv As New Investigador(_idinvestigador)
        Dim con As New Conferencia
        Try
            inv.readInvestigador()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        txtbxNombre.Text = inv.Nombre
        txtbxApellido.Text = inv.Apellidos
        txtbxEdificio.Text = inv.Edificio
        txtbxDepartamento.Text = inv.Departamento
        txtbxDespacho.Text = inv.Despacho
        txtbxTlf.Text = inv.Telefono
        txtbxEmail.Text = inv.Email

        Try
            con.readConfAsiste()
            For Each con In con.DAOConferencia.ListaConferencias
                txtbxConferencias.Text = con.Nombre & " " & con.Siglas & " " & con.Lugar & " " & con.FechaInicio & " " & con.FechaFin
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
        'Dim inv As New Investigador(_idinvestigador)
        'Try
        'inv.generateCV()
        'Catch ex As Exception
        'MessageBox.Show(ex.ToString)
        'Exit Sub
        'End Try

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub
End Class
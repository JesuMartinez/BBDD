Public Class Curriculum_Vitae
    Private _idInvestigador As Integer

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
        cargarDatosPersonales()
        cargarAsistencias()
        'cargarAUTORES y terminado
    End Sub

    Private Sub cargarAsistencias()
        Dim listaConf As New Collection
        Dim inv As New Investigador(Me._idInvestigador)
        Try
            inv.readAsistencias()
            For Each conf As Conferencia In inv.ListaConferencias
                conf.readConferencia()
                txtbxConferencias.Text += conf.Nombre & " . " & conf.Siglas & " . " & conf.Lugar & " . " & Convert.ToDateTime(conf.FechaInicio) & "-" & Convert.ToDateTime(conf.FechaFin) & vbNewLine
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub

    Private Sub cargarDatosPersonales()
        lblAutor.Visible = True
        lblAutor.Text = "CURRICULUM DEL AUTOR CON ID (" & _idinvestigador.ToString & ")"
        Dim inv As New Investigador(Me._idInvestigador)
        Try
            inv.readInvestigador()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
        txtbxNombre.Text = inv.Nombre
        txtbxApellido.Text = inv.Apellidos
        txtbxEdificio.Text = inv.Edificio
        txtbxDepartamento.Text = inv.Departamento
        txtbxDespacho.Text = inv.Despacho
        txtbxTlf.Text = inv.Telefono
        txtbxEmail.Text = inv.Email
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub

    Private Sub Curriculum_Vitae_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
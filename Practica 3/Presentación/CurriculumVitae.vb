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
        cargarDatosPersonales()
        cargarAsistencias()
    End Sub

    Private Sub cargarAsistencias()
        Dim listaConf As New Collection
        Dim inv As New Investigador(_idinvestigador)
        Dim conf As Conferencia
        Try
            inv.consultarAsistencias()

            For Each item As Integer In inv.ListaConferencias
                conf = New Conferencia(item)
                Read
                txtbxConferencias.Text = conf.Nombre & " " & conf.Siglas & " " & conf.Lugar & " " & conf.FechaInicio & " " & conf.FechaFin & vbNewLine
            Next
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cargarDatosPersonales()
        lblAutor.Visible = True
        lblAutor.Text = "CURRICULUM DEL AUTOR CON ID (" & _idinvestigador.ToString & ")"
        Dim inv As New Investigador(_idinvestigador)
        Try
            inv.readInvestigador()
            'txtbxConferencias.Text = con.Nombre & " " & con.Siglas & " " & con.Lugar & " " & con.FechaInicio & " " & con.FechaFin
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
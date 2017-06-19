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
        cargarArticulos()
    End Sub

    Private Sub cargarDatosPersonales()
        lblAutor.Visible = True
        lblAutor.Text = "CURRICULUM DEL AUTOR CON ID (" & Me._idInvestigador.ToString & ")"
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

    Private Sub cargarAsistencias()
        Dim inv As New Investigador(Me._idInvestigador)
        Try
            inv.readAsistencias()
            For Each conf As Conferencia In inv.ListaConferencias
                conf.readConferencia()
                txtbxConferencias.Text += conf.Nombre & ".  " & conf.Siglas & ".  " & conf.Lugar & ".  " & Convert.ToDateTime(conf.FechaInicio) & " - " & Convert.ToDateTime(conf.FechaFin) & vbNewLine
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Public Sub cargarArticulos()
        Dim inv As New Investigador(Me._idInvestigador)
        Dim autores As New ArrayList
        Try
            inv.readArticulos()
            For Each art As Articulo In inv.ListaArticulos
                autores.Clear() 'refrescamos los autores para que no se acumulen los que han intervenido en distintos articulos 
                art.readArticulo()
                art.Conferencia.readConferencia() 'para poder acceder a los datos de la conferencia
                art.readAutores() 'de esta manera averigüamos quien ha intervenido (autores) en el artículo publicado por el investigador seleccionado
                For Each invest As Investigador In art.ListaInvestigadores
                    invest.readInvestigador()
                    autores.Add(invest.Apellidos & " " & invest.Nombre)
                Next

                txtbxArticulos.Text += String.Join(",", autores.ToArray) & ".  " & art.Titulo & ".  " & art.Conferencia.Nombre & " (" & art.Conferencia.Siglas & ").  pp.  " & art.PagInicio & "-" & art.PagFin & ".  " & art.Conferencia.Lugar & ".  " & Year(Convert.ToDateTime(art.Conferencia.FechaFin)) & vbNewLine

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Hide()
        FrmInvestigadores.Show()
    End Sub

    Private Sub Curriculum_Vitae_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class
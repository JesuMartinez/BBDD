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
        Try
            inv.generateCV()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtbxCV.TextChanged

    End Sub

    Private Sub lblAutor_Click(sender As Object, e As EventArgs) Handles lblAutor.Click

    End Sub
End Class
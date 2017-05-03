Public Class Curriculum_Vitae
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
    Private Sub Curriculum_Vitae_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim inv As New Investigador(Me._idInvestigador)
        Try
            inv.generateCV()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            Exit Sub
        End Try
    End Sub
End Class
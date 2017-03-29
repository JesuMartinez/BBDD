Public Class Ecuacion2Grado
    Private _a As Double
    Private _b As Double
    Private _c As Double
    Private _x1 As Double
    Private _x2 As Double

    'CONSTRUCTOR'
    Public Sub New(ByVal a As Double, ByVal b As Double, ByVal c As Double)
        Me._a = a
        Me._b = b
        Me._c = c
    End Sub

    'GETTER Y SETTER'
    Public Property A() As Double
        Get
            Return _a
        End Get
        Set(value As Double)
            Me._a = value
        End Set
    End Property

    Public Property B() As Double
        Get
            Return _b
        End Get
        Set(value As Double)
            Me._b = value
        End Set
    End Property

    Public Property C() As Double
        Get
            Return _c
        End Get
        Set(value As Double)
            Me._c = value
        End Set
    End Property

    Public Property X1() As Double
        Get
            Return _x1
        End Get
        Set(value As Double)
            Me._x1 = value
        End Set
    End Property

    Public Property X2() As Double
        Get
            Return _x2
        End Get
        Set(value As Double)
            Me._x2 = value
        End Set
    End Property

    'MÉTODO PRINCIPAL QUE SE ENCARGARÁ DE CALCULAR LAS RAÍCES DEPENDIENDO DEL DISCRIMINANTE'
    Public Function Calcular() As Double
        Dim discriminante = (B ^ 2) - (4 * A * C)
        If discriminante > 0 Then
            'Con el método Math.Round redondeamos a dos decimales
            X1 = Math.Round((-B + Math.Sqrt(discriminante)) / (2 * A), 2)
            X2 = Math.Round((-B - Math.Sqrt(discriminante)) / (2 * A), 2)
        ElseIf discriminante = 0 Then
            X1 = Math.Round((-B + Math.Sqrt(discriminante)) / (2 * A), 2)
        Else
            X1 = Math.Round(-B / (2 * A), 2)
            X2 = Math.Round((Math.Sqrt(Math.Abs(discriminante))) / (2 * A), 2)
        End If
        Return discriminante
    End Function
End Class
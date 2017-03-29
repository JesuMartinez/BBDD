Public Class FrmPrincipal
    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim A, B, C As Double
        Try
            A = Convert.ToDouble(txtbxA.Text)
            B = Convert.ToDouble(txtbxB.Text)
            C = Convert.ToDouble(txtbxC.Text)
        Catch ex As Exception
            MessageBox.Show("Por favor introduzca valores numéricos en los campos A,B,C para proceder a resolver la ecuación de 2 grado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End Try
        'Declaramos un objeto de la clase Ecuacion2Grado para invocar al método calcular
        'y poder acceder a los valores de las raíces correspondientes
        Dim ecuacion As New Ecuacion2Grado(A, B, C)
        'Ecuacion.calcular nos devuelve el discriminante que dependiendo del caso, calculará un tipo de raíces u otras
        If (A <> 0 And B <> 0 And C <> 0) Then
            Select Case ecuacion.Calcular
                Case Is > 0
                    lblResRaiz1.Text = ecuacion.X1.ToString
                    lblResRaiz1.ForeColor = Color.Blue
                    lblResRaiz1.Visible = True
                    lblResRaiz2.Text = ecuacion.X2.ToString
                    lblResRaiz2.ForeColor = Color.Blue
                    lblResRaiz2.Visible = True
                    lblTitulo.Text = "2 Soluciones Reales"
                    lblTitulo.Visible = True
                Case Is = 0
                    lblResRaiz1.Text = ecuacion.X1.ToString
                    lblResRaiz1.ForeColor = Color.Blue
                    lblResRaiz1.Visible = True
                    lblResRaiz2.Visible = False
                    lblTitulo.Text = "1 Solución Real"
                    lblTitulo.Visible = True
                Case Is < 0
                    lblResRaiz1.Text = ecuacion.X1 & "+" & ecuacion.X2 & "i"
                    lblResRaiz1.ForeColor = Color.Red
                    lblResRaiz1.Visible = True
                    lblResRaiz2.Text = ecuacion.X1 & "-" & ecuacion.X2 & "i"
                    lblResRaiz2.ForeColor = Color.Red
                    lblResRaiz2.Visible = True
                    lblTitulo.Text = "2 Soluciones Imaginarias"
                    lblTitulo.Visible = True
            End Select
        Else
            MessageBox.Show("Por favor introduzca valores distintos de cero en los campos A,B,C para proceder a calcular las raíces", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    'Método para que el botón calcular se encuentre deshabilitado hasta que se introduzca algún valor
    'en los tres campos A,B y C
    Private Sub txtbxA_TextChanged(sender As Object, e As EventArgs) Handles txtbxA.TextChanged, txtbxB.TextChanged, txtbxC.TextChanged
        If (txtbxA.TextLength > 0) And (txtbxB.TextLength > 0) And (txtbxC.TextLength > 0) Then
            btnCalcular.Enabled = True
        Else
            btnCalcular.Enabled = False
        End If
    End Sub

    Private Sub btnLimpiarCampos_Click(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        txtbxA.Clear()
        txtbxB.Clear()
        txtbxC.Clear()
        lblResRaiz1.Text = ""
        lblResRaiz2.Text = ""
        lblTitulo.Text = ""
    End Sub
End Class

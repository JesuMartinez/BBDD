<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblFraseInicial = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblFrase2 = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblC = New System.Windows.Forms.Label()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.txtbxA = New System.Windows.Forms.TextBox()
        Me.txtbxB = New System.Windows.Forms.TextBox()
        Me.txtbxC = New System.Windows.Forms.TextBox()
        Me.lblRaiz1 = New System.Windows.Forms.Label()
        Me.lblRaiz2 = New System.Windows.Forms.Label()
        Me.lblResRaiz1 = New System.Windows.Forms.Label()
        Me.lblResRaiz2 = New System.Windows.Forms.Label()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFraseInicial
        '
        Me.lblFraseInicial.AutoSize = True
        Me.lblFraseInicial.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFraseInicial.Location = New System.Drawing.Point(55, 71)
        Me.lblFraseInicial.Name = "lblFraseInicial"
        Me.lblFraseInicial.Size = New System.Drawing.Size(549, 25)
        Me.lblFraseInicial.TabIndex = 0
        Me.lblFraseInicial.Text = "Dada la fórmula general de las ecuaciones de segundo grado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(655, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ax^2+Bx+C=0"
        '
        'lblFrase2
        '
        Me.lblFrase2.AutoSize = True
        Me.lblFrase2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrase2.Location = New System.Drawing.Point(55, 133)
        Me.lblFrase2.Name = "lblFrase2"
        Me.lblFrase2.Size = New System.Drawing.Size(569, 25)
        Me.lblFrase2.TabIndex = 2
        Me.lblFrase2.Text = "Introduzca los valores de los parámetros para obtener las raíces:"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblA.Location = New System.Drawing.Point(55, 214)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(26, 25)
        Me.lblA.TabIndex = 3
        Me.lblA.Text = "A"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblB.Location = New System.Drawing.Point(55, 262)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(25, 25)
        Me.lblB.TabIndex = 4
        Me.lblB.Text = "B"
        '
        'lblC
        '
        Me.lblC.AutoSize = True
        Me.lblC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC.Location = New System.Drawing.Point(55, 314)
        Me.lblC.Name = "lblC"
        Me.lblC.Size = New System.Drawing.Size(27, 25)
        Me.lblC.TabIndex = 5
        Me.lblC.Text = "C"
        '
        'btnCalcular
        '
        Me.btnCalcular.Enabled = False
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(265, 212)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(358, 126)
        Me.btnCalcular.TabIndex = 6
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'txtbxA
        '
        Me.txtbxA.Location = New System.Drawing.Point(100, 218)
        Me.txtbxA.Name = "txtbxA"
        Me.txtbxA.Size = New System.Drawing.Size(100, 22)
        Me.txtbxA.TabIndex = 7
        '
        'txtbxB
        '
        Me.txtbxB.Location = New System.Drawing.Point(100, 266)
        Me.txtbxB.Name = "txtbxB"
        Me.txtbxB.Size = New System.Drawing.Size(100, 22)
        Me.txtbxB.TabIndex = 8
        '
        'txtbxC
        '
        Me.txtbxC.Location = New System.Drawing.Point(100, 318)
        Me.txtbxC.Name = "txtbxC"
        Me.txtbxC.Size = New System.Drawing.Size(100, 22)
        Me.txtbxC.TabIndex = 9
        '
        'lblRaiz1
        '
        Me.lblRaiz1.AutoSize = True
        Me.lblRaiz1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaiz1.Location = New System.Drawing.Point(672, 225)
        Me.lblRaiz1.Name = "lblRaiz1"
        Me.lblRaiz1.Size = New System.Drawing.Size(72, 25)
        Me.lblRaiz1.TabIndex = 10
        Me.lblRaiz1.Text = "Raíz 1:"
        '
        'lblRaiz2
        '
        Me.lblRaiz2.AutoSize = True
        Me.lblRaiz2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRaiz2.Location = New System.Drawing.Point(672, 290)
        Me.lblRaiz2.Name = "lblRaiz2"
        Me.lblRaiz2.Size = New System.Drawing.Size(72, 25)
        Me.lblRaiz2.TabIndex = 11
        Me.lblRaiz2.Text = "Raíz 2:"
        '
        'lblResRaiz1
        '
        Me.lblResRaiz1.AutoSize = True
        Me.lblResRaiz1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRaiz1.Location = New System.Drawing.Point(775, 225)
        Me.lblResRaiz1.Name = "lblResRaiz1"
        Me.lblResRaiz1.Size = New System.Drawing.Size(119, 25)
        Me.lblResRaiz1.TabIndex = 12
        Me.lblResRaiz1.Text = "Titulo Raiz 1"
        Me.lblResRaiz1.Visible = False
        '
        'lblResRaiz2
        '
        Me.lblResRaiz2.AutoSize = True
        Me.lblResRaiz2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResRaiz2.Location = New System.Drawing.Point(775, 290)
        Me.lblResRaiz2.Name = "lblResRaiz2"
        Me.lblResRaiz2.Size = New System.Drawing.Size(119, 25)
        Me.lblResRaiz2.TabIndex = 13
        Me.lblResRaiz2.Text = "Titulo Raiz 2"
        Me.lblResRaiz2.Visible = False
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(265, 386)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(357, 97)
        Me.btnLimpiarCampos.TabIndex = 14
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(674, 359)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(66, 25)
        Me.lblTitulo.TabIndex = 15
        Me.lblTitulo.Text = "Titulo"
        Me.lblTitulo.Visible = False
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 559)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.lblResRaiz2)
        Me.Controls.Add(Me.lblResRaiz1)
        Me.Controls.Add(Me.lblRaiz2)
        Me.Controls.Add(Me.lblRaiz1)
        Me.Controls.Add(Me.txtbxC)
        Me.Controls.Add(Me.txtbxB)
        Me.Controls.Add(Me.txtbxA)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.lblC)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblFrase2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblFraseInicial)
        Me.Name = "FrmPrincipal"
        Me.Text = "Resolución Ecuación De Segundo Grado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFraseInicial As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblFrase2 As Label
    Friend WithEvents lblA As Label
    Friend WithEvents lblB As Label
    Friend WithEvents lblC As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents txtbxA As TextBox
    Friend WithEvents txtbxB As TextBox
    Friend WithEvents txtbxC As TextBox
    Friend WithEvents lblRaiz1 As Label
    Friend WithEvents lblRaiz2 As Label
    Friend WithEvents lblResRaiz1 As Label
    Friend WithEvents lblResRaiz2 As Label
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents lblTitulo As Label
End Class

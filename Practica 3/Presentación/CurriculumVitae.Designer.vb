<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curriculum_Vitae
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblListaAutores = New System.Windows.Forms.Label()
        Me.lblTituloArticulo = New System.Windows.Forms.Label()
        Me.lblConferencia = New System.Windows.Forms.Label()
        Me.lblPag = New System.Windows.Forms.Label()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.lblAño = New System.Windows.Forms.Label()
        Me.txtbxListaAutores = New System.Windows.Forms.TextBox()
        Me.txtbxTituloArticulo = New System.Windows.Forms.TextBox()
        Me.txtbxConferencia = New System.Windows.Forms.TextBox()
        Me.txtbxPag = New System.Windows.Forms.TextBox()
        Me.txtbxLugar = New System.Windows.Forms.TextBox()
        Me.txtbxAño = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(196, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CURRICULUM VITAE"
        '
        'lblListaAutores
        '
        Me.lblListaAutores.AutoSize = True
        Me.lblListaAutores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblListaAutores.Location = New System.Drawing.Point(201, 176)
        Me.lblListaAutores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblListaAutores.Name = "lblListaAutores"
        Me.lblListaAutores.Size = New System.Drawing.Size(114, 17)
        Me.lblListaAutores.TabIndex = 1
        Me.lblListaAutores.Text = "Lista de autores:"
        '
        'lblTituloArticulo
        '
        Me.lblTituloArticulo.AutoSize = True
        Me.lblTituloArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloArticulo.Location = New System.Drawing.Point(201, 219)
        Me.lblTituloArticulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTituloArticulo.Name = "lblTituloArticulo"
        Me.lblTituloArticulo.Size = New System.Drawing.Size(47, 17)
        Me.lblTituloArticulo.TabIndex = 2
        Me.lblTituloArticulo.Text = "Título:"
        '
        'lblConferencia
        '
        Me.lblConferencia.AutoSize = True
        Me.lblConferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConferencia.Location = New System.Drawing.Point(201, 261)
        Me.lblConferencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConferencia.Name = "lblConferencia"
        Me.lblConferencia.Size = New System.Drawing.Size(140, 17)
        Me.lblConferencia.TabIndex = 3
        Me.lblConferencia.Text = "Conferencia (Siglas):"
        '
        'lblPag
        '
        Me.lblPag.AutoSize = True
        Me.lblPag.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPag.Location = New System.Drawing.Point(201, 305)
        Me.lblPag.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPag.Name = "lblPag"
        Me.lblPag.Size = New System.Drawing.Size(122, 17)
        Me.lblPag.TabIndex = 4
        Me.lblPag.Text = "Pag inicio-Pag fin:"
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.Location = New System.Drawing.Point(201, 350)
        Me.lblLugar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(146, 17)
        Me.lblLugar.TabIndex = 5
        Me.lblLugar.Text = "Lugar de celebración:"
        '
        'lblAño
        '
        Me.lblAño.AutoSize = True
        Me.lblAño.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAño.Location = New System.Drawing.Point(201, 394)
        Me.lblAño.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAño.Name = "lblAño"
        Me.lblAño.Size = New System.Drawing.Size(134, 17)
        Me.lblAño.TabIndex = 6
        Me.lblAño.Text = "Año de celebración:"
        '
        'txtbxListaAutores
        '
        Me.txtbxListaAutores.Location = New System.Drawing.Point(335, 174)
        Me.txtbxListaAutores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxListaAutores.Name = "txtbxListaAutores"
        Me.txtbxListaAutores.Size = New System.Drawing.Size(456, 20)
        Me.txtbxListaAutores.TabIndex = 7
        '
        'txtbxTituloArticulo
        '
        Me.txtbxTituloArticulo.Location = New System.Drawing.Point(335, 219)
        Me.txtbxTituloArticulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxTituloArticulo.Name = "txtbxTituloArticulo"
        Me.txtbxTituloArticulo.Size = New System.Drawing.Size(456, 20)
        Me.txtbxTituloArticulo.TabIndex = 8
        '
        'txtbxConferencia
        '
        Me.txtbxConferencia.Location = New System.Drawing.Point(335, 261)
        Me.txtbxConferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxConferencia.Name = "txtbxConferencia"
        Me.txtbxConferencia.Size = New System.Drawing.Size(456, 20)
        Me.txtbxConferencia.TabIndex = 9
        '
        'txtbxPag
        '
        Me.txtbxPag.Location = New System.Drawing.Point(335, 302)
        Me.txtbxPag.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxPag.Name = "txtbxPag"
        Me.txtbxPag.Size = New System.Drawing.Size(456, 20)
        Me.txtbxPag.TabIndex = 10
        '
        'txtbxLugar
        '
        Me.txtbxLugar.Location = New System.Drawing.Point(335, 348)
        Me.txtbxLugar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxLugar.Name = "txtbxLugar"
        Me.txtbxLugar.Size = New System.Drawing.Size(456, 20)
        Me.txtbxLugar.TabIndex = 11
        '
        'txtbxAño
        '
        Me.txtbxAño.Location = New System.Drawing.Point(335, 394)
        Me.txtbxAño.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxAño.Name = "txtbxAño"
        Me.txtbxAño.Size = New System.Drawing.Size(456, 20)
        Me.txtbxAño.TabIndex = 12
        '
        'Curriculum_Vitae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(815, 466)
        Me.Controls.Add(Me.txtbxAño)
        Me.Controls.Add(Me.txtbxLugar)
        Me.Controls.Add(Me.txtbxPag)
        Me.Controls.Add(Me.txtbxConferencia)
        Me.Controls.Add(Me.txtbxTituloArticulo)
        Me.Controls.Add(Me.txtbxListaAutores)
        Me.Controls.Add(Me.lblAño)
        Me.Controls.Add(Me.lblLugar)
        Me.Controls.Add(Me.lblPag)
        Me.Controls.Add(Me.lblConferencia)
        Me.Controls.Add(Me.lblTituloArticulo)
        Me.Controls.Add(Me.lblListaAutores)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Curriculum_Vitae"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculum_Vitae"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblListaAutores As Label
    Friend WithEvents lblTituloArticulo As Label
    Friend WithEvents lblConferencia As Label
    Friend WithEvents lblPag As Label
    Friend WithEvents lblLugar As Label
    Friend WithEvents lblAño As Label
    Friend WithEvents txtbxListaAutores As TextBox
    Friend WithEvents txtbxTituloArticulo As TextBox
    Friend WithEvents txtbxConferencia As TextBox
    Friend WithEvents txtbxPag As TextBox
    Friend WithEvents txtbxLugar As TextBox
    Friend WithEvents txtbxAño As TextBox
End Class

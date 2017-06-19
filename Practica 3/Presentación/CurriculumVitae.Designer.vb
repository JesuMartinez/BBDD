<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Curriculum_Vitae
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.grpbxDatos = New System.Windows.Forms.GroupBox()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.txtbxTlf = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblTlf = New System.Windows.Forms.Label()
        Me.txtbxApellido = New System.Windows.Forms.TextBox()
        Me.txtbxEdificio = New System.Windows.Forms.TextBox()
        Me.txtbxDespacho = New System.Windows.Forms.TextBox()
        Me.txtbxDepartamento = New System.Windows.Forms.TextBox()
        Me.txtbxNombre = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.grpbxAsistencias = New System.Windows.Forms.GroupBox()
        Me.txtbxConferencias = New System.Windows.Forms.TextBox()
        Me.grpbxArticulos = New System.Windows.Forms.GroupBox()
        Me.txtbxArticulos = New System.Windows.Forms.TextBox()
        Me.grpbxDatos.SuspendLayout()
        Me.grpbxAsistencias.SuspendLayout()
        Me.grpbxArticulos.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Verdana", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(44, 41)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(573, 59)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "CURRICULUM VITAE"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Verdana", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(652, 72)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(60, 20)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "autor"
        Me.lblAutor.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(16, 45)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(91, 20)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "NOMBRE"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblApellido.ForeColor = System.Drawing.Color.Black
        Me.lblApellido.Location = New System.Drawing.Point(15, 98)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(117, 20)
        Me.lblApellido.TabIndex = 4
        Me.lblApellido.Text = "APELLIDOS"
        '
        'lblEdificio
        '
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblEdificio.ForeColor = System.Drawing.Color.Black
        Me.lblEdificio.Location = New System.Drawing.Point(16, 157)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(99, 20)
        Me.lblEdificio.TabIndex = 5
        Me.lblEdificio.Text = "EDIFICIO"
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblDepartamento.ForeColor = System.Drawing.Color.Black
        Me.lblDepartamento.Location = New System.Drawing.Point(15, 208)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(166, 20)
        Me.lblDepartamento.TabIndex = 6
        Me.lblDepartamento.Text = "DEPARTAMENTO"
        '
        'lblDespacho
        '
        Me.lblDespacho.AutoSize = True
        Me.lblDespacho.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblDespacho.ForeColor = System.Drawing.Color.Black
        Me.lblDespacho.Location = New System.Drawing.Point(16, 266)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(112, 20)
        Me.lblDespacho.TabIndex = 7
        Me.lblDespacho.Text = "DESPACHO"
        '
        'grpbxDatos
        '
        Me.grpbxDatos.Controls.Add(Me.txtbxEmail)
        Me.grpbxDatos.Controls.Add(Me.txtbxTlf)
        Me.grpbxDatos.Controls.Add(Me.lblEmail)
        Me.grpbxDatos.Controls.Add(Me.lblTlf)
        Me.grpbxDatos.Controls.Add(Me.txtbxApellido)
        Me.grpbxDatos.Controls.Add(Me.txtbxEdificio)
        Me.grpbxDatos.Controls.Add(Me.txtbxDespacho)
        Me.grpbxDatos.Controls.Add(Me.txtbxDepartamento)
        Me.grpbxDatos.Controls.Add(Me.txtbxNombre)
        Me.grpbxDatos.Controls.Add(Me.lblDespacho)
        Me.grpbxDatos.Controls.Add(Me.lblDepartamento)
        Me.grpbxDatos.Controls.Add(Me.lblEdificio)
        Me.grpbxDatos.Controls.Add(Me.lblApellido)
        Me.grpbxDatos.Controls.Add(Me.lblNombre)
        Me.grpbxDatos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxDatos.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.grpbxDatos.Location = New System.Drawing.Point(35, 150)
        Me.grpbxDatos.Name = "grpbxDatos"
        Me.grpbxDatos.Size = New System.Drawing.Size(503, 433)
        Me.grpbxDatos.TabIndex = 8
        Me.grpbxDatos.TabStop = False
        Me.grpbxDatos.Text = "DATOS PERSONALES"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Enabled = False
        Me.txtbxEmail.Location = New System.Drawing.Point(211, 380)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(236, 26)
        Me.txtbxEmail.TabIndex = 17
        '
        'txtbxTlf
        '
        Me.txtbxTlf.Enabled = False
        Me.txtbxTlf.Location = New System.Drawing.Point(211, 322)
        Me.txtbxTlf.Name = "txtbxTlf"
        Me.txtbxTlf.Size = New System.Drawing.Size(236, 26)
        Me.txtbxTlf.TabIndex = 16
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(17, 386)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(70, 20)
        Me.lblEmail.TabIndex = 15
        Me.lblEmail.Text = "EMAIL"
        '
        'lblTlf
        '
        Me.lblTlf.AutoSize = True
        Me.lblTlf.Font = New System.Drawing.Font("Verdana", 9.8!, System.Drawing.FontStyle.Bold)
        Me.lblTlf.ForeColor = System.Drawing.Color.Black
        Me.lblTlf.Location = New System.Drawing.Point(16, 328)
        Me.lblTlf.Name = "lblTlf"
        Me.lblTlf.Size = New System.Drawing.Size(109, 20)
        Me.lblTlf.TabIndex = 14
        Me.lblTlf.Text = "TELÉFONO"
        '
        'txtbxApellido
        '
        Me.txtbxApellido.Enabled = False
        Me.txtbxApellido.Location = New System.Drawing.Point(210, 92)
        Me.txtbxApellido.Name = "txtbxApellido"
        Me.txtbxApellido.Size = New System.Drawing.Size(236, 26)
        Me.txtbxApellido.TabIndex = 13
        '
        'txtbxEdificio
        '
        Me.txtbxEdificio.Enabled = False
        Me.txtbxEdificio.Location = New System.Drawing.Point(210, 151)
        Me.txtbxEdificio.Name = "txtbxEdificio"
        Me.txtbxEdificio.Size = New System.Drawing.Size(236, 26)
        Me.txtbxEdificio.TabIndex = 12
        '
        'txtbxDespacho
        '
        Me.txtbxDespacho.Enabled = False
        Me.txtbxDespacho.Location = New System.Drawing.Point(210, 266)
        Me.txtbxDespacho.Name = "txtbxDespacho"
        Me.txtbxDespacho.Size = New System.Drawing.Size(236, 26)
        Me.txtbxDespacho.TabIndex = 11
        '
        'txtbxDepartamento
        '
        Me.txtbxDepartamento.Enabled = False
        Me.txtbxDepartamento.Location = New System.Drawing.Point(210, 208)
        Me.txtbxDepartamento.Name = "txtbxDepartamento"
        Me.txtbxDepartamento.Size = New System.Drawing.Size(236, 26)
        Me.txtbxDepartamento.TabIndex = 9
        '
        'txtbxNombre
        '
        Me.txtbxNombre.Enabled = False
        Me.txtbxNombre.Location = New System.Drawing.Point(210, 39)
        Me.txtbxNombre.Name = "txtbxNombre"
        Me.txtbxNombre.Size = New System.Drawing.Size(236, 26)
        Me.txtbxNombre.TabIndex = 8
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(1159, 33)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(189, 67)
        Me.btnVolver.TabIndex = 9
        Me.btnVolver.Text = "Investigadores"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'grpbxAsistencias
        '
        Me.grpbxAsistencias.Controls.Add(Me.txtbxConferencias)
        Me.grpbxAsistencias.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxAsistencias.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.grpbxAsistencias.Location = New System.Drawing.Point(637, 150)
        Me.grpbxAsistencias.Name = "grpbxAsistencias"
        Me.grpbxAsistencias.Size = New System.Drawing.Size(717, 209)
        Me.grpbxAsistencias.TabIndex = 10
        Me.grpbxAsistencias.TabStop = False
        Me.grpbxAsistencias.Text = "CONFERENCIAS A LAS QUE ASISTE"
        '
        'txtbxConferencias
        '
        Me.txtbxConferencias.Enabled = False
        Me.txtbxConferencias.Location = New System.Drawing.Point(6, 25)
        Me.txtbxConferencias.Multiline = True
        Me.txtbxConferencias.Name = "txtbxConferencias"
        Me.txtbxConferencias.Size = New System.Drawing.Size(705, 178)
        Me.txtbxConferencias.TabIndex = 9
        '
        'grpbxArticulos
        '
        Me.grpbxArticulos.Controls.Add(Me.txtbxArticulos)
        Me.grpbxArticulos.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbxArticulos.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.grpbxArticulos.Location = New System.Drawing.Point(637, 374)
        Me.grpbxArticulos.Name = "grpbxArticulos"
        Me.grpbxArticulos.Size = New System.Drawing.Size(717, 209)
        Me.grpbxArticulos.TabIndex = 11
        Me.grpbxArticulos.TabStop = False
        Me.grpbxArticulos.Text = "ARTÍCULOS QUE HA PUBLICADO"
        '
        'txtbxArticulos
        '
        Me.txtbxArticulos.Enabled = False
        Me.txtbxArticulos.Location = New System.Drawing.Point(6, 25)
        Me.txtbxArticulos.Multiline = True
        Me.txtbxArticulos.Name = "txtbxArticulos"
        Me.txtbxArticulos.Size = New System.Drawing.Size(705, 178)
        Me.txtbxArticulos.TabIndex = 10
        '
        'Curriculum_Vitae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1379, 635)
        Me.Controls.Add(Me.grpbxArticulos)
        Me.Controls.Add(Me.grpbxAsistencias)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.grpbxDatos)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.lblTitulo)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Curriculum_Vitae"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculum_Vitae"
        Me.grpbxDatos.ResumeLayout(False)
        Me.grpbxDatos.PerformLayout()
        Me.grpbxAsistencias.ResumeLayout(False)
        Me.grpbxAsistencias.PerformLayout()
        Me.grpbxArticulos.ResumeLayout(False)
        Me.grpbxArticulos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblAutor As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblEdificio As Label
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblDespacho As Label
    Friend WithEvents grpbxDatos As GroupBox
    Friend WithEvents txtbxApellido As TextBox
    Friend WithEvents txtbxEdificio As TextBox
    Friend WithEvents txtbxDespacho As TextBox
    Friend WithEvents txtbxDepartamento As TextBox
    Friend WithEvents txtbxNombre As TextBox
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents txtbxTlf As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblTlf As Label
    Friend WithEvents btnVolver As Button
    Friend WithEvents grpbxAsistencias As GroupBox
    Friend WithEvents txtbxConferencias As TextBox
    Friend WithEvents grpbxArticulos As GroupBox
    Friend WithEvents txtbxArticulos As TextBox
End Class

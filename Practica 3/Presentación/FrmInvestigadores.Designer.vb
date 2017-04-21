<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInvestigadores
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
        Me.grpbxInvestigadores = New System.Windows.Forms.GroupBox()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnGestionarAsistencias = New System.Windows.Forms.Button()
        Me.btnCrearCV = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtbxEmail = New System.Windows.Forms.TextBox()
        Me.txtbxTelefono = New System.Windows.Forms.TextBox()
        Me.txtbxDepartamento = New System.Windows.Forms.TextBox()
        Me.txtbxEdificio = New System.Windows.Forms.TextBox()
        Me.txtbxDespacho = New System.Windows.Forms.TextBox()
        Me.txtbxApellidosInvestigador = New System.Windows.Forms.TextBox()
        Me.txtbxNombreInvestigador = New System.Windows.Forms.TextBox()
        Me.txtbxIDInvestigador = New System.Windows.Forms.TextBox()
        Me.lblDepartamento = New System.Windows.Forms.Label()
        Me.lblEdificio = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDespacho = New System.Windows.Forms.Label()
        Me.lblApellidosInvestigador = New System.Windows.Forms.Label()
        Me.lblNombreInvestigador = New System.Windows.Forms.Label()
        Me.lblIDInvestigador = New System.Windows.Forms.Label()
        Me.lstbxInvestigadores = New System.Windows.Forms.ListBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.grpbxInvestigadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxInvestigadores
        '
        Me.grpbxInvestigadores.Controls.Add(Me.btnArticulos)
        Me.grpbxInvestigadores.Controls.Add(Me.Button1)
        Me.grpbxInvestigadores.Controls.Add(Me.btnGestionarAsistencias)
        Me.grpbxInvestigadores.Controls.Add(Me.btnCrearCV)
        Me.grpbxInvestigadores.Controls.Add(Me.btnAñadir)
        Me.grpbxInvestigadores.Controls.Add(Me.btnModificar)
        Me.grpbxInvestigadores.Controls.Add(Me.btnEliminar)
        Me.grpbxInvestigadores.Controls.Add(Me.lblEmail)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxEmail)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxTelefono)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxDepartamento)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxEdificio)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxDespacho)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxApellidosInvestigador)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxNombreInvestigador)
        Me.grpbxInvestigadores.Controls.Add(Me.txtbxIDInvestigador)
        Me.grpbxInvestigadores.Controls.Add(Me.lblDepartamento)
        Me.grpbxInvestigadores.Controls.Add(Me.lblEdificio)
        Me.grpbxInvestigadores.Controls.Add(Me.lblTelefono)
        Me.grpbxInvestigadores.Controls.Add(Me.lblDespacho)
        Me.grpbxInvestigadores.Controls.Add(Me.lblApellidosInvestigador)
        Me.grpbxInvestigadores.Controls.Add(Me.lblNombreInvestigador)
        Me.grpbxInvestigadores.Controls.Add(Me.lblIDInvestigador)
        Me.grpbxInvestigadores.Controls.Add(Me.lstbxInvestigadores)
        Me.grpbxInvestigadores.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.grpbxInvestigadores.Location = New System.Drawing.Point(38, 31)
        Me.grpbxInvestigadores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpbxInvestigadores.Name = "grpbxInvestigadores"
        Me.grpbxInvestigadores.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpbxInvestigadores.Size = New System.Drawing.Size(766, 406)
        Me.grpbxInvestigadores.TabIndex = 0
        Me.grpbxInvestigadores.TabStop = False
        Me.grpbxInvestigadores.Text = "INVESTIGADORES"
        '
        'btnArticulos
        '
        Me.btnArticulos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnArticulos.Location = New System.Drawing.Point(434, 323)
        Me.btnArticulos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(107, 46)
        Me.btnArticulos.TabIndex = 23
        Me.btnArticulos.Text = "Artículos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button1.Location = New System.Drawing.Point(570, 323)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 46)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Conferencias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnGestionarAsistencias
        '
        Me.btnGestionarAsistencias.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGestionarAsistencias.Location = New System.Drawing.Point(105, 315)
        Me.btnGestionarAsistencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGestionarAsistencias.Name = "btnGestionarAsistencias"
        Me.btnGestionarAsistencias.Size = New System.Drawing.Size(80, 62)
        Me.btnGestionarAsistencias.TabIndex = 21
        Me.btnGestionarAsistencias.Text = "Gestionar Asistencias"
        Me.btnGestionarAsistencias.UseVisualStyleBackColor = True
        '
        'btnCrearCV
        '
        Me.btnCrearCV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCrearCV.Location = New System.Drawing.Point(21, 315)
        Me.btnCrearCV.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCrearCV.Name = "btnCrearCV"
        Me.btnCrearCV.Size = New System.Drawing.Size(80, 62)
        Me.btnCrearCV.TabIndex = 20
        Me.btnCrearCV.Text = "Crear CV"
        Me.btnCrearCV.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAñadir.Location = New System.Drawing.Point(242, 232)
        Me.btnAñadir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(114, 49)
        Me.btnAñadir.TabIndex = 19
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(406, 232)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(114, 49)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(581, 232)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(114, 49)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmail.Location = New System.Drawing.Point(448, 174)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(51, 17)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "E-mail:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Location = New System.Drawing.Point(553, 172)
        Me.txtbxEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(113, 20)
        Me.txtbxEmail.TabIndex = 15
        '
        'txtbxTelefono
        '
        Me.txtbxTelefono.Location = New System.Drawing.Point(553, 134)
        Me.txtbxTelefono.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxTelefono.Name = "txtbxTelefono"
        Me.txtbxTelefono.Size = New System.Drawing.Size(113, 20)
        Me.txtbxTelefono.TabIndex = 14
        '
        'txtbxDepartamento
        '
        Me.txtbxDepartamento.Location = New System.Drawing.Point(553, 93)
        Me.txtbxDepartamento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxDepartamento.Name = "txtbxDepartamento"
        Me.txtbxDepartamento.Size = New System.Drawing.Size(113, 20)
        Me.txtbxDepartamento.TabIndex = 13
        '
        'txtbxEdificio
        '
        Me.txtbxEdificio.Location = New System.Drawing.Point(553, 58)
        Me.txtbxEdificio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxEdificio.Name = "txtbxEdificio"
        Me.txtbxEdificio.Size = New System.Drawing.Size(113, 20)
        Me.txtbxEdificio.TabIndex = 12
        '
        'txtbxDespacho
        '
        Me.txtbxDespacho.Location = New System.Drawing.Point(311, 174)
        Me.txtbxDespacho.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxDespacho.Name = "txtbxDespacho"
        Me.txtbxDespacho.Size = New System.Drawing.Size(112, 20)
        Me.txtbxDespacho.TabIndex = 11
        '
        'txtbxApellidosInvestigador
        '
        Me.txtbxApellidosInvestigador.Location = New System.Drawing.Point(311, 136)
        Me.txtbxApellidosInvestigador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxApellidosInvestigador.Name = "txtbxApellidosInvestigador"
        Me.txtbxApellidosInvestigador.Size = New System.Drawing.Size(112, 20)
        Me.txtbxApellidosInvestigador.TabIndex = 10
        '
        'txtbxNombreInvestigador
        '
        Me.txtbxNombreInvestigador.Location = New System.Drawing.Point(311, 94)
        Me.txtbxNombreInvestigador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxNombreInvestigador.Name = "txtbxNombreInvestigador"
        Me.txtbxNombreInvestigador.Size = New System.Drawing.Size(112, 20)
        Me.txtbxNombreInvestigador.TabIndex = 9
        '
        'txtbxIDInvestigador
        '
        Me.txtbxIDInvestigador.Location = New System.Drawing.Point(311, 58)
        Me.txtbxIDInvestigador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxIDInvestigador.Name = "txtbxIDInvestigador"
        Me.txtbxIDInvestigador.Size = New System.Drawing.Size(112, 20)
        Me.txtbxIDInvestigador.TabIndex = 8
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepartamento.Location = New System.Drawing.Point(448, 94)
        Me.lblDepartamento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(102, 17)
        Me.lblDepartamento.TabIndex = 7
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblEdificio
        '
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdificio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEdificio.Location = New System.Drawing.Point(448, 59)
        Me.lblEdificio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(57, 17)
        Me.lblEdificio.TabIndex = 6
        Me.lblEdificio.Text = "Edificio:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTelefono.Location = New System.Drawing.Point(448, 136)
        Me.lblTelefono.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(68, 17)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblDespacho
        '
        Me.lblDespacho.AutoSize = True
        Me.lblDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDespacho.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDespacho.Location = New System.Drawing.Point(239, 174)
        Me.lblDespacho.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(76, 17)
        Me.lblDespacho.TabIndex = 4
        Me.lblDespacho.Text = "Despacho:"
        '
        'lblApellidosInvestigador
        '
        Me.lblApellidosInvestigador.AutoSize = True
        Me.lblApellidosInvestigador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosInvestigador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblApellidosInvestigador.Location = New System.Drawing.Point(240, 136)
        Me.lblApellidosInvestigador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApellidosInvestigador.Name = "lblApellidosInvestigador"
        Me.lblApellidosInvestigador.Size = New System.Drawing.Size(69, 17)
        Me.lblApellidosInvestigador.TabIndex = 3
        Me.lblApellidosInvestigador.Text = "Apellidos:"
        '
        'lblNombreInvestigador
        '
        Me.lblNombreInvestigador.AutoSize = True
        Me.lblNombreInvestigador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreInvestigador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombreInvestigador.Location = New System.Drawing.Point(239, 94)
        Me.lblNombreInvestigador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreInvestigador.Name = "lblNombreInvestigador"
        Me.lblNombreInvestigador.Size = New System.Drawing.Size(62, 17)
        Me.lblNombreInvestigador.TabIndex = 2
        Me.lblNombreInvestigador.Text = "Nombre:"
        '
        'lblIDInvestigador
        '
        Me.lblIDInvestigador.AutoSize = True
        Me.lblIDInvestigador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDInvestigador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIDInvestigador.Location = New System.Drawing.Point(240, 59)
        Me.lblIDInvestigador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDInvestigador.Name = "lblIDInvestigador"
        Me.lblIDInvestigador.Size = New System.Drawing.Size(25, 17)
        Me.lblIDInvestigador.TabIndex = 1
        Me.lblIDInvestigador.Text = "ID:"
        '
        'lstbxInvestigadores
        '
        Me.lstbxInvestigadores.FormattingEnabled = True
        Me.lstbxInvestigadores.Location = New System.Drawing.Point(21, 30)
        Me.lstbxInvestigadores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstbxInvestigadores.Name = "lstbxInvestigadores"
        Me.lstbxInvestigadores.Size = New System.Drawing.Size(164, 251)
        Me.lstbxInvestigadores.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Microsoft Access Base de datos(*.accdb)|*.accdb"
        '
        'FrmInvestigadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 469)
        Me.Controls.Add(Me.grpbxInvestigadores)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmInvestigadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Investigadores"
        Me.grpbxInvestigadores.ResumeLayout(False)
        Me.grpbxInvestigadores.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpbxInvestigadores As GroupBox
    Friend WithEvents lstbxInvestigadores As ListBox
    Friend WithEvents btnGestionarAsistencias As Button
    Friend WithEvents btnCrearCV As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtbxEmail As TextBox
    Friend WithEvents txtbxTelefono As TextBox
    Friend WithEvents txtbxDepartamento As TextBox
    Friend WithEvents txtbxEdificio As TextBox
    Friend WithEvents txtbxDespacho As TextBox
    Friend WithEvents txtbxApellidosInvestigador As TextBox
    Friend WithEvents txtbxNombreInvestigador As TextBox
    Friend WithEvents txtbxIDInvestigador As TextBox
    Friend WithEvents lblDepartamento As Label
    Friend WithEvents lblEdificio As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDespacho As Label
    Friend WithEvents lblApellidosInvestigador As Label
    Friend WithEvents lblNombreInvestigador As Label
    Friend WithEvents lblIDInvestigador As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents btnArticulos As Button
End Class

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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpbxInvestigadores.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpbxInvestigadores
        '
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
        Me.grpbxInvestigadores.Location = New System.Drawing.Point(50, 38)
        Me.grpbxInvestigadores.Name = "grpbxInvestigadores"
        Me.grpbxInvestigadores.Size = New System.Drawing.Size(1022, 500)
        Me.grpbxInvestigadores.TabIndex = 0
        Me.grpbxInvestigadores.TabStop = False
        Me.grpbxInvestigadores.Text = "INVESTIGADORES"
        '
        'btnGestionarAsistencias
        '
        Me.btnGestionarAsistencias.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGestionarAsistencias.Location = New System.Drawing.Point(176, 388)
        Me.btnGestionarAsistencias.Name = "btnGestionarAsistencias"
        Me.btnGestionarAsistencias.Size = New System.Drawing.Size(107, 76)
        Me.btnGestionarAsistencias.TabIndex = 21
        Me.btnGestionarAsistencias.Text = "Gestionar Asistencias"
        Me.btnGestionarAsistencias.UseVisualStyleBackColor = True
        '
        'btnCrearCV
        '
        Me.btnCrearCV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCrearCV.Location = New System.Drawing.Point(28, 388)
        Me.btnCrearCV.Name = "btnCrearCV"
        Me.btnCrearCV.Size = New System.Drawing.Size(107, 76)
        Me.btnCrearCV.TabIndex = 20
        Me.btnCrearCV.Text = "Crear CV"
        Me.btnCrearCV.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAñadir.Location = New System.Drawing.Point(323, 285)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(152, 60)
        Me.btnAñadir.TabIndex = 19
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(541, 285)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(152, 60)
        Me.btnModificar.TabIndex = 18
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(775, 285)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(152, 60)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEmail.Location = New System.Drawing.Point(598, 214)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(62, 20)
        Me.lblEmail.TabIndex = 16
        Me.lblEmail.Text = "E-mail:"
        '
        'txtbxEmail
        '
        Me.txtbxEmail.Location = New System.Drawing.Point(737, 212)
        Me.txtbxEmail.Name = "txtbxEmail"
        Me.txtbxEmail.Size = New System.Drawing.Size(149, 22)
        Me.txtbxEmail.TabIndex = 15
        '
        'txtbxTelefono
        '
        Me.txtbxTelefono.Location = New System.Drawing.Point(737, 165)
        Me.txtbxTelefono.Name = "txtbxTelefono"
        Me.txtbxTelefono.Size = New System.Drawing.Size(149, 22)
        Me.txtbxTelefono.TabIndex = 14
        '
        'txtbxDepartamento
        '
        Me.txtbxDepartamento.Location = New System.Drawing.Point(737, 114)
        Me.txtbxDepartamento.Name = "txtbxDepartamento"
        Me.txtbxDepartamento.Size = New System.Drawing.Size(149, 22)
        Me.txtbxDepartamento.TabIndex = 13
        '
        'txtbxEdificio
        '
        Me.txtbxEdificio.Location = New System.Drawing.Point(737, 71)
        Me.txtbxEdificio.Name = "txtbxEdificio"
        Me.txtbxEdificio.Size = New System.Drawing.Size(149, 22)
        Me.txtbxEdificio.TabIndex = 12
        '
        'txtbxDespacho
        '
        Me.txtbxDespacho.Location = New System.Drawing.Point(415, 214)
        Me.txtbxDespacho.Name = "txtbxDespacho"
        Me.txtbxDespacho.Size = New System.Drawing.Size(148, 22)
        Me.txtbxDespacho.TabIndex = 11
        '
        'txtbxApellidosInvestigador
        '
        Me.txtbxApellidosInvestigador.Location = New System.Drawing.Point(415, 167)
        Me.txtbxApellidosInvestigador.Name = "txtbxApellidosInvestigador"
        Me.txtbxApellidosInvestigador.Size = New System.Drawing.Size(148, 22)
        Me.txtbxApellidosInvestigador.TabIndex = 10
        '
        'txtbxNombreInvestigador
        '
        Me.txtbxNombreInvestigador.Location = New System.Drawing.Point(415, 116)
        Me.txtbxNombreInvestigador.Name = "txtbxNombreInvestigador"
        Me.txtbxNombreInvestigador.Size = New System.Drawing.Size(148, 22)
        Me.txtbxNombreInvestigador.TabIndex = 9
        '
        'txtbxIDInvestigador
        '
        Me.txtbxIDInvestigador.Location = New System.Drawing.Point(415, 71)
        Me.txtbxIDInvestigador.Name = "txtbxIDInvestigador"
        Me.txtbxIDInvestigador.Size = New System.Drawing.Size(148, 22)
        Me.txtbxIDInvestigador.TabIndex = 8
        '
        'lblDepartamento
        '
        Me.lblDepartamento.AutoSize = True
        Me.lblDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDepartamento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDepartamento.Location = New System.Drawing.Point(598, 116)
        Me.lblDepartamento.Name = "lblDepartamento"
        Me.lblDepartamento.Size = New System.Drawing.Size(120, 20)
        Me.lblDepartamento.TabIndex = 7
        Me.lblDepartamento.Text = "Departamento:"
        '
        'lblEdificio
        '
        Me.lblEdificio.AutoSize = True
        Me.lblEdificio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdificio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblEdificio.Location = New System.Drawing.Point(598, 73)
        Me.lblEdificio.Name = "lblEdificio"
        Me.lblEdificio.Size = New System.Drawing.Size(69, 20)
        Me.lblEdificio.TabIndex = 6
        Me.lblEdificio.Text = "Edificio:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTelefono.Location = New System.Drawing.Point(598, 167)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(78, 20)
        Me.lblTelefono.TabIndex = 5
        Me.lblTelefono.Text = "Teléfono:"
        '
        'lblDespacho
        '
        Me.lblDespacho.AutoSize = True
        Me.lblDespacho.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDespacho.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDespacho.Location = New System.Drawing.Point(319, 214)
        Me.lblDespacho.Name = "lblDespacho"
        Me.lblDespacho.Size = New System.Drawing.Size(90, 20)
        Me.lblDespacho.TabIndex = 4
        Me.lblDespacho.Text = "Despacho:"
        '
        'lblApellidosInvestigador
        '
        Me.lblApellidosInvestigador.AutoSize = True
        Me.lblApellidosInvestigador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidosInvestigador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblApellidosInvestigador.Location = New System.Drawing.Point(320, 167)
        Me.lblApellidosInvestigador.Name = "lblApellidosInvestigador"
        Me.lblApellidosInvestigador.Size = New System.Drawing.Size(82, 20)
        Me.lblApellidosInvestigador.TabIndex = 3
        Me.lblApellidosInvestigador.Text = "Apellidos:"
        '
        'lblNombreInvestigador
        '
        Me.lblNombreInvestigador.AutoSize = True
        Me.lblNombreInvestigador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreInvestigador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombreInvestigador.Location = New System.Drawing.Point(319, 116)
        Me.lblNombreInvestigador.Name = "lblNombreInvestigador"
        Me.lblNombreInvestigador.Size = New System.Drawing.Size(73, 20)
        Me.lblNombreInvestigador.TabIndex = 2
        Me.lblNombreInvestigador.Text = "Nombre:"
        '
        'lblIDInvestigador
        '
        Me.lblIDInvestigador.AutoSize = True
        Me.lblIDInvestigador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDInvestigador.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIDInvestigador.Location = New System.Drawing.Point(320, 73)
        Me.lblIDInvestigador.Name = "lblIDInvestigador"
        Me.lblIDInvestigador.Size = New System.Drawing.Size(31, 20)
        Me.lblIDInvestigador.TabIndex = 1
        Me.lblIDInvestigador.Text = "ID:"
        '
        'lstbxInvestigadores
        '
        Me.lstbxInvestigadores.FormattingEnabled = True
        Me.lstbxInvestigadores.ItemHeight = 16
        Me.lstbxInvestigadores.Location = New System.Drawing.Point(28, 37)
        Me.lstbxInvestigadores.Name = "lstbxInvestigadores"
        Me.lstbxInvestigadores.Size = New System.Drawing.Size(197, 308)
        Me.lstbxInvestigadores.TabIndex = 0
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Microsoft Access Base de datos(*.accdb)|*.accdb"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.InfoText
        Me.Button1.Location = New System.Drawing.Point(808, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 57)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Conferencias"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmInvestigadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 577)
        Me.Controls.Add(Me.grpbxInvestigadores)
        Me.Name = "FrmInvestigadores"
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
End Class

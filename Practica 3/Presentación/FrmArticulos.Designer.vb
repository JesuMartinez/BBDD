<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmArticulos
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnInvestigadores = New System.Windows.Forms.Button()
        Me.btnConferencias = New System.Windows.Forms.Button()
        Me.btnEliminarArticulo = New System.Windows.Forms.Button()
        Me.btnModificarArticulo = New System.Windows.Forms.Button()
        Me.btnAñadirArticulo = New System.Windows.Forms.Button()
        Me.btnGestionarAutores = New System.Windows.Forms.Button()
        Me.txtbxPag_fin = New System.Windows.Forms.TextBox()
        Me.txtbxPag_inicio = New System.Windows.Forms.TextBox()
        Me.txtbxConferencia = New System.Windows.Forms.TextBox()
        Me.txtbxTituloArticulo = New System.Windows.Forms.TextBox()
        Me.txtbxIDArticulo = New System.Windows.Forms.TextBox()
        Me.lblPag_fin = New System.Windows.Forms.Label()
        Me.lblPag_inicio = New System.Windows.Forms.Label()
        Me.lblConferencia = New System.Windows.Forms.Label()
        Me.lblTituloArticulo = New System.Windows.Forms.Label()
        Me.lblIDArticulo = New System.Windows.Forms.Label()
        Me.lstbxArticulos = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInvestigadores)
        Me.GroupBox1.Controls.Add(Me.btnConferencias)
        Me.GroupBox1.Controls.Add(Me.btnEliminarArticulo)
        Me.GroupBox1.Controls.Add(Me.btnModificarArticulo)
        Me.GroupBox1.Controls.Add(Me.btnAñadirArticulo)
        Me.GroupBox1.Controls.Add(Me.btnGestionarAutores)
        Me.GroupBox1.Controls.Add(Me.txtbxPag_fin)
        Me.GroupBox1.Controls.Add(Me.txtbxPag_inicio)
        Me.GroupBox1.Controls.Add(Me.txtbxConferencia)
        Me.GroupBox1.Controls.Add(Me.txtbxTituloArticulo)
        Me.GroupBox1.Controls.Add(Me.txtbxIDArticulo)
        Me.GroupBox1.Controls.Add(Me.lblPag_fin)
        Me.GroupBox1.Controls.Add(Me.lblPag_inicio)
        Me.GroupBox1.Controls.Add(Me.lblConferencia)
        Me.GroupBox1.Controls.Add(Me.lblTituloArticulo)
        Me.GroupBox1.Controls.Add(Me.lblIDArticulo)
        Me.GroupBox1.Controls.Add(Me.lstbxArticulos)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(36, 47)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(789, 497)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ARTÍCULOS"
        '
        'btnInvestigadores
        '
        Me.btnInvestigadores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInvestigadores.Location = New System.Drawing.Point(540, 327)
        Me.btnInvestigadores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnInvestigadores.Name = "btnInvestigadores"
        Me.btnInvestigadores.Size = New System.Drawing.Size(223, 63)
        Me.btnInvestigadores.TabIndex = 17
        Me.btnInvestigadores.Text = "Investigadores"
        Me.btnInvestigadores.UseVisualStyleBackColor = True
        '
        'btnConferencias
        '
        Me.btnConferencias.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConferencias.Location = New System.Drawing.Point(304, 327)
        Me.btnConferencias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnConferencias.Name = "btnConferencias"
        Me.btnConferencias.Size = New System.Drawing.Size(223, 63)
        Me.btnConferencias.TabIndex = 16
        Me.btnConferencias.Text = "Conferencias"
        Me.btnConferencias.UseVisualStyleBackColor = True
        '
        'btnEliminarArticulo
        '
        Me.btnEliminarArticulo.Enabled = False
        Me.btnEliminarArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminarArticulo.Location = New System.Drawing.Point(614, 240)
        Me.btnEliminarArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminarArticulo.Name = "btnEliminarArticulo"
        Me.btnEliminarArticulo.Size = New System.Drawing.Size(149, 63)
        Me.btnEliminarArticulo.TabIndex = 15
        Me.btnEliminarArticulo.Text = "Eliminar"
        Me.btnEliminarArticulo.UseVisualStyleBackColor = True
        '
        'btnModificarArticulo
        '
        Me.btnModificarArticulo.Enabled = False
        Me.btnModificarArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificarArticulo.Location = New System.Drawing.Point(459, 240)
        Me.btnModificarArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnModificarArticulo.Name = "btnModificarArticulo"
        Me.btnModificarArticulo.Size = New System.Drawing.Size(149, 63)
        Me.btnModificarArticulo.TabIndex = 14
        Me.btnModificarArticulo.Text = "Modificar"
        Me.btnModificarArticulo.UseVisualStyleBackColor = True
        '
        'btnAñadirArticulo
        '
        Me.btnAñadirArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAñadirArticulo.Location = New System.Drawing.Point(304, 240)
        Me.btnAñadirArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAñadirArticulo.Name = "btnAñadirArticulo"
        Me.btnAñadirArticulo.Size = New System.Drawing.Size(149, 63)
        Me.btnAñadirArticulo.TabIndex = 13
        Me.btnAñadirArticulo.Text = "Añadir"
        Me.btnAñadirArticulo.UseVisualStyleBackColor = True
        '
        'btnGestionarAutores
        '
        Me.btnGestionarAutores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGestionarAutores.Location = New System.Drawing.Point(48, 411)
        Me.btnGestionarAutores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnGestionarAutores.Name = "btnGestionarAutores"
        Me.btnGestionarAutores.Size = New System.Drawing.Size(149, 63)
        Me.btnGestionarAutores.TabIndex = 12
        Me.btnGestionarAutores.Text = "Gestionar Autores"
        Me.btnGestionarAutores.UseVisualStyleBackColor = True
        '
        'txtbxPag_fin
        '
        Me.txtbxPag_fin.Location = New System.Drawing.Point(430, 195)
        Me.txtbxPag_fin.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxPag_fin.Name = "txtbxPag_fin"
        Me.txtbxPag_fin.Size = New System.Drawing.Size(180, 22)
        Me.txtbxPag_fin.TabIndex = 11
        '
        'txtbxPag_inicio
        '
        Me.txtbxPag_inicio.Location = New System.Drawing.Point(430, 159)
        Me.txtbxPag_inicio.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxPag_inicio.Name = "txtbxPag_inicio"
        Me.txtbxPag_inicio.Size = New System.Drawing.Size(180, 22)
        Me.txtbxPag_inicio.TabIndex = 10
        '
        'txtbxConferencia
        '
        Me.txtbxConferencia.Location = New System.Drawing.Point(430, 124)
        Me.txtbxConferencia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxConferencia.Name = "txtbxConferencia"
        Me.txtbxConferencia.Size = New System.Drawing.Size(180, 22)
        Me.txtbxConferencia.TabIndex = 9
        '
        'txtbxTituloArticulo
        '
        Me.txtbxTituloArticulo.Location = New System.Drawing.Point(430, 88)
        Me.txtbxTituloArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxTituloArticulo.Name = "txtbxTituloArticulo"
        Me.txtbxTituloArticulo.Size = New System.Drawing.Size(180, 22)
        Me.txtbxTituloArticulo.TabIndex = 8
        '
        'txtbxIDArticulo
        '
        Me.txtbxIDArticulo.Location = New System.Drawing.Point(430, 48)
        Me.txtbxIDArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbxIDArticulo.Name = "txtbxIDArticulo"
        Me.txtbxIDArticulo.Size = New System.Drawing.Size(180, 22)
        Me.txtbxIDArticulo.TabIndex = 7
        '
        'lblPag_fin
        '
        Me.lblPag_fin.AutoSize = True
        Me.lblPag_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPag_fin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPag_fin.Location = New System.Drawing.Point(300, 195)
        Me.lblPag_fin.Name = "lblPag_fin"
        Me.lblPag_fin.Size = New System.Drawing.Size(66, 20)
        Me.lblPag_fin.TabIndex = 6
        Me.lblPag_fin.Text = "Pag fin:"
        '
        'lblPag_inicio
        '
        Me.lblPag_inicio.AutoSize = True
        Me.lblPag_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPag_inicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPag_inicio.Location = New System.Drawing.Point(300, 159)
        Me.lblPag_inicio.Name = "lblPag_inicio"
        Me.lblPag_inicio.Size = New System.Drawing.Size(87, 20)
        Me.lblPag_inicio.TabIndex = 5
        Me.lblPag_inicio.Text = "Pag inicio:"
        '
        'lblConferencia
        '
        Me.lblConferencia.AutoSize = True
        Me.lblConferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConferencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblConferencia.Location = New System.Drawing.Point(300, 124)
        Me.lblConferencia.Name = "lblConferencia"
        Me.lblConferencia.Size = New System.Drawing.Size(104, 20)
        Me.lblConferencia.TabIndex = 4
        Me.lblConferencia.Text = "Conferencia:"
        '
        'lblTituloArticulo
        '
        Me.lblTituloArticulo.AutoSize = True
        Me.lblTituloArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTituloArticulo.Location = New System.Drawing.Point(300, 88)
        Me.lblTituloArticulo.Name = "lblTituloArticulo"
        Me.lblTituloArticulo.Size = New System.Drawing.Size(55, 20)
        Me.lblTituloArticulo.TabIndex = 3
        Me.lblTituloArticulo.Text = "Título:"
        '
        'lblIDArticulo
        '
        Me.lblIDArticulo.AutoSize = True
        Me.lblIDArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDArticulo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIDArticulo.Location = New System.Drawing.Point(300, 48)
        Me.lblIDArticulo.Name = "lblIDArticulo"
        Me.lblIDArticulo.Size = New System.Drawing.Size(93, 20)
        Me.lblIDArticulo.TabIndex = 2
        Me.lblIDArticulo.Text = "ID Artículo:"
        '
        'lstbxArticulos
        '
        Me.lstbxArticulos.FormattingEnabled = True
        Me.lstbxArticulos.ItemHeight = 16
        Me.lstbxArticulos.Location = New System.Drawing.Point(48, 50)
        Me.lstbxArticulos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstbxArticulos.Name = "lstbxArticulos"
        Me.lstbxArticulos.Size = New System.Drawing.Size(181, 340)
        Me.lstbxArticulos.TabIndex = 0
        '
        'FrmArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 581)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmArticulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Articulos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lstbxArticulos As ListBox
    Friend WithEvents txtbxIDArticulo As TextBox
    Friend WithEvents lblPag_fin As Label
    Friend WithEvents lblPag_inicio As Label
    Friend WithEvents lblConferencia As Label
    Friend WithEvents lblTituloArticulo As Label
    Friend WithEvents lblIDArticulo As Label
    Friend WithEvents btnEliminarArticulo As Button
    Friend WithEvents btnModificarArticulo As Button
    Friend WithEvents btnAñadirArticulo As Button
    Friend WithEvents btnGestionarAutores As Button
    Friend WithEvents txtbxPag_fin As TextBox
    Friend WithEvents txtbxPag_inicio As TextBox
    Friend WithEvents txtbxConferencia As TextBox
    Friend WithEvents txtbxTituloArticulo As TextBox
    Friend WithEvents btnInvestigadores As Button
    Friend WithEvents btnConferencias As Button
End Class

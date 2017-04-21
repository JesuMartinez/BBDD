<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmConferencias
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtbxFecha_fin = New System.Windows.Forms.TextBox()
        Me.txtbxFecha_inicio = New System.Windows.Forms.TextBox()
        Me.txtbxLugar = New System.Windows.Forms.TextBox()
        Me.txtbxNombreConferencia = New System.Windows.Forms.TextBox()
        Me.txtbxSiglas = New System.Windows.Forms.TextBox()
        Me.txtbxIDConferencia = New System.Windows.Forms.TextBox()
        Me.lblLugar = New System.Windows.Forms.Label()
        Me.lblFecha_fin = New System.Windows.Forms.Label()
        Me.lblFecha_inicio = New System.Windows.Forms.Label()
        Me.lblNombreConferencia = New System.Windows.Forms.Label()
        Me.lblSiglas = New System.Windows.Forms.Label()
        Me.lblIDConferencia = New System.Windows.Forms.Label()
        Me.lstbxConferencias = New System.Windows.Forms.ListBox()
        Me.btnArticulos = New System.Windows.Forms.Button()
        Me.btnInvestigadores = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnInvestigadores)
        Me.GroupBox1.Controls.Add(Me.btnArticulos)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.btnAñadir)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.txtbxFecha_fin)
        Me.GroupBox1.Controls.Add(Me.txtbxFecha_inicio)
        Me.GroupBox1.Controls.Add(Me.txtbxLugar)
        Me.GroupBox1.Controls.Add(Me.txtbxNombreConferencia)
        Me.GroupBox1.Controls.Add(Me.txtbxSiglas)
        Me.GroupBox1.Controls.Add(Me.txtbxIDConferencia)
        Me.GroupBox1.Controls.Add(Me.lblLugar)
        Me.GroupBox1.Controls.Add(Me.lblFecha_fin)
        Me.GroupBox1.Controls.Add(Me.lblFecha_inicio)
        Me.GroupBox1.Controls.Add(Me.lblNombreConferencia)
        Me.GroupBox1.Controls.Add(Me.lblSiglas)
        Me.GroupBox1.Controls.Add(Me.lblIDConferencia)
        Me.GroupBox1.Controls.Add(Me.lstbxConferencias)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(23, 35)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(776, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CONFERENCIAS"
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(421, 250)
        Me.btnModificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(110, 52)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAñadir.Location = New System.Drawing.Point(276, 250)
        Me.btnAñadir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(110, 52)
        Me.btnAñadir.TabIndex = 14
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(568, 250)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(110, 52)
        Me.btnEliminar.TabIndex = 13
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'txtbxFecha_fin
        '
        Me.txtbxFecha_fin.Location = New System.Drawing.Point(567, 198)
        Me.txtbxFecha_fin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxFecha_fin.Name = "txtbxFecha_fin"
        Me.txtbxFecha_fin.Size = New System.Drawing.Size(103, 19)
        Me.txtbxFecha_fin.TabIndex = 12
        '
        'txtbxFecha_inicio
        '
        Me.txtbxFecha_inicio.Location = New System.Drawing.Point(568, 142)
        Me.txtbxFecha_inicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxFecha_inicio.Name = "txtbxFecha_inicio"
        Me.txtbxFecha_inicio.Size = New System.Drawing.Size(102, 19)
        Me.txtbxFecha_inicio.TabIndex = 11
        '
        'txtbxLugar
        '
        Me.txtbxLugar.Location = New System.Drawing.Point(567, 84)
        Me.txtbxLugar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxLugar.Name = "txtbxLugar"
        Me.txtbxLugar.Size = New System.Drawing.Size(103, 19)
        Me.txtbxLugar.TabIndex = 10
        '
        'txtbxNombreConferencia
        '
        Me.txtbxNombreConferencia.Location = New System.Drawing.Point(331, 199)
        Me.txtbxNombreConferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxNombreConferencia.Name = "txtbxNombreConferencia"
        Me.txtbxNombreConferencia.Size = New System.Drawing.Size(100, 19)
        Me.txtbxNombreConferencia.TabIndex = 9
        '
        'txtbxSiglas
        '
        Me.txtbxSiglas.Location = New System.Drawing.Point(331, 142)
        Me.txtbxSiglas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxSiglas.Name = "txtbxSiglas"
        Me.txtbxSiglas.Size = New System.Drawing.Size(100, 19)
        Me.txtbxSiglas.TabIndex = 8
        '
        'txtbxIDConferencia
        '
        Me.txtbxIDConferencia.Location = New System.Drawing.Point(331, 84)
        Me.txtbxIDConferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtbxIDConferencia.Name = "txtbxIDConferencia"
        Me.txtbxIDConferencia.Size = New System.Drawing.Size(100, 19)
        Me.txtbxIDConferencia.TabIndex = 7
        '
        'lblLugar
        '
        Me.lblLugar.AutoSize = True
        Me.lblLugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLugar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLugar.Location = New System.Drawing.Point(482, 86)
        Me.lblLugar.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLugar.Name = "lblLugar"
        Me.lblLugar.Size = New System.Drawing.Size(49, 17)
        Me.lblLugar.TabIndex = 6
        Me.lblLugar.Text = "Lugar:"
        '
        'lblFecha_fin
        '
        Me.lblFecha_fin.AutoSize = True
        Me.lblFecha_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha_fin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFecha_fin.Location = New System.Drawing.Point(482, 201)
        Me.lblFecha_fin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha_fin.Name = "lblFecha_fin"
        Me.lblFecha_fin.Size = New System.Drawing.Size(70, 17)
        Me.lblFecha_fin.TabIndex = 5
        Me.lblFecha_fin.Text = "Fecha fin:"
        '
        'lblFecha_inicio
        '
        Me.lblFecha_inicio.AutoSize = True
        Me.lblFecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha_inicio.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblFecha_inicio.Location = New System.Drawing.Point(482, 144)
        Me.lblFecha_inicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha_inicio.Name = "lblFecha_inicio"
        Me.lblFecha_inicio.Size = New System.Drawing.Size(87, 17)
        Me.lblFecha_inicio.TabIndex = 4
        Me.lblFecha_inicio.Text = "Fecha inicio:"
        '
        'lblNombreConferencia
        '
        Me.lblNombreConferencia.AutoSize = True
        Me.lblNombreConferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreConferencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombreConferencia.Location = New System.Drawing.Point(273, 201)
        Me.lblNombreConferencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombreConferencia.Name = "lblNombreConferencia"
        Me.lblNombreConferencia.Size = New System.Drawing.Size(62, 17)
        Me.lblNombreConferencia.TabIndex = 3
        Me.lblNombreConferencia.Text = "Nombre:"
        '
        'lblSiglas
        '
        Me.lblSiglas.AutoSize = True
        Me.lblSiglas.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSiglas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSiglas.Location = New System.Drawing.Point(273, 144)
        Me.lblSiglas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSiglas.Name = "lblSiglas"
        Me.lblSiglas.Size = New System.Drawing.Size(50, 17)
        Me.lblSiglas.TabIndex = 2
        Me.lblSiglas.Text = "Siglas:"
        '
        'lblIDConferencia
        '
        Me.lblIDConferencia.AutoSize = True
        Me.lblIDConferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDConferencia.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblIDConferencia.Location = New System.Drawing.Point(273, 86)
        Me.lblIDConferencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblIDConferencia.Name = "lblIDConferencia"
        Me.lblIDConferencia.Size = New System.Drawing.Size(25, 17)
        Me.lblIDConferencia.TabIndex = 1
        Me.lblIDConferencia.Text = "ID:"
        '
        'lstbxConferencias
        '
        Me.lstbxConferencias.FormattingEnabled = True
        Me.lstbxConferencias.Location = New System.Drawing.Point(32, 32)
        Me.lstbxConferencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lstbxConferencias.Name = "lstbxConferencias"
        Me.lstbxConferencias.Size = New System.Drawing.Size(153, 342)
        Me.lstbxConferencias.TabIndex = 0
        '
        'btnArticulos
        '
        Me.btnArticulos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnArticulos.Location = New System.Drawing.Point(276, 322)
        Me.btnArticulos.Margin = New System.Windows.Forms.Padding(2)
        Me.btnArticulos.Name = "btnArticulos"
        Me.btnArticulos.Size = New System.Drawing.Size(187, 52)
        Me.btnArticulos.TabIndex = 16
        Me.btnArticulos.Text = "Artículos"
        Me.btnArticulos.UseVisualStyleBackColor = True
        '
        'btnInvestigadores
        '
        Me.btnInvestigadores.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInvestigadores.Location = New System.Drawing.Point(491, 322)
        Me.btnInvestigadores.Margin = New System.Windows.Forms.Padding(2)
        Me.btnInvestigadores.Name = "btnInvestigadores"
        Me.btnInvestigadores.Size = New System.Drawing.Size(187, 52)
        Me.btnInvestigadores.TabIndex = 17
        Me.btnInvestigadores.Text = "Investigadores"
        Me.btnInvestigadores.UseVisualStyleBackColor = True
        '
        'FrmConferencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 470)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmConferencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conferencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtbxLugar As TextBox
    Friend WithEvents txtbxNombreConferencia As TextBox
    Friend WithEvents txtbxSiglas As TextBox
    Friend WithEvents txtbxIDConferencia As TextBox
    Friend WithEvents lblLugar As Label
    Friend WithEvents lblFecha_fin As Label
    Friend WithEvents lblFecha_inicio As Label
    Friend WithEvents lblNombreConferencia As Label
    Friend WithEvents lblSiglas As Label
    Friend WithEvents lblIDConferencia As Label
    Friend WithEvents lstbxConferencias As ListBox
    Friend WithEvents txtbxFecha_fin As TextBox
    Friend WithEvents txtbxFecha_inicio As TextBox
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnInvestigadores As Button
    Friend WithEvents btnArticulos As Button
End Class

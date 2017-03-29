<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
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
        Me.grboxPersonas = New System.Windows.Forms.GroupBox()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.txtbxNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.listbxPersonas = New System.Windows.Forms.ListBox()
        Me.btnRutaBD = New System.Windows.Forms.Button()
        Me.btnconectarBD = New System.Windows.Forms.Button()
        Me.lblEstadoBD = New System.Windows.Forms.Label()
        Me.txtRuta = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.txtbxDNI = New System.Windows.Forms.MaskedTextBox()
        Me.grboxPersonas.SuspendLayout()
        Me.SuspendLayout()
        '
        'grboxPersonas
        '
        Me.grboxPersonas.Controls.Add(Me.txtbxDNI)
        Me.grboxPersonas.Controls.Add(Me.btnLimpiarCampos)
        Me.grboxPersonas.Controls.Add(Me.btnEliminar)
        Me.grboxPersonas.Controls.Add(Me.btnModificar)
        Me.grboxPersonas.Controls.Add(Me.btnAñadir)
        Me.grboxPersonas.Controls.Add(Me.txtbxNombre)
        Me.grboxPersonas.Controls.Add(Me.lblNombre)
        Me.grboxPersonas.Controls.Add(Me.lblDNI)
        Me.grboxPersonas.Controls.Add(Me.listbxPersonas)
        Me.grboxPersonas.ForeColor = System.Drawing.SystemColors.Highlight
        Me.grboxPersonas.Location = New System.Drawing.Point(43, 42)
        Me.grboxPersonas.Name = "grboxPersonas"
        Me.grboxPersonas.Size = New System.Drawing.Size(932, 368)
        Me.grboxPersonas.TabIndex = 0
        Me.grboxPersonas.TabStop = False
        Me.grboxPersonas.Text = "PERSONAS"
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.Enabled = False
        Me.btnLimpiarCampos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(304, 269)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(504, 57)
        Me.btnLimpiarCampos.TabIndex = 8
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEliminar.Location = New System.Drawing.Point(657, 174)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(151, 69)
        Me.btnEliminar.TabIndex = 7
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnModificar.Location = New System.Drawing.Point(477, 174)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(151, 69)
        Me.btnModificar.TabIndex = 6
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAñadir
        '
        Me.btnAñadir.Enabled = False
        Me.btnAñadir.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAñadir.Location = New System.Drawing.Point(304, 174)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(151, 69)
        Me.btnAñadir.TabIndex = 5
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'txtbxNombre
        '
        Me.txtbxNombre.Enabled = False
        Me.txtbxNombre.Location = New System.Drawing.Point(477, 110)
        Me.txtbxNombre.Name = "txtbxNombre"
        Me.txtbxNombre.Size = New System.Drawing.Size(144, 22)
        Me.txtbxNombre.TabIndex = 4
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblNombre.Location = New System.Drawing.Point(403, 112)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(68, 20)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        '
        'lblDNI
        '
        Me.lblDNI.AutoSize = True
        Me.lblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDNI.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDNI.Location = New System.Drawing.Point(403, 61)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(38, 20)
        Me.lblDNI.TabIndex = 1
        Me.lblDNI.Text = "DNI"
        '
        'listbxPersonas
        '
        Me.listbxPersonas.FormattingEnabled = True
        Me.listbxPersonas.ItemHeight = 16
        Me.listbxPersonas.Location = New System.Drawing.Point(18, 30)
        Me.listbxPersonas.Name = "listbxPersonas"
        Me.listbxPersonas.Size = New System.Drawing.Size(226, 308)
        Me.listbxPersonas.TabIndex = 0
        '
        'btnRutaBD
        '
        Me.btnRutaBD.Location = New System.Drawing.Point(61, 443)
        Me.btnRutaBD.Name = "btnRutaBD"
        Me.btnRutaBD.Size = New System.Drawing.Size(142, 33)
        Me.btnRutaBD.TabIndex = 1
        Me.btnRutaBD.Text = "Ruta BD"
        Me.btnRutaBD.UseVisualStyleBackColor = True
        '
        'btnconectarBD
        '
        Me.btnconectarBD.Enabled = False
        Me.btnconectarBD.Location = New System.Drawing.Point(61, 559)
        Me.btnconectarBD.Name = "btnconectarBD"
        Me.btnconectarBD.Size = New System.Drawing.Size(142, 33)
        Me.btnconectarBD.TabIndex = 2
        Me.btnconectarBD.Text = "Conectar BD"
        Me.btnconectarBD.UseVisualStyleBackColor = True
        '
        'lblEstadoBD
        '
        Me.lblEstadoBD.AutoSize = True
        Me.lblEstadoBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoBD.Location = New System.Drawing.Point(233, 567)
        Me.lblEstadoBD.Name = "lblEstadoBD"
        Me.lblEstadoBD.Size = New System.Drawing.Size(132, 25)
        Me.lblEstadoBD.TabIndex = 3
        Me.lblEstadoBD.Text = "Estado BBDD"
        Me.lblEstadoBD.Visible = False
        '
        'txtRuta
        '
        Me.txtRuta.Location = New System.Drawing.Point(238, 443)
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.ReadOnly = True
        Me.txtRuta.Size = New System.Drawing.Size(564, 93)
        Me.txtRuta.TabIndex = 4
        Me.txtRuta.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Microsoft Access Base de datos(*.accdb)|*.accdb"
        '
        'txtbxDNI
        '
        Me.txtbxDNI.Enabled = False
        Me.txtbxDNI.Location = New System.Drawing.Point(477, 61)
        Me.txtbxDNI.Mask = "00000000>L"
        Me.txtbxDNI.Name = "txtbxDNI"
        Me.txtbxDNI.PromptChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtbxDNI.Size = New System.Drawing.Size(144, 22)
        Me.txtbxDNI.TabIndex = 10
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 636)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.lblEstadoBD)
        Me.Controls.Add(Me.btnconectarBD)
        Me.Controls.Add(Me.btnRutaBD)
        Me.Controls.Add(Me.grboxPersonas)
        Me.Name = "FrmPrincipal"
        Me.Text = "Acceso a BBDD"
        Me.grboxPersonas.ResumeLayout(False)
        Me.grboxPersonas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grboxPersonas As GroupBox
    Friend WithEvents listbxPersonas As ListBox
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnAñadir As Button
    Friend WithEvents txtbxNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblDNI As Label
    Friend WithEvents btnRutaBD As Button
    Friend WithEvents btnconectarBD As Button
    Friend WithEvents lblEstadoBD As Label
    Friend WithEvents txtRuta As RichTextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtbxDNI As MaskedTextBox
End Class

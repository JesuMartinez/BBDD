<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAsistencias
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
        Me.ListbxConferenciasAsiste = New System.Windows.Forms.ListBox()
        Me.ListbxConferencias = New System.Windows.Forms.ListBox()
        Me.Añadir = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.btnAplicarGuardar = New System.Windows.Forms.Button()
        Me.lstbxInvestigadores = New System.Windows.Forms.ListBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListbxConferenciasAsiste
        '
        Me.ListbxConferenciasAsiste.FormattingEnabled = True
        Me.ListbxConferenciasAsiste.ItemHeight = 16
        Me.ListbxConferenciasAsiste.Location = New System.Drawing.Point(17, 28)
        Me.ListbxConferenciasAsiste.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListbxConferenciasAsiste.Name = "ListbxConferenciasAsiste"
        Me.ListbxConferenciasAsiste.Size = New System.Drawing.Size(212, 404)
        Me.ListbxConferenciasAsiste.TabIndex = 0
        '
        'ListbxConferencias
        '
        Me.ListbxConferencias.FormattingEnabled = True
        Me.ListbxConferencias.ItemHeight = 16
        Me.ListbxConferencias.Location = New System.Drawing.Point(15, 28)
        Me.ListbxConferencias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListbxConferencias.Name = "ListbxConferencias"
        Me.ListbxConferencias.Size = New System.Drawing.Size(212, 404)
        Me.ListbxConferencias.TabIndex = 1
        '
        'Añadir
        '
        Me.Añadir.Enabled = False
        Me.Añadir.Location = New System.Drawing.Point(692, 83)
        Me.Añadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(131, 55)
        Me.Añadir.TabIndex = 2
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Enabled = False
        Me.Eliminar.Location = New System.Drawing.Point(692, 159)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(131, 49)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'btnAplicarGuardar
        '
        Me.btnAplicarGuardar.Enabled = False
        Me.btnAplicarGuardar.Location = New System.Drawing.Point(692, 236)
        Me.btnAplicarGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAplicarGuardar.Name = "btnAplicarGuardar"
        Me.btnAplicarGuardar.Size = New System.Drawing.Size(131, 117)
        Me.btnAplicarGuardar.TabIndex = 4
        Me.btnAplicarGuardar.Text = "Aplicar y guardar"
        Me.btnAplicarGuardar.UseVisualStyleBackColor = True
        '
        'lstbxInvestigadores
        '
        Me.lstbxInvestigadores.FormattingEnabled = True
        Me.lstbxInvestigadores.ItemHeight = 16
        Me.lstbxInvestigadores.Location = New System.Drawing.Point(20, 32)
        Me.lstbxInvestigadores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstbxInvestigadores.Name = "lstbxInvestigadores"
        Me.lstbxInvestigadores.Size = New System.Drawing.Size(212, 404)
        Me.lstbxInvestigadores.TabIndex = 5
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(692, 390)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(131, 54)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ListbxConferencias)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox1.Location = New System.Drawing.Point(388, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(243, 450)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Lista de conferencias totales"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lstbxInvestigadores)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(41, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 449)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Lista de investigadores"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ListbxConferenciasAsiste)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox3.Location = New System.Drawing.Point(867, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(244, 448)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conferencias a las que asiste"
        '
        'FrmAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 539)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAplicarGuardar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencias"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListbxConferenciasAsiste As ListBox
    Friend WithEvents ListbxConferencias As ListBox
    Friend WithEvents Añadir As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents btnAplicarGuardar As Button
    Friend WithEvents lstbxInvestigadores As ListBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class

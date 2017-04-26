<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAsistencias
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
        Me.lstConferenciasAsiste = New System.Windows.Forms.ListBox()
        Me.lstConferencias = New System.Windows.Forms.ListBox()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnAplicarGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lstConferenciasAsiste
        '
        Me.lstConferenciasAsiste.FormattingEnabled = True
        Me.lstConferenciasAsiste.ItemHeight = 16
        Me.lstConferenciasAsiste.Location = New System.Drawing.Point(511, 39)
        Me.lstConferenciasAsiste.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstConferenciasAsiste.Name = "lstConferenciasAsiste"
        Me.lstConferenciasAsiste.Size = New System.Drawing.Size(212, 404)
        Me.lstConferenciasAsiste.TabIndex = 0
        '
        'lstConferencias
        '
        Me.lstConferencias.FormattingEnabled = True
        Me.lstConferencias.ItemHeight = 16
        Me.lstConferencias.Location = New System.Drawing.Point(63, 39)
        Me.lstConferencias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstConferencias.Name = "lstConferencias"
        Me.lstConferencias.Size = New System.Drawing.Size(212, 404)
        Me.lstConferencias.TabIndex = 1
        '
        'btnAñadir
        '
        Me.btnAñadir.Enabled = False
        Me.btnAñadir.Location = New System.Drawing.Point(317, 82)
        Me.btnAñadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(131, 55)
        Me.btnAñadir.TabIndex = 2
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Enabled = False
        Me.btnEliminar.Location = New System.Drawing.Point(317, 158)
        Me.btnEliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(131, 49)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnAplicarGuardar
        '
        Me.btnAplicarGuardar.Location = New System.Drawing.Point(317, 327)
        Me.btnAplicarGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAplicarGuardar.Name = "btnAplicarGuardar"
        Me.btnAplicarGuardar.Size = New System.Drawing.Size(131, 117)
        Me.btnAplicarGuardar.TabIndex = 4
        Me.btnAplicarGuardar.Text = "Aplicar y guardar"
        Me.btnAplicarGuardar.UseVisualStyleBackColor = True
        '
        'FrmAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 501)
        Me.Controls.Add(Me.btnAplicarGuardar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lstConferencias)
        Me.Controls.Add(Me.lstConferenciasAsiste)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstConferenciasAsiste As ListBox
    Friend WithEvents lstConferencias As ListBox
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnAplicarGuardar As Button
End Class

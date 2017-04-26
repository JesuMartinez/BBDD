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
        Me.SuspendLayout()
        '
        'ListbxConferenciasAsiste
        '
        Me.ListbxConferenciasAsiste.FormattingEnabled = True
        Me.ListbxConferenciasAsiste.ItemHeight = 16
        Me.ListbxConferenciasAsiste.Location = New System.Drawing.Point(511, 39)
        Me.ListbxConferenciasAsiste.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListbxConferenciasAsiste.Name = "ListbxConferenciasAsiste"
        Me.ListbxConferenciasAsiste.Size = New System.Drawing.Size(212, 404)
        Me.ListbxConferenciasAsiste.TabIndex = 0
        '
        'ListbxConferencias
        '
        Me.ListbxConferencias.FormattingEnabled = True
        Me.ListbxConferencias.ItemHeight = 16
        Me.ListbxConferencias.Location = New System.Drawing.Point(63, 39)
        Me.ListbxConferencias.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListbxConferencias.Name = "ListbxConferencias"
        Me.ListbxConferencias.Size = New System.Drawing.Size(212, 404)
        Me.ListbxConferencias.TabIndex = 1
        '
        'btnAñadir
        '
        Me.Añadir.Enabled = False
        Me.Añadir.Location = New System.Drawing.Point(317, 82)
        Me.Añadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(131, 55)
        Me.Añadir.TabIndex = 2
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.Eliminar.Enabled = False
        Me.Eliminar.Location = New System.Drawing.Point(317, 158)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(131, 49)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'btnAplicarGuardar
        '
        Me.btnAplicarGuardar.Location = New System.Drawing.Point(317, 327)
        Me.btnAplicarGuardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.ListbxConferencias)
        Me.Controls.Add(Me.ListbxConferenciasAsiste)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FrmAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asistencias"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListbxConferenciasAsiste As ListBox
    Friend WithEvents ListbxConferencias As ListBox
    Friend WithEvents Añadir As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents btnAplicarGuardar As Button
End Class

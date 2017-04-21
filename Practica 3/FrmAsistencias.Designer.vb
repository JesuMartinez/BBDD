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
        Me.ListConferenciasAsiste = New System.Windows.Forms.ListBox()
        Me.ListConferencias = New System.Windows.Forms.ListBox()
        Me.Añadir = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.btnAplicarGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListConferenciasAsiste
        '
        Me.ListConferenciasAsiste.FormattingEnabled = True
        Me.ListConferenciasAsiste.Location = New System.Drawing.Point(383, 32)
        Me.ListConferenciasAsiste.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListConferenciasAsiste.Name = "ListConferenciasAsiste"
        Me.ListConferenciasAsiste.Size = New System.Drawing.Size(160, 329)
        Me.ListConferenciasAsiste.TabIndex = 0
        '
        'ListConferencias
        '
        Me.ListConferencias.FormattingEnabled = True
        Me.ListConferencias.Location = New System.Drawing.Point(47, 32)
        Me.ListConferencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ListConferencias.Name = "ListConferencias"
        Me.ListConferencias.Size = New System.Drawing.Size(160, 329)
        Me.ListConferencias.TabIndex = 1
        '
        'Añadir
        '
        Me.Añadir.Enabled = False
        Me.Añadir.Location = New System.Drawing.Point(238, 67)
        Me.Añadir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(98, 45)
        Me.Añadir.TabIndex = 2
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Enabled = False
        Me.Eliminar.Location = New System.Drawing.Point(238, 128)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(98, 40)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'btnAplicarGuardar
        '
        Me.btnAplicarGuardar.Location = New System.Drawing.Point(238, 266)
        Me.btnAplicarGuardar.Name = "btnAplicarGuardar"
        Me.btnAplicarGuardar.Size = New System.Drawing.Size(98, 95)
        Me.btnAplicarGuardar.TabIndex = 4
        Me.btnAplicarGuardar.Text = "Aplicar y guardar"
        Me.btnAplicarGuardar.UseVisualStyleBackColor = True
        '
        'FrmAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 407)
        Me.Controls.Add(Me.btnAplicarGuardar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.ListConferencias)
        Me.Controls.Add(Me.ListConferenciasAsiste)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "FrmAsistencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListConferenciasAsiste As ListBox
    Friend WithEvents ListConferencias As ListBox
    Friend WithEvents Añadir As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents btnAplicarGuardar As Button
End Class

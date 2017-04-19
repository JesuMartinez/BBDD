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
        Me.SuspendLayout()
        '
        'ListConferenciasAsiste
        '
        Me.ListConferenciasAsiste.FormattingEnabled = True
        Me.ListConferenciasAsiste.ItemHeight = 16
        Me.ListConferenciasAsiste.Location = New System.Drawing.Point(511, 39)
        Me.ListConferenciasAsiste.Name = "ListConferenciasAsiste"
        Me.ListConferenciasAsiste.Size = New System.Drawing.Size(212, 404)
        Me.ListConferenciasAsiste.TabIndex = 0
        '
        'ListConferencias
        '
        Me.ListConferencias.FormattingEnabled = True
        Me.ListConferencias.ItemHeight = 16
        Me.ListConferencias.Location = New System.Drawing.Point(63, 39)
        Me.ListConferencias.Name = "ListConferencias"
        Me.ListConferencias.Size = New System.Drawing.Size(212, 404)
        Me.ListConferencias.TabIndex = 1
        '
        'Añadir
        '
        Me.Añadir.Location = New System.Drawing.Point(318, 82)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(131, 85)
        Me.Añadir.TabIndex = 2
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Location = New System.Drawing.Point(318, 275)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(131, 85)
        Me.Eliminar.TabIndex = 3
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'FrmAsistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 501)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.ListConferencias)
        Me.Controls.Add(Me.ListConferenciasAsiste)
        Me.Name = "FrmAsistencias"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListConferenciasAsiste As ListBox
    Friend WithEvents ListConferencias As ListBox
    Friend WithEvents Añadir As Button
    Friend WithEvents Eliminar As Button
End Class

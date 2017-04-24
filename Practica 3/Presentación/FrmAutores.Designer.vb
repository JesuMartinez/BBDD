<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAutores
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
        Me.btnAplicarGuardar = New System.Windows.Forms.Button()
        Me.Eliminar = New System.Windows.Forms.Button()
        Me.Añadir = New System.Windows.Forms.Button()
        Me.ListAutores = New System.Windows.Forms.ListBox()
        Me.ListAutoresArticulo = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnAplicarGuardar
        '
        Me.btnAplicarGuardar.Location = New System.Drawing.Point(296, 340)
        Me.btnAplicarGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAplicarGuardar.Name = "btnAplicarGuardar"
        Me.btnAplicarGuardar.Size = New System.Drawing.Size(131, 117)
        Me.btnAplicarGuardar.TabIndex = 9
        Me.btnAplicarGuardar.Text = "Aplicar y guardar"
        Me.btnAplicarGuardar.UseVisualStyleBackColor = True
        '
        'Eliminar
        '
        Me.Eliminar.Enabled = False
        Me.Eliminar.Location = New System.Drawing.Point(296, 171)
        Me.Eliminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.Size = New System.Drawing.Size(131, 49)
        Me.Eliminar.TabIndex = 8
        Me.Eliminar.Text = "Eliminar"
        Me.Eliminar.UseVisualStyleBackColor = True
        '
        'Añadir
        '
        Me.Añadir.Enabled = False
        Me.Añadir.Location = New System.Drawing.Point(296, 95)
        Me.Añadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(131, 55)
        Me.Añadir.TabIndex = 7
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'ListAutores
        '
        Me.ListAutores.FormattingEnabled = True
        Me.ListAutores.ItemHeight = 16
        Me.ListAutores.Location = New System.Drawing.Point(42, 52)
        Me.ListAutores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListAutores.Name = "ListAutores"
        Me.ListAutores.Size = New System.Drawing.Size(212, 404)
        Me.ListAutores.TabIndex = 6
        '
        'ListAutoresArticulo
        '
        Me.ListAutoresArticulo.FormattingEnabled = True
        Me.ListAutoresArticulo.ItemHeight = 16
        Me.ListAutoresArticulo.Location = New System.Drawing.Point(490, 52)
        Me.ListAutoresArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListAutoresArticulo.Name = "ListAutoresArticulo"
        Me.ListAutoresArticulo.Size = New System.Drawing.Size(212, 404)
        Me.ListAutoresArticulo.TabIndex = 5
        '
        'FrmAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 508)
        Me.Controls.Add(Me.btnAplicarGuardar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.ListAutores)
        Me.Controls.Add(Me.ListAutoresArticulo)
        Me.Name = "FrmAutores"
        Me.Text = "FrmAutores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAplicarGuardar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Añadir As Button
    Friend WithEvents ListAutores As ListBox
    Friend WithEvents ListAutoresArticulo As ListBox
End Class

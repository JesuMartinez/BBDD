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
        Me.ListbxAutores = New System.Windows.Forms.ListBox()
        Me.ListbxAutoresArticulos = New System.Windows.Forms.ListBox()
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
        Me.Añadir.Location = New System.Drawing.Point(296, 95)
        Me.Añadir.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Añadir.Name = "Añadir"
        Me.Añadir.Size = New System.Drawing.Size(131, 55)
        Me.Añadir.TabIndex = 7
        Me.Añadir.Text = "Añadir"
        Me.Añadir.UseVisualStyleBackColor = True
        '
        'ListbxAutores
        '
        Me.ListbxAutores.FormattingEnabled = True
        Me.ListbxAutores.ItemHeight = 16
        Me.ListbxAutores.Location = New System.Drawing.Point(42, 52)
        Me.ListbxAutores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListbxAutores.Name = "ListbxAutores"
        Me.ListbxAutores.Size = New System.Drawing.Size(212, 404)
        Me.ListbxAutores.TabIndex = 6
        '
        'ListbxAutoresArticulos
        '
        Me.ListbxAutoresArticulos.FormattingEnabled = True
        Me.ListbxAutoresArticulos.ItemHeight = 16
        Me.ListbxAutoresArticulos.Location = New System.Drawing.Point(490, 52)
        Me.ListbxAutoresArticulos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ListbxAutoresArticulos.Name = "ListbxAutoresArticulos"
        Me.ListbxAutoresArticulos.Size = New System.Drawing.Size(212, 404)
        Me.ListbxAutoresArticulos.TabIndex = 5
        '
        'FrmAutores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(745, 508)
        Me.Controls.Add(Me.btnAplicarGuardar)
        Me.Controls.Add(Me.Eliminar)
        Me.Controls.Add(Me.Añadir)
        Me.Controls.Add(Me.ListbxAutores)
        Me.Controls.Add(Me.ListbxAutoresArticulos)
        Me.Name = "FrmAutores"
        Me.Text = "FrmAutores"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAplicarGuardar As Button
    Friend WithEvents Eliminar As Button
    Friend WithEvents Añadir As Button
    Friend WithEvents ListbxAutores As ListBox
    Friend WithEvents ListbxAutoresArticulos As ListBox
End Class

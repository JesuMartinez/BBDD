<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Curriculum_Vitae
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtbxCV = New System.Windows.Forms.TextBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(44, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 55)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CURRICULUM VITAE"
        '
        'txtbxCV
        '
        Me.txtbxCV.Enabled = False
        Me.txtbxCV.Location = New System.Drawing.Point(54, 173)
        Me.txtbxCV.Multiline = True
        Me.txtbxCV.Name = "txtbxCV"
        Me.txtbxCV.Size = New System.Drawing.Size(775, 402)
        Me.txtbxCV.TabIndex = 1
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Font = New System.Drawing.Font("Verdana", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAutor.Location = New System.Drawing.Point(50, 125)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(60, 20)
        Me.lblAutor.TabIndex = 2
        Me.lblAutor.Text = "autor"
        Me.lblAutor.Visible = False
        '
        'Curriculum_Vitae
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 606)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.txtbxCV)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Curriculum_Vitae"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Curriculum_Vitae"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtbxCV As TextBox
    Friend WithEvents lblAutor As Label
End Class

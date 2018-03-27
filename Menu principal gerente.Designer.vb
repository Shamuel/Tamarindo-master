<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_principal_gerente
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
        Me.ButtonReportes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonReportes
        '
        Me.ButtonReportes.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonReportes.Location = New System.Drawing.Point(155, 108)
        Me.ButtonReportes.Name = "ButtonReportes"
        Me.ButtonReportes.Size = New System.Drawing.Size(210, 93)
        Me.ButtonReportes.TabIndex = 0
        Me.ButtonReportes.Text = "Reportes"
        Me.ButtonReportes.UseVisualStyleBackColor = True
        '
        'Menu_principal_gerente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 321)
        Me.Controls.Add(Me.ButtonReportes)
        Me.Name = "Menu_principal_gerente"
        Me.Text = "Menu_principal_gerente"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonReportes As Button
End Class

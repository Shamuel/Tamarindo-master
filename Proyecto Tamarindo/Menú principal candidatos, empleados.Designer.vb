<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú_principal_candidatos__empleados
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
        Me.ButtonPruebas = New System.Windows.Forms.Button()
        Me.ButtonExpediente = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonPruebas
        '
        Me.ButtonPruebas.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPruebas.Location = New System.Drawing.Point(133, 87)
        Me.ButtonPruebas.Name = "ButtonPruebas"
        Me.ButtonPruebas.Size = New System.Drawing.Size(194, 95)
        Me.ButtonPruebas.TabIndex = 0
        Me.ButtonPruebas.Text = "Pruebas"
        Me.ButtonPruebas.UseVisualStyleBackColor = True
        '
        'ButtonExpediente
        '
        Me.ButtonExpediente.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExpediente.Location = New System.Drawing.Point(391, 87)
        Me.ButtonExpediente.Name = "ButtonExpediente"
        Me.ButtonExpediente.Size = New System.Drawing.Size(194, 95)
        Me.ButtonExpediente.TabIndex = 1
        Me.ButtonExpediente.Text = "Expediente"
        Me.ButtonExpediente.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(483, 300)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(90, 60)
        Me.ButtonSalir.TabIndex = 2
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menú_principal_candidatos__empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 422)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonExpediente)
        Me.Controls.Add(Me.ButtonPruebas)
        Me.Name = "Menú_principal_candidatos__empleados"
        Me.Text = "Menú principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonPruebas As Button
    Friend WithEvents ButtonExpediente As Button
    Friend WithEvents ButtonSalir As Button
End Class

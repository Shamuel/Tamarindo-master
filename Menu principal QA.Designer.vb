<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu_principal_QA
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
        Me.ButtonExpedientes = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonPruebas
        '
        Me.ButtonPruebas.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPruebas.Location = New System.Drawing.Point(47, 99)
        Me.ButtonPruebas.Name = "ButtonPruebas"
        Me.ButtonPruebas.Size = New System.Drawing.Size(167, 89)
        Me.ButtonPruebas.TabIndex = 2
        Me.ButtonPruebas.Text = "Pruebas"
        Me.ButtonPruebas.UseVisualStyleBackColor = True
        '
        'ButtonExpedientes
        '
        Me.ButtonExpedientes.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExpedientes.Location = New System.Drawing.Point(254, 101)
        Me.ButtonExpedientes.Name = "ButtonExpedientes"
        Me.ButtonExpedientes.Size = New System.Drawing.Size(167, 89)
        Me.ButtonExpedientes.TabIndex = 3
        Me.ButtonExpedientes.Text = "Registro de empleados"
        Me.ButtonExpedientes.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(402, 225)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(90, 48)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menu_principal_QA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 313)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonExpedientes)
        Me.Controls.Add(Me.ButtonPruebas)
        Me.Name = "Menu_principal_QA"
        Me.Text = "Menu principal QA"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonPruebas As Button
    Friend WithEvents ButtonExpedientes As Button
    Friend WithEvents ButtonSalir As Button
End Class

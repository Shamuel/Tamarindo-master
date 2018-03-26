<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menú_principal_admi
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
        Me.ButtonAnalitycs = New System.Windows.Forms.Button()
        Me.ButtonPruebas = New System.Windows.Forms.Button()
        Me.ButtonExpedientes = New System.Windows.Forms.Button()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ButtonAnalitycs
        '
        Me.ButtonAnalitycs.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnalitycs.Location = New System.Drawing.Point(12, 166)
        Me.ButtonAnalitycs.Name = "ButtonAnalitycs"
        Me.ButtonAnalitycs.Size = New System.Drawing.Size(167, 89)
        Me.ButtonAnalitycs.TabIndex = 0
        Me.ButtonAnalitycs.Text = "Analitycs"
        Me.ButtonAnalitycs.UseVisualStyleBackColor = True
        '
        'ButtonPruebas
        '
        Me.ButtonPruebas.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPruebas.Location = New System.Drawing.Point(280, 166)
        Me.ButtonPruebas.Name = "ButtonPruebas"
        Me.ButtonPruebas.Size = New System.Drawing.Size(167, 89)
        Me.ButtonPruebas.TabIndex = 1
        Me.ButtonPruebas.Text = "Pruebas"
        Me.ButtonPruebas.UseVisualStyleBackColor = True
        '
        'ButtonExpedientes
        '
        Me.ButtonExpedientes.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExpedientes.Location = New System.Drawing.Point(538, 166)
        Me.ButtonExpedientes.Name = "ButtonExpedientes"
        Me.ButtonExpedientes.Size = New System.Drawing.Size(167, 89)
        Me.ButtonExpedientes.TabIndex = 2
        Me.ButtonExpedientes.Text = "Expedientes"
        Me.ButtonExpedientes.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSalir.Location = New System.Drawing.Point(581, 346)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(121, 64)
        Me.ButtonSalir.TabIndex = 3
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Menú_principal_admi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 422)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.ButtonExpedientes)
        Me.Controls.Add(Me.ButtonPruebas)
        Me.Controls.Add(Me.ButtonAnalitycs)
        Me.Name = "Menú_principal_admi"
        Me.Text = "Menú principal"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ButtonAnalitycs As Button
    Friend WithEvents ButtonPruebas As Button
    Friend WithEvents ButtonExpedientes As Button
    Friend WithEvents ButtonSalir As Button
End Class

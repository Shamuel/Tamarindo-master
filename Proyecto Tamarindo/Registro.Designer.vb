<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NombreDePersona = New System.Windows.Forms.TextBox()
        Me.Apellido1 = New System.Windows.Forms.TextBox()
        Me.Apellido2 = New System.Windows.Forms.TextBox()
        Me.Telefono = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.Correo = New System.Windows.Forms.TextBox()
        Me.FechaInclusion = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 366)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Correo Electronico:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(120, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(230, 36)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha de Inclusión"
        '
        'NombreDePersona
        '
        Me.NombreDePersona.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.NombreDePersona.Location = New System.Drawing.Point(415, 56)
        Me.NombreDePersona.Name = "NombreDePersona"
        Me.NombreDePersona.Size = New System.Drawing.Size(257, 43)
        Me.NombreDePersona.TabIndex = 7
        '
        'Apellido1
        '
        Me.Apellido1.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Apellido1.Location = New System.Drawing.Point(415, 120)
        Me.Apellido1.Name = "Apellido1"
        Me.Apellido1.Size = New System.Drawing.Size(257, 43)
        Me.Apellido1.TabIndex = 8
        '
        'Apellido2
        '
        Me.Apellido2.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Apellido2.Location = New System.Drawing.Point(415, 182)
        Me.Apellido2.Name = "Apellido2"
        Me.Apellido2.Size = New System.Drawing.Size(257, 43)
        Me.Apellido2.TabIndex = 9
        '
        'Telefono
        '
        Me.Telefono.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Telefono.Location = New System.Drawing.Point(415, 297)
        Me.Telefono.Name = "Telefono"
        Me.Telefono.Size = New System.Drawing.Size(257, 43)
        Me.Telefono.TabIndex = 14
        '
        'Guardar
        '
        Me.Guardar.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guardar.Location = New System.Drawing.Point(668, 501)
        Me.Guardar.Name = "Guardar"
        Me.Guardar.Size = New System.Drawing.Size(141, 49)
        Me.Guardar.TabIndex = 15
        Me.Guardar.Text = "Guardar"
        Me.Guardar.UseVisualStyleBackColor = True
        '
        'Correo
        '
        Me.Correo.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Correo.Location = New System.Drawing.Point(415, 359)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(257, 43)
        Me.Correo.TabIndex = 17
        '
        'FechaInclusion
        '
        Me.FechaInclusion.Location = New System.Drawing.Point(415, 251)
        Me.FechaInclusion.Name = "FechaInclusion"
        Me.FechaInclusion.Size = New System.Drawing.Size(257, 20)
        Me.FechaInclusion.TabIndex = 23
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 467)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(650, 219)
        Me.DataGridView1.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(124, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 36)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Primer Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(220, 36)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Segundo Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(124, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 36)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Telefono:"
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(874, 698)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FechaInclusion)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Telefono)
        Me.Controls.Add(Me.Apellido2)
        Me.Controls.Add(Me.Apellido1)
        Me.Controls.Add(Me.NombreDePersona)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents NombreDePersona As TextBox
    Friend WithEvents Apellido1 As TextBox
    Friend WithEvents Apellido2 As TextBox
    Friend WithEvents Telefono As TextBox
    Friend WithEvents Guardar As Button
    Friend WithEvents Correo As TextBox
    Friend WithEvents FechaInclusion As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
End Class

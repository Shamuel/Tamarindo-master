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
        Me.Cedula = New System.Windows.Forms.TextBox()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.Guardar = New System.Windows.Forms.Button()
        Me.RepetirContraseña = New System.Windows.Forms.TextBox()
        Me.FechaInclusion = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(123, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 36)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(123, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 36)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Contraseña:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(124, 320)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(238, 36)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Fecha de Inclusión:"
        '
        'NombreDePersona
        '
        Me.NombreDePersona.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.NombreDePersona.Location = New System.Drawing.Point(415, 56)
        Me.NombreDePersona.Name = "NombreDePersona"
        Me.NombreDePersona.Size = New System.Drawing.Size(257, 43)
        Me.NombreDePersona.TabIndex = 7
        '
        'Cedula
        '
        Me.Cedula.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Cedula.Location = New System.Drawing.Point(415, 120)
        Me.Cedula.Name = "Cedula"
        Me.Cedula.Size = New System.Drawing.Size(257, 43)
        Me.Cedula.TabIndex = 8
        '
        'Contraseña
        '
        Me.Contraseña.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Contraseña.Location = New System.Drawing.Point(415, 182)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(257, 43)
        Me.Contraseña.TabIndex = 9
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
        'RepetirContraseña
        '
        Me.RepetirContraseña.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.RepetirContraseña.Location = New System.Drawing.Point(415, 240)
        Me.RepetirContraseña.Name = "RepetirContraseña"
        Me.RepetirContraseña.Size = New System.Drawing.Size(257, 43)
        Me.RepetirContraseña.TabIndex = 17
        '
        'FechaInclusion
        '
        Me.FechaInclusion.Location = New System.Drawing.Point(415, 331)
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
        Me.Label4.Size = New System.Drawing.Size(103, 36)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Cedula:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(124, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(246, 36)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Repetir Contraseña:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.TextBox1.Location = New System.Drawing.Point(415, 369)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 43)
        Me.TextBox1.TabIndex = 27
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 698)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FechaInclusion)
        Me.Controls.Add(Me.RepetirContraseña)
        Me.Controls.Add(Me.Guardar)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Cedula)
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
    Friend WithEvents Cedula As TextBox
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents Guardar As Button
    Friend WithEvents RepetirContraseña As TextBox
    Friend WithEvents FechaInclusion As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
End Class

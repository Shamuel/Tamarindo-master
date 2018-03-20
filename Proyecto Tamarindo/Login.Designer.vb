<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ingresar = New System.Windows.Forms.Button()
        Me.Usuario = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Contraseña = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GenerarCodigo = New System.Windows.Forms.Button()
        Me.Registrarse = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(696, 289)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Transparent
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Ingresar)
        Me.TabPage1.Controls.Add(Me.Usuario)
        Me.TabPage1.Controls.Add(Me.LinkLabel1)
        Me.TabPage1.Controls.Add(Me.Contraseña)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(688, 258)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(138, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 36)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(138, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 36)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Contraseña:"
        '
        'Ingresar
        '
        Me.Ingresar.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ingresar.Location = New System.Drawing.Point(415, 171)
        Me.Ingresar.Name = "Ingresar"
        Me.Ingresar.Size = New System.Drawing.Size(141, 49)
        Me.Ingresar.TabIndex = 24
        Me.Ingresar.Text = "Ingresar"
        Me.Ingresar.UseVisualStyleBackColor = True
        '
        'Usuario
        '
        Me.Usuario.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Usuario.Location = New System.Drawing.Point(299, 29)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(257, 43)
        Me.Usuario.TabIndex = 21
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(140, 189)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(221, 19)
        Me.LinkLabel1.TabIndex = 23
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Olvido su Usuario o Contraseña?"
        '
        'Contraseña
        '
        Me.Contraseña.Font = New System.Drawing.Font("Calibri", 21.75!)
        Me.Contraseña.Location = New System.Drawing.Point(299, 106)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(257, 43)
        Me.Contraseña.TabIndex = 22
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TabPage2.Controls.Add(Me.GenerarCodigo)
        Me.TabPage2.Controls.Add(Me.Registrarse)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(688, 258)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Registro"
        '
        'GenerarCodigo
        '
        Me.GenerarCodigo.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.GenerarCodigo.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerarCodigo.Location = New System.Drawing.Point(181, 18)
        Me.GenerarCodigo.Name = "GenerarCodigo"
        Me.GenerarCodigo.Size = New System.Drawing.Size(343, 88)
        Me.GenerarCodigo.TabIndex = 24
        Me.GenerarCodigo.Text = "Generar Codigo"
        Me.GenerarCodigo.UseVisualStyleBackColor = False
        '
        'Registrarse
        '
        Me.Registrarse.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Registrarse.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Registrarse.Location = New System.Drawing.Point(181, 146)
        Me.Registrarse.Name = "Registrarse"
        Me.Registrarse.Size = New System.Drawing.Size(343, 88)
        Me.Registrarse.TabIndex = 23
        Me.Registrarse.Text = "Registrarse "
        Me.Registrarse.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(717, 422)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Ingresar As Button
    Friend WithEvents Usuario As TextBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Contraseña As TextBox
    Friend WithEvents GenerarCodigo As Button
    Friend WithEvents Registrarse As Button
End Class

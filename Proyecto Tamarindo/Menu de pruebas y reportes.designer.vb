<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsginarPruebasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CrearReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PruebasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(668, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PruebasToolStripMenuItem
        '
        Me.PruebasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPruebasToolStripMenuItem, Me.AsginarPruebasToolStripMenuItem})
        Me.PruebasToolStripMenuItem.Name = "PruebasToolStripMenuItem"
        Me.PruebasToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.PruebasToolStripMenuItem.Text = "Pruebas"
        '
        'VerPruebasToolStripMenuItem
        '
        Me.VerPruebasToolStripMenuItem.Name = "VerPruebasToolStripMenuItem"
        Me.VerPruebasToolStripMenuItem.Size = New System.Drawing.Size(183, 22)
        Me.VerPruebasToolStripMenuItem.Text = "Ver fecha de pruebas"
        '
        'AsginarPruebasToolStripMenuItem
        '
        Me.AsginarPruebasToolStripMenuItem.Name = "AsginarPruebasToolStripMenuItem"
        Me.AsginarPruebasToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AsginarPruebasToolStripMenuItem.Text = "Asginar fecha de pruebas"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CrearReporteToolStripMenuItem, Me.VerReporteToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'CrearReporteToolStripMenuItem
        '
        Me.CrearReporteToolStripMenuItem.Name = "CrearReporteToolStripMenuItem"
        Me.CrearReporteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CrearReporteToolStripMenuItem.Text = "Crear reporte"
        '
        'VerReporteToolStripMenuItem
        '
        Me.VerReporteToolStripMenuItem.Name = "VerReporteToolStripMenuItem"
        Me.VerReporteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.VerReporteToolStripMenuItem.Text = "Ver reporte"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 444)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsginarPruebasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearReporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerReporteToolStripMenuItem As ToolStripMenuItem
End Class

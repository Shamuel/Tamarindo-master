Public Class Form1
    Private Sub VerPruebasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPruebasToolStripMenuItem.Click
        Ver_fecha_de_pruebas.Show()
    End Sub

    Private Sub AsginarPruebasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AsginarPruebasToolStripMenuItem.Click
        Asignar_fecha_de_prueba.Show()
    End Sub

    Private Sub CrearReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CrearReporteToolStripMenuItem.Click
        Crear_reporte.Show()
    End Sub

    Private Sub VerReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerReporteToolStripMenuItem.Click
        Ingresar_codigo_del_empleado.Show()
    End Sub
End Class
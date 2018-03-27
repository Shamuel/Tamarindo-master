Public Class ExpedienteDeEmpleado
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ExpedienteEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TextBox1.Enabled = False
        Me.DateTimePicker1.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = True
        Me.TextBox5.Enabled = True
        Me.TextBox6.Enabled = True
    End Sub
End Class
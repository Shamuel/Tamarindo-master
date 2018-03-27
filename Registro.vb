Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If Correo.Text = RepetirContraseña.Text Then

            Try
                '3- Abre conexion a base de datos
                conexion.ConnectionString = servidor_datos
                conexion.Open()
                '4- Crear adaptador para llenar el dataset  
                Dim adaptador As SqlClient.SqlDataAdapter
                '5- Definir el dataset
                Dim set_de_datos As New DataSet()
                '6- Definir la variable para la instruccion SQL
                Dim instruccionSQL As String
                instruccionSQL = "insert into TBL_Usuario_102 values (" " " + ",'" + Cedula.Text + ",'" +
                    Apellido2.Text +"','" + NombreDePersona.Text + "','" +
                    Correo.Text + "','" + FechaInclusion.Text + "')"

                '7- Cargar el datagridview y ver si la persona puso datos 
                If Apellido1.Text = "" Or NombreDePersona.Text = "" Or Apellido2.Text = "" Or
                    Correo.Text = "" Or FechaInclusion.Text = "" Then

                    MessageBox.Show("Escriba", "MENSAJE DEL SISTEMA",
                         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    DataGridView1.DataSource = ""
                    adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
                    adaptador.Fill(set_de_datos, "TBL_Usuario_102")
                    DataGridView1.DataSource = set_de_datos.Tables("TBL_Usuario_102")

                    MessageBox.Show("Datos agregados correctamente")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            conexion.Close()

        End If
    End Sub

End Class
Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = FechaInclusion.ToString()
    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        If (RepetirContraseña.Text = Contraseña.Text) Then

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
                instruccionSQL = "insert into TBL_Usuario_102 (PK_IdUsuario,FK_Id_500,FK_TipoUsuario_103,
                    CP_Contrasena,CP_FechaCambioContrasena,CP_EstadoBloqueo,CP_Fecha_Inclusion,
                    CP_Contador_CambioContrasena) values 
                    ( '1234'" + ",'" + Cedula.Text + "'," +
                    4 + ",'" + Contraseña.Text + "','" +
                   FechaInclusion.Text + "'," + 0 + ",'" + FechaInclusion.Text + "'," +
                     +3 + ")"

                '7- Cargar el datagridview y ver si la persona puso datos 
                If Cedula.Text = "" Or NombreDePersona.Text = "" Or Contraseña.Text = "" Or
                    RepetirContraseña.Text = "" Or FechaInclusion.Text = "" Then

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
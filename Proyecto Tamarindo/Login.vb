Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Registrarse.Enabled = False

    End Sub

    Private Sub GenerarCodigo_Click(sender As Object, e As EventArgs) Handles GenerarCodigo.Click
        Registrarse.Enabled = True

    End Sub

    Private Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click

        Registro.Show()

    End Sub

    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
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
            instruccionSQL = "Select * from TBL_Usuario_102 where PK_IdUsuario = '" & Usuario.Text & "' 
                and CP_Contrasena = '" & Contraseña.Text & "'"

            '7- Cargar el datagridview y ver si la persona puso datos 
            If Usuario.Text = "" Or Contraseña.Text = "" Then

                MessageBox.Show("Escriba", "MENSAJE DEL SISTEMA",
                         MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            End If
            Menú_principal_candidatos__empleados.Show()

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        conexion.Close()

    End Sub
End Class

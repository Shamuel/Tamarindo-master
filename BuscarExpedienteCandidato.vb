Public Class BuscarExpedienteCandidato
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


        If TextBox1.Text <> "" Then
            '1- Definir nombre del servidor y la base de datos para conexion
            Dim servidor_datos As String
            servidor_datos = "Data Source=LAPTOP-MIG91646;Initial Catalog=TAMARINDO;Integrated Security=SSPI;"
            '2- Definir una conexion para la base de datos
            Dim conexion As New SqlClient.SqlConnection(servidor_datos)
            conexion.ConnectionString = servidor_datos
            '3- Abre conexion a base de datos
            conexion.Open()
            Try
                '4- Crear adaptador para llenar el dataset  
                Dim adaptador As SqlClient.SqlDataAdapter
                '5- Definir el dataset
                Dim set_de_datos As New DataSet()
                '6- Definir la variable para la instruccion SQL
                Dim instruccionSQL As String
                instruccionSQL = "select * from TBL_Usuario_102 where PK_IdUsuario = " & TextBox1.Text

                '7- Cargar el datagridview
                DataGridView1.DataSource = ""
                adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
                adaptador.Fill(set_de_datos, "TBL_Usuario_102")
                DataGridView1.DataSource = set_de_datos.Tables("TBL_Usuario_102")

                '8- Enviar mensaje si encontr� o no encontro datos
                Me.Label2.Text = DataGridView1.Rows.Count - 1
                If DataGridView1.Rows.Count > 1 Then
                    MessageBox.Show("LO ENCONTRO!", "MENSAJE DEL SISTEMA",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    MessageBox.Show("NO HAY DATOS PARA MOSTRAR!", "MENSAJE DEL SISTEMA",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
        Else
            MessageBox.Show("DEBE DIGITAR UN DATO PARA BUSCAR!", "MENSAJE DEL SISTEMA",
           MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            TextBox1.Focus()
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub ExpedienteAdmi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class

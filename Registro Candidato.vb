Public Class RegistroCandidato
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'VENTASDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.TextBox1.Enabled = False
        Me.TextBox2.Enabled = False
        Me.TextBox3.Enabled = False
        Me.TextBox4.Enabled = False
        Me.ComboBox1.Enabled = False
        Me.Button3.Enabled = False
        Me.Button2.Enabled = False
        Me.Button4.Enabled = False

    End Sub




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        'TODOS ESTOS COMANDOS REALIZAN CONEXION MANUAL A BASE DE DATOS Y BORRAN UN REGISTRO
        'ELIMINA
        '1- Definir nombre del servidor y la base de datos para conexion
        Dim servidor_datos As String
        servidor_datos = "Data Source=LAB4-22;Initial Catalog=VENTAS;Integrated Security=SSPI;"

        '2- Definir una conexion para la base de datos
        Dim conexion As New SqlClient.SqlConnection(servidor_datos)
        conexion.ConnectionString = servidor_datos

        '3- Ejecuta un comando para insertar datos en la base de datos
        Dim instruccionSQL As String
        Try
            '3.1 Define comando SQL
            instruccionSQL = "DELETE FROM CLIENTES WHERE CEDULA=" & Me.TextBox1.Text

            '3.2 Define conexion y aplica comando
            Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)

            '3.3 Abre la conexion a la base de datos
            conexion.Open()

            '3.4 Ejecuta el comando para sentencias SQL
            comando.ExecuteNonQuery()

            '3.5 Refresca el datagridview
            TextBox1.Refresh()
            TextBox2.Refresh()
            TextBox3.Refresh()
            TextBox4.Refresh()
            ComboBox1.Refresh()

            MessageBox.Show("DATOS ACTUALIZADOS!", "MENSAJE DEL SISTEMA",
       MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

        Catch mensajeERROR As Exception
            MsgBox(mensajeERROR.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        Me.ComboBox1.Enabled = True
        Me.Button3.Enabled = True
        Me.Button2.Enabled = True
        Me.Button4.Enabled = True
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TextBox1.Enabled = True
        Me.TextBox2.Enabled = True
        Me.TextBox3.Enabled = True
        Me.TextBox4.Enabled = True
        Me.ComboBox1.Enabled = True
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            'Define conectividad a base de datos
            conexion.ConnectionString = servidor_datos
            conexion.Open()
            Dim adaptador As SqlClient.SqlDataAdapter
            Dim set_de_datos As New DataSet()
            Dim instruccionSQL As String
            instruccionSQL = "select * from TBL_Persona_500 where FK_TIPOID_TIPOID_104 =" & TextBox1.Text

            DataGridView1.DataSource = ""
            adaptador = New SqlClient.SqlDataAdapter(instruccionSQL, conexion)
            adaptador.Fill(set_de_datos, "TBL_Persona_500")
            DataGridView1.DataSource = set_de_datos.Tables("TBL_Persona_500")

            'Buscar dato 
            Try
                If DataGridView1.Rows.Count > 1 Then
                    'LO ENCONTRO -> ACTUALIZA CON UN UPDATE Y ENVIA MENSAJE
                    'Ejecuta un comando para insertar datos en la base de datos
                    'Define comando SQL
                    instruccionSQL = "update TBL_Persona_500 set NOMBRE ='" & TextBox2.Text & "', DIRECCION = '" & TextBox3.Text & "', CORREO_ELECTRONICO = '" & TextBox4.Text & "', PROVINCIA = '" & ComboBox1.Text & "' WHERE CEDULA = '" & TextBox1.Text & "'"
                    Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("DATOS ACTUALIZADOS!", "MENSAJE DEL SISTEMA",
       MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                Else
                    'NO ENCONTRO -> INSERTA CON UN INSERT Y ENVIA MENSAJE
                    instruccionSQL = "insert into CLIENTES (CEDULA,NOMBRE,DIRECCION,CORREO_ELECTRONICO,PROVINCIA) values ('" & TextBox1.Text & "',' " & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & ComboBox1.Text & "')"
                    Dim comando As New SqlClient.SqlCommand(instruccionSQL, conexion)
                    comando.ExecuteNonQuery()
                    MessageBox.Show("DATOS INSERTADOS!", "MENSAJE DEL SISTEMA",
       MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                End If
                Button4.PerformClick()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try
            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
        conexion.Close()

        Dim Agregar As String = "Insert into TBL_Usuario_102 values" & "('" & TextBox1.Text & "','" & TextBox2.Text & "'," & 3 & ",'" & TextBox3.Text & "','" & ")"


        If TextBox1.Text <> "" And TextBox2.Text <> "" Then


            If (TodoLaConexion.Insertar(Agregar)) Then
                MsgBox("Datos Guardados Correctamente")
            Else
                MsgBox("Error al guardar los datos")
            End If

            TextBox1.Clear()
            TextBox2.Clear()

        Else
            MsgBox("Escriba en Cada Campo")
        End If

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BuscarExpedienteCandidato.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
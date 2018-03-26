Module TodoLaConexion
    '1- Definir nombre del servidor y la base de datos para conexion
    Public servidor_datos As String = "Data Source=LAPTOP-MIG91646;Initial Catalog=Tamarindo;Integrated Security=SSPI;"
    '2- Definir una conexion para la base de datos
    Public conexion As New SqlClient.SqlConnection(servidor_datos)
    Public instruccionSQL As SqlClient.SqlCommand
    Public Respuesta As SqlClient.SqlDataReader
    'sub para abrir conexion
    Sub abrirConexion()
        Try
            conexion.Open()

        Catch ex As Exception
            MsgBox("No se pudo Conectar")
        End Try


    End Sub
    'funcion para obtener usuarios de la BD
    Function UsuarioRegistrado(ByVal NombredeUsuario As String) As Boolean
        Dim ResultadoConexion As Boolean = False
        Try
            instruccionSQL = New SqlClient.SqlCommand("Select * from TBL_Usuario_102 where PK_IdUsuario='" & NombredeUsuario & "'", conexion)
            Respuesta = instruccionSQL.ExecuteReader

            If Respuesta.Read Then
                ResultadoConexion = True
            End If
            Respuesta.Close()

        Catch ex As Exception

        End Try
        Return ResultadoConexion
    End Function
    'funcion para obtener usuarios de la BD
    Function contrasena(ByVal NombredeUsuario As String) As String
        Dim ResultadoConexion As String = ""
        Try
            instruccionSQL = New SqlClient.SqlCommand("Select CP_Contrasena from TBL_Usuario_102 where PK_IdUsuario='" & NombredeUsuario & "'", conexion)
            Respuesta = instruccionSQL.ExecuteReader

            If Respuesta.Read Then
                ResultadoConexion = Respuesta.Item("CP_Contrasena")
            End If
            Respuesta.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return ResultadoConexion
    End Function

    Function Insertar(ByVal sql)
        instruccionSQL = New SqlClient.SqlCommand(sql, conexion)
        Dim i As Integer = instruccionSQL.ExecuteNonQuery
        If (i > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

End Module

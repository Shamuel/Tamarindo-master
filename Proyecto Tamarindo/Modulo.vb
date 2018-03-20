Module Modulo
    '1- Definir nombre del servidor y la base de datos para conexion
    Public servidor_datos As String = "Data Source=LAPTOP-MIG91646;Initial Catalog=Tamarindo;Integrated Security=SSPI;"
    '2- Definir una conexion para la base de datos
    Public conexion As New SqlClient.SqlConnection(servidor_datos)
End Module

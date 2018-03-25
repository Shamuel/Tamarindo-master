Public Class Registro
    Private Sub Registro_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Guardar_Click(sender As Object, e As EventArgs) Handles Guardar.Click
        Dim Agregar As String = "Insert into TBL_Usuario_102 values" & "('" & Cedula.Text & "','" & NombreDePersona.Text & "'," & 3 & ",'" & Contraseña.Text & "','" & FechaInclusion.Value.Date.ToString(" yyyy-MM-dd hh:mm") & "'," & 0 & ",'" & FechaInclusion.Value.Date.ToString(" yyyy-MM-dd hh:mm") & "'," & 3 & ")"


        If NombreDePersona.Text <> "" And Cedula.Text <> "" And RepetirContraseña.Text <> "" And Contraseña.Text <> "" Then
            If (RepetirContraseña.Text = Contraseña.Text) Then

                If (TodoLaConexion.Insertar(Agregar)) Then
                    MsgBox("Datos Guardados Correctamente")
                Else
                    MsgBox("Error al guardar los datos")
                End If

                Cedula.Clear()
                NombreDePersona.Clear()
                Contraseña.Clear()
                RepetirContraseña.Clear()


            Else
                MsgBox("Las contraseñas no coinciden")
            End If
        Else
            MsgBox("Escriba en Cada Campo")
        End If

    End Sub

End Class
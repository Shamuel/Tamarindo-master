Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Registrarse.Enabled = False
        abrirConexion()
    End Sub

    Private Sub GenerarCodigo_Click(sender As Object, e As EventArgs) Handles GenerarCodigo.Click
        Registrarse.Enabled = True

    End Sub

    Private Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click

        Registro.Show()

    End Sub



    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        'Verificar si exite algun usuario con el usuario que se digito y hacer lo mismo con la contrasena
        Try
            If UsuarioRegistrado(Usuario.Text) = True Then
                Dim contra As String = contrasena(Usuario.Text)
                If contra.Equals(Contraseña.Text) = True Then
                    Menú_principal_candidatos__empleados.Show()

                Else
                    MsgBox("Contraseña Invalida", MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("El Usuario: " + Usuario.Text + " no se encuentra registrado")
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
End Class

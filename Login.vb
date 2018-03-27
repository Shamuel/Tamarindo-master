Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Registrarse.Visible = False
        DigiteCorreo.Visible = False
        EnviarCorreo.Visible = False
        CodigoRecibido.Visible = False
        abrirConexion()
    End Sub

    Private Sub GenerarCodigo_Click(sender As Object, e As EventArgs) Handles GenerarCodigo.Click
        GenerarCodigo.Visible = False

        DigiteCorreo.Visible = True
        EnviarCorreo.Visible = True

    End Sub

    Private Sub Registrarse_Click(sender As Object, e As EventArgs) Handles Registrarse.Click
        If CodigoRecibido.Text = Codigo Then
            Registro.Show()
        Else
            MsgBox("Codigo Incorrecto")
        End If


    End Sub



    Private Sub Ingresar_Click(sender As Object, e As EventArgs) Handles Ingresar.Click
        'Verificar si exite algun usuario con el usuario que se digito y hacer lo mismo con la contrasena
        Try
            If UsuarioRegistrado(Usuario.Text) = True Then
                Dim contra As String = contrasena(Usuario.Text)
                If contra.Equals(Contraseña.Text) = True Then
                    MenúprincipalSystemAdmin.Show()

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

    Public Codigo As String

    Private Sub EnviarCorreo_Click(sender As Object, e As EventArgs) Handles EnviarCorreo.Click
        If EnviarCorreo.Text <> "" Then


            Try
                Dim SmtpServer As New Net.Mail.SmtpClient()
                Dim mail As New Net.Mail.MailMessage()
                SmtpServer.UseDefaultCredentials = False
                SmtpServer.Credentials = New Net.NetworkCredential("proyecto1tamarindo@gmail.com", "sistemaHRtamarindo")
                SmtpServer.Port = 587
                SmtpServer.Host = "smtp.gmail.com"
                SmtpServer.EnableSsl = True
                SmtpServer.DeliveryMethod = Net.Mail.SmtpDeliveryMethod.Network
                mail = New Net.Mail.MailMessage()
                mail.From = New Net.Mail.MailAddress("proyecto1tamarindo@gmail.com")
                mail.To.Add(DigiteCorreo.Text)
                mail.Subject = "MailSubject"
                mail.Body = ""
                If mail.Body = "" Then
                    Dim rng As New Random
                    Dim number As Integer = rng.Next(1000, 9999)
                    Codigo = number.ToString("0000")
                    mail.Body = Codigo
                End If
                SmtpServer.Send(mail)
                Registrarse.Visible = True
                DigiteCorreo.Visible = False
                EnviarCorreo.Visible = False
                CodigoRecibido.Visible = True
            Catch ex As Exception
                MessageBox.Show("Error", "Error al enviar", MessageBoxButtons.OK, MessageBoxIcon.Error)



            End Try





        End If

    End Sub
End Class

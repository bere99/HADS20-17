Public Class ModificarPass
    Inherits System.Web.UI.Page

    Dim ln As New LibreriasLAB.LogicaDeNegocio


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If (Page.IsPostBack) Then
            prueba.Text = "Email enviado"
            RequestChangePass.Enabled = False
            codpass.Enabled = True
            changePass.Enabled = True
        End If
    End Sub

    Protected Sub RequestChangePass_Click(sender As Object, e As EventArgs) Handles RequestChangePass.Click
        Dim ln As New LibreriasLAB.LogicaDeNegocio
        If ln.SolicitarCambioPass(email.Text) Then
            prueba.Text = "Email enviado"
            RequestChangePass.Enabled = False
            codpass.ReadOnly = False
            codpass.Text = ""
            changePass.Enabled = True
        Else
            prueba.Text = "Ha ocurrido un error al enviar el email"
        End If



    End Sub

    Protected Sub changePass_Click(sender As Object, e As EventArgs) Handles changePass.Click
        If (ln.VerificarCodPass(email.Text, codpass.Text)) Then
            pass.ReadOnly = False
            repass.ReadOnly = False
            confirm.Enabled = True
            email.ReadOnly = True
            NewPass.Enabled = True
            NewRePass.Enabled = True
            pass.Enabled = True
            repass.Enabled = True
            prueba.Text = "Código correcto."
        Else
            prueba.Text = "No se ha podido verificar el código."
        End If
    End Sub

    Protected Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        If (ln.CambiarPass(email.Text, pass.Text)) Then
            prueba.Text = "La contraseña se ha restablecido correctamente."
        Else
            prueba.Text = "No se ha podido restablecer la contraseña."
        End If
    End Sub

    Protected Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Protected Sub codpass_TextChanged(sender As Object, e As EventArgs) Handles codpass.TextChanged

    End Sub
End Class
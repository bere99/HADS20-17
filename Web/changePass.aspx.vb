Public Class changePass
    Inherits System.Web.UI.Page

    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Protected Sub confirm_Click(sender As Object, e As EventArgs) Handles confirm.Click
        Dim email As String
        email = Request.QueryString("email")

        ln.CambiarPass(email, pass.Text)
    End Sub
End Class
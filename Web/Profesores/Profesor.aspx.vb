Public Class Profesor
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

            ln.Conectar()

        End If
    End Sub

    Protected Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        System.Web.Security.FormsAuthentication.SignOut()
        Session.RemoveAll()
        Session.Abandon()
        Response.Redirect("http://hads1920-g17.azurewebsites.net/Inicio.aspx")

    End Sub
End Class
Public Class Inicio
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ln.Conectar()
    End Sub


    Protected Sub Login(sender As Object, e As EventArgs) Handles loginButton.Click


        If (ln.Login(email.Text, password.Text)) Then
            Session("email") = email.Text
            Dim tipo As String
            tipo = ln.EsProfe(email.Text)
            If Session("email") = "admin@ehu.es" Then

                FormsAuthentication.SetAuthCookie("admin", False)
                Response.Redirect("http://localhost:56083/ManageUsers.aspx")
            ElseIf tipo Then
                Session("tipo") = "Profesor"
                If Session("email") = "vadillo@ehu.es" Then
                    FormsAuthentication.SetAuthCookie("vadillo", False)

                Else
                    FormsAuthentication.SetAuthCookie("profesor", False)

                End If

                Response.Redirect("http://localhost:54384/Profesor.aspx?email=" & email.Text & "")
            Else
                Session("tipo") = "Alumno"
                    FormsAuthentication.SetAuthCookie("alumno", False)
                    FormsAuthentication.RedirectFromLoginPage("alumno", False)


                Response.Redirect("http://localhost:56523/TareasAlumno.aspx?email=" & email.Text & "")
                End If
            Else
                conection.Text = "Login incorrecto"
        End If

    End Sub

End Class

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
            If tipo Then
                Session("tipo") = "Profesor"
                Response.Redirect("http://localhost:54384/TareasProfesor.aspx?email=" & email.Text & "")
            Else
                Session("tipo") = "Alumno"
                Response.Redirect("http://localhost:56523/TareasAlumno.aspx?email=" & email.Text & "")
            End If
        Else
            conection.Text = "Login incorrecto"
        End If

    End Sub

End Class
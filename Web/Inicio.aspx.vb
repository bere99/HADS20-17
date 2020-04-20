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
                Response.Redirect("http://localhost:56315/Admin/ManageUsers.aspx")
            Else
                If tipo Then
                    Session("tipo") = "Profesor"
                    If Session("email") = "vadillo@ehu.es" Then
                        FormsAuthentication.SetAuthCookie("vadillo", False)
                    Else
                        FormsAuthentication.SetAuthCookie("profesor", False)
                    End If
                    UpdateLogs(Session("email"), "Profesor")
                    Response.Redirect("http://localhost:56315/Profesores/Profesor.aspx")
                Else
                    Session("tipo") = "Alumno"
                    FormsAuthentication.SetAuthCookie("alumno", False)
                    UpdateLogs(Session("email"), "Alumno")
                    Response.Redirect("http://localhost:56315/Alumnos/TareasAlumno.aspx")
                End If

            End If

        Else
            conection.Text = "Login incorrecto"
        End If

    End Sub

    Protected Sub UpdateLogs(ByVal email As String, ByVal tipo As String)
        Application.Lock()
        Dim lista As New List(Of String)
        If Not IsNothing(Application.Contents(tipo)) Then
            lista = Application.Contents(tipo)
        End If
        lista.Add(email)
        Application.Contents(tipo) = New List(Of String)(lista)
        Application.UnLock()

    End Sub



End Class
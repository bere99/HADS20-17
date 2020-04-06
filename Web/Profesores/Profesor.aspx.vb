Public Class Profesor
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ln.Conectar()

        End If

        Dim listaProf As New List(Of String)

        listaProf = Application.Contents("Profesor")
        ListBoxProfes.DataSource = listaProf
        ListBoxProfes.DataBind()
        profes.Text = listaProf.Count

        Dim listaAlum As New List(Of String)
        listaAlum = Application.Contents("Alumno")
        ListBoxAlumnos.DataSource = listaAlum
        ListBoxAlumnos.DataBind()
        If Not IsNothing(listaAlum) Then
            alumnos.Text = listaAlum.Count
        End If



    End Sub

    Protected Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        System.Web.Security.FormsAuthentication.SignOut()

        UpdateLogsOut(Session("email"), Session("tipo"))
        Session.RemoveAll()
        Session.Abandon()
        Response.Redirect("http://localhost:56315/Inicio.aspx")

    End Sub

    Protected Sub UpdateLogsOut(ByVal email As String, ByVal tipo As String)
        Application.Lock()
        Dim lista As New List(Of String)
        lista = Application.Contents(tipo)
        lista.Remove(email)
        Application.Contents(tipo) = New List(Of String)(lista)
        Application.UnLock()
    End Sub
End Class
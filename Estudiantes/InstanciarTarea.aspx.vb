Public Class InstanciarTarea
    Inherits System.Web.UI.Page

    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        email.Text = Session("email")
        tarea.Text = Session("tarea")
        horas.Text = Session("horas")
        GridView.DataSource = ln.GetTareasInstanciadas(Session("email"))
        GridView.DataBind()
    End Sub

    Protected Sub crearTarea_Click(sender As Object, e As EventArgs) Handles crearTarea.Click
        If (ln.InstanciarTarea(Session("email"), Session("tarea"), horas.Text, reales.Text)) Then
            GridView.DataSource = ln.GetTareasInstanciadas(Session("email"))
            GridView.DataBind()
            crearTarea.Enabled = "false"
            ibi.Text = "La tarea se ha instanciado correctamente"

        Else
            ibi.Text = "La tarea no se ha podido instanciar correctamente."
        End If


    End Sub

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView.SelectedIndexChanged

    End Sub
End Class
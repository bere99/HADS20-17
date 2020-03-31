
Public Class TareasAlumno
    Inherits System.Web.UI.Page

    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim rowMbrs As DataRow

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            dstMbrs = Session("datos")
            Session("datos") = dstMbrs
        Else
            ln.Conectar()
            If (Session("email") = "") Then
                Session("email") = Request("email")
            End If
            DropDownList.DataSource = ln.GetAsignaturas(Session("email"))
            DropDownList.DataValueField = "codigoasig"
            DropDownList.DataBind()
        End If
    End Sub

    Protected Sub DropDownList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList.SelectedIndexChanged
        GridView.DataSource = Nothing
        GridView.DataBind()
        Session("asig") = DropDownList.SelectedValue
        GridView.DataSource = ln.GetTareasPRUEBA(Session("email"), Session("asig"))
        GridView.DataBind()
    End Sub

    Protected Sub GridView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GridView.SelectedIndexChanged
        Session("tarea") = GridView.SelectedRow.Cells(1).Text
        Session("horas") = GridView.SelectedRow.Cells(4).Text
        Response.Redirect("InstanciarTarea.aspx?")

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        System.Web.Security.FormsAuthentication.SignOut()
        Session.RemoveAll()
        Session.Abandon()
        Response.Redirect("http://hads1920-g17.azurewebsites.net/Inicio.aspx")
    End Sub
End Class
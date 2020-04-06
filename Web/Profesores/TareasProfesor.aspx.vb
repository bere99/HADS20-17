Public Class TareasProfesor
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio
    Dim dstMbrs As DataSet
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then
            dstMbrs = Session("datos")
        End If
    End Sub

    Protected Sub DropDownList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList.SelectedIndexChanged
        Session("asig") = DropDownList.SelectedValue
    End Sub

    Protected Sub Mostrador_Selecting(sender As Object, e As SqlDataSourceSelectingEventArgs) Handles Mostrador.Selecting

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("InsertarTareas.aspx")
    End Sub

End Class
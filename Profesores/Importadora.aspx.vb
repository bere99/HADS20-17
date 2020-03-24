Imports System.Xml

Public Class Importadora
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio
    Dim dstMbrs As DataSet

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            ln.Conectar()
        End If
    End Sub

    Protected Sub DropDownList_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList.SelectedIndexChanged
        Session("asig") = DropDownList.SelectedValue
        Xml.DocumentSource = Server.MapPath("App_Data/" & DropDownList.SelectedValue & ".xml")
        Xml.TransformSource = Server.MapPath("App_Data/XSLTFile.xsl")
    End Sub

    Protected Sub importar_Click(sender As Object, e As EventArgs) Handles importar.Click
        Dim docxml As New XmlDocument
        docxml.Load(Server.MapPath("App_Data/" & Session("asig") & ".xml"))
        If ln.ImportarXML(Session("asig"), docxml) Then
            ibi.Text = "Las tareas se han importado correctamente"
        Else
            ibi.Text = "No se han podido importar las tareas"
        End If
    End Sub
End Class
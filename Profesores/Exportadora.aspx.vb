Imports System.Data.SqlClient
Imports System.Xml

Public Class Exportadora
    Inherits System.Web.UI.Page
    Dim dapMbrs As New SqlDataAdapter()
    Dim dstMbrs As New DataSet
    Dim tblMbrs As New DataTable
    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Session("asig") = ln.GetFirstAsig(Session("email"))
        End If

        dapMbrs = ln.GetTareasProfe(DropDownList1.SelectedValue)
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "tarea")
        tblMbrs = dstMbrs.Tables("tarea")
        GridView1.DataSource = tblMbrs
        GridView1.DataBind()
        Session("datos") = dstMbrs
    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        Session("asig") = DropDownList1.SelectedValue
    End Sub

    Protected Sub exportar_Click(sender As Object, e As EventArgs) Handles exportar.Click
        Dim config As New XmlWriterSettings
        config.Indent = True
        config.Encoding = Encoding.UTF8
        Dim file_t As String
        file_t = Server.MapPath("App_Data/" & Session("asig") & ".xml")
        Dim Tareas As New DataSet()
        Tareas = Session("datos")
        Tareas.DataSetName = "tareas"

        For Each col As DataColumn In Tareas.Tables("tarea").Columns
            If col.ColumnName = "Codigo" Then
                col.ColumnMapping = MappingType.Attribute
            ElseIf col.ColumnName <> "CodsAsig" Then
                col.ColumnMapping = MappingType.Element
            End If
            col.ColumnName = col.ColumnName.ToLower()
        Next col

        Using TareasAsig As XmlWriter = XmlWriter.Create(file_t, config)
            TareasAsig.Close()
            Tareas.WriteXml(file_t)
        End Using
        Label1.Text = "Las tareas se han exportado correctamente."
    End Sub

End Class
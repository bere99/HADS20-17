Imports System.Data
Imports System.Data.SqlClient
Public Class Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Protected Sub Insertar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles registrar.Click
        Dim ln As New LibreriasLAB.LogicaDeNegocio
        Label2.Text = ln.Registrar(email.Text, nombre.Text, apellidos.Text, rol.SelectedItem.Text, pass.Text)
    End Sub

End Class
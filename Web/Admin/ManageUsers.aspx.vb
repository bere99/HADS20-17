﻿Public Class ManageUsers
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub CerrarSesion_Click(sender As Object, e As EventArgs) Handles CerrarSesion.Click
        System.Web.Security.FormsAuthentication.SignOut()
        Session.RemoveAll()
        Session.Abandon()
        Response.Redirect("http://hads1920-g17.azurewebsites.net/Inicio.aspx")
    End Sub
End Class
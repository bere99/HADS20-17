﻿Public Class Profesor
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Page.IsPostBack Then

        Else
            ln.Conectar()
            If (Session("email") = "") Then
                Session("email") = Request("email")
            End If
        End If
    End Sub

    Protected Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Session.RemoveAll()
        Response.Redirect("http://localhost:56315/Inicio.aspx")
        'http://hads1920-g17.azurewebsites.net/Inicio.aspx")
    End Sub
End Class
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class Register
    Inherits System.Web.UI.Page
    Dim matricula As New Matricula.Matriculas
    Dim validEmail As Boolean

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub pass_TextChanged(sender As Object, e As EventArgs) Handles pass.TextChanged

    End Sub

    Protected Sub Insertar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles registrar.Click
        If validEmail Then
            Dim ln As New LibreriasLAB.LogicaDeNegocio
            Label2.Text = ln.Registrar(email.Text, nombre.Text, apellidos.Text, rol.SelectedItem.Text, pass.Text)
        ElseIf Not validEmail Then
            Label2.Text = "Para registrarse debe estar matriculado en la UPV/EHU"
        Else
            Label2.Text = "No se ha podido registrar correctamente."
        End If

    End Sub

    Protected Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged
        If matricula.comprobar(email.Text) = "SI" Then
            validEmail = True
            registrar.Enabled = True
            ibiText.Text = "El email es válido"
            ibiText.ForeColor = Color.Green
        Else
            validEmail = False
            registrar.Enabled = False
            ibiText.Text = "El email no es válido"
            ibiText.ForeColor = Color.Red
        End If
    End Sub
End Class
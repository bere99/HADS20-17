Public Class Confirmado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim da As New LibreriasLAB.SQLDataAccess
        Dim email As String = Request.QueryString("email")
        Dim numconfir As String = Request.QueryString("numconfir")
        Dim ln As New LibreriasLAB.LogicaDeNegocio

        If (ln.VerificarRegistro(email, numconfir)) Then
            Label1.Text = "Su registro se ha confirmado correctamente"
        Else
            Label1.Text = "Su registro no se ha podido confirmar"
        End If





    End Sub

End Class
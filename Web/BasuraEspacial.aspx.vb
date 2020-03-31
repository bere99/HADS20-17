Public Class BasuraEspacial
    Inherits System.Web.UI.Page

    Dim ln As New LibreriasLAB.LogicaDeNegocio
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ibi.Text = ln.MD5EncryptPass(TextBox1.Text)
    End Sub
End Class
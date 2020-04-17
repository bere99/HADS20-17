Public Class coordinador
    Inherits System.Web.UI.Page
    Private Shared dedication As New Dedication.Service


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownList1.SelectedIndexChanged
        ibiLabel.Text = "Dedicación media: "
        ibiTxt.Text = dedication.getDedication(DropDownList1.SelectedValue)

    End Sub
End Class
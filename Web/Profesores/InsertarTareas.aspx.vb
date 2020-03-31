Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim ln As New LibreriasLAB.LogicaDeNegocio

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub addTarea_Click(sender As Object, e As EventArgs) Handles addTarea.Click
        If ln.InsertarTarea(codigo.Text, descripcion.Text, DropDownList.SelectedValue, horas.Text, DropDownList1.SelectedValue) Then
            ibi.Text = "La tarea se ha insertado correctamente."
        Else
            ibi.Text = "La tarea no se ha podido insertar."
        End If
    End Sub


End Class
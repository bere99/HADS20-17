Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel
Imports System.Data.SqlClient

' Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente.
' <System.Web.Script.Services.ScriptService()> _
<System.Web.Services.WebService(Namespace:="http://tempuri.org/")> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<ToolboxItem(False)> _
Public Class Dedicaciones
    Inherits System.Web.Services.WebService

    <WebMethod()>
    Public Function getDedication(ByVal asig As String) As Integer
        Dim avg As Integer
        Dim comando As New SqlCommand
        Dim conexion As New SqlConnection

        conexion.ConnectionString = “Server=tcp:hads.database.windows.net,1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=vadillo@ehu.es@hads;Password=curso19-20;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
        conexion.Open()

        Dim st = "Select avg(EstudiantesTareas.HReales) FROM EstudiantesTareas INNER JOIN TareasGenericas On EstudiantesTareas.CodTarea=TareasGenericas.Codigo Where CodAsig='" & asig & "' "
        comando = New SqlCommand(st, conexion)
        Try
            avg = comando.ExecuteScalar
            conexion.Close()

            Return avg
        Catch ex As Exception
            Return 0
        End Try
    End Function

End Class

dotnet add package System.Data.SqlClient
Imports System.Data.sqlClient

Public Class SQLDataAccess
    Private Shared conexion As New SqlConnection
    Private Shared comando As New System.Data.SqlClient
    Public Shared Function conectar() As String
        Try
            conexion.ConnectionString = “string para la BD de Azure"
            conexion.Open()
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
    End Function
End Class

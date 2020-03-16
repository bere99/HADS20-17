Imports System.Data.SqlClient


Public Class SQLDataAccess
    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Private Shared adaptador As New SqlDataAdapter
    Private Shared dstMbrs As New DataSet


    Public Function Conectar() As String
        Try
            conexion.ConnectionString = “Server=tcp:hads.database.windows.net,1433;Initial Catalog=Amigos;Persist Security Info=False;User ID=vadillo@ehu.es@hads;Password=curso19-20;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"
            conexion.Open()

            Return "Conexión establecida"
        Catch ex As Exception
            Return "ERROR DE CONEXIÓN: " + ex.Message
        End Try
    End Function

    Public Function Registrar(ByVal email As String, ByVal nombre As String, ByVal apellidos As String, ByVal rol As String, ByVal pass As String, ByVal numConfirm As Integer) As Boolean
        Dim st = "insert into Usuarios values ('" & email & "', '" & nombre & "', '" & apellidos & "',  '" & numConfirm & "', 0, '" & rol & "','" & pass & "','0')"
        comando = New SqlCommand(st, conexion)
        comando.ExecuteNonQuery()
        Return True
    End Function

    Public Function Login(ByVal email As String, ByVal pass As String) As Boolean
        Dim st = "select count(*) from Usuarios where email='" & email & "' and pass='" & pass & "'  and confirmado=1"
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            Return True
        End If
        Return False
    End Function


    Public Function VerificarRegistro(ByVal email As String, ByVal numConfir As Integer) As Boolean
        Dim st = "select count(*) from Usuarios where email='" & email & "' and numconfir='" & numConfir & "' and confirmado=0"
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            st = "update Usuarios set confirmado = 1 where email= '" & email & "' "
            comando = New SqlCommand(st, conexion)
            comando.ExecuteNonQuery()
            Return True
        End If
        Return False
    End Function


    Public Function CambiarPass(ByVal email As String, ByVal pass As String) As Boolean
        Dim st = "select count(*) from Usuarios where email='" & email & "' "
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            st = "update Usuarios set pass = '" & pass & "' where email= '" & email & "' "
            comando = New SqlCommand(st, conexion)
            comando.ExecuteNonQuery()
            Return True
        End If
        Return False
    End Function


    Public Function CambiarCodPass(ByVal email As String, ByVal codpass As Integer) As Boolean

        Dim st = "select count(*) from Usuarios where email='" & email & "' "
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            st = "update Usuarios set codpass = " & codpass & " where email= '" & email & "' "
            comando = New SqlCommand(st, conexion)
            comando.ExecuteNonQuery()
            Return True

        End If
        Return False
    End Function



    Public Function VerificarCodPass(ByVal email As String, ByVal codpass As Integer) As Boolean

        Dim st = "select count(*) from Usuarios where email='" & email & "' and codpass='" & codpass & "' "
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 1 Then
            Return True
        End If
        Return False
    End Function


    Public Function GetAsignaturas(ByVal email As String) As DataTable
        Dim dapMbrs As New SqlDataAdapter()
        Dim tblMbrs As New DataTable
        dapMbrs = New SqlDataAdapter("Select * from EstudiantesGrupo  inner join GruposClase on EstudiantesGrupo.Grupo=GruposClase.codigo where email='" & email & "'", conexion)
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "EstudiantesGrupo")
        tblMbrs = dstMbrs.Tables("EstudiantesGrupo")
        Return tblMbrs

    End Function


    Public Function GetTareasPRUEBA(ByVal email As String, ByVal asig As String) As DataTable
        Dim dapMbrs As New SqlDataAdapter()
        Dim tblMbrs As New DataTable


        dapMbrs = New SqlDataAdapter("Select * From TareasGenericas Where TareasGenericas.CodAsig ='" & asig & "' And Codigo Not In (Select EstudiantesTareas.CodTarea FROM EstudiantesTareas WHERE EstudiantesTareas.Email = '" & email & "')", conexion)
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "EstudiantesTarea")
        tblMbrs = dstMbrs.Tables("EstudiantesTarea")
        Return tblMbrs
    End Function

    Public Function InstanciarTarea(ByVal email As String, ByVal tarea As String, ByVal estimadas As Integer, ByVal reales As Integer) As Boolean

        Dim st As String
        st = "Select Count(*) From EstudiantesTareas Where email ='" & email & "' AND CodTarea='" & tarea & "'"
        comando = New SqlCommand(st, conexion)
        If comando.ExecuteScalar() = 0 Then
            st = "Insert into EstudiantesTareas values ('" & email & "', '" & tarea & "', '" & estimadas & "', '" & reales & "' )"
            comando = New SqlCommand(st, conexion)
            comando.ExecuteScalar()
            Return True
        Else
            Return False
        End If
    End Function


    Public Function GetTareasInstanciadas(ByVal email As String) As DataTable
        Dim dapMbrs As New SqlDataAdapter()
        Dim tblMbrs As New DataTable

        dapMbrs = New SqlDataAdapter("Select * FROM EstudiantesTareas WHERE EstudiantesTareas.Email = '" & email & "'", conexion)
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "EstudiantesTareasInstanciadas")
        tblMbrs = dstMbrs.Tables("EstudiantesTareasInstanciadas")
        Return tblMbrs
    End Function

    Public Function EsProfe(ByVal email As String) As Boolean
        Dim st = "select Count(*) from Usuarios where email='" & email & "' AND tipo='Profesor' "
        comando = New SqlCommand(st, conexion)
        Return comando.ExecuteScalar() = 1
    End Function

    Public Function InsertarTarea(ByVal codigo As String, ByVal descripcion As String, ByVal CodAsig As String, ByVal horas As Integer, ByVal tipo As String) As Boolean
        adaptador = New SqlDataAdapter("Select * From TareasGenericas", conexion)
        adaptador.Fill(dstMbrs, "TareasGen")
        'Dim dtbl As DataTable = dstMbrs.Tables("TareasGen")
        Dim row As DataRow = dstMbrs.Tables("TareasGen").NewRow()
        row("Codigo") = codigo
        row("Descripcion") = descripcion
        row("CodAsig") = CodAsig
        row("HEstimadas") = horas
        row("Explotacion") = True
        row("TipoTarea") = tipo

        dstMbrs.Tables("TareasGen").Rows.Add(row)

        Dim s As New SqlCommandBuilder(adaptador)
        adaptador.InsertCommand = s.GetInsertCommand()
        Try
            adaptador.Update(dstMbrs, "TareasGen")
            dstMbrs.AcceptChanges()
        Catch ex As Exception
            Return False
        End Try

        Return True
    End Function



End Class

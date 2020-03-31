
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Imports System.Security.Cryptography

Public Class SQLDataAccess

    Private Shared conexion As New SqlConnection
    Private Shared comando As New SqlCommand
    Private Shared adaptador As New SqlDataAdapter
    Private Shared dstMbrs As New DataSet
    Private Shared tblMbrs As New DataTable

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

    Public Function GetTareasProfeMAL(ByVal asig As String) As DataTable
        Dim dapMbrs As New SqlDataAdapter()
        dapMbrs = New SqlDataAdapter("Select Distinct TareasGenericas.Codigo, TareasGenericas.Descripcion, TareasGenericas.CodAsig, TareasGenericas.HEstimadas, TareasGenericas.Explotacion, TareasGenericas.TipoTarea FROM TareasGenericas INNER JOIN GruposClase On TareasGenericas.CodAsig = GruposClase.codigoasig INNER JOIN ProfesoresGrupo On GruposClase.codigo = ProfesoresGrupo.codigogrupo WHERE (TareasGenericas.CodAsig ='" & asig & "')
", conexion)
        Dim bldMbrs As New SqlCommandBuilder(dapMbrs)
        dapMbrs.Fill(dstMbrs, "ProfesoresTarea")
        tblMbrs = dstMbrs.Tables("ProfesoresTarea")
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

    Public Function ImportarXML(ByVal asig As String, ByVal docxml As XmlDocument) As Boolean
        adaptador = New SqlDataAdapter("Select * From TareasGenericas", conexion)
        adaptador.Fill(dstMbrs, "TareasGenricas")
        Dim tbl As DataTable
        Dim row As DataRow
        tbl = dstMbrs.Tables("TareasGenricas")

        Dim doc As XmlNode = docxml.DocumentElement
        Dim nodeList As XmlNodeList
        nodeList = doc.SelectNodes("//tarea")


        For Each node As XmlNode In nodeList
            row = tbl.NewRow()
            row("CodAsig") = asig

            row("Codigo") = node.Attributes("codigo").InnerText

            row("Descripcion") = node.ChildNodes.Item(0).InnerText

            row("HEstimadas") = node.ChildNodes.Item(1).InnerText

            row("Explotacion") = node.ChildNodes.Item(2).InnerText

            row("TipoTarea") = node.ChildNodes.Item(3).InnerText
            Try
                tbl.Rows.Add(row)
            Catch e As ArgumentException
                Return False
            End Try
        Next node


        Dim s As New SqlCommandBuilder(adaptador)
        adaptador.InsertCommand = s.GetInsertCommand()
        Try
            adaptador.Update(dstMbrs, "TareasGenricas")
            dstMbrs.AcceptChanges()
            Return True
        Catch ex As SqlException
            Return False
        End Try
    End Function

    Public Function ExportarXML(ByVal asig As String) As String
        Dim dapMbrs As New SqlDataAdapter()
        Dim tblMbrs As New DataTable
        dapMbrs = New SqlDataAdapter("Select * From TareasGenericas where CodAsig='" & asig & "'", conexion)
        dapMbrs.Fill(dstMbrs, "exportar")
        Return dstMbrs.GetXml

    End Function


    Public Function GetTareasProfe(ByVal asig As String) As SqlDataAdapter
        Conectar()
        Dim st = "SELECT distinct Codigo, Descripcion, HEstimadas, Explotacion, TipoTarea FROM TareasGenericas WHERE CodAsig = '" & asig & "'"
        Dim adapter As New SqlDataAdapter(st, conexion)
        Return adapter
    End Function

    Public Function GetFirstAsig(ByVal email As String) As String
        Conectar()
        Dim st = "SELECT GruposClase.codigoasig FROM ProfesoresGrupo INNER JOIN GruposClase ON ProfesoresGrupo.codigogrupo = GruposClase.codigo WHERE (ProfesoresGrupo.email = '" & email & "')"
        comando = New SqlCommand(st, conexion)

        Dim reader As SqlDataReader
        reader = comando.ExecuteReader()
        reader.Read()
        Dim result As String
        result = reader.GetString(0)
        reader.Close()
        Return result

    End Function





End Class

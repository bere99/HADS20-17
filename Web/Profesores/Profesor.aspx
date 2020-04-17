<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="Web.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 662px">
    <form id="form1" runat="server">
        <div style="height: 443px">
            <asp:HyperLink ID="asignaturas" runat="server">Asignaturas</asp:HyperLink>
            <br />
            <asp:HyperLink ID="tareas" runat="server" NavigateUrl="~/Profesores/TareasProfesor.aspx">Tareas</asp:HyperLink>
            <br />
            <asp:HyperLink ID="Grupos" runat="server">Grupos</asp:HyperLink>
            <br />
            <asp:HyperLink ID="importar" runat="server" NavigateUrl="~/Profesores/Importadora.aspx">Importar v. XMLDocument</asp:HyperLink>
            <br />
            <asp:HyperLink ID="exportar" runat="server" NavigateUrl="~/Profesores/Exportadora.aspx">Exportar</asp:HyperLink>
            <br />
            <asp:HyperLink ID="importar0" runat="server" NavigateUrl="~/Profesores/coordinador.aspx">Consultar medias</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="cerrar" runat="server" Text="Cerrar Sesión" />
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
            <br />
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                Usuarios Logueados:
                <asp:Label ID="alumnos" runat="server" Text="0"></asp:Label>
                    &nbsp;Alumno/s y
                <asp:Label ID="profes" runat="server" Text="0"></asp:Label>
                &nbsp;Profe/s
                    <asp:Timer ID="Timer1" runat="server" Interval="6000" ClientIDMode="AutoID">
                    </asp:Timer>
                    <br />
                    <asp:ListBox ID="ListBoxAlumnos" runat="server"></asp:ListBox>
                    <asp:ListBox ID="ListBoxProfes" runat="server"></asp:ListBox>
                    <br />
                    <br />
                    <br />
                </ContentTemplate>
            </asp:UpdatePanel>
            <br />
        </div>
    </form>
</body>
</html>

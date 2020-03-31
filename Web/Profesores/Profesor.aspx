<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="Web.Profesor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 431px">
    <form id="form1" runat="server">
        <div style="height: 418px">
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
            <br />
            <asp:Button ID="cerrar" runat="server" Text="Cerrar Sesión" />
        </div>
    </form>
</body>
</html>

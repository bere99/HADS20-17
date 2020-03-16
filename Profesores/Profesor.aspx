<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Profesor.aspx.vb" Inherits="Profesores.Profesor" %>

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
            <asp:HyperLink ID="tareas" runat="server">Tareas</asp:HyperLink>
            <br />
            <asp:HyperLink ID="Grupos" runat="server">Grupos</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>

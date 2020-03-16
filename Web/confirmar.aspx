<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Confirmado.aspx.vb" Inherits="Web.Confirmado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Confirmado Correctamente"></asp:Label>
            <br />
            <br />
            <asp:HyperLink ID="irAlogin" runat="server" BorderStyle="None" NavigateUrl="~/Inicio.aspx">Iniciar sesión</asp:HyperLink>
        </div>
    </form>
</body>
</html>

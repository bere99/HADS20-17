<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="Web.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 328px; width: 572px; margin-left: 249px; margin-right: 93px; margin-top: 65px; margin-bottom: 92px;">
            <asp:Label ID="Label1" runat="server" Text="Email:"></asp:Label>
            <br />
            <asp:TextBox ID="email" runat="server" ClientIDMode="AutoID"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Email" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="Email" ErrorMessage="El formato del email no es correcto" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Contraseña:"></asp:Label>
            <br />
            <asp:TextBox ID="password" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            &nbsp;
            <asp:Button ID="loginButton" runat="server" Text="Iniciar sesión" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Registrarse</asp:HyperLink>
&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="CambiarPass" runat="server" NavigateUrl="~/ModifyPass.aspx">Cambiar contraseña</asp:HyperLink>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="conection" runat="server"></asp:Label>
            </div>
    </form>
</body>
</html>


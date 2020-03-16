<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="changePass.aspx.vb" Inherits="Web.changePass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            CAMBIAR CONTRASEÑA<br />
            <br />
            Nueva contraseña:<br />
            <asp:TextBox ID="pass" runat="server" Width="233px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="pass" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Repite la contraseña:<br />
            <asp:TextBox ID="repass" runat="server" Width="236px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="repass" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="confirm" runat="server" Text="Confirmar" />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

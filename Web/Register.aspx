<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Register.aspx.vb" Inherits="Web.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text1 {
            text-align: center;
            width: 479px;
        }
        #Text2 {
            width: 479px;
            text-align: center;
        }
        #Text3 {
            width: 478px;
            text-align: center;
        }
        #Text4 {
            width: 478px;
            text-align: center;
        }
        #Text5 {
            width: 481px;
            text-align: center;
        }
        #email {
            width: 330px;
            text-align: center;
        }
        #nombre {
            text-align: center;
        }
        #apellidos {
            width: 330px;
            text-align: center;
        }
        #pass {
            width: 330px;
            text-align: center;
        }
        #repass {
            width: 330px;
            text-align: center;
        }
        #Button1 {
            width: 165px;
        }
        #botonregistrar {
            width: 166px;
        }
        #register {
            width: 136px;
        }
    </style>
</head>
<body style="width: 535px; height: 549px">
    <form id="form1" runat="server">
        <div style="height: 540px; width: 524px">
            <asp:Label ID="Label1" runat="server" Font-Names="Arial Black" Font-Size="X-Large" style="text-align: center" Text="Registro de usuarios"></asp:Label>
            <br />
            <br />
            Tu Email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server" TextMode="Email" Width="311px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="email" ErrorMessage="*" ForeColor="#CC0000" InitialValue=" "></asp:RequiredFieldValidator>
            <br />
            <br />
            Tu nombre:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="nombre" runat="server" Width="312px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="nombre" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Tus apellidos:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="apellidos" runat="server" Width="316px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="apellidos" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="pass" runat="server" TextMode="Password" Width="315px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" BorderColor="#CC0000" ControlToValidate="pass" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <br />
            Contraseña:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="repass" runat="server" TextMode="Password" Width="318px"></asp:TextBox>
&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="repass" ErrorMessage="*" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pass" ControlToValidate="repass" ErrorMessage="Las contraseñas no coinciden." ForeColor="#CC0000"></asp:CompareValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Tu rol:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;
            <br />
            <asp:DropDownList ID="rol" runat="server" Width="171px">
                <asp:ListItem>Alumno</asp:ListItem>
                <asp:ListItem>Profesor</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="registrar" runat="server" Text="Registrar" Width="165px" />
            <br />
            <asp:Label ID="Label3" runat="server" ForeColor="#CC0000"></asp:Label>
            <br />
            <asp:HyperLink ID="Atras" runat="server" NavigateUrl="~/Inicio.aspx">Atrás</asp:HyperLink>
        </div>
    </form>
</body>
</html>

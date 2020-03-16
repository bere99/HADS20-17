<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ModifyPass.aspx.vb" Inherits="Web.ModificarPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #Text1 {
            width: 325px;
        }
        #Text2 {
            width: 325px;
        }
        #Text3 {
            width: 325px;
            text-align: center;
        }
        #Button1 {
            width: 328px;
            height: 28px;
        }
        #Submit1 {
            width: 325px;
            height: 29px;
        }
        #Submit2 {
            width: 325px;
            height: 28px;
        }
        #Submit2 {
            width: 325px;
            height: 29px;
            text-align: center;
        }
        #Text4 {
            width: 325px;
            text-align: center;
        }
        #Submit2 {
            width: 325px;
            height: 29px;
        }
        #email {
            width: 325px;
        }
        #changepass {
            width: 323px;
        }
        #ibi {
            height: 248px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 542px; height: 740px" id="errores">
            <asp:Label ID="Label2" runat="server" Font-Names="Arial Black" Font-Size="X-Large" style="text-align: center" Text="Cambiar contraseña"></asp:Label>
            <br />
            <br />
            Tu email:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server" Width="325px"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="RequestChangePass" runat="server" Text="Solicitar cambio de contraseña" Width="326px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            Código:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="codpass" runat="server" style="text-align: center" TextMode="Number" Width="324px" Enabled="False"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="codpass" ErrorMessage="*" ForeColor="Red" Enabled="False"></asp:RequiredFieldValidator>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="changePass" runat="server" Height="28px" Text="Cambiar contraseña" Width="320px" Enabled="False" style="margin-bottom: 0px" />
            <br />
            <br />
            <br />

    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CAMBIAR CONTRASEÑA<br />
                <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Nueva contraseña:<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="pass" runat="server" Width="268px" Enabled="False" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NewPass" runat="server" ControlToValidate="pass" ErrorMessage="*" ForeColor="#CC0000" Enabled="False"></asp:RequiredFieldValidator>
                <br />
                <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Repite la contraseña:<br />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="repass" runat="server" Width="267px" Enabled="False" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="NewRePass" runat="server" ControlToValidate="repass" ErrorMessage="*" ForeColor="#CC0000" Enabled="False"></asp:RequiredFieldValidator>
                <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="confirm" runat="server" Text="Confirmar" Enabled="False" />
                <br />
                &nbsp;
            <asp:HyperLink ID="Atras" runat="server" NavigateUrl="~/Inicio.aspx">Atras</asp:HyperLink>
            <br />            
            <asp:Label ID="prueba" runat="server" Text=" "></asp:Label>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="pass" ControlToValidate="repass" ErrorMessage="Las contraseñas no coinciden." ForeColor="#CC0000"></asp:CompareValidator>
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

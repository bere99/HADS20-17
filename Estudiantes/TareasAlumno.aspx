<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="TareasAlumno.aspx.vb" Inherits="Estudiantes.TareasAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; ALUMNOS<br />
            GESTIÓN DE TAREAS GENÉRICAS&nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Button ID="Button2" runat="server" Height="27px" Text="Cerrar Sesión" Width="173px" />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList" runat="server" AutoPostBack="True">
            </asp:DropDownList>
            <asp:GridView ID="GridView" runat="server">
                <Columns>
                    <asp:CommandField ButtonType="Button" HeaderText="Instanciar" ShowHeader="True" ShowSelectButton="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

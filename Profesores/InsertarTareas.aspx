<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InsertarTareas.aspx.vb" Inherits="Profesores.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 576px">
            <br />
            Codigo:<br />
            <asp:TextBox ID="codigo" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="codigo" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Descripción:<br />
            <asp:TextBox ID="descripcion" runat="server" TextMode="MultiLine"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="descripcion" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Asignatura:<br />
            <asp:DropDownList ID="DropDownList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="Select * from ProfesoresGrupo inner join GruposClase on ProfesoresGrupo.codigogrupo=GruposClase.codigo where email=@email">
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="email" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            Horas Estimadas:<br />
            <asp:TextBox ID="horas" runat="server" TextMode="Number"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="horas" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <br />
            Tipo Tarea:<br />
            <asp:DropDownList ID="DropDownList1" runat="server" Height="20px" Width="131px">
                <asp:ListItem>Laboratorio</asp:ListItem>
                <asp:ListItem>Ejercicio</asp:ListItem>
                <asp:ListItem>Examen</asp:ListItem>
                <asp:ListItem>Informe</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="addTarea" runat="server" Text="Añadir Tarea" />
            <br />
            <asp:Label ID="ibi" runat="server"></asp:Label>
            <br />
            <asp:HyperLink ID="VerTareas" runat="server" NavigateUrl="~/TareasProfesor.aspx">Ver Tareas</asp:HyperLink>
        </div>
    </form>
</body>
</html>

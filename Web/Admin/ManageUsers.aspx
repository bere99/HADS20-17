<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="ManageUsers.aspx.vb" Inherits="Web.ManageUsers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 537px">
    <form id="form1" runat="server">
        <div style="height: 339px">
            <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="email" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" />
                    <asp:BoundField DataField="email" HeaderText="email" ReadOnly="True" SortExpression="email" />
                    <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
                    <asp:BoundField DataField="nombre" HeaderText="nombre" SortExpression="nombre" />
                    <asp:BoundField DataField="pass" HeaderText="pass" SortExpression="pass" />
                    <asp:BoundField DataField="tipo" HeaderText="tipo" SortExpression="tipo" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" DeleteCommand="DELETE FROM [Usuarios] WHERE [email] = @email" InsertCommand="INSERT INTO [Usuarios] ([email], [apellidos], [nombre], [pass], [tipo]) VALUES (@email, @apellidos, @nombre, @pass, @tipo)" SelectCommand="SELECT [email], [apellidos], [nombre], [pass], [tipo] FROM [Usuarios] WHERE ([email] &lt;&gt; @email)" UpdateCommand="UPDATE [Usuarios] SET [apellidos] = @apellidos, [nombre] = @nombre, [pass] = @pass, [tipo] = @tipo WHERE [email] = @email">
                <DeleteParameters>
                    <asp:Parameter Name="email" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="email" Type="String" />
                    <asp:Parameter Name="apellidos" Type="String" />
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="pass" Type="String" />
                    <asp:Parameter Name="tipo" Type="String" />
                </InsertParameters>
                <SelectParameters>
                    <asp:Parameter DefaultValue="admin@ehu.es" Name="email" Type="String" />
                </SelectParameters>
                <UpdateParameters>
                    <asp:Parameter Name="apellidos" Type="String" />
                    <asp:Parameter Name="nombre" Type="String" />
                    <asp:Parameter Name="pass" Type="String" />
                    <asp:Parameter Name="tipo" Type="String" />
                    <asp:Parameter Name="email" Type="String" />
                </UpdateParameters>
            </asp:SqlDataSource>
            <asp:Button ID="CerrarSesion" runat="server" Text="Cerrar Sesión" />
        </div>
    </form>
</body>
</html>

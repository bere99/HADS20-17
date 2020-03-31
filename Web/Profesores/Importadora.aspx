<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Importadora.aspx.vb" Inherits="Web.Importadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body style="height: 702px">
    <form id="form1" runat="server">
        <div id="m" style="height: 694px">
            PROFESOR IMPORTAR TAREAS GENÉRICAS<br />
            <br />
            Seleccionar Asignatura a Importar:<br />
            <br />
            <asp:DropDownList ID="DropDownList" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="codigoasig" DataValueField="codigoasig">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:AmigosConnectionString %>" SelectCommand="Select * from ProfesoresGrupo inner join GruposClase on ProfesoresGrupo.codigogrupo=GruposClase.codigo where email=@email">
                <SelectParameters>
                    <asp:SessionParameter Name="email" SessionField="email" />
                </SelectParameters>
            </asp:SqlDataSource>
            <br />
            <br />
            Lista de tareas de la asignatura selecionada<br />
            <asp:Xml ID="Xml" runat="server"></asp:Xml>
            <br />
            <br />
            <asp:Button ID="importar" runat="server" Height="51px" Text="IMPORTAR (XMLD)" />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="menu" runat="server" NavigateUrl="~/Profesores/Profesor.aspx">Atrás</asp:HyperLink>
            <br />
            <asp:Label ID="ibi" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

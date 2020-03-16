<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="InstanciarTarea.aspx.vb" Inherits="Estudiantes.InstanciarTarea" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            ALUMNOS INSTANCIAR TAREA GENÉRICA<br />
            Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="email" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            Tarea&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tarea" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            Horas Est.&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="horas" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            Horas Reales&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="reales" runat="server" TextMode="Number"></asp:TextBox>
            <br />
            <asp:Button ID="crearTarea" runat="server" Text="Crear Tarea" />
            <br />
            <asp:GridView ID="GridView" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
            <asp:Label ID="ibi" runat="server" ForeColor="Black"></asp:Label>
            <br />
            <asp:HyperLink ID="paganterior" runat="server" NavigateUrl="~/TareasAlumno.aspx">Página anterior</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>

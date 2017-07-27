<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewPageOne.aspx.cs" Inherits="CompleteGridView.Views.ViewPageOne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div name="Content">
        <asp:Label runat="server" Text="Label">Llenar manualmente</asp:Label>
        <asp:GridView ID="GridView1" runat="server">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id"/>
                <asp:BoundField DataField="Nombre" HeaderText="Nombre"/>
                <asp:BoundField DataField="Apellido" HeaderText="Apellido"/>
            </Columns>
        </asp:GridView>

        <asp:Label ID="Label1" runat="server" Text="Label">Enlazar a una Base de datos </asp:Label>

        <asp:GridView ID="GridView2" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CRUD.aspx.cs" Inherits="CRUDCompleted.Views.CRUD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Codigo"></asp:Label> &nbsp
        <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label> &nbsp
        <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
        <br/>
        <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label> &nbsp
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Ciudad"></asp:Label> &nbsp
        <asp:TextBox ID="txtCiudad" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Fecha"></asp:Label> &nbsp
        <asp:TextBox ID="txtFecha" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insertar" OnClick="btnInsert_Click" /> &nbsp
        <asp:Button ID="btnDelete" runat="server" Text="Eliminar" OnClick="btnDelete_Click" />&nbsp
        <asp:Button ID="btnUpdate" runat="server" Text="Actualizar" OnClick="btnUpdate_Click" />

        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>

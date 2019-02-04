<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WCFTest1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        //$(document).ready(function () {
            $('#btnSearch').click(function () {
                var vId = $('#txtValue').val();
                $.ajax({
                    url: 'ServiceCliente.svc/GetClienteById',
                    method: 'post',
                    contentType: 'application/json;charset-utf-8',
                    data: JSON.stringify({ Id: vId }),
                    dataType: 'json',
                    success: function(data)
                    {
                        $('#txtId').val(data.d.Id);
                        $('#txtName').val(data.d.Name);
                        $('#txtLastName').val(data.d.LastName);
                        $('#txtSexo').val(data.d.Sexo);
                        $('#txtCity').val(data.d.City);
                    },
                    error: function(err)
                    {
                        alert(err);
                    }
                });
            });
        //});
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <label>Search</label>
        <input type="text" id="txtValue" />
        <input type="button" id="btnSearch" value="Get-Client" />
        <div>
            <table>
                <tr>
                    <td>Id</td>
                    <td>Name</td>
                    <td>LastName</td>
                    <td>Sexo</td>
                    <td>City</td>
                </tr>
                <tr>
                    <td>
                        <input type="text" id="txtId" /></td>
                    <td>
                        <input type="text" id="txtName" /></td>
                    <td>
                        <input type="text" id="txtLastName" /></td>
                    <td>
                        <input type="text" id="txtSexo" /></td>
                    <td>
                        <input type="text" id="txtCity" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

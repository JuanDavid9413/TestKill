$(document).ready(function () {
    $("#btnInsert").click(function () {
        ClientScripts.InsertClient();
    });

    $("#btnUpdate").click(function () {
        ClientScripts.UpdateClient();
    });

    $("#btnDelete").click(function () {
        ClientScripts.DeleteClient();
    });

    var infoClient = ClientScripts.GetDataClient();

    $("#TableClient").kendoGrid({
        dataSource: {
            data: infoClient,
            schema: {
                model: {
                    Id: { type: "number" },
                    Name: { type: "string" },
                    LastName: { type: "string" },
                    Age: { type: "number" }
                }
            }
        },
        pageSize: 20,
        height: 250,
        columns: [{
            field: "Id",
            title: "Id",
            width: 20,
            type: "number"
        }, {
            field: "Name",
            title: "Name",
            width: 30,
            type: "string"
        }, {
            field: "LastName",
            title: "LastName",
            width: 30,
            type: "string"
        }, {
            field: "Age",
            title: "Age",
            width: 30,
            type: "number"
        }]
    });
});

class ClientScripts {
    static InsertClient() {
        new ClientRequestScripts();
        ClientRequestScripts.InsertClientRequest(ClientScripts.ModelClientData());
    }

    static UpdateClient() {
        new ClientRequestScripts();
        ClientRequestScripts.UpdateClientRequest(ClientScripts.ModelClientData());
    }

    static DeleteClient() {
        new ClientRequestScripts();
        ClientRequestScripts.DeleteClientRequest(ClientScripts.ModelClientData());
    }

    static GetDataClient() {
        var getData;
        new ClientRequestScripts();
        getData = ClientRequestScripts.GetDataClientRequest();
        return getData.responseJSON;
    }

    static ModelClientData() {
        var dataclient = {
            Id: $("#inputId").val(),
            Name: $("#inputName").val(),
            LastName: $("#inputLastName").val(),
            Age: $("#inputAge").val()
        };
        return dataclient;
    }
}
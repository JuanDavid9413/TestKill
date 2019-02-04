$(document).ready(function () {
    $("#btnInsert").click(function () {
        Client.InsertClient();
    });

    $("#btnUpdate").click(function () {
        Client.UpdateClient();
    });

    $("#btnDelete").click(function () {
        Client.DeleteClient();
    });

    var GridData = Client.GetDataClient();

    $("#GridClient").kendoGrid({
        dataSource: {
            data: GridData,
            schema: {
                model: {
                    fields: {
                        Id: { type: "number" },
                        Name: { type: "string" },
                        LastName: { type: "string" },
                        Age: { type: "number" }
                    }
                }
            }
        },
        pageSize: 20,
        height: 400,
        columns: [{
            field: "Id",
            title: "Id",
            width: 200,
            type: "number"
        }, {
            field: "Name",
            title: "Name",
            width: 200,
            type: "string"
        }, {
            field: "LastName",
            title: "LastName",
            width: 200,
            type: "string"

        }, {
            field: "Age",
            title: "Age",
            width: 200,
            type: "number"
        }]
    });
});

class Client {
    static InsertClient() {
        var ClientModel = Client.ClientMapingModel();
        new ClientRequest();
        ClientRequest.InsertClient(ClientModel).done(function (data) {
            if (data.success) {
                alert("Ingreso Correctamente");
            }
        }).fail(function (data) {
            alert("Ocurrio un error");
        });
    }

    static UpdateClient() {
        new ClientRequest();
        var ClientModel = Client.ClientMapingModel();
        ClientRequest.UpdateClient(ClientModel).done(function (data) {
            if (data.success) {
                alert("Success");
            }
        }).fail(function (data) {
            alert("Error");
        });
    }

    static DeleteClient() {
        new ClientRequest();
        var ClientModel = Client.ClientMapingModel();
        ClientRequest.DeleteClient(ClientModel).done(function (data) {
            if (data.success) {
                alert("Success");
            }
        }).fail(function (data) {
            alert("Error");
        });
    }

    static GetDataClient() {
        new ClientRequest();
        var result = ClientRequest.GetAllClient();
        return result.responseJSON;
        //ClientRequest.GetAllClient().done(function (data) {
        //    if (data.success) {
        //        result = data.result;
        //        return result;
        //    }
        //}).fail(function (data) {
        //    alert("Error");
        //    return result;
        //});
    }

    static ClientMapingModel() {
        var ClientModel = {};
        ClientModel.Id = $("#inputId").val();
        ClientModel.Name = $("#inputName").val();
        ClientModel.LastName = $("#inputLastName").val();
        ClientModel.Age = $("#inputAge").val();

        return ClientModel;
    }
}
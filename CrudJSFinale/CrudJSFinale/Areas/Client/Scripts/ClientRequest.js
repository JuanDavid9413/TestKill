class ClientRequest {

    static InsertClient(clientModel) {
        return $.ajax({
            type: "POST",
            url: "/Client/Client/InsertClient",
            dataType: "json",
            data: JSON.stringify(clientModel),
            contentType: "application/json"
        });
    }

    static UpdateClient(clientModel) {
        return $.ajax({
            type: "POST",
            url: "/Client/Client/UpdateClient",
            data: JSON.stringify({ clientViewModel: clientModel }),
            contentType: "application/json",
            complete: function (data) {
                console.log(data);
            }
        });
    }

    static DeleteClient(clientModel) {
        return $.ajax({
            type: "POST",
            url: "/Client/Client/DeleteClient",
            data: JSON.stringify({ clientViewModel: clientModel }),
            contentType: "application/json"
        });
    }

    static GetAllClient() {
        return $.ajax({
            type: "GET",
            async: false,
            cache: false,
            url: "/Client/Client/GetDataClient",
            dataType : "json",
            contenType: "application/json; charset=utf-8"
        });
    }
}
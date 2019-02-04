class ClientRequestScripts {
    static InsertClientRequest(ClientData) {
        return $.ajax({
            type: "POST",
            url: "/Client/Client/InsertClient",
            data: JSON.stringify({ clientViewModel: ClientData }),
            contentType: "application/json"
        });
    }

    static UpdateClientRequest(ClientData) {
        return $.ajax({
            type: "POST",
            url: "/Client/Client/UpdateClient",
            data: JSON.stringify({ clientViewModel: ClientData}),
            contentType: "application/json"
        });
    }

    static DeleteClientRequest(ClientData) {
        return $.ajax({
            type: "POST",
            url: "/Client/Client/DeleteClient",
            data: JSON.stringify({ clientViewModel: ClientData }),
            contentType: "application/json"
        });
    }

    static GetDataClientRequest() {
        return $.ajax({
            type: "GET",
            async: false,
            cache: false,
            url: "/Client/Client/GetDataClient",
            dataType: "json",
            contentType: "application/json"
        });
    }
}
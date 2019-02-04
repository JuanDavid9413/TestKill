class ClientScriptRequestTest {
    static ClientInsert(clientViewModel) {
        return $.ajax({
            type: "POST",
            url: "/Client/ClientViewInsert",
            data: JSON.stringify({ clientViewModel: clientViewModel }),
            contentType: "application/json"
        });
    }

    static ClientUpdate(clientViewModel) {
        return $.ajax({
            type: "POST",
            url: "/Client/ClientViewUpdate",
            data: JSON.stringify({ clientViewModel: clientViewModel }),
            contentType: "application/json"
        });
    }

    static ClientDelete(Id) {
        return $.ajax({
            type: "POST",
            url: "/Client/ClientViewDelete",
            data: JSON.stringify({ Id: Id }),
            contentType: "application/json"
        });
    }

    static GetClientData() {
        return $.ajax({
            type:"GET",
            url: "/Client/GetDataClient",
            contentType:"application/json"
        });
    }
}
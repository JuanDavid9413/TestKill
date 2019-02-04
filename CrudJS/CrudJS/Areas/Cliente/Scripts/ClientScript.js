$(document).ready(function () {
    debugger
    $("#btnInsert").click(function () {
        ClientScriptPrincipal.ClientInsert();
    });

    $("#btnUpdate").click(function () {
        ClientScriptPrincipal.ClientUpdate();
    });

    $("#btnDelete").click(function () {
        ClientScriptPrincipal.ClientDelete();
    });

    $("#GridTable").jqGrid({
        url: "/Client/GetDataClient",
        type: "GET",
        contentType: "application/json",
        colModel: [
            { label: "Id", name: "Id", width: 100, formatter: "number", formatoptions: { defaultvalue: "No Value Set", thousandsSeparator: ","} },
            { label: "Name", name: "Name", width: 100 },
            { label: "LastName", name: "LastName", width: 100 },
            { label: "Age", name:"Age", width: 100, formatter: "number" }
        ],
        //data: [
        //    { Id: 10, Name: "Angela", LastName: "Merkel", Age: 1 },
        //    { Id: 20, Name: "Vladimir", LastName: "Putin", Age: 2 },
        //    { Id: 30, Name: "David", LastName: "Cameron", Age: 3 },
        //    { Id: 40, Name: "Barack", LastName: "Obama", Age: 4 },
        //    { Id: 50, Name: "François", LastName: "Hollande", Age: 5 }
        //],
        height: 250,
        width: 780
    });

    //ClientScriptPrincipal.GetDataClient();
});

class ClientScriptPrincipal { 
    static ClientInsert() {
        var test = ClientScriptPrincipal.GetModelForm();
        new ClientScriptRequestTest();
        ClientScriptRequestTest.ClientInsert(test);
    }

    static ClientUpdate() {
        var ModelForm = ClientScriptPrincipal.GetModelForm();
        new ClientScriptRequestTest();
        ClientScriptRequestTest.ClientUpdate(ModelForm);
    }

    static ClientDelete() {
        new ClientScriptRequestTest();
        ClientScriptRequestTest.ClientDelete(parseInt($("#inputId").val()));
    }

    static GetDataClient() {
        new ClientScriptRequestTest();
        ClientScriptRequestTest.GetClientData().done(function (data) {
            if (data.success) {
                $("se lleno la pinche grilla");
            }
        }).fail(function (data) {
            alert("Se revento todo");
        });
    }

    static GetModelForm() {
        var ModelForm = {};
            ModelForm.Id = $("#inputId").val();
            ModelForm.Name = $("#inputName").val();
            ModelForm.LastName = $("#inputLastName").val();
            ModelForm.Age = $("#inputAge").val();
        return ModelForm;
    }
}
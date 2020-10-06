
function Edit(id) {

    $.ajax({
        url: '/Anuncio/Edit/' + id,
        type: 'POST',
        data: { id: id},
        success: function (result) {
            var url = '/Anuncio/Edit/' + id;
            debugger;
            if (!result.Success) {
                swal(result.Response, "", "error");
                return false;
            }
            else {
                window.location = url;
            }
        }
    });
};







function EditarAnuncioSave() {

    var returnInfo = pegaDadosReturn();

    $.ajax({
        url: '/Anuncio/Edit',
        type: 'POST',
        data: { model: returnInfo},
        async: false,
        cache: false,
        contentType: false,
        enctype: 'multipart/form-data',
        processData: false,
        success: function (result) {
            var url = '/Anuncio/EditAnuncio';
            debugger;
            if (!result.Success) {
                swal(result.Response, "", "error");
                return false;
            }
            else {
                window.location = url;
            }
        }
    });
};

function pegaDadosReturn() {
    var returnDados;
    returnDados = {
        'id': $('#id').val(),
        'descricao': $('#descricao').val(),
        'preco': $('#preco').val(),
        'medida': $('#medida').val()
    };

    return returnDados;
}
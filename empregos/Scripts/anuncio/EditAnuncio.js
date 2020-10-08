

function Edit(id) {
    var url = '/Anuncio/Edit/' + id;
    window.location = url;
    $.ajax({
        url: '/Anuncio/Edit/' + id,
        type: 'POST',
        data: { id: id},
        success: function (result) {
           
            debugger;
            if (!result.Success) {
                swal(result.Response, "", "error");
                return false;
            }
            else {
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

// editar
function editarAnun() {
    /// <summary>
    /// </summary>
    var model = pegaDadosReturnEditar();
    var msg = "Deseja realmente editar este anuncio?";
    swal({
        title: msg,
        text: "",
        icon: "warning",
        buttons: ["Não", "Sim"],
        dangerMode: true,
    })
        .then(
            (willAdd) => {

                if (!willAdd) {
                    return;
                }
                else {

                    $.ajax({
                        url: '/Anuncio/EditarAnuncioEscolhido',
                        type: 'POST',
                        data: { anuncio : model},
                        success: function (result) {
                            var url = '/Anuncio/EditAnuncio';

                            if (!result.Success) {
                                swal(result.Response, "", "error");
                                return false;
                            }
                            else {
                                swal("Anuncio editado com sucesso.", "", "success")
                                    .then(() => {
                                        window.location = url;
                                    });
                            }
                        }
                    });
                }
            });

};

function pegaDadosReturnEditar() {
    var returnDados;
    returnDados = {
        'id': $('#id').val(),
        'descricao': $('#descricao').val(),
        'preco': $('#preco').val(),
        'medida': $('#medida').val(),
        'foto1': $('#foto1').val()
    };

    return returnDados;
}

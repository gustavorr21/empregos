// cadastrar FIR
$(function () {
    /// <summary>
    /// função que detecta o post do formulario e realiza a gravação de um registro FIR.
    /// </summary>
    $('form').submit(function () {

        if ($(this).valid()) {

            $.ajax({
                url: '/Login/CreateUsuario',
                type: 'POST',
                data: $(this).serialize(),
                success: function (result) {
                    var url = '/Login/login';
                    debugger;
                    if (!result.Success) {
                        swal(result.Response, "", "error");
                        return false;
                    }
                    else {
                        swal("Usuario cadastrado com sucesso.", "", "success")
                            .then(function () {
                                window.location = url;
                            });
                    }
                }
            });
        }
        return false;
    });
});





function loginteste() {
    var login = $("#login").val();
    var senhalogin = $("#senha").val();


    if (DadosLoginObrigatorio(login, senhalogin)) {
        $.ajax({
            url: '/Login/login',
            type: 'POST',
            data: { login: login, senhalogin: senhalogin },
            success: function (result) {
                debugger;
                if (result.nomeLogin == "aa") {

                }
                if (!result.Success) {
                    window.open('Home', 'Home');
                }
                else {
                    window.open('Home', 'Home');
                }
            }
        });
    } else {
        document.getElementById("senhaincorreta").display = none;
    }
};

function DadosLoginObrigatorio(login, senhalogin) {
    if (login == null || senhalogin == null || login == "" || senhalogin == "") {
        return false;
    }
    return true;
};





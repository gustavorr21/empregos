function loginteste() {
    var login = $("#login").val();
    var senhalogin = $("#senha").val();


    if (DadosLoginObrigatorio(login, senhalogin)) {
        $.ajax({
            url: '/Login/login',
            type: 'POST',
            data: { login: login, senhalogin: senhalogin },
            success: function (result) {
                if (!result.Success) {
                    document.getElementById("nomeLogin").style.visibility = "visible";
                    document.getElementById("nomeLogin").innerHTML = 'login inexistente';
                }
                else {
                    document.getElementById("nomeLogin").style.visibility = "visible";
                    document.getElementById("nomeLogin").innerHTML = 'Seja Bem Vindo ' + result.nomeLogin;
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



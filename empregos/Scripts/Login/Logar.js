// logar
$(function () {
    /// <summary>
    /// </summary>
    $('form').submit(function () {

        if ($(this).valid()) {

            $.ajax({
                url: '/Login/login',
                type: 'POST',
                data: $(this).serialize(),
                success: function (result) {
                    var url = '/Home/Home';
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
        }
        return false;
    });
});

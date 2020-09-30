$("form").submit(function (evt) {
    evt.preventDefault();
    var formData = new FormData($(this)[0]);
    $.ajax({
        url: '/Anuncio/CreateAnuncio',
        type: 'POST',
        data: formData,
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
    return false;
});

//// cadastrar
//$(function () {
//    /// <summary>
//    /// </summary>
//    $('form').submit(function () {
//        event.preventDefault();
//        if ($(this).valid()) {
//            var foto1 = $("#foto1").val();
//            $.ajax({
//                url: '/Anuncio/CreateAnuncio',
//                type: 'POST',
//                data: new FormData(this),
//                processData: false,
//                contentType: false,
//                success: function (result) {
//                    var url = '/Anuncio/EditAnuncio';
//                    debugger;
//                    if (!result.Success) {
//                        swal(result.Response, "", "error");
//                        return false;
//                    }
//                    else {
//                        window.location = url;
//                    }
//                }
//            });
//        }
//        return false;
//    });
//});

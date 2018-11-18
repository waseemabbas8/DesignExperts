// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// ajax form events
onBegin = function (res) {
    $('#btn-save').attr('disabled', true);
    $('body').loader('show');
}
onSuccess = function (res) {
    $('#btn-save').attr('disabled', false);
    $('body').loader('hide');

    var titl, txt, typ;
    if (res === "CRUD Success") {
        titl = "Saved!";
        txt = "New client saved successfully";
        typ = "success";
    } else {
        titl = "Error!";
        txt = "Error while processing your request";
        typ = "warning";
    }
    swal({
        title: titl,
        text: txt,
        type: typ,
        buttonsStyling: false,
        confirmButtonClass: 'btn btn-sm btn-light',
        background: 'rgba(0, 0, 0, 0.96)'
    });
}

//calander
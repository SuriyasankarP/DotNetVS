// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(function () {
    var PopUp = $("#PopUp");
    $('button[data-toggle="ajax-modal"]').click(function (event) {
        var url = $(this).data('url');
        var decodedUrl = decodeURIComponent(url)
        $.get(decodedUrl).done(function (data) {
            PopUp.html(data);
            PopUp.find('.modal').modal('show');
        })
    })

    PopUp.on('click', '[data-save="modal"]', function (event) {
        var form = $(this).parents('.modal').find('form');
        var actionUrl = form.attr('action');
        var sendData = form.serialize();
        $.post(actionUrl,sendData).done(function (data) {
            PopUp.find('.modal').modal('hide');
            location.reload(true);
        })
    })

})
$(function () {
    $('.btn').on('click', function () {
        var url = $(this).data('url');
        $.get("/home/renderUrl", { url: url }, function (data) {
            $('div').html(data);
        })
    })
})

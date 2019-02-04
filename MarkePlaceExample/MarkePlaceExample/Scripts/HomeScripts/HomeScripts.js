$(document).ready(function () {
    $('#btnSiguiente').click(function () {
        $('#Slider').find('.ElementSlider').each(
            function (index, value) {
                if ($(value).hasClass('.ElementVisible'))
                {
                    $(value).slideUp();
                }
        });
    });
    $('#btnAnterior').click(function () {

    });
});
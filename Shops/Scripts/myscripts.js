$(function () {
    //datetime-picker
    $('.date').datetimepicker({
        format: 'LT'
    });
    //
    $('[data-browse-shopid]').on('click', function () {
        var shopName = $(this).attr('data-shopname');
        var shopId = $(this).attr('data-browse-shopid');
        $.ajax({
            type: 'POST',
            url: '/Products/GetShopProducts',
            data: { 'id': shopId },
            success: function (data) {
                $("#myModalLabel").html(shopName);
                $(".modal-body").html(data);
                $('#myModal').modal();

            }
        });



    });
    $('[data-addproduct-shopid]').on('click', function () {
        var shopId = $(this).attr('data-addproduct-shopid');
        window.location.replace("/Products/AddProduct/" + shopId);
    });
    $('#addNewShop').on('click', function () {
        window.location.replace("/Shops/AddNewShop");
    });
});
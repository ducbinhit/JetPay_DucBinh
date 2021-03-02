$(document).ready(function () {
    new ConfirmJS();
})
class ConfirmJS {
    constructor() {
        this.initEvent();
        this.initInforOrder();
    }

    initEvent() {
        let me = this;
    }
    /**
* Lấy thông tin đơn hàng
* CreatedBy: NDBINH (22/02/2021)
* */
    initInforOrder() {
        var tongTien = GetParameterValues('amount');
        var orderId = GetParameterValues('orderId');
        var result = GetParameterValues('payment_processing');
        if (result != "SUCCESS") {
            let imgUrl = "url('../../../image/failure-payment.png')";
            $('.img').css("background-image", imgUrl)
            $('.info').addClass("info-failure");
            $('.orderResult').text("Thanh toán không thành công");
            $('.info-order p').text("Giao dịch không thành công vì Failed. Bấm quay về trang chủ để tiếp tục mua sắm. Sendo rất hân hạnh phục vụ bạn");
            $('.button-order').empty();
            $('.button-order').append(`<button id="continue">Quay về trang chủ</button>`);
        }
        $('#orderId').text(orderId);
        $('#amount').text(tongTien + " VND");
    }
}
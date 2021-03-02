﻿$(document).ready(function () {
    // Khởi tạo đối tượng cổng thanh toán
    new NapasResultJS();
    marqueeInit({
        uniqueid: 'bankscroll',
        style: {
            'padding': '2px',
            'width': '790px',
            'height': '36px'
        },
        inc: 1,
        mouse: 'cursor driven', //mouseover behavior ('pause' 'cursor driven' or false)
        moveatleast: 1,
        neutral: 150,
        savedirection: true,
        random: false
    });
})

/**===========================================
 * Class quản lý sự kiện cho trang gateway
 * CreatedBy: NDBINH (19/01/2021)
 * */
class NapasResultJS {
    constructor() {
        this.initInforOrder();
        this.initEventsOfGateway();
    }

    /**
     * Khởi tạo sự kiện của trang cổng thanh toán
     * CreatedBy: NDBINH (19/02/2021)
     * */
    initEventsOfGateway() {
        let thisInIt = this;
        // Kiểm tra giá trị input bắt buộc nhập
        $('input[required]').blur(function () {
            thisInIt.eventsValidateRequiredWhenInputBlur(this);
        })

        // Thực hiện thanh toán khi nhấn nút thanh toán
        $('#g-btn-pay').click(this.eventWhenClickButtonPay.bind(thisInIt));

        // Tự động chuyển trang sau 3s
        this.evenAutoNextPage();
    }

    /**
     * Kiểm tra trường bắt buộc nhập
     * @param {any} seft đại diện cho đối tượng input, select
     * CreatedBy: NDBINH (21/02/2021)
     */
    eventsValidateRequiredWhenInputBlur(seft) {
        let inScope = seft;
        let value = $(inScope).val();
        if (!value) {
            $(inScope).addClass('border-red');
            $(inScope).attr('title', `${$(inScope).attr('name')} không được để trống`);
            $(inScope).attr('validated', false);
        }
        else {
            $(inScope).removeClass('border-red');
            $(inScope).attr('validated', true);
        }
    }

    /**
     * Thực hiện thanh toán
     * CreatedBy: NDBINH (21/02/2021)
     * */
    eventWhenClickButtonPay() {
        let thisHere = this;
        $('.error-message').text('');
        // validate dữ liệu
        let inputValidates = $('input[required]');
        $.each(inputValidates, function (index, input) {
            $(input).trigger('blur');
        })
        // Lấy các thẻ input có thuộc tính validated = false
        let inputNotValidates = $('input[validated = "false"]');
        if (inputNotValidates && inputNotValidates.length > 0) {
            // Thông báo không hợp lệ dữ liệu
            $('.error-message').append(`<img style="margin-right:6px; margin-top:2px;" src="/content/icon/error_icon.gif" />
                            <div>Qúy khách vui lòng nhập đầy đủ thông tin.</div>`);
            inputNotValidates[0].focus();
            return;
        }
        else {
            var codeOTP = '0000';
            var codeCaptcha = 'UAE';
            if ($('#txtMaOTP').val() == codeOTP) {
                if ($('#txtMaCaptcha').val() == codeCaptcha) {
                    $('#g-btn-pay a').attr('href', 'success.html');
                }
                else {
                    $('.error-message').append(`<img style="margin-right:6px; margin-top:2px;" src="/content/icon/error_icon.gif" />
                            <div>Qúy khách vui lòng nhập chính xác chuỗi ký tự hiển thị bên dưới.</div>`);
                }
            }
            else {
                $('.error-message').append(`<img style="margin-right:6px; margin-top:2px;" src="/content/icon/error_icon.gif" />
                            <div>Qúy khách nhập sai mật khẩu OTP, vui lòng nhập lại.</div>`);
            }
        }
    }

    /**
     * Sự kiện tự động chuyển trang sau khi trang load xong
     * CreatedBy: NDBINH (01/03/2021)*/
    evenAutoNextPage() {
        let orderId = $('#txtDonHang').val();
        let amount = $('#txtGiaTriDonHang').val();
        var tongtien = amount.split(" ", 1);
        var result = $('#orderResult').text();
        var merchantId = $('#merchantId').text();
        setTimeout(function () {
            window.location = window.location.protocol +
                '//' + window.location.hostname + ':5001' + `/home/confirm?orderId=${orderId}&payment_processing=${result}&merchantId=${merchantId}&amount=${tongtien}`;
        }, 4000);
    }
    /**
    * Lấy thông tin đơn hàng
    * CreatedBy: NDBINH (22/02/2021)
    * */
    initInforOrder() {
        var tongTien = GetParameterValues('amount');
        var orderId = GetParameterValues('orderId');
        $('#txtDonHang').val(orderId);
        $('#txtGiaTriDonHang').val(tongTien + ' VND');
    }
}
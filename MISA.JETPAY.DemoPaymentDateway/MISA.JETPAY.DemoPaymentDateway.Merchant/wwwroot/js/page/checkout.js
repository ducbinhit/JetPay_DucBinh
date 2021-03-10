$(document).ready(function () {
    new CheckOutJS();
})
class CheckOutJS {
    constructor() {
        this.initEvent();
    }

    initEvent() {
        let me = this;
        let nameBank = "";
        $(".payment-list").on("click", "li", function () {
            $(this).parent('ul').find('li div').removeClass('border-red');
            $(this).find("div").addClass('border-red');
            // Lấy tên của ngân hàng
            nameBank = $(this).find("div").attr("id");
        })

        // Kiểm tra giá trị input bắt buộc nhập
        $('input[required]').blur(function () {
            me.eventsValidateRequiredWhenInputBlur(this);
        })
        // Thực hiện thanh toán khi nhấn nút thanh toán thẻ quốc tế
        $('#g-btn-pay').click(this.eventWhenClickButtonPay.bind(me));

        // click thanh toán
        $(".btn-access").click(function () {
            $(".payment").css("display", "none");
            $('.option-bank').show();
            $("#nameBank").text(nameBank);
        })
        // sự kiện click đống popup chọn ngân hàng
        $("#btn-close").click(function () {
            $(".payment").css("display", "none");
        })
        // sự kiện click đóng popup thanh toán qua thẻ quốc tế
        $('#btn-close-national').click(function () {
            $('.national').css("display", "none");
        })
        // hiển thị ngân hàng được chọn
        $('#ecom-payment').click(function () {
            $(".payment").show();
            /* $('#dialog').hide();*/
        })
        // hiển thị pop up điền thông tin ngân hàng quốc tế
        $('#paymentNational').click(function () {
            $('.national').show();
            $('#txtSoThe').focus();
        })
        // thay  đổi ngân hàng thanh toán
        $('#ecom-paymentChange').click(function () {
            $(".payment").show();
        })

        //Kiểm tra giá trị phương thức thanh toán
        var value = "";
        $('.panel-content input').on('change', function () {
            value = $('input[name=paymentMethod]:checked').val();
        });
        // thực hiện thanh toán khi click vao button thanh toán
        $('.btn-pay').click(function () {
            // Nếu phương thức thanh toán là JetPay thì thực hiện thanh toán :))
            if (value == "JetPay") {
                me.evenWhenClickButtonPay();
            }

        });

        $('#txtMaHoaDon').val(autoGenCode());


        /*let tongtien = $('#txtTongTien').val();
        let nameBank = $('#nameBank').text();*/


    }
    /*
     * Hàm chuyển thông tin dữ liệu sang cổng thanh toán
     * createby : vhduong(24/2/2021)
     * *
     */
    evenWhenClickButtonPay() {
        let tongtien = $('#txtTongTien').val();
        let nameBank = $('#nameBank').text();
        let maHoaDon = $('#txtMaHoaDon').val();
        // $('.btn-pay button').attr('href', `home/gateway?tongtien=${tongtien}&bank=${nameBank}`);

        window.location = window.location.protocol +
            '//' + window.location.hostname + ':44322' + `/home/gateway?merchantId="APITEST"&orderId=${maHoaDon}&amount=${tongtien}`;

    }
    /**
    * Kiểm tra trường bắt buộc nhập
    * @param {any} seft đại diện cho đối tượng input, select
    * CreatedBy: NDBINH (10/03/2021)
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
     * CreatedBy: NDBINH (10/03/2021)
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
            //$('.error-message').append(`<img style="margin-right:6px; margin-top:2px;" src="/content/icon/error_icon.gif" />
            //                <div>Qúy khách vui lòng nhập đầy đủ thông tin.</div>`);
            inputNotValidates[0].focus();
            return;
        }
    }
}
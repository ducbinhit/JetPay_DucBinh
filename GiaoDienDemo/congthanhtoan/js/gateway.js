$(document).ready(function () {
    // Khởi tạo đối tượng cổng thanh toán
    new GatewayJS();
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
class GatewayJS {
    constructor() {
        this.initInforOrder();
        this.initCardYear();
        this.initCardMonth();
        this.showAtmCardName();
        this.showAtmCardNumber();
        this.showAtmCardExp();
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
    }

    /**
     * Khởi tạo giá trị cho combobox năm
     * CreatedBy: NDBINH (19/02/2021)
     * */
    initCardYear() {
        let cardYear = $("#cardYear");
        cardYear.empty();
        for (var i = 0; i < 100; i++) {
            if (i < 10)
                cardYear.append(`<option value ='0${i}'>0${i}</option>`);
            else
                cardYear.append(`<option value ='${i}'>${i}</option>`)
        }
    }

    /**
     * Khởi tạo giá trị cho combobox tháng
     * CreatedBy: NDBINH (19/02/2021)
     * */
    initCardMonth() {
        let cardMonth = $("#cardMonth");
        cardMonth.empty();
        for (var i = 0; i < 13; i++) {
            if (i < 10)
                cardMonth.append(`<option value='0${i}'>0${i}</option>`)
            else
                cardMonth.append(`<option value='${i}'>${i}</option>`)
        }
    }
    /**
     * Sự kiện khi focus vào thẻ nhập tên chủ thẻ
     * CreatedBy: NDBINH (21/02/2021)
     * */
    showAtmCardName() {
        var cardName = $('#txtTenChuThe');
        cardName.focus(function () {
            $('#imgCardLogo').attr('src','/content/img/cardName.jpg')
            $('.logo-desc').text('Vui lòng gõ tiếng Việt không dấu, chữ hoa hoặc chữ thường: "Nguyen Van A".');
        });
    }

    /**
     * Sự kiện khi focus vào thẻ nhập số thẻ
     * CreatedBy: NDBINH (21/02/2021)
     * */
    showAtmCardNumber() {
        var cardNumber = $('#txtSoThe');
        cardNumber.focus(function () {
            $('#imgCardLogo').attr('src', '/content/img/cardNumber.jpg');
            $('.logo-desc').text('Nhập số thẻ liên tục, không sử dụng dấu cách: "9704360000000000056".');
        });
    }

    /**
     * Sự kiện khi focus vào thẻ tháng/năm
     * CreatedBy: NDBINH (21/02/2021)
     * */
    showAtmCardExp() {
        var cardExpDate = $('.cardExpDate');
        cardExpDate.focus(function () {
            $('#imgCardLogo').attr('src', '/content/img/cardExpdate.jpg');
            $('.logo-desc').text('Chọn thông tin tháng/năm phát hành hoặc hết hạn in trên mặt trước của thẻ: "04/11".');
        });
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
            $('#g-btn-pay a').attr('href', 'verify.html');
        }
    }

    initInforOrder() {
        var name = GetParameterValues('tongtien');
        function GetParameterValues(param) {
            var url = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < url.length; i++) {
                var urlparam = url[i].split('=');
                if (urlparam[0] == param) {
                    return urlparam[1];
                }
            }
        }
        $('#txtGiaTriDonHang').val(name);
    }
}
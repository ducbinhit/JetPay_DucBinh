/**
 * Hàm thay đổi trạng thái của class
 * CreateBy: BVHA (9/3/2021)
 */
$(".left").on('focus', 'input[name]', function () {
    var valueOfAttr = $(this).attr("name");
    var classInput = "rccs__" + valueOfAttr;
    $('.' + classInput).toggleClass('rccs--focused').siblings().removeClass('rccs--focused');
})

/**
 * Hàm sét giá trị của input sang thẻ ATM
 * CreateBy: BVHA (9/3/2021)
 */
$(".left").on('keydown keyup', 'input[name]', function () {
    var valueOfAttr = $(this).attr("name");
    var defaultLengthAttr = defaultLength(valueOfAttr);

    // Xét maxLength của thẻ input
    $(this).attr('maxLength', defaultLengthAttr);
    var classInput = "rccs__" + valueOfAttr;

    var value = $(this).val().length;
    if (value <= defaultLengthAttr) {
        if (valueOfAttr === 'number') {
            console.log($(this).val());
            if (value == 4 || value == 9 || value == 14) {
                $(this).val($(this).val() + ' ');
            } else {
                $('.' + classInput + '__value').text($(this).val());
            }
        }

        if (valueOfAttr === 'expiry') {
            if (value == 2) {
                $(this).val($(this).val() + '/');
            } else {
                $('.' + classInput + '__value').text($(this).val());
            }
        } else {
            $('.' + classInput).text($(this).val());
        }
    }
})

/**
 * Hàm thêm class vào input có name=cvc
 * CreateBy: BVHA (9/3/2021)
 */
$("input[name='cvc']").click(function () {
    $('.rccs__card').addClass('rccs__card--flipped');
})

/**
 * Hàm xóa class những input không có name=cvc
 * CreateBy: BVHA (9/3/2021)
 */
$("input[name!='cvc']").click(function () {
    $('.rccs__card').removeClass('rccs__card--flipped');
})


/**
 * Hàm xét độ dài tối đa
 * @param {string} nameAttr 
 * CreateBy: BVHA (9/3/2021)
 */
function defaultLength(nameAttr) {
    let value;
    switch (nameAttr) {
        case 'number':
            value = 19;
            break;
        case 'name':
            value = 25;
            break;
        case 'expiry':
            value = 5;
            break;
        case 'cvc':
            value = 3;
            break;
    }
    return value;
}
// rccs__card--front
// rccs__card--back

$(".left").on('click', 'input[name]', function () {
    var valueOfAttr = $(this).attr("name");
    var classInput = "rccs__" + valueOfAttr;
    $('.' + classInput).toggleClass('rccs--focused').siblings().removeClass('rccs--focused');
})

$(".left").on('keyup', 'input[name]', function () {
    var valueOfAttr = $(this).attr("name");
    var defaultLengthAttr = defaultLength(valueOfAttr);

    // Xét maxLength của thẻ input
    $(this).attr('maxLength', defaultLengthAttr);
    var classInput = "rccs__" + valueOfAttr;

    var value = $(this).val().length;
    if (value <= defaultLengthAttr) {
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

$("input[name='cvc']").click(function () {
    $('.rccs__card').addClass('rccs__card--flipped');
})

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
            value = 16;
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
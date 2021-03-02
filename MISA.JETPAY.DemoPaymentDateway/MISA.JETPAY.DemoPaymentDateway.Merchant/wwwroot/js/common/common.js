/**
 * Lấy giá trị paramter
 * @param {any} param tên paramter
 * CreatedBy: NDBINH (02/03/2021)
 */
function GetParameterValues(param) {
    var url = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
    for (var i = 0; i < url.length; i++) {
        var urlparam = url[i].split('=');
        if (urlparam[0] == param) {
            return urlparam[1];
        }
    }
}

/**
 * Tự động gen mã code*/
function autoGenCode() {
    var x = Math.floor((Math.random() * 1000000) + 1);
    var y = "ORD" + Math.random().toString(36).replace(/[^a-z]+/g, '').substr(0, 3);
    var xy = y + "_" + x;
    return xy;
}
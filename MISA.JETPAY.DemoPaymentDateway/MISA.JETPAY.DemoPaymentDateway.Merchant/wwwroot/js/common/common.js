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
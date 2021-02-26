/**
* Định dạng tiền (dạng 2500 =>2.500)
* @param{any} money dữ liệu số tiền
* CreatedBy: NDBINH(23/02/2021)
*/
function formatMoney(money) {
    if (money == null || typeof (money) == "string" || Number.isNaN(money)) {
        return "";
    } else {
        returnmoney.toFixed(0).replace(/(\d)(?=(\d{3})+\b)/g, '$1.');
    }
}

/**
* Lấyaccesstoken
* CreatedBy: NDBINH (26/02/2021)
**/
async function getAccessToken() {
    var accessToken = null;
    //var objReq = {
    //    grant_type: "password",
    //    client_id: "APITEST",
    //    client_secret: "TT3F6AM5UQZXJEJXAWJ8CHVC9ZJ02A51",
    //    username: "apitest",
    //    password:"fPJFVp5qnCWeFmtd"
    //}
    //var dataReq = "InputJSON=" + JSON.stringify(objReq);
    //let entity = { grant_type: "password", client_id: "APITEST", client_secret: "TT3F6AM5UQZXJEJXAWJ8CHVC9ZJ02A51", username: "apitest", password: "fPJFVp5qnCWeFmtd" };
    ////let entity1 = (grant_type=password & client_id=APITEST& client_secret=TT3F6AM5UQZXJEJXAWJ8CHVC9ZJ02A51& username=apitest & password=fPJFVp5qnCWeFmtd);
    //try {
    //    $.ajax({
    //        type: 'POST',
    //        url: "https://dps-staging.napas.com.vn/api/oauth/token",
    //        headers: { 'Access-Control-Allow-Origin': '*' },
    //        headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
    //        contentType: 'application/x-www-form-urlencoded; charset=utf-8',
    //        dataType: 'jsonp',
    //        data: "grant_type=password&client_id=APITEST&client_secret=TT3F6AM5UQZXJEJXAWJ8CHVC9ZJ02A51&username=apitest&password=fPJFVp5qnCWeFmtd",
    //        success: function (response) {
    //            console.log(response);
    //            return response;
    //        }

    //})
    //} catch (e) {
    //    alert('loiroi');
    //}

    var accessToken = null;
    try {
        await $.ajax({
            type: 'POST',
            url: "https://dps-staging.napas.com.vn/api/oauth/token",
            headers: { 'Content-Type': 'application/x-www-form-urlencoded' },
            data: "grant_type=password&client_id=APITEST&client_secret=TT3F6AM5UQZXJEJXAWJ8CHVC9ZJ02A51&username=apitest&password=fPJFVp5qnCWeFmtd",
            success: function (response) {
                accessToken = response.access_token;
            }
        })
    } catch (e) {
    }
    return getDataKeyAndNapasKey(accessToken);
}

function getDataKeyAndNapasKey(accessToken) {
    var objReg = {
        "apiOperation": "DATA_KEY",
        "inputParameters": {
            "clientIP": "192.168.1.1",
            "deviceId": "0123456789",
            "environment": "WebApp",
            "cardScheme": "AtmCard",
            "enable3DSecure": "false"
        },
        "order": {
            "id": "ORD_892646",
            "amount": "100000",
            "currency": "VND"
        }
    }
    try {
        $.ajax({
            url: "https://dps-staging.napas.com.vn/api/rest/version/32/merchant/APITEST/datakey?access_token=" + accessToken,
            method: "POST",
            headers: { 'Content-Type': 'application/json' },
            data: JSON.stringify(objReg),
            async: false
        }).done(function (res) {
            console.log(res.dataKey);
            console.log(res.napasKey);
        }).fail(function (res) {

        })
    } catch (e) {

    }
}
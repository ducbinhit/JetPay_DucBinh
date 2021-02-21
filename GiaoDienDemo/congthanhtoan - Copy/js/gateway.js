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

    }

    /**
     * Khởi tạo sự kiện của trang cổng thanh toán
     * CreatedBy: NDBINH (19/02/2021)
     * */
    initEventsOfGateway() {

    }

    /**
     * Khởi tạo marquee
     * CreatedBy: NDBINH (19/02/2021)
     * */
    initMarquee() {
    }
}
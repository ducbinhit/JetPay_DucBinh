window._apis = {
    Auth: "https://localhost:44351",
    Management: "https://localhost:44358/api/Management",
};

/**
 * Cấu hình endpoint api
 */
window._apis = {
    General: "http://testgeneral.rdp.local/api/General/file/stream",
    Auth: "https://testauthapi.jetpay.vn",
    Management: "https://testmanagementapi.jetpay.vn/api/Management",
};
/**
 * Cấu hình các kết nối với bên ngoài
 */
window._external = {
    amisUrl: "https://apps.amispdc.misa.local",
    amisMenu: {
        css: [
            "https://cdnapps.amispdc.misa.local/apjs/apcore/apcore-2.0.1.min.css?v=20200309",
        ],
        js: [
            "https://cdnapps.amispdc.misa.local/vendor/jquery-3.3.1.min.js",
            "https://cdnapps.amispdc.misa.local/vendor/socket.io-2.2.0.js",
            "https://cdnapps.amispdc.misa.local/apjs/apcore/apcore-2.0.1.min.js?v=20200309",
        ],
    },
    amisAmsHelp: "https://helpamis.misa.vn/amis-ams",
    misaStore: {
        url: "https://store.misa.local",
        linkBuy: "https://store.misa.local/quote?pid=202",
    },
};

/**
 * Cấu hình cho phần nhập khẩu
 */
window._import = {};

/**
 * thông tin timeout (ms)
 */
window._appConfig = {
    saveTimeout: 100,
    syncLoadingTimeOut: 600000,
};

/**
 * Cấu hình tích hợp với amis
 */
window.__appInfo = {
    ApplicationCode: "amsdev",
    ApplicationURL: "/ams/",
    // HelpURL: "http://helpamis.misa.vn/amis-ams/",
    Notification: {
        DefaultDisplay: 1, //hiển thị số thông báo chưa đọc
    },
    NPS: {
        Enable: false, //có cho khảo sát hiển thị không
        Manual: false, // tự ứng dụng gọi form khảo sát NPS.
    },
    Dock: {
        Disable: false, //không sử dụng application dock
        DarkMode: false, //chế độ dark mode
    },
};
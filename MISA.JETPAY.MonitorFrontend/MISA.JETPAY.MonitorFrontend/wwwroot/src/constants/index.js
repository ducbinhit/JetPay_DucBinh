/**
 * Config api phía Service.
 * Author: LTQUAN (11/12/2020)
 */
export const Api = {
    TRANSACTION: "/api/v1/transactions",
    APPLICATION: "/api/v1/applications"
}

/**
 * HttpMethod dùng trong hệ thống.
 * Author: LTQUAN (11/12/2020)
 */
export const HttpMethod = {
    GET: "GET",
    POST: "POST",
    PUT: "PUT",
    DELETE: "DELETE"
}

/**
 * Trạng thái dialog.
 * Author: LTQUAN (11/12/2020)
 */
export const ActionConfirm = {
    CONFIRM_CLOSE: 1,
    CONFIRM_DELETE: 2,
    CONFIRM_INFO: 3,
    CONFIRM_DELETE_ALL: 4
}

/**
 * Tên trạng thái của status.
 * Author: LTQUAN (11/12/2020)
 */
export const ChipStatus = {
    SUCCESS: "success",
    PRIMARY: "primary",
    WARNING: "warning",
    DANGER: "danger"
}

/**
 * Trạng thái giao dịch.
 * Author: LTQUAN (11/12/2020)
 */
export const TransactionType = {
    SUCCESS: 2,
    PRIMARY: 1,
    WARNING: 0
}

/**
 * Thông báo chung.
 * Author: LTQUAN (11/12/2020)
 */
export const Message = {
    TITLE_INFO: "Thông báo",
    TITLE_FORM_INFO: "Đóng form nhập thông tin",
    MSG_CONFIRM_CLOSE: "Bạn có chắc chắn muốn đóng form nhập thông tin ứng dụng tích hợp không?",
    DATA_INVALID: "Thiếu thông tin ứng dụng tích hợp",
    MSG_PL_INPUT: "Vui lòng nhập đầy đủ các trường cần thiết",
    DELETE_APP: "Xóa ứng dụng tích hợp",
}

/**
 * Constant cho phần phân trang.
 * Author: LTQUAN (11/12/2020)
 */
export const Paginate = {
    FIRST_PAGE: "FIRST",
    PREVIOUS_PAGE: "PREV",
    NEXT_PAGE: "NEXT",
    LAST_PAGE: "LAST",
    FIRST: 1,
    SECOND: 2,
    THIRD: 3,
    FOURTH: 4
}

/**
 * Icon cho thông báo.
 * Author: LTQUAN (11/12/2020)
 */
export const Icon = {
    WARNING: "el-icon-warning m-warning",
    DANGER: "el-icon-warning m-danger"
}

/**
 * Mã lỗi khi thêm, sửa, xóa.
 * Author: LTQUAN (11/12/2020)
 */
export const Code = {
    ADD_SUCCESS: "100",
    UPDATE_SUCCESS: "101",
    DELETE_SUCCESS: "103"
}
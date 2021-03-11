import { CallService } from "./../../service";
import { HttpMethod } from './../../constants';

const state = {
    dialogVisible: false, // Trạng thái của dialog
    objectDetail: {}, // Đối tượng detail khi load form chi tiết, thêm, sửa
    confirmDetail: {
        dialogConfirmVisible: false, //Trạng thái dialog confirm
        title: "", // Title của dialog
        icon: null, // Icon của dialog
        message: "", // Message của dialog
        action: "" //Hành động của dialog (thêm-POST, sửa-PUT)
    },
    response: {}, // data phản hồi khi gọi api
    action: "", // Hành động của dialog sửa hay thêm
    handerValidate: false, // Biến kích hoạt sự kiện validate khi thêm/sửa trên form
    select: true, // Điều khiển select text vào input khi mở form sửa
    listItems: [], // Mảng danh sách bản ghi được chọn ( dùng cho table )
    itemClicked: false, //Kiểm tra một dòng có được chọn không
    allItemClicked: false //Kiểm tra tất cả các dòng có được chọn hay không
};

/**
 * Các hàm getters để lấy thông tin trên store
 */
const getters = {
    /**
     * Lấy trạng thái của dialog
     */
    dialogVisible: state => {
        return state.dialogVisible;
    },
    /**
     * Thông tin của dialog confirm
     */
    confirmDetail: state => {
        return state.confirmDetail;
    },
    /**
     * Đối tượng sử dụng với form dialog
     */
    objectDetail: state => {
        return state.objectDetail;
    },
    /**
     * Đối tượng trả về khi call api
     */
    response: state => {
        return state.response;
    },
    /**
     * Hành động thêm/sửa
     */
    action: state => {
        return state.action;
    },
    /**
     * Biến kích hoạt sự kiện validate khi thêm/sửa trên form
     */
    handerValidate: state => {
        return state.handerValidate;
    },
    //Lấy biến điều khiển select text vào input đầu tiên khi mở form sửa
    select: state => {
        return state.select;
    },
    //Lấy danh sách bản ghi được chọn (table)
    listItems: state => {
        return state.listItems;
    },
    //Kiểm tra xem có item nào được chọn không
    itemClicked: state => {
        return state.itemClicked;
    },
    //Kiểm tra xem tất cả các bản ghi có được chọn hay không
    allItemClicked: state => {
        return state.allItemClicked;
    }
};

/**
 * Các hàm thay đổi trực tiếp state
 * Author: LTQUAN (11/12/2020)
 */
const mutations = {
    /**
     * Ẩn/hiện dialog dùng chung
     * @param {payload} Object
     * Author: LTQUAN (11/12/2020)
     */
    SHOW_DIALOG: (state, payload) => {
        state.dialogVisible = payload;
    },
    /**
     * Gán lại giá trị chi tiết của bản ghi hiển thị trên dialog
     * @param {payload} Object
     */
    SET_OBJECT_DETAIL: (state, payload) => {
        state.objectDetail = payload;
    },
    /**
     * Gán lại giá trị trạng thái của dialog confirm
     * @param {*} payload
     */
    SHOW_CONFIRM_DIALOG: (state, payload) => {
        state.confirmDetail = payload;
    },
    /**
     * Gán lại giá trị trạng thái khi call request
     * @param {*} payload
     */
    SET_RESPONSE: (state, payload) => {
        state.response = payload;
    },
    /**
     * Gán lại giá trị action
     * @param {*} payload
     */
    SET_ACTION: (state, payload) => {
        state.action = payload;
    },
    /**
     * Kích hoạt sự kiện validate
     * Author: LTQUAN (16/12/2020)
     */
    HANDER_VALIDATE: state => {
        state.handerValidate = !state.handerValidate;
    },
    /**
     * Set biến kích hoạt sự kiện select text
     * Author: NCBAO (16/12/2020)
     */
    SET_SELECT: (state, payload) => {
        state.select = payload;
    },
    /**
     * Set gía trị cho listItems
     * Author: NCBAO (15/12/2020)
     */
    ADD_LISTITEM: (state, payload) => {
        state.listItems = payload;
    },
    /**
     * Gán giá trị cho biến check xem có bản ghi nào được chọn không
     * Author: NCBAO (15/12/2020)
     *  */
    SET_ITEMCLICKED: (state, payload) => {
        state.itemClicked = payload;
    },
    /**
     * Gán giá trị cho biến check xem tất cả bản ghi có được chọn không
     * Author: NCBAO (15/12/2020)
     *  */
    SET_ALLITEMCLICKED: (state, payload) => {
        state.allItemClicked = payload;
    }
};

const actions = {
    /**
     * Ẩn/hiện dialog dùng chung (tham số checkAction truyền vào 'true' là thêm false là 'sửa')
     * Author: LTQUAN (11/12/2020)
     */
    showDialog: ({ commit }, payload) => {
        commit("SHOW_DIALOG", payload.isShow);
        commit("SET_ACTION", payload.action);
        // Refresh các ô input khi đóng form
        if (!payload.isShow) state.objectDetail = {};
    },
    /**
     * Ẩn hiện dialog confirm dùng chung (tham số checkAction truyền vào 'true' là thêm false là 'sửa')
     *  Author: NCBAO (12/12/2020)
     */
    showConfirmDialog: ({ commit }, payload) => {
        commit("SHOW_CONFIRM_DIALOG", payload);
    },
    /**
     * Load chi tiết bản ghi
     * @param {Object} payload đối tượng gồm { apiUrl: '', id: '' }
     * Author: LTQUAN (14/12/2020)
     */
    fetchObjectDetail: async({ commit }, payload) => {
        try {
            const { data } = await CallService(`${payload.apiUrl}/${payload.id}`, {
                method: "GET"
            });
            await commit("SET_OBJECT_DETAIL", data);
            commit("SET_SELECT", false);
        } catch (e) {
            console.log(e.response);
        }
    },
    /**
     * Thêm và sửa dùng chung
     * @param {Object} payload đối tượng gồm { apiUrl: '', id: '' }
     * Author: NCBAO (14/12/2020)
     */
    saveObject: async({ commit, state }, payload) => {
        try {
            const { data } = await CallService(payload.apiUrl, {
                method: state.action,
                data: payload.data
            });
            commit("SET_RESPONSE", data);
        } catch (e) {
            commit("SET_RESPONSE", e.response.data);
        }
    },
    /**
     * Xóa bản ghi theo Id
     * Hàm này trả về 1 Promise để có thể thông báo ngay khi xóa thành công.
     * Author: LTQUAN (15/12/2020)
     */
    deleteObject: ({ commit, state }) => {
        return new Promise((resolve, reject) => {
            CallService(`${state.confirmDetail.apiUrl}/${state.confirmDetail.id}`, {
                    method: "DELETE"
                })
                .then(res => {
                    commit("SET_RESPONSE", res.data);
                    resolve(true);
                })
                .catch(e => {
                    commit("SET_RESPONSE", e.response.data);
                    reject(false);
                });
        });
    },
    /**
     * Xóa nhiều bản ghi
     * Hàm này trả về 1 Promise để có thể thông báo ngay khi xóa thành công.
     * Author: NCBAO (15/12/2020)
     */
    deleteAlotObject: ({ commit, state }) => {
        return new Promise((resolve, reject) => {
            CallService(
                    `${state.confirmDetail.apiUrl}/${state.listItems.toString()}`, {
                        method: "DELETE"
                    }
                )
                .then(res => {
                    commit("SET_RESPONSE", res.data);
                    resolve(true);
                })
                .catch(e => {
                    commit("SET_RESPONSE", e.response.data);
                    reject(false);
                });
        });
    },
    /**
     * Kích hoạt sự kiện validate
     * Author: LTQUAN (16/12/2020)
     */
    setHanderValidate: ({ commit }) => {
        commit("HANDER_VALIDATE");
    },
    /**
     * Set thay đổi biến điều khiển việc select text trong input khi mở form sửa
     * Author: NCBAO (14/12/2020)
     */
    setSelect: ({ commit }) => {
        commit("SET_SELECT", true);
    },
    /**
     * Gán danh sách các bản ghi được chọn từ một danh sách khác
     * Author: NCBAO (16/12/2020)
     */
    setListItem: function({ commit, state }, payload) {
        state.listItems.splice(0, state.listItems.length);
        commit("ADD_LISTITEM", payload);
    },
    /**
     * Thêm hoặc xóa bản ghi được chọn vào danh sách
     * Author: NCBAO (16/12/2020)
     */
    changeListItem: ({ commit, state }, payload) => {
        if (state.listItems.includes(payload)) {
            state.listItems = state.listItems.filter(item => item != payload);
            commit("ADD_LISTITEM", state.listItems);
        } else {
            state.listItems.push(payload);
            commit("ADD_LISTITEM", state.listItems);
        }
    },
    /**
     * Xóa danh sách bản ghi được chọn
     * Author: NCBAO (16/12/2020)
     */
    deleteListItem: ({ state }) => {
        state.listItems.splice(0, state.listItems.length);
    },
    /**
     * Set giá trị cho biến kiểm tra xem có bản ghi nào được chịn không
     * @param {Boolean} payload Chọn/hủy chọn checkbox
     * Author: NCBAO (18/12/2020)
     */
    setItemClicked: ({ commit, state }, payload) => {
        if (state.listItems.length > 0) commit("SET_ITEMCLICKED", payload || true);
        else commit("SET_ITEMCLICKED", payload && false);
    },
    /**
     * Set giá trị cho biến kiểm tra xem tất cả các bản ghi có đang được chọn hay không
     * @param {Boolean} payload Chọn tất cả/hủy chọn các checkbox
     * Author:NCBAO (18/12/2020)
     */
    setAllItemClicked: ({ commit }, payload) => {
        commit("SET_ALLITEMCLICKED", payload);
    }
};

export default {
    state,
    getters,
    mutations,
    actions
};
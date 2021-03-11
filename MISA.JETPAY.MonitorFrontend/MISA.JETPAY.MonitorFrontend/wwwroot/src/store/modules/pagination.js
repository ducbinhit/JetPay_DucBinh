import { CallService } from './../../service';
import { Paginate, HttpMethod } from './../../constants';

//#region State

/**
 * State quản lý cho phân trang, load dữ liệu
 * Author: LTQUAN (11/12/2020)
 */
const state = {
    apiUrl: '', // Tên api url kết nối tới MonitorService
    paginateInfo: {
        index: 0, // Vị trí trang
        size: 25, // Số bản ghi/trang
        count: 0, // Tổng số bản ghi
        pages: 0, // Tổng số bản trang
        hasPrevious: false, // Có thể tiến sang trang sau
        hasNext: false, // Có thể lùi
        items: [] // Danh sách bản ghi
    },
    pageInfo: {
        cursor: Paginate.FIRST, // Vị trí active của trang
        pagesDisplay: [1, 2, 3, 4] // Hiển thị danh sách pageNumber
    },
    filter: {}, // Đối tượng filter nói chung, sẽ gán ở đây
}

//#endregion

//#region Getters

/**
 * Các hàm getters để lấy thông tin trên store
 * Author: LTQUAN (11/12/2020)
 */
const getters = {
    /**
     * Thông tin phân trang
     * Author: LTQUAN (11/12/2020)
     */
    paginateInfo: (state) => {
        return state.paginateInfo;
    },
    /**
     * Đối tượng thông tin vị trí cursor active và pageDisplay
     * Author: LTQUAN (11/12/2020)
     */
    pageInfo: (state) => {
        return state.pageInfo;
    },
    /**
     * Số bản ghi trên/trang
     * Author: LTQUAN (11/12/2020)
     */
    size: (state) => {
        return state.paginateInfo.size;
    },
    /**
     * Đối tượng tìm kiếm
     * Author: LTQUAN (11/12/2020)
     */
    filter: (state) => {
        return state.filter;
    },
    /**
     * Thông tin hiển thị vị trí của các bản ghi
     * Author: LTQUAN (11/12/2020)
     */
    infoRecord: (state) => {

        let { index, size, count } = state.paginateInfo;

        let minIndex = index * size;
        let maxIndex = (minIndex + size) <= count ? (minIndex + size) : count;
        return `${minIndex == 0 ? 1 : minIndex}-${maxIndex}/${count}`;
    },
    /**
     * Link api theo từng page
     * Author: LTQUAN (11/12/2020)
     */
    apiUrl: (state) => {
        return state.apiUrl;
    }
}

//#endregion

//#region Mutations

/**
 * Các hàm thay đổi trực tiếp state
 * Author: LTQUAN (11/12/2020)
 */
const mutations = {
    /**
     * Gán lại apiUrl
     * @param {String} payload apiUrl truyền lên
     * Author: LTQUAN (11/12/2020)
     */
    SET_API_URL: (state, payload) => {
        state.apiUrl = payload;
        state.paginateInfo = {
            index: 0,
            size: 25,
            count: 0,
            pages: 0,
            hasPrevious: false,
            hasNext: false,
            items: []
        };
        state.filter = {};
    },
    /**
     * Gán lại thông tin phân trang
     * @param {Object} payload Thông tin phân trang
     * Author: LTQUAN (11/12/2020)
     */
    SET_PAGINATE_INFO: (state, payload) => {
        state.paginateInfo = payload;
    },
    /**
     * Gán lại vị trí trang
     * @param {Any} payload chỉ số tăng giảm page, 2 TH:
     * 1. Đối tượng {pageCursor: '', pageNumber: ''}
     * 2. Chỉ số pageControl FIRST_PAGE, PREV, NEXT, LAST_PAGE
     * Author: LTQUAN (11/12/2020)
     */
    SET_INDEX: (state, payload) => {
        let { index, pages, hasPrevious, hasNext } = state.paginateInfo;
        let { cursor } = state.pageInfo;

        //#region Sự kiện cho các page number
        if (typeof payload === 'object') {
            switch (payload.pageCursor) {
                case Paginate.FIRST:
                    if (cursor != Paginate.FIRST) {
                        state.paginateInfo.index = payload.pageNumber - 1;
                        // Kiểm tra nếu index > 3 tức là vị trí trang đã xa những trang đầu, ta sẽ set lại vị trí cursor
                        if (index <= 2) {
                            state.pageInfo.pagesDisplay = [1, 2, 3, 4];
                            // Gán lại vị trí cursor bằng chính vị trí trang vì ở đây các chỉ số trang sẽ về trạng thái ban đầu
                            state.pageInfo.cursor = payload.pageNumber;
                        } else {
                            state.pageInfo.cursor = Paginate.SECOND;
                            state.pageInfo.pagesDisplay = [payload.pageNumber - 1, payload.pageNumber, payload.pageNumber + 1, payload.pageNumber + 2];
                        }
                    }
                    break;
                case Paginate.SECOND:
                    if (cursor != Paginate.SECOND && pages > 1) {
                        state.paginateInfo.index = payload.pageNumber - 1;
                        state.pageInfo.cursor = Paginate.SECOND;
                    }
                    break;
                case Paginate.THIRD:
                    if (cursor != Paginate.THIRD && pages > 2) {
                        state.paginateInfo.index = payload.pageNumber - 1;
                        state.pageInfo.cursor = Paginate.THIRD;
                    }
                    break;
                case Paginate.FOURTH:
                    if (cursor != Paginate.FOURTH && pages > 3) {
                        state.paginateInfo.index = payload.pageNumber - 1;
                        // Kiểm nếu index >= pages(tổng số trang) -2 thì thay đổi thuộc tính pageDisplay theo những trang cuối
                        if (index >= pages - 2) {
                            // Gán lại cursor khi tiến dần tới những trang cuối
                            state.pageInfo.cursor = (4 - (pages - payload.pageNumber));
                            state.pageInfo.pagesDisplay = [pages - 3, pages - 2, pages - 1, pages]
                        } else {
                            state.pageInfo.pagesDisplay = [payload.pageNumber - 2, payload.pageNumber - 1, payload.pageNumber, payload.pageNumber + 1];
                            state.pageInfo.cursor = Paginate.THIRD;
                        }
                    }
                    break;
            }
        }
        //#endregion

        //#region Sự kiên cho các button control
        else {
            switch (payload) {
                case Paginate.FIRST_PAGE: // Trang đầu tiên
                    // Nếu vị trí hiện tại không phải đầu tiên thì mới gán lại các giá trị phân trang
                    if (hasPrevious) {
                        state.paginateInfo.index = 0;
                        state.pageInfo.cursor = Paginate.FIRST;
                        state.pageInfo.pagesDisplay = [1, 2, 3, 4];
                    }
                    break;
                case Paginate.PREVIOUS_PAGE: // Trang trước đó
                    if (hasPrevious) {
                        // Nếu tổng số trang nhỏ hơn 4
                        if (pages <= 4) {
                            state.pageInfo.cursor = cursor - 1;
                        }
                        // Nếu không thể tiến
                        else if (!hasNext) {
                            state.pageInfo.pagesDisplay = [index - 2, index - 1, index, index + 1];
                            state.pageInfo.cursor = Paginate.THIRD;
                        }
                        // Nếu ở vị trí thứ 3
                        else if (cursor == Paginate.THIRD) {
                            state.pageInfo.cursor = Paginate.SECOND;
                        }
                        // Nếu chỉ số index = 1 thì di chuyển cursor tiến về cuối 
                        else if (index == 1) {
                            state.pageInfo.cursor = Paginate.FIRST;
                        }
                        // Nếu ở vị trí thứ 2
                        else if (cursor == Paginate.SECOND) {
                            state.pageInfo.pagesDisplay = [index - 1, index, index + 1, index + 2];
                            // state.pageInfo.cursor = Paginate.SECOND;
                        }
                    }
                    state.paginateInfo.index--;
                    break;
                case Paginate.NEXT_PAGE: // Trang tiếp theo
                    if (hasNext) {
                        // Nếu không thể lùi
                        if (!hasPrevious) {
                            state.pageInfo.pagesDisplay = [1, 2, 3, 4];
                            state.pageInfo.cursor = Paginate.SECOND;
                        }
                        // Nếu ở vị trí thứ 2
                        else if (cursor == Paginate.SECOND) {
                            state.pageInfo.pagesDisplay = [index, index + 1, index + 2, index + 3];
                            state.pageInfo.cursor = Paginate.THIRD;
                        }
                        // Nếu chỉ số index áp chót thì di chuyển cursor tiến về cuối 
                        else if (index == pages - 2) {
                            state.pageInfo.cursor = Paginate.FOURTH;
                        }
                        // Nếu ở vị trí thứ 3
                        else if (cursor == Paginate.THIRD) {
                            state.pageInfo.pagesDisplay = [index, index + 1, index + 2, index + 3];
                            // state.pageInfo.cursor = Paginate.THIRD;
                        }
                        state.paginateInfo.index++;
                    }
                    break;
                case Paginate.LAST_PAGE: // Trang cuối cùng
                    if (hasNext) {
                        state.paginateInfo.index = pages - 1;
                        // Nếu tổng số trang lớn hơn 4
                        if (pages > Paginate.FOURTH) {
                            state.pageInfo.cursor = Paginate.FOURTH;
                            state.pageInfo.pagesDisplay = [pages - 3, pages - 2, pages - 1, pages];
                        } else {
                            state.pageInfo.cursor = pages;
                            state.pageInfo.pagesDisplay = [1, 2, 3, 4];
                        }
                    }
                    break;
            }
            //#endregion
        }
    },
    /**
     * Gán lại các giá trị thông số phân trang khi thay đổi size
     * @param {Number} payload số bản ghi 1 trang
     * Author: LTQUAN (12/12/2020)
     */
    SET_PAGE_SIZE: (state, payload) => {
        state.paginateInfo.size = payload;
        state.paginateInfo.index = 0;
        state.pageInfo.cursor = Paginate.FIRST;
        state.pageInfo.pagesDisplay = [1, 2, 3, 4];
    },
    /**
     * Gán lại giá trị filter
     * @param {Object} payload đối tượng filter
     * Author: LTQUAN (12/12/2020)
     */
    SET_FILTER: (state, payload) => {
        state.filter = payload;
        state.paginateInfo.index = 0;
        state.pageInfo.cursor = Paginate.FIRST;
        state.pageInfo.pagesDisplay = [1, 2, 3, 4];
    },
    /**
     * Refresh trang
     * Author: LTQUAN (14/12/2020)
     */
    REFRESH_PAGE: (state) => {
        state.paginateInfo = {
            index: 0, // Vị trí trang
            size: 25, // Số bản ghi/trang
            count: 0, // Tổng số bản ghi
            pages: 0, // Tổng số bản ghi
            hasPrevious: false, // Có thể tiến sang trang sau
            hasNext: false, // Có thể lùi
            items: [] // Danh sách bản ghi
        };
        state.pageInfo = {
            cursor: Paginate.FIRST, // Vị trí active của trang
            pagesDisplay: [1, 2, 3, 4] // Hiển thị danh sách pageNumber
        };
        state.filter = {} // Đối tượng filter nói chung
    }
}

//#endregion

//#region Actions

/**
 * Các hàm cung cấp cho các components, fetchApi
 * Author: LTQUAN (11/12/2020)
 */
const actions = {
    /**
     * Gán giá trị apiUrl
     * @param {String} payload Địa chỉ api để gọi tới Service
     * Author: LTQUAN (11/12/2020)
     */
    setApiUrl: ({ commit }, payload) => {
        commit('SET_API_URL', payload);
    },
    /**
     * Load dữ liệu
     * Author: LTQUAN (11/12/2020)
     */
    fetchData: async({ commit, state }) => {
        try {
            const { data } = await CallService(state.apiUrl, {
                    method: HttpMethod.GET,
                    params: {
                        pageIndex: state.paginateInfo.index,
                        pageSize: state.paginateInfo.size,
                        ...state.filter
                    },
                })
                // Gán lại thông tin phân trang
            commit("SET_PAGINATE_INFO", data)
        } catch (e) {
            console.log(e.response);
        }
    },
    /**
     * Gán lại vị trí trang
     * @param {Number} payload chỉ số tăng giảm page
     * Author: LTQUAN (11/12/2020)
     */
    setIndex: ({ commit }, payload) => {
        commit("SET_INDEX", payload);
    },
    /**
     * Gán lại giá trị page size
     * @param {String} payload apiUrl truyền lên
     * Author: LTQUAN (12/12/2020)
     */
    setPageSize: ({ commit }, payload) => {
        commit('SET_PAGE_SIZE', payload);
    },
    /**
     * Gán lại giá trị filter
     * @param {Object} payload đối tượng filter
     * Author: LTQUAN (12/12/2020)
     */
    setFilter: ({ commit }, payload) => {
        commit('SET_FILTER', payload);
    },
    /**
     * Load lại trang
     * Author: LTQUAN(12/12/2020)
     */
    refreshPage: ({ commit }) => {
        commit('REFRESH_PAGE');
    }
}

//#endregion

/**
 * Đối tượng store cho phân trang
 * Author: LTQUAN (11/12/2020)
 */
export default {
    state,
    getters,
    mutations,
    actions
}
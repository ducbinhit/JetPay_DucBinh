const state = {
  modalServiceVisible: false, // Trạng thái của dialog chỉnh sửa dịch vụ đối tác
  tableServiceVisible: false // Trạng thái của bảng chi tiết các dịch vụ đối tác
};
const getters = {
  modalServiceVisible: state => {
    return state.modalServiceVisible;
  },
  tableServiceVisible: state => {
    return state.tableServiceVisible;
  }
};
const mutations = {
  SET_MODALSERVICEVISIBLE: (state, payLoad) => {
    state.modalServiceVisible = payLoad;
  },
  SET_TABLESERVICEVISIBLE: (state, payLoad) => {
    state.tableServiceVisible = payLoad;
  }
};
const actions = {
  showModalService: ({ commit }, payLoad) => {
    commit("SET_MODALSERVICEVISIBLE", payLoad);
    debugger
  },
  showTableService: ({ commit }, payLoad) => {
    commit("SET_TABLESERVICEVISIBLE", payLoad);
  }
};

export default {
  state,
  getters,
  mutations,
  actions
};

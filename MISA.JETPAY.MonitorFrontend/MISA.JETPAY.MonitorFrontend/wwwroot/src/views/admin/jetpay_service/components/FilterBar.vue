<template>
  <div class="filter-bar" @keyup.prevent.enter="searchService">
    <div class="left-filter-bar">
      <div class="icon-input txt-seach">
        <input
          type="text"
          class="m-input m-input-icon"
          placeholder="Nhập mã dịch vụ, tên dịch vụ"
          v-model="filter.search"
        />
        <span><i class="el-icon-search"></i></span>
      </div>
    </div>
    <div class="right-filter-bar">
      <!-- <button class="m-btn m-btn-default">
        <i class="el-icon-download"></i><span>Xuất file</span>
      </button> -->
      <button
        v-if="listItems.length"
        class="m-btn m-btn-icon m-btn-default"
        @click="handerDeleteAlot"
      >
        <i class="el-icon-delete"></i>
      </button>
      <button
        v-else
        class="m-btn btn-add"
        @click="showDialog({ isShow: true, action: 'POST' })"
      >
        <i class="el-icon-plus"></i><span>Thêm mới</span>
      </button>
    </div>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import { ActionConfirm } from "./../../../../constants";

export default {
  name: "FilterBar",
  data() {
    return {
      itemClicked: false,//Biến cục bộ kiểm trả có bản ghi nào được chọn không
    };
  },
  computed: {
    ...mapGetters(["filter", "apiUrl", "listItems"]),
  },
  methods: {
    ...mapActions([
      "fetchData",
      "showDialog",
      "setFilter",
      "showConfirmDialog",
    ]),
    searchService() {
      console.log(this.filter);
      this.setFilter(this.filter);
      this.fetchData();
    },
    /**
     * Hàm xóa nhiều bản ghi đã chọn
     */
    handerDeleteAlot() {
      this.showConfirmDialog({
        dialogConfirmVisible: true,
        title: "Xóa dịch vụ",
        message: `Bạn có chắc chắn muốn xóa các dịch vụ đã chọn ?`,
        action: ActionConfirm.CONFIRM_DELETE_ALL,
        apiUrl: this.apiUrl,
        icon: "el-icon-warning m-danger",
      });
    },
  },
};
</script>
<style scoped>
@import url("./../../../../assets/css/form.css");
@import url("./../../../../assets/css/button.css");
.filter-bar {
  width: 100%;
  height: 40px;
  display: flex;
  margin-bottom: 16px;
}
.txt-seach {
  width: 400px;
}
.left-filter-bar,
.right-filter-bar {
  height: 100%;
}
.right-filter-bar {
  position: relative;
  width: calc(100% - 400px);
  display: flex;
  grid-gap: 16px;
  justify-content: flex-end;
}
</style>
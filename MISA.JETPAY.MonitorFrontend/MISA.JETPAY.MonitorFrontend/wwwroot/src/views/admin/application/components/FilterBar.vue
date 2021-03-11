<template>
  <div class="filter-bar" @keyup.prevent.enter="searchApplication">
    <div class="left-filter-bar">
      <div class="icon-input txt-seach">
        <input
          v-model="filter.search"
          type="text"
          class="m-input m-input-icon"
          placeholder="Nhập mã ứng dụng, tên ứng dụng"
        />
        <span><i class="el-icon-search"></i></span>
        <span
          @mouseover="isShowIconClear = true"
          @mouseout="isShowIconClear = false"
          @click="
            filter.search = '';
            searchApplication();
          "
          class="clear-text"
          ><i @mouseover="isShowIconClear = !isShowIconClear" v-show="isShowIconClear" class="el-icon-circle-close"></i
        ></span>
      </div>
    </div>
    <div class="right-filter-bar">
      <!-- <button class="m-btn m-btn-default">
        <i class="el-icon-download"></i><span>Xuất file</span>
      </button> -->
      <button class="m-btn btn-add" @click="showDialog({isShow:true, action:'POST'})">
        <i class="el-icon-plus"></i><span>Thêm mới</span>
      </button>
    </div>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";

export default {
  name: "FilterBar",
  data() {
    return {
      isShowIconClear: false
    };
  },
  computed:{
    // Lấy các getters trên store, file: common.js
    ...mapGetters(["filter"])
  },
  methods: {
    // Lấy các actions trên store, file: common.js
    ...mapActions(["fetchData","showDialog", "setFilter"]),
    searchApplication() {
      this.setFilter(this.filter);
      this.fetchData();
    },
  },
};
</script>

<style scoped>
@import url("./../../../../assets/css/form.css");
@import url("./../../../../assets/css/button.css");
@import url("./../../../../assets/css/pages/application/filter_bar.css");
</style>
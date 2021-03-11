<template>
  <div class="filter-bar">
    <div class="left-filter-bar">
      <div class="icon-input txt-seach">
        <input type="text" class="m-input m-input-icon" placeholder="Nhập mã đối tác, tên đối tác thanh toán">
        <span><i class="el-icon-search"></i></span>
      </div>
    </div>
    <div class="right-filter-bar">
      <button class="m-btn btn-add" @click="showDialog({isShow: true})">
        <i class="el-icon-plus"></i><span>Thêm mới</span>
      </button>
    </div>
  </div>
</template>

<script>
import { mapActions } from 'vuex';
export default {
  name: "FilterBar",
  data() {
    return {
      seach: ''
    }
  },
  methods: {
    ...mapActions(['showDialog'])
  }
};
</script>
<style scoped>
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
.left-filter-bar{
  position: relative;
}
.left-filter-bar,
.right-filter-bar {
  height: 100%;
}
.right-filter-bar {
  position: relative;
  width: calc(100% - 350px);
  display: flex;
  grid-gap: 16px;
  justify-content: flex-end;
}
</style>
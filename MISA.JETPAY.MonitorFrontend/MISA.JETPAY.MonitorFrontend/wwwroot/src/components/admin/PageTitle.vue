<template>
  <div class="page-title">
    <div class="title">{{ title }}</div>
    <button class="m-btn m-btn-icon m-btn-default btn-right" @click="onRefreshPage">
      <i class="el-icon-refresh"></i>
    </button>
  </div>
</template>

<script>
import { mapActions } from 'vuex';

export default {
  props: {
    title: "",
  },
  methods: {
    ...mapActions(['refreshPage', 'fetchData']),
    /**
     * Refresh page về trạng thái ban đầu
     * Author: LTQUAN (14/12/2020)
     */
    onRefreshPage(){
      this.refreshPage();
      this.fetchData();
    }
  }
};
</script>

<style scoped>
@import url("./../../assets/css/page_title.css");
@import url("./../../assets/css/button.css");
</style>
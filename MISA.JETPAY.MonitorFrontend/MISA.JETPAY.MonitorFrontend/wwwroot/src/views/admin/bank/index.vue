<template>
  <div class="main-content">
    <PageTitle :title="title" />
    <FilterBar />
    <Table />
    <Pagination />
    <Modal />
  </div>
</template>

<script>

//#region Import

import PageTitle from "@/components/admin/PageTitle";
import Pagination from "@/components/admin/Pagination";
import Table from "./components/Table";
import FilterBar from "./components/FilterBar";
import Modal from './components/Modal';

//#endregion

/**
 * Quản lý đối tác tích hợp
 * Author: LTQUAN (03/05/2020)
 */
export default {
  name: "Bank",
  components: {
    PageTitle,
    Pagination,
    Table,
    FilterBar,
    Modal
  },
  data() {
    return {
      seach: "",
      title: "Danh sách đối tác"
    };
  },
};
</script>

<style scoped>
@import url("./../../../assets/css/button.css");
.grid {
  width: 100%;
  height: calc(100% - 168px);
  margin-bottom: 16px;
}
</style>
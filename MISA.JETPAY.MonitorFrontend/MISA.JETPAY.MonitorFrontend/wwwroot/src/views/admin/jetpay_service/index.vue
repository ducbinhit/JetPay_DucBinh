<template>
  <div class="main-content">
    <PageTitle title="Danh sách dịch vụ hệ thống"/>
    <FilterBar />
    <Table />
    <Pagination />
    <Modal />
  </div>
</template>

<script>
import PageTitle from "@/components/admin/PageTitle";
import Pagination from "@/components/admin/Pagination";
import Table from "./components/Table";
import FilterBar from "./components/FilterBar";
import Modal from "./components/Modal";
export default {
  name: "JetpayService",
  components: {
    PageTitle,
    Pagination,
    Table,
    FilterBar,
    Modal,
  },
  data() {
    return {
      seach: "",
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
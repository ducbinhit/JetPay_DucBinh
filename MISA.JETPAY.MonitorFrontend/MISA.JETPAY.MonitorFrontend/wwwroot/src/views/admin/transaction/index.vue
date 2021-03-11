<template>
  <div class="main-content">
    <PageTitle title="Danh sách giao dịch"/>
    <FillterBar />
    <Table />
    <Pagination />
    <Modal />
  </div>
</template>

<script>
export default {
  name: "Transaction",
  components: {
    FillterBar: () => import("./components/FillterBar"),
    Table: () => import("./components/Table"),
    PageTitle: () => import("@/components/admin/PageTitle"),
    Pagination: () => import("@/components/admin/Pagination"),
    Modal: () => import("./components/Modal")
  },
};
</script>

<style scoped>
@import url('./../../../assets/css/pages/transaction/index.css');
</style>
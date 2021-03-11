<template>
  <div class="main">
    <!-- Sidebar -->
    <Sidebar />
    <!-- End sidebar -->
    <div class="right-main">
      <!-- Header -->
      <Header />
      <!-- End header -->

      <!-- Content -->
      <router-view />
      <!-- End content -->
    </div>
  </div>
</template>

<script>
import Header from "@/components/admin/Header";
import Sidebar from "@/components/admin/Sidebar";
export default {
  components: {
    Header,
    Sidebar,
  },
};
</script>

<style scoped>
.main {
  width: 100%;
  height: 100vh;
  display: flex;
}
.sidebar {
  width: 220px;
  height: 100%;
}
.right-main {
  width: calc(100% - 220px);
  height: 100%;
}
.right-main .header {
  width: 100%;
  height: 60px;
  background-color: #fff;
  border-bottom: 1px solid #bbbbbb;
}
.right-main .main-content {
  width: calc(100% - 32px);
  height: calc(100% - 93px);
  padding: 16px;
}
</style>
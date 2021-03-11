<template>
  <div class="sidebar">
    <div class="logo">
      <div class="icon-toggle"></div>
      <div class="icon-logo"></div>
    </div>
    <div class="navbar-content">
      <router-link tag="a" class="navbar-item" :to="{ name: 'transaction' }" active-class="active" exact>
        <div class="navbar-item-icon icon-transaction"></div>
        <div class="navbar-item-text">Giao dịch</div>
      </router-link>
      <!-- <router-link tag="a" class="navbar-item" :to="{ name: 'bank' }" active-class="active">
        <div class="navbar-item-icon icon-bank"></div>
        <div class="navbar-item-text">Đối tác tích hợp</div>
      </router-link> -->
      <router-link tag="a" class="navbar-item" :to="{ name: 'application' }" active-class="active">
        <div class="navbar-item-icon icon-app"></div>
        <div class="navbar-item-text">Ứng dụng tích hợp</div>
      </router-link>
      <!-- <router-link tag="a" class="navbar-item" :to="{ name: 'service' }" active-class="active">
        <div class="navbar-item-icon icon-service"></div>
        <div class="navbar-item-text">Dịch vụ hệ thống</div>
      </router-link> -->
    </div>
  </div>
</template>

<script>
export default {
  name: "Sidebar"
};
</script>

<style scoped>
@import url('./../../assets/css/sidebar.css');
</style>
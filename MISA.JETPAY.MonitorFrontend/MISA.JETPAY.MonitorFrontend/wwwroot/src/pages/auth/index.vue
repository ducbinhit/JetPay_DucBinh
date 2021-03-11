<template>
  <div class="main-login">
    <div class="container">
      <div class="wraper">
        <div class="top-content">
          <img src="./../../assets/images/logo-jetpay.png" width="150px" />
        </div>
        <router-view v-on:showLoad="showLoad"></router-view>
      </div>
    </div>
    <div v-bind:class="{ overlay: isActive, disoverlay: !isActive }">
      <div class="background"></div>
      <div class="loading">
        <i style="z-index: 100; font-size: 20px" class="el-icon-loading" /> Đang
        xử lý...
      </div>
    </div>
  </div>
</template>


<script>
export default {
  data() {
    return {
      username: "",
      password: "",
      isActive: false,
    };
  },
  methods: {
    showLoad(isActive) {
      this.isActive = isActive;
    },
  },
};
</script>


<style scoped>
.main-login {
  width: 100%;
  height: 100vh;
  background: url(./../../assets/images/bg.svg) no-repeat 50%;
  background-size: cover;
}
.main-login .container {
  display: flex;
  margin: auto;
  width: 1140px;
  height: 100%;
  align-items: center;
  justify-content: center;
}
.container .wraper {
  display: table;
  width: 350px;
  height: 500px;
  text-align: center;
}
.main-login .container .wraper .top-content {
  margin-bottom: 30px;
}
/* Nền mờ */
.main-login .overlay {
  display: block;
  position: absolute;
  top: 0;
  width: 100%;
  height: 100vh;
  z-index: 10;
}
.main-login .disoverlay {
  display: none;
}
.main-login .overlay .background {
  position: absolute;
  top: 0;
  opacity: 0.4;
  width: 100%;
  height: 100%;
  background-color: #afaaaa;
  z-index: 20;
}
.main-login .overlay .loading {
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #000;
  line-height: 10px;
  background-color: #fff;
  z-index: 30;
}
</style>

<template>
  <div class="middle-content"  @keyup.enter.prevent="login">
    <span class="text-title">Đăng nhập</span>
    <el-input placeholder="Nhập tên đăng nhập" v-model="username"></el-input>
    <el-input
      placeholder="Nhập mật khẩu"
      v-model="password"
      show-password
    ></el-input>
     <div class="forget-pass"><a>Bạn quên mật khẩu ?</a></div>
    <el-button type="primary" round style="width: 350px" @click="login"
     >Đăng nhập</el-button
    >
    <span>Bạn chưa có tài khoản?,</span>
    <router-link
      tag="a"
      class="navbar-item"
      :to="{ name: 'register' }"
      active-class="active"
      exact
    >
      <a href="">Đăng ký ngay</a>
    </router-link>
    <p>Hoặc đăng nhập bằng</p>
    <a href="https://id.misa.com.vn/account/login" target="blank_">MISAID</a>
  </div>
</template>

<script>
export default {
  name: "Login",
  data() {
    return {
      username: "",
      password: "",
    };
  },
  methods: {
    login() {
      this.$emit("showLoad", true);
      setTimeout(() => {
        this.$emit("showLoad", false);
        if (this.username == "admin" && this.password == "12345678@Abc") {
          localStorage.setItem(
            "user",
            JSON.stringify({ username: this.username, password: this.password })
          );
          this.$router.push("/admin/transaction");
        }
      }, 1000);
    },
  },
};
</script>

<style>
@import url("./../../assets/css/form.css");
@import url("./../../assets/css/pages/auth/index.css");
.main-login .container .wraper .middle-content .forget-pass {
  display: flex;
  justify-content: flex-end;
  padding-top: 24px;
  margin: 0;
}
</style>
<template>
  <div class="middle-content">
    <span class="text-title">Đăng ký</span>
    <el-input placeholder="Nhập tên đăng nhập" v-model="username"></el-input>
    <el-input
      placeholder="Nhập mật khẩu"
      v-model="password"
      show-password
    ></el-input>
     <el-input
      placeholder="Nhập lại mật khẩu"
      v-model="password"
      show-password
    ></el-input>
    <el-button type="primary" round style="width: 350px" @click="login"
      >Đăng ký</el-button
    >

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
@import url('./../../assets/css/form.css');
@import url('./../../assets/css/pages/auth/index.css');
</style>
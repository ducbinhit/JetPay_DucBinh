<template>
  <div class="header">
    <div class="user-infor">
      <p class="user-name">
        {{ username }}
      </p>
      <div
        class="user-avatar"
        :style="{ 'background-image': 'url(' + avtUrl + ')' }"
      ></div>
      <el-dropdown trigger="click" @command="logout">
        <i class="el-icon-more el-dropdown-link user-more"> </i>
        <el-dropdown-menu slot="dropdown" class="dropdown-more">
          <el-dropdown-item command="a">Đăng xuất</el-dropdown-item>
          <el-dropdown-item command="b">Chỉnh sủa thông tin</el-dropdown-item>
        </el-dropdown-menu>
      </el-dropdown>
    </div>
  </div>
</template>

<script>
export default {
  name: "Header",
  data() {
    return {
      username: "Lê Trọng Quân",
      userAvatarUrl: "user-avatar.png",
    };
  },
  methods: {
    showMore() {},
    logout(command) {
      console.log(command);
      if (command == "a") {
        localStorage.clear();
        this.$router.push({ name: "login" });
      }
    },
  },
  computed: {
    avtUrl() {
      return require(`@/assets/images/${this.userAvatarUrl}`);
    },
  },
};
</script>

<style scoped>
@import url("./../../assets/css/header.css");
</style>

<template>
  <div id="app">
    <router-view/>
  </div>
</template>

<script>
export default {
  name: 'App'
}
</script>

<style>
body{
  margin: 0;
  padding: 0;
  font-size: 13px;
  font-family: GoogleSans Regular;
  /* color: #606266; */
}
@font-face {
  font-family: "GoogleSans Regular";
  src: url('./assets/font/google_sans/GoogleSans-Regular.otf') format("truetype");
}
</style>

<template>
<div class="global">
  <div class="g-global">
    <div><InformationGlobal /></div>
    <div><OrderDetail /></div>
  </div>
  </div>
</template>

<script>
import InformationGlobal from "./Information-Global.vue";
import OrderDetail from "./OrderDetail.vue";

export default {
  components: { InformationGlobal, OrderDetail },
};
</script>

<style>
.global{
  width: 1366px;
  margin: auto;
}
.g-global {
  display: flex;
  justify-content: center !important;
  padding: 32px 40px;
  font-family: GoogleSans Regular;
}
</style>
<template>
  <div class="slide-bar">
    <div class="home">
      <div class="spacing">
        <DropdownMenu id="dropdownmenu1" :arrays="arrays">
          DropdownMenu 1
        </DropdownMenu>
      </div>
    </div>
  </div>
</template>
<script>
export default {};
</script>
<style scoped>
.slide-bar {
  width: 250px;
  border: 1px solid #707070;
  background-color: rgb(131, 131, 114);
}
</style>

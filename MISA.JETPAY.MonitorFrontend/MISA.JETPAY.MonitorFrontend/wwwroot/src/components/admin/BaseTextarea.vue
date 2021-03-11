<template>
  <div>
    <label class="m-label">{{ label }}</label>
    <textarea
      class="m-input"
      v-bind:style="{ height: height }"
      v-bind="$attrs"
      v-bind:value="value"
      v-bind:placeholder="placeholder"
      v-on:input="$emit('input', $event.target.value)"
      v-on:keyup="setRef"
    ></textarea>
  </div>
</template>

<script>
export default {
  name: "BaseTextarea",
  inheritAttrs: false,
  props: {
    refName: String,
    height: String,
    label: String,
    value: String,
    placeholder: String,
    refName: String
  },
  methods: {
    setRef(){
      this.$emit("setRef", this.refName);
    }
  }
};
</script>

<style scoped>
@import url("./../../assets/css/form.css");
</style>
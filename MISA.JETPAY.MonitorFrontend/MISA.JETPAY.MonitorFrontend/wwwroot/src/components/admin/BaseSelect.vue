 <template>
  <div>
    <label class="m-label">{{ label }}</label>
    <el-select v-model="value" multiple placeholder="Select">
      <el-option
        v-for="item in options"
        :key="item.value"
        :label="item.label"
        :value="item.value"
      >
      </el-option>
    </el-select>
  </div>
</template>
 
 <script>
export default {
  name: "BaseInput",
  data() {
    return {
      input: "",
      options: [
        {
          value: "Option1",
          label: "Option1",
        },
        {
          value: "Option2",
          label: "Option2",
        },
        {
          value: "Option3",
          label: "Option3",
        },
        {
          value: "Option4",
          label: "Option4",
        },
        {
          value: "Option5",
          label: "Option5",
        },
      ],
      value: "",
    };
  },
  inheritAttrs: false,
  props: {
    label: String,
    placeholder: String,
  },
};
</script>

<style scoped>
@import url("./../../assets/css/form.css");
</style>
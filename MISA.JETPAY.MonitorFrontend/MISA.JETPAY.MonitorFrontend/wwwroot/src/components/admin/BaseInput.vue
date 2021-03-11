<template>
  <div class="m-p-input">
    <label class="m-label" v-html="label"></label>
    <input
      @focus="select"
      type="text"
      :class="`m-input ${isValid ? '' : 'error'}`"
      v-bind="$attrs"
      v-bind:value="value"
      v-bind:placeholder="placeholder"
      v-on:input="$emit('input', $event.target.value)"
      v-on:blur="validate"
      v-on:keyup="setRef"
    />
    <div :class="`${isValid ? 'hidden' : 'ridbon'}`">{{ title }}</div>
    <div :class="`${isValid ? 'hidden' : 'triangle'}`"></div>
  </div>
</template>

<script>
import { mapGetters } from "vuex";

export default {
  name: "BaseInput",
  inheritAttrs: false,
  props: {
    refName: String, // Tên của input hiện tại để dễ dàng set focus,...
    label: String, // Nhãn của input (Đây là input nhập nội dung gì)
    value: String, // Giá trị của input
    placeholder: String,
    required: {
      //Biến để biết input có cần được validate không (true-cần, false-không cần)
      required: false, //Không yêu cầu
      default: false, //Giá trị mặc định
    },
    title: String,
  },
  data() {
    return {
      isValid: true, // Biến kiểm tra dữ liệu hợp lệ của input được validate (true-hợp lệ, false-không hợp lệ)
    };
  },
  computed: {
    // Lấy các biến kiểm soát trên store
    ...mapGetters(["dialogVisible", "handerValidate"]),
    /**
     * Dùng để get/set dữ liệu với biến value, đồng bộ hóa khi thay đổi trong quá trình validate, cụ thể là khi trim chuỗi value
     * Author: LTQUAN (22/12/2020)
     */
    valueInput: {
      get() {
        // Khi thay đổi bằng hàm set thì biến value ở ngữ cảnh hiện tại chưa được cập nhật ngay
        // vì thế t phải để nó trong hàm setTimeout để có thể lấy được giá trị thay đổi
        setTimeout(() => {
          return this.value;
        }, 0);
      },
      set(newValue) {
        this.$emit("input", newValue);
      },
    },
  },
  methods: {
    /**
     * Hàm validate input
     * Author: LTQUAN (07/12/2020)
     * Updated by: NCBAO (21/12/2020) - check cả trường hợp input chứa cả nhiều ký tự space cũng là rỗng
     */
    validate() {
      // Nếu input cần validate thì tiến hành check
      if (this.required) {
        if (this.value) {
          // Cắt khoảng trắng 2 đầu
          this.valueInput = this.value.trim();
          this.isValid = this.valueInput ? true : false;
        } else {
          this.isValid = false;
        }
      }
    },
    /**
     * Hàm bôi đen toàn bộ text khi input được focus
     * Author: NCBAO (15/12/2020)
     */
    select: function (event) {
      event.target.setSelectionRange(0, event.target.value.length);
    },
    /**
     * Truyền ref của input hiện tại sang Component cha (modal chứa nó)
     * Author: NCBAO (15/12/2020)
     */
    setRef() {
      this.$emit("setRef", this.refName);
    },
  },
  /**
   * Hook updated khi value input thay đổi
   * Author: LTQUAN (07/12/2020)
   * Updated by: NCBAO (21/12/2020) - check cả trường hợp input chứa cả nhiều ký tự space cũng là rỗng
   */
  /**
   * Gán lại giá trị isValid khi nhập text
   * Author: LTQUAN (14/12/2020)
   */
  updated() {
    // Nếu value thay đổi thì gán lại isValid
    if (this.value) this.isValid = true;
  },
  watch: {
    /**
     * Gán lại giá trị isValid = true khi mởi form mới
     * Author: LTQUAN (14/12/2020)
     */
    dialogVisible: function (newDialogVisible) {
      this.isValid = true;
    },
    /**
     * Lắng nghe sự kiện save để gọi hàm validate
     * Author: LTQUAN (14/12/2020)
     */
    handerValidate: function (newHanderValidate) {
      if (this.required) {
        this.validate();
      }
    },
  },
};
</script>

<style scoped>
@import url("./../../assets/css/form.css");
</style>
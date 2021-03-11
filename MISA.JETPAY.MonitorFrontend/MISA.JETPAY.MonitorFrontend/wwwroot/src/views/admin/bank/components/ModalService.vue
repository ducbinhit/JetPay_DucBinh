<template>
  <el-dialog
    title="Thông tin dịch vụ"
    :visible.sync="modalServiceVisible"
    width="700px"
    :before-close="hideModalService"
  >
    <el-row :gutter="16">
      <el-col :span="12" :offset="0">
        <label class="m-label">Chọn dịch vụ thanh toán</label>
        <el-select
          class="m-el-select"
          v-model="value"
          placeholder="Chọn dịch vụ thanh toán"
          ref="firstTab"
        >
          <el-option
            v-for="item in options"
            :key="item.value"
            :label="item.label"
            :value="item.value"
          >
          </el-option>
        </el-select>
      </el-col>
      <el-col :span="12" :offset="0">
        <label class="m-label">Trạng thái</label>
        <el-select
          class="m-el-select"
          v-model="value"
          placeholder="Chọn trạng thái"
        >
          <el-option
            v-for="item in options"
            :key="item.value"
            :label="item.label"
            :value="item.value"
          >
          </el-option>
        </el-select>
      </el-col>
    </el-row>
    <el-row :gutter="16">
      <el-col :span="12" :offset="0">
        <BaseInput
          label="Jetpay Key"
          placeholder="Nhập Jeypay key"
          v-model="input"
        />
      </el-col>
      <el-col :span="12" :offset="0">
        <BaseInput
          label="Jetpay Password"
          placeholder="Nhập Jetpay password"
          v-model="input"
        />
      </el-col>
    </el-row>
    <el-row :gutter="16">
      <el-col :span="12" :offset="0">
        <BaseInput
          label="Bank Key"
          placeholder="Nhập Bank key"
          v-model="input"
        />
      </el-col>
      <el-col :span="12" :offset="0">
        <BaseInput
          label="Bank Password"
          placeholder="Nhập Bank password"
          v-model="input"
        />
      </el-col>
    </el-row>
    <el-row :gutter="16">
      <el-col :span="24" :offset="0">
        <BaseInput
          label="Url kết nối"
          placeholder="Nhập Url kết nối"
          v-model="input"
        />
      </el-col>
    </el-row>
    <span slot="footer" class="dialog-footer">
      <button
        class="m-btn m-btn-text-2 m-btn-cancel"
      >
        <span>Hủy</span>
      </button>
      <button
        class="m-btn m-btn-text-2 btn-add"
        @click="hideModalService"
        ref="endTab"
      >
        <span>Lưu</span>
      </button>
    </span>
  </el-dialog>
</template>

<script>
import BaseInput from "@/components/admin/BaseInput";
import { mapActions, mapGetters } from "vuex";
export default {
  name: "ModalService",
  props: {
    isShow: Boolean,
  },
  components: {
    BaseInput,
  },
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
      tabService: true, // Đặt trạng thái focus ở input đầu tiên
    };
  },
  computed:{
    ...mapGetters(['modalServiceVisible'])
  },
  methods: {
    ...mapActions(["showModalService"]),
    hideModalService() {
      this.showModalService(false);
    },
    /**
     * Xử lý tab index
     * Author: LTQUAN (09/12/2020)
     */
    setFocus(isFirst) {
      if (!isFirst) {
        this.$refs.endTab.focus();
      } else {
        this.$refs.firstTab.focus();
      }
    },
  },
  updated() {
    // Set tab index cho input đầu tiên
    if (this.tabService) {
      this.tabService = false;
      this.setFocus(true);
    }
  },
  watch: {
    /**
     * Theo dõi sự thay đổi của dialogVisible
     * Author: LTQUAN (09/12/2020)
     */
    isShow: function (newActive) {
      if (newActive) {
        // Đặt focus ở vị trí input đầu tiên khi mở dialog
        this.tabService = true;
      }
    },
  },
};
</script>

<style>
@import url("./../../../../assets/css/form.css");
@import url("./../../../../assets/css/dialog.css");
@import url("./../../../../assets/css/button.css");
.bank-dialog .m-el-select {
  width: 100%;
}
.el-select{
    width: 100%;
}
</style>
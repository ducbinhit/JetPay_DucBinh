<template>
  <div class="bank-dialog">
    <el-dialog
      title="THÊM MỚI ĐỐI TÁC TÍCH HỢP"
      custom-class="m-dialog"
      :visible.sync="dialogVisible"
      width="900px"
      :before-close="showDialog"
    >
      <el-row :gutter="16">
        <el-col :span="12" :offset="0">
          <BaseInput
            label="Mã đối tác"
            placeholder="Nhập mã đối tác"
            v-model="input"
            ref="firstTab"
          />
        </el-col>
        <el-col :span="12" :offset="0">
          <BaseInput
            label="Mã doanh nghiệp phát triển"
            placeholder="Mã doanh nghiệp phát triển"
            v-model="input"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseInput
            label="Tên đối tác"
            placeholder="Tên đối tác"
            v-model="input"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseSelect label="Chọn dịch vụ" v-model="input" />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseTextarea
            height="121px"
            label="Mô tả"
            placeholder="Nhập mô tả"
            v-model="input"
          />
        </el-col>
      </el-row>
      <span slot="footer" class="dialog-footer">
        <button class="m-btn m-btn-text-2 m-btn-cancel" @click="showDialog">
          <span>Hủy</span>
        </button>
        <button
          class="m-btn m-btn-text-2 btn-add"
          @click="showDialog"
          ref="endTab"
        >
          <span>Thêm mới</span>
        </button>
      </span>
    </el-dialog>
    <ModalService
      v-bind:isShow="isShowDialogService"
      v-on:showDialogService="showDialogService"
    />
  </div>
</template>

<script>
import { mapGetters } from "vuex";
import ModalService from "./ModalService";
import BaseInput from "@/components/admin/BaseInput";
import BaseTextarea from "@/components/admin/BaseTextarea";
import BaseSelect from "@/components/admin/BaseSelect";

/**
 * Dialog cho view danh sách đối tác tích hợp
 * Author: LTQUAN (05/12/2020)
 */
export default {
  components: {
    ModalService,
    BaseInput,
    BaseTextarea,
    BaseSelect,
  },
  data() {
    return {
      active: "first",
      isShowDialogService: false,
      input: "",
      textarea: "",
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
      value1: [],
      tab: true, // Đặt trạng thái focus ở input đầu tiên
    };
  },
  computed: {
    ...mapGetters(["dialogVisible"]),
  },
  methods: {
    /**
     * Ẩn hiện dialog
     * Author: LTQUAN (05/12/2020)
     */
    showDialog() {
      // this.$confirm("Are you sure to close this dialog?")
      //   .then(() => {
      //     this.$emit('showDialog', false);
      //   });
      this.$store.dispatch("showDialog", false);
      this.active = "first";
    },
    showDialogService(isShow) {
      this.isShowDialogService = isShow;
    },
    handleCloseService() {
      this.dialogService = false;
    },
    /**
     * Sự kiện thay đổi tab
     * Author: LTQUAN (06/12/2020)
     */
    handleClick(tab, event) {
      // console.log(tab, event);
    },
    /**
     * Xử lý tab index
     * Author: LTQUAN (09/12/2020)
     */
    setFocus(isFirst) {
      if (!isFirst) {
        this.$refs.endTab.focus();
      } else {
        this.$refs.firstTab.$el.children[1].focus();
      }
    },
  },
  updated() {
    // Set tab index cho input đầu tiên
    if (this.tab) {
      this.tab = false;
      this.setFocus(true);
    }
  },
  watch: {
    /**
     * Theo dõi sự thay đổi của dialogVisible
     * Author: LTQUAN (09/12/2020)
     */
    dialogVisible: function (newActive) {
      if (newActive) {
        // Đặt focus ở vị trí input đầu tiên khi mở dialog
        this.tab = true;
      }
    },
  },
};
</script>

<style scoped>
@import url("./../../../../assets/css/table.css");
/* @import url("./../../../../assets/css/form.css"); */
@import url("./../../../../assets/css/dialog.css");
@import url("./../../../../assets/css/button.css");
.bank-dialog .el-tabs__item {
  padding: 0 8px;
}
.bank-dialog .el-tab-pane {
  height: 300px;
}
.bank-dialog .el-tab-pane.tab-table {
  overflow-x: auto;
  overflow-y: hidden;
}
.bank-dialog .el-tab-pane table {
  width: 100%;
  height: calc(100% - 58px);
}
.bank-dialog .el-tabs__item {
  font-size: 15px;
}
.bank-dialog .el-tabs__nav-wrap::after {
  background-color: #bbbbbb;
}
.bank-dialog .m-btn-right {
  display: flex;
  align-items: center;
  justify-content: flex-end;
  grid-gap: 16px;
}
</style>
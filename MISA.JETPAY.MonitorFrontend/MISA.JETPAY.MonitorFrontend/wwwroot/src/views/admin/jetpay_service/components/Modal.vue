<template>
  <div class="service-modal">
    <el-dialog
      title="Thông tin dịch vụ"
      custom-class="m-dialog"
      :visible.sync="dialogVisible"
      width="600px"
      :before-close="showDialog"
    >
      <input class="hiddeninput" v-on:focus="setFocus(false)" />
      <el-row :gutter="16">
        <!-- Input ẩn phục mục đích tab index -->
        <el-col :span="24" :offset="0">
          <BaseInput
            label="Mã dịch vụ"
            placeholder="Nhập mã dịch vụ"
            v-model="objectDetail.code"
            ref="code"
            refName="code"
            required="true"
            title="Nhập mã dịch vụ"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseInput
            label="Tên dịch vụ"
            placeholder="Nhập tên dịch vụ"
            v-model="objectDetail.name"
            required="true"
            ref="name"
            refName="name"
            title="Nhập tên dịch vụ"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseTextarea
            height="100px"
            label="Mô tả"
            placeholder="Nhập mô tả"
            ref="descrip"
            refName="descrip"
            v-model="objectDetail.description"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <span slot="footer" class="dialog-footer">
        <button class="m-btn m-btn-text-2 m-btn-cancel" @click="showDialog">
          <span>Hủy</span>
        </button>
        <button
          class="m-btn m-btn-text-2 btn-add"
          @click="saveService"
          ref="endTab"
        >
          <span>Lưu</span>
        </button>
        <!-- Input ẩn phục mục đích tab index -->
        <input class="hiddeninput" v-on:focus="setFocus(true)" />
      </span>
    </el-dialog>
  </div>
</template>

<script>
import { ActionConfirm } from "./../../../../constants";
import { mapGetters, mapActions } from "vuex";
import BaseInput from "@/components/admin/BaseInput";
import BaseTextarea from "@/components/admin/BaseTextarea";
// import mixins from "./../../../../mixins";
/**
 * Dialog cho view dịch vụ hệ thống
 * Author: NCBAO (05/12/2020)
 */
export default {
  name: "jetpay-service",
  // mixins: [mixins],
  components: {
    BaseInput,
    BaseTextarea,
  },
  data() {
    return {
      tab: true, // Đặt trạng thái focus ở input đầu tiên
      refed: "", //Input đang được focus khi nhập liệu
    };
  },
  computed: {
    ...mapGetters([
      "dialogVisible",
      "objectDetail",
      "confirmDetail",
      "response",
      "action",
      "select",
    ]),
    //Set title cho form dialog
    title() {
      if (this.response.errorCode == "100") return "Thêm thành công";
      else return "Thêm thất bại";
    },
  },
  methods: {
    ...mapActions([
      "saveObject",
      "fetchData",
      "setSelect",
      "setHanderValidate",
    ]),
    /**
     *
     */
    setRef(refed) {
      this.refed = refed;
    },
    /**
     * Ẩn hiện dialog
     * Author: LTQUAN (07/12/2020)
     * Updated by: NCBAO (21/12/2020) - check cả trường hợp input chứa cả nhiều ký tự space cũng là rỗng
     */
    showDialog(isShow = true) {
      if (!isShow) {
        this.$store.dispatch("showDialog", {
          isShow: false,
          action: this.action,
        });
        this.setSelect();
      } else {
        // Kiểm tra xem form có giá trị nhập hay không
        let values = Object.values(this.objectDetail);
        if (values.length > 0)
          values = values.reduce((result, item) => result + item); // Chuyển các giá trị từ mảng values thành 1 chuỗi
        if (values.length > 0) {
          // Mở form confirm đóng
          this.showConfirmDialog({
            dialogConfirmVisible: true,
            title: "Thông báo",
            message: "Bạn có muốn đóng form hiện tại không?",
            action: ActionConfirm.CONFIRM_INFO,
            icon: "el-icon-warning m-warning",
          });
        } else {
          // Đóng form
          this.$store.dispatch("showDialog", {
            isShow: false,
            action: this.action,
          });
          this.setSelect();
        }
      }
      this.active = "first";
      this.setSelect();
    },
    /**
     * Ẩn hiện dialog confirm
     * Author: NCBAO(15/12/2020)
     */
    showConfirmDialog(isShow) {
      this.$store.dispatch("showConfirmDialog", isShow);
    },
    /**
     * Xử lý tab index
     * Author: NCBAO (09/12/2020)
     */
    setFocus(isFirst) {
      if (!isFirst) {
        this.$refs.endTab.focus();
      } else {
        this.$refs.code.$el.children[1].focus();
      }
    },

    /** Thêm dịch vụ hệ thống mới
     * Author: NCBAO (21/12/2020)
     */
    async saveService() {
      let valid = true;
      this.setHanderValidate();
      if (!this.objectDetail.name) valid = false;
      if (!this.objectDetail.code) valid = false;
      if (valid) {
        await this.saveObject({
          apiUrl: "/api/v1/services",
          data: this.objectDetail,
        });
        if (
          this.response.errorCode == "100" ||
          this.response.errorCode == "101"
        ) {
          this.$notify({
            title: this.response.userMsg,
            type: "success",
            customClass: "notify",
          });
          this.fetchData();
          this.showDialog(false);
        } else {
          this.showConfirmDialog({
            dialogConfirmVisible: true,
            title: "Thông báo",
            message: this.response.userMsg,
            action: 1,
            icon: "el-icon-warning m-warning",
          });
        }
        this.fetchData();
      } else {
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: "Dữ liệu không hợp lệ",
          message: `Vui lòng nhập đầy đủ các trường cần thiết`,
          action: ActionConfirm.CONFIRM_CLOSE,
          icon: "el-icon-warning m-warning",
        });
      }
    },
    /**
     * Nhận sự kiện ctrl + s gọi hàm saveService
     * Author: NCBAO (16/12/2020)
     */
    handerSave(e) {
      if (e.ctrlKey && e.keyCode === 83) {
        e.preventDefault();
        if (this.dialogVisible) this.saveService();
      } else return;
    },
  },
  /**
   * Add sự kiện keydown cho dom
   * Author: NCBAO (16/12/2020)
   */
  mounted() {
    document.addEventListener("keydown", this.handerSave);
  },
  /**
   * Xóa sự kiện keydown cho dom
   * Author: NCBAO (16/12/2020)
   */
  beforeDestroy() {
    document.removeEventListener("keydown", this.handerSave);
  },
  /**
   * Set tab Index
   * Author: NCBAO (11/12/2020)
   */
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
     * Author: NCBAO (09/12/2020)
     */
    dialogVisible: function (newActive) {
      if (newActive) {
        //Đặt focus ở vị trí input đầu tiên khi mở dialog
        this.tab = true;
      }
    },
    /**
     * Theo dõi sự thay đổi của computed select để select all text ô input đầu tiên khi mở form sửa
     * Author: NCBAO (15/12/2020)
     */
    select: function (newSelect) {
      this.$refs.code.$el.children[1].setSelectionRange(
        0,
        this.$refs.code.$el.children[1].value.length
      );
    },
    /**
     * Theo dõi vị trí của imput đang focus để focus lại khi hoàn tác đóng form
     * Author: NCBAO (15/12/2020)
     */
    confirmDetail: function (newConfirmDetail) {
      if (this.$refs[this.refed] != undefined)
        this.$refs[this.refed].$el.children[1].focus();
    },
  },
};
</script>

<style>
@import url("./../../../../assets/css/dialog.css");
@import url("./../../../../assets/css/button.css");
.service-modal .el-tabs__item {
  padding: 0 8px;
}
.service-modal .el-tab-pane {
  height: 300px;
}
.service-modal .el-tab-pane.tab-table {
  overflow-x: auto;
  overflow-y: hidden;
}
.service-modal .el-tab-pane table {
  width: 100%;
  height: calc(100% - 58px);
}
.service-modal .m-btn-right {
  display: flex;
  align-items: center;
  justify-content: flex-end;
  grid-gap: 16px;
}
div.cancel {
  display: flex;
}
</style>
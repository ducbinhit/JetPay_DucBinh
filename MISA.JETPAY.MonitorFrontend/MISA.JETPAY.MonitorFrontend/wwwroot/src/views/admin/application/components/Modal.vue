<template>
  <div>
    <el-dialog
      title="THÔNG TIN ỨNG DỤNG TÍCH HỢP"
      custom-class="m-dialog"
      :visible.sync="dialogVisible"
      width="700px"
      :before-close="showDialog"
      @keydown.ctrl.83.prevent.stop="handerSave"
    >
      <el-row :gutter="16">
        <!-- Input ẩn phục mục đích tab index -->
        <input class="hiddeninput" v-on:focus="setFocus(false)" />
        <el-col :span="12" :offset="0">
          <BaseInput
            label="Mã ứng dụng tích hợp (<span class='span-required'>*</span>)"
            placeholder="Nhập mã ứng dụng tích hợp"
            v-model="objectDetail.code"
            ref="firstTab"
            refName="firstTab"
            required="true"
            title="Hãy nhập mã ứng dụng tích hợp"
            v-on:setRef="setRef"
          />
        </el-col>
        <el-col :span="12" :offset="0">
          <BaseInput
            label="Tên ứng dụng tích hợp (<span class='span-required'>*</span>)"
            placeholder="Nhập tên ứng dụng tích hợp"
            v-model="objectDetail.name"
            ref="name"
            refName="name"
            required="true"
            title="Hãy nhập tên ứng dụng tích hợp"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="12" :offset="0">
          <BaseInput
            label="Key xác thực"
            placeholder="Nhập key xác thực"
            v-model="objectDetail.key"
            ref="key"
            refName="key"
            v-on:setRef="setRef"
          />
        </el-col>
        <el-col :span="12" :offset="0">
          <BaseInput
            label="Mã xác thực"
            placeholder="Nhập mã xác thực"
            v-model="objectDetail.pass"
            ref="pass"
            refName="pass"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseInput
            label="Địa chỉ kết nối (<span class='span-required'>*</span>)"
            placeholder="Nhập địa chỉ kết nối"
            v-model="objectDetail.url"
            required="true"
            title="Hãy nhập địa chỉ kết nối"
            ref="url"
            refName="url"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <el-row :gutter="16">
        <el-col :span="24" :offset="0">
          <BaseTextarea
            height="60px"
            label="Mô tả"
            placeholder="Nhập mô tả"
            v-model="objectDetail.description"
            ref="description"
            refName="description"
            v-on:setRef="setRef"
          />
        </el-col>
      </el-row>
      <span slot="footer" class="dialog-footer">
        <button class="m-btn m-btn-text-2 m-btn-cancel" @click="showDialog">
          <span>Hủy</span>
        </button>
        <button class="m-btn m-btn-text-2 btn-add" ref="endTab" @click="save">
          <span>Lưu</span>
        </button>
        <!-- Input ẩn phục mục đích tab index -->
        <input class="hiddeninput" v-on:focus="setFocus(true)" />
      </span>
    </el-dialog>
  </div>
</template>

<script>
//#region Import

import {
  ActionConfirm,
  Message,
  Icon,
  ChipStatus,
  Code,
  Api,
} from "./../../../../constants";
import { mapGetters, mapActions } from "vuex";
import BaseInput from "@/components/admin/BaseInput";
import BaseTextarea from "@/components/admin/BaseTextarea";

//#endregion

/**
 * Dialog cho view danh sách ứng dụng tích hợp
 * Author: LTQUAN (07/12/2020)
 */
export default {
  components: {
    BaseInput,
    BaseTextarea,
  },
  props: {
    isActionSuccess: Boolean,
  },
  data() {
    return {
      tab: true, // Đặt trạng thái focus ở input đầu tiên
      customClass: "notify",
      refed: 'firstTab'
    };
  },
  computed: {
    // Nhận các getters trên store, file: common.js
    ...mapGetters([
      "dialogVisible",
      "objectDetail",
      "dialogConfirmVisible",
      "response",
      "action",
      "select",
      "confirmDetail"
    ]),
  },
  methods: {
    // Nhận các action trên store, file: common.js
    ...mapActions([
      "saveObject",
      "fetchData",
      "setHanderValidate",
      "setSelect",
      "showDialog",
    ]),
    /**
     * Ẩn hiện dialog
     * @param {Boolean} isShow nếu isShow = false: Đóng form bỏ qua confirm
     * Author: LTQUAN (07/12/2020)
     */
    showDialog(isShow = true) {
      if (!isShow) {
        // Đóng form
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
            title: Message.TITLE_FORM_INFO,
            message: Message.MSG_CONFIRM_CLOSE,
            action: ActionConfirm.CONFIRM_INFO,
            icon: Icon.WARNING,
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
    },
    /**
     * Ẩn/hiện dialog confirm
     * @param {Object} dialogConfig Đối tượng cấu hình cho dialog confirm
     * Author: LTQUAN (14/12/2020)
     */
    showConfirmDialog(dialogConfig) {
      this.$store.dispatch("showConfirmDialog", dialogConfig);
    },
    /**
     * Xử lý tab index
     * @param {Boolean} isFirst true: input đầu tiên, false: input cuối
     * Author: LTQUAN (09/12/2020)
     */
    setFocus(isFirst) {
      if (!isFirst) {
        this.$refs.endTab.focus();
      } else {
        this.$refs.firstTab.$el.children[1].focus();
      }
    },
    /**
     * Lưu thay đổi trên form
     * Author: LTQUAN (16/12/2020)
     */
    async save() {
      // Nếu dữ liệu hợp lệ
      if (this.validate()) {
        // Gọi tới hàm lưu trên store
        await this.saveObject({
          apiUrl: Api.APPLICATION,
          data: this.objectDetail,
        });
        // Nếu thêm/sửa thành công
        if (
          this.response.errorCode == Code.ADD_SUCCESS ||
          this.response.errorCode == Code.UPDATE_SUCCESS
        ) {
          this.fetchData();
          // Show thông báo
          this.$notify({
            title: this.response.userMsg,
            type: ChipStatus.SUCCESS,
            customClass: this.customClass,
          });
          this.showDialog(false);
        } else {
          // Hiển thị dialog lỗi khi thêm, sửa thất bại
          this.showConfirmDialog({
            dialogConfirmVisible: true,
            title: Message.TITLE_INFO,
            message: this.response.userMsg,
            action: ActionConfirm.CONFIRM_CLOSE,
            icon: Icon.WARNING,
          });
        }
      } else {
        // Hiển thị dialog lỗi khi data không hợp lệ
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: Message.DATA_INVALID,
          message: Message.MSG_PL_INPUT,
          action: ActionConfirm.CONFIRM_CLOSE,
          icon: Icon.WARNING,
        });
      }
    },
    /**
     * Nhận sự kiện ctrl + s gọi hàm save
     * Author: LTQUAN(16/12/2020)
     */
    handerSave(e) {
      if(e.ctrlKey && e.keyCode === 83){
        e.preventDefault();
        // Nếu đang hiển thị form dialog thì mới gọi hàm save
        if (this.dialogVisible) this.save();
        return
      }
    },
    /**
     * Set lại ref khi nhập để đóng form dialog sẽ focus lại ô input đang nhập
     * @param {String} refName Tên của ref ứng với ô input
     * Author: LTQUAN (19/12/2020)
     */
    setRef(refName){
      this.refed = refName;
    },
    /**
     * Validate dữ liệu trên form
     * Author: LTQUAN (16/12/2020)
     */
    validate(){
      // Khởi tạo biến validate
      let valid = true;
      this.setHanderValidate();
      
      if (!this.objectDetail.code) { // Nếu code rỗng
        valid = false;
      } else if (!this.objectDetail.name) { // Nếu name rỗng
        valid = false;
      } else if (!this.objectDetail.url) { // Nếu url rỗng
        valid = false;
      }
      return valid;
    }
  },
  /**
   * Add sự kiện keydown cho dom
   * Author: LTQUAN (16/12/2020)
   */
  mounted() {
    document.addEventListener("keydown", this.handerSave);
  },
  /**
   * Xóa sự kiện keydown cho dom
   * Author: LTQUAN (16/12/2020)
   */
  beforeDestroy() {
    document.removeEventListener("keydown", this.handerSave);
  },
  /**
   * Set tab Index
   * Author: LTQUAN (11/12/2020)
   */
  updated() {
    // Set tab index cho input đầu tiên nếu this.tab = true
    if (this.tab) {
      this.tab = false;
      this.setFocus(true);
    }
  },
  watch: {
    /**
     * Theo dõi sự thay đổi của dialogVisible
     * @param {Boolean} newActive giá trị thay đổi của dialogVisible
     * Author: LTQUAN (09/12/2020)
     */
    dialogVisible: function (newActive) {
      if (newActive) {
        // Đặt focus ở vị trí input đầu tiên khi mở dialog
        this.tab = true;
      }
    },
    /**
     * Theo dõi sự thay đổi của biến select để gán lại input focus
     * @param {Any} newSelect giá trị thay đổi của select
     * Author: NCBAO (17/12/2020)
     */
    select: function (newSelect) {
      this.$refs.firstTab.$el.children[1].setSelectionRange(
        0,
        this.$refs.firstTab.$el.children[1].value.length
      );
    },
    /**
     * Theo dõi sự thay đổi của đối tượng comfimDetail để khi đóng form sẽ focus vào input hiện tại đang nhập
     * @param {Object} newConfirmDetail giá trị thay đổi của dialogVisible
     * Author: LTQUAN (19/12/2020)
     */
    confirmDetail: function(newComfirmDetail){
      // Nếu đóng form confirm và form dialog chi tiết vẫn hiển thị thì mới focus
      if(!newComfirmDetail.dialogConfirmVisible && this.dialogVisible){
        this.$refs[this.refed].$el.children[1].focus();
      }
    }
  },
};
</script>

<style>
@import url("./../../../../assets/css/dialog.css");
@import url("./../../../../assets/css/button.css");
</style>
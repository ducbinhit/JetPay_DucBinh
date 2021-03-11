<template>
  <el-dialog
    :title="confirmDetail.title"
    :visible.sync="confirmDetail.dialogConfirmVisible"
    width="450px"
    top="30vh"
    :before-close="showConfirmDialog"
  >
    <div class="body-dialog">
      <i
        v-if="confirmDetail.icon"
        class="m-icon-40"
        :class="confirmDetail.icon"
      ></i>
      <span style="word-break: break-word">{{ confirmDetail.message }}</span>
    </div>
    <span slot="footer" class="dialog-footer">
      <button
        v-if="confirmDetail.action == 3"
        class="m-btn m-btn-cancel"
        @click="showDialog(true)"
        ref="continue"
      >
        <span>Tiếp tục nhập</span>
      </button>
      <button
        v-if="confirmDetail.action == 2 || confirmDetail.action == 4"
        class="m-btn m-btn-text-2 m-btn-cancel"
        @click="showDialog"
        ref="cancel"
        @blur="foc('deleteAll')"
      >
        <span>Hủy</span>
      </button>
      <button
        v-if="confirmDetail.action == 1"
        class="m-btn m-btn-text-2 btn-add"
        ref="close"
        @click="showDialog"
       
      >
        <span>Đóng</span>
      </button>
      <button
        v-if="confirmDetail.action == 3"
        class="m-btn m-btn-text-2 btn-add"
        ref="closeAll"
        @click="onHideAll"
        @blur="foc('continue')"
      >
        <span>Đóng</span>
      </button>
      <button
        v-if="confirmDetail.action == 2"
        class="m-btn m-btn-text-2 m-btn-danger"
        ref="delete"
        @click="onDelete"
        @blur="foc('cancel')"
      >
        <span>Xóa</span>
      </button>
      <button
        v-if="confirmDetail.action == 4"
        class="m-btn m-btn-text-2 m-btn-danger"
        ref="deleteAll"
        @click="onDeleteAlot"
        @blur="foc('cancel')"
      >
        <span>Xóa</span>
      </button>
    </span>
  </el-dialog>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import { Icon, Message, ChipStatus } from './../../constants';

export default {
  computed: {
    ...mapGetters(["confirmDetail", "response"]),
  },
  data(){
    return {
      customClass: "notify",
    }
  },
  methods: {
    ...mapActions([
      "showConfirmDialog",
      "deleteObject",
      "fetchData",
      "deleteAlotObject",
      "setItemClicked",
      "deleteListItem",
    ]),
    /**
     * Đóng form dialog
     * Author: LTQUAN (11/12/2020)
     */
    showDialog() {
      this.confirmDetail.dialogConfirmVisible = false;
      this.showConfirmDialog({ dialogConfirmVisible: false });
    },
    /**
     * Đóng tất cả form
     * Author: LTQUAN (16/12/2020)
     */
    onHideAll() {
      this.showDialog();
      this.$store.dispatch("showDialog", { isShow: false });
    },
    /**
     * Sự kiện xóa khỏi danh sách
     * Author: LTQUAN (15/12/2020)
     */
    async onDelete() {
      const isSuccess = await this.deleteObject();
      if (isSuccess) {
        this.$notify({
          title: this.response.userMsg,
          type: ChipStatus.SUCCESS,
          customClass: this.customClass,
        });
      } else {
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: "Thông báo",
          message: this.response.userMsg,
          action: 1,
          icon: "el-icon-warning m-warning",
        });
      }
      this.showDialog();
      this.fetchData();
    },
    /**
     * Sự kiện xóa nhiều khỏi danh sách
     * Author: NCBAO (15/12/2020)
     */
    async onDeleteAlot() {
      const isSuccess = await this.deleteAlotObject();
      if (isSuccess) {
        this.$notify({
          title: this.response.userMsg,
          type: "success",
          customClass: "notify",
        });
        this.deleteListItem();
        this.setItemClicked(false);
      } else {
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: Message.TITLE_INFO,
          message: this.response.userMsg,
          action: 1,
          icon: Icon.WARNING,
        });
      }
      this.showDialog();
      this.fetchData();
    },
    /**
     * Set focus qua lại giữa các nút trong form confirm
     * Author NCBAO (17/12/2020)
     */
    foc(btn) {
      if(!(this.$refs[btn]==undefined))
      this.$refs[btn].focus();
    },
  },
  /**
   * Set focus vào button khi mở dialog
   * Author: LTQUAN (16/12/2020)
   */
  updated() {
    if (this.confirmDetail.action == 2) {
      this.$refs.delete.focus();
    } else if (this.confirmDetail.action == 3) {
      this.$refs.closeAll.focus();
    } else if (this.confirmDetail.action == 1) {
      this.$refs.close.focus();
    } else if (this.confirmDetail.action == 4) {
      this.$refs.deleteAll.focus();
    }
  },
};
</script>

<style>
.body-dialog {
  display: flex;
  align-items: center;
  grid-gap: 10px;
}

.m-icon-40 {
  font-size: 40px;
}
.m-warning {
  color: #fdd579;
}
.m-danger {
  color: #f56c6c;
}
</style>
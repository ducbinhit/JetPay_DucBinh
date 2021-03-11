<template>
  <div>
    <el-dialog
      top="5vh"
      title="THÔNG TIN GIAO DỊCH"
      custom-class="m-dialog dialog-transaction-infor"
      :visible.sync="dialogVisible"
      width="1000px"
      :before-close="showDialog"
      close-on-press-escape
    >
      <!-- #region Nội dung dialog -->
      <div class="dialog-content">
        <div class="left-side">
          <p>
            <span style="border-bottom: 3px solid red; padding-bottom: 3px"
              >Thông tin</span
            >
            giao dịch
          </p>
          <div>
            <label class="title">Id giao dịch: </label>
            <label class="content">{{ objectDetail.id }}</label>
          </div>
          <div>
            <label class="title">Mã giao dịch: </label>
            <label class="content">{{ objectDetail.code }}</label>
          </div>
          <div>
            <label class="title">Số tiền: </label>
            <label class="content">{{
              formatCurrency(objectDetail.amount)
            }}</label>
          </div>
          <div>
            <label class="title">Trạng thái: </label>
            <label class="content">{{ objectDetail.statusName }}</label>
          </div>
          <div>
            <label class="title">Loại giao dịch: </label>
            <label class="content">{{ objectDetail.typeName }}</label>
          </div>
          <div>
            <label class="title">Phí: </label>
            <label class="content">{{ objectDetail.fee }}</label>
          </div>
          <div>
            <label class="title">Đơn vị tiền tệ: </label>
            <label class="content">{{ objectDetail.ccy }}</label>
          </div>
          <div>
            <label class="title">Mô tả giao dịch: </label>
            <label class="content">{{ objectDetail.description }}</label>
          </div>
          <div>
            <label class="title">Mã hóa đơn: </label>
            <label class="content">{{ objectDetail.orderId }}</label>
          </div>
          <div>
            <label class="title">Mã khách hàng: </label>
            <label class="content">{{ objectDetail.customerId }}</label>
          </div>
          <div>
            <label class="title">Ngày tạo: </label>
            <label class="content">{{
              formatDate(objectDetail.createdDate)
            }}</label>
          </div>
          <div>
            <label class="title">Ngày cập nhật: </label>
            <label class="content">{{
              formatDate(objectDetail.updatedDate)
            }}</label>
          </div>
        </div>
        <div class="right-side">
          <div>
            <p>
              <span style="border-bottom: 3px solid red; padding-bottom: 3px"
                >Thông tin</span
              >
              phía đối tác thanh toán
            </p>
            <div>
              <label class="title">Mã ngân hàng: </label>
              <label class="content">{{ objectDetail.bankCode }}</label>
            </div>
            <div>
              <label class="title">Mã giao dịch: </label>
              <label class="content">{{ objectDetail.bankRefId }}</label>
            </div>
            <div>
              <label class="title">Mã lỗi: </label>
              <label class="content">{{ objectDetail.bankResponseCode }}</label>
            </div>
            <div>
              <label class="title">Mô tả mã lỗi: </label>
              <label class="content">{{
                objectDetail.bankResponseMessage
              }}</label>
            </div>
          </div>
          <div>
            <p>
              <span style="border-bottom: 3px solid red; padding-bottom: 3px"
                >Thông tin</span
              >
              phía ứng dụng tích hợp
            </p>
            <div>
              <label class="title">Mã ứng dụng: </label>
              <label class="content">{{ objectDetail.appCode }}</label>
            </div>
            <div>
              <label class="title">Mã giao dịch: </label>
              <label class="content">{{ objectDetail.appRefId }}</label>
            </div>
            <div>
              <label class="title">Mã lỗi: </label>
              <label class="content">{{ objectDetail.appResponseCode }}</label>
            </div>
            <div>
              <label class="title">Mô tả mã lỗi: </label>
              <label class="content">{{
                objectDetail.appResponseMessage
              }}</label>
            </div>
          </div>
        </div>
      </div>
      <!-- #endregion -->
      <span slot="footer" class="dialog-footer">
        <button class="m-btn m-btn-text-2 btn-add" @click="showDialog">
          <span>Đóng</span>
        </button>
      </span>
    </el-dialog>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import mixins from "./../../../../mixins";

export default {
  // Sử dụng các hàm dùng chung
  mixins: [mixins],
  computed: {
    // Nhận các biến trên store
    ...mapGetters(["dialogVisible", "objectDetail"]),
  },
  methods: {
    /**
     * Ẩn/hiện dialog
     * Author: LTQUAN (09/12/2020)
     */
    showDialog() {
      this.$store.dispatch("showDialog", false);
    },
  },
};
</script>

<style>
@import url("./../../../../assets/css/dialog.css");
@import url("./../../../../assets/css/button.css");
@import url("./../../../../assets/css/pages/transaction/modal.css");
</style>            
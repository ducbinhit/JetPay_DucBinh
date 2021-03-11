<template>
  <div class="grid">
    <table border="0" cellspacing="0">
      <thead>
        <th title="Mã giao dịch phía ngân hàng">MDG ngân hàng</th>
        <th title="Mã hóa đơn">Mã hóa đơn</th>
        <th title="Loại giao dịch">Loại giao dịch</th>
        <th title="Trạng thái giao dịch">Trạng thái</th>
        <th title="Số tiền">Số tiền</th>
        <th title="Mã khách hàng">Mã khách hàng</th>
        <th title="Tên khách hàng">Tên khách hàng</th>
        <th title="Mã ngân hàng giao dịch">Mã ngân hàng</th>
        <th title="Ngày giao dịch">Ngày giao dịch</th>
      </thead>
      <tbody>
        <!-- #region tr -->
        <tr
          v-for="(item, i) in paginateInfo.items"
          :key="i"
          @dblclick="showDialog(item.id)"
        >
          <td :title="item.bankRefId">{{ item.bankRefId }}</td>
          <td :title="item.orderId">{{ item.orderId }}</td>
          <td :title="item.typeName">{{ item.typeName }}</td>
          <td style="text-align: center">
            <span class="chip-status" :class="statusState(item.status)">{{
              item.statusName
            }}</span>
          </td>
          <td style="text-align: right">
            {{ formatCurrency(item.amount) }}
          </td>
          <td :title="item.customerId">{{ item.customerId }}</td>
          <td :title="item.customerName">{{ item.customerName }}</td>
          <td :title="item.bankCode">{{ item.bankCode }}</td>
          <td style="text-align: center" :title="formatDate(item.createdDate)">
            {{ formatDate(item.createdDate) }}
          </td>
        </tr>
        <!-- end region -->
      </tbody>
    </table>
  </div>
</template>

<script>
//#region Import

import { mapGetters, mapActions } from "vuex";
import { CallService } from "./../../../../service";
import mixins from "./../../../../mixins";
import { ChipStatus, Api, TransactionType } from './../../../../constants';

//#endregion

export default {
  name: "TableTransaction",
  mixins: [mixins],
  computed: {
    // Nhận các biến trên store
    ...mapGetters(["paginateInfo", "apiUrl"]),
  },
  created() {
    this.setApiUrl(Api.TRANSACTION);
    this.fetchData();
  },
  methods: {
    // Nhân các action trên store
    ...mapActions(["fetchData", "setApiUrl", "fetchObjectDetail"]),
    /**
     * Hiển thị/ẩn dialog
     * Author: LTQUAN (11/12/2020)
     * @param {String} id Id bản ghi cần lấy chi tiết
     */
    showDialog(id) {
      this.$store.dispatch("showDialog", { isShow: true });
      // Load chi tiết bản ghi
      this.fetchObjectDetail({ apiUrl: this.apiUrl, id: id });
    },
    /**
     * Lấy class trạng thái
     * Author: LTQUAN (15/12/2020)
     */
    statusState(status) {
      if (status == TransactionType.SUCCESS) return ChipStatus.SUCCESS;
      else if (status == TransactionType.PRIMARY) return ChipStatus.PRIMARY;
      else if (status == TransactionType.WARNING) return ChipStatus.WARNING;
      else return ChipStatus.DANGER;
    },
  },
};
</script>

<style scoped>
@import url("./../../../../assets/css/table.css");
@import url("./../../../../assets/css/pages/transaction/table.css");
</style> 
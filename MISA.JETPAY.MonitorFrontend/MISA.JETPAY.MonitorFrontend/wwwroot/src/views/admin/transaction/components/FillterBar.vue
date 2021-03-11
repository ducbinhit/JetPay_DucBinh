<template>
  <div class="container">
    <div class="left-side">
      <div class="icon-input txt-seach">
        <input
          type="text"
          class="m-input m-input-icon"
          placeholder="Mã giao dịch tại ngân hàng, mã hóa đơn, mã khách hàng, tên khách hàng"
          v-model="filter.search"
          @keyup.prevent.enter="searchTransaction"
          @blur="searchTransaction"
        />
        <span><i class="el-icon-search"></i></span>
        <span
          @mouseover="isShowIconClear = true"
          @mouseout="isShowIconClear = false"
          @click="
            filter.search = '';
            searchTransaction();
          "
          class="clear-text"
        >
          <i
            @mouseover="isShowIconClear = !isShowIconClear"
            v-show="isShowIconClear"
            class="el-icon-circle-close"
          ></i>
        </span>
      </div>
      <!-- Chọn loại giao dịch -->
      <el-select
        v-model="filter.type"
        clearable
        placeholder="Chọn loại giao dịch"
        title="Chọn loại giao dịch"
        v-on:change="searchTransaction"
      >
        <el-option
          v-for="item in types"
          :key="item.value"
          :label="item.label"
          :value="item.value"
        >
        </el-option>
      </el-select>
      <!-- Chọn trạng thái giao dịch -->
      <el-select
        v-model="filter.status"
        clearable
        placeholder="Chọn trạng thái giao dịch"
        title="Chọn trạng thái giao dịch"
        v-on:change="searchTransaction"
      >
        <el-option
          v-for="item in statusData"
          :key="item.value"
          :label="item.label"
          :value="item.value"
        >
        </el-option>
      </el-select>
      <!-- Chọn khoảng thời gian -->
      <div class="block">
        <el-date-picker
          v-model="time"
          type="datetimerange"
          range-separator="-"
          start-placeholder="Ngày bắt đầu"
          end-placeholder="Ngày kết thúc"
          title="Chọn khoảng thời gian giao dịch"
          v-on:change="searchTransaction"
        >
        </el-date-picker>
      </div>
    </div>
    <!-- <div class="right-side">
      <button class="m-btn m-btn-default">
        <i class="el-icon-download"></i><span>Xuất file</span>
      </button>
    </div> -->
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import mixins from "./../../../../mixins";

export default {
  name: "FilterBar",
  mixins: [mixins],
  data() {
    return {
      isShowIconClear: false,
      time: [],
      //Loại giao dịch
      types: [
        {
          value: 1,
          label: "Thu hộ",
        },
        {
          value: 2,
          label: "QR Code",
        },
        {
          value: 3,
          label: "Cổng thanh toán",
        },
        {
          value: 4,
          label: "Ví điện tử",
        },
      ],
      //Trạng thái giao dịch
      statusData: [
        {
          value: 0,
          label: "Mới tạo",
        },
        {
          value: 1,
          label: "Đang xử lý",
        },
        {
          value: 2,
          label: "Thành công",
        },
        {
          value: 3,
          label: "Thất bại",
        },
      ],
    };
  },
  computed: {
    // Lấy các getters trên store, file: paginate.js
    ...mapGetters(["filter"]),
  },
  methods: {
    // Lấy các action trên store, filae: paginate.js
    ...mapActions(["setFilter", "fetchData"]),
    /**
     * Kích hoạt tìm kiếm
     * Author: NCBAO (09/12/2020)
     * EditBy: LTQUAN (14/12/2020) thêm các thuộc tính filter
     */
    searchTransaction() {
      let filter = {
        search: this.filter.search,
        type: this.filter.type || null,
        status: this.filter.status >= 0 ? this.filter.status : null,
        startDate: this.time ? this.formatDateTime(this.time[0]) : null,
        endDate: this.time ? this.formatDateTime(this.time[1]) : null,
      };
      this.setFilter(filter);
      this.fetchData();
    },
  },
  watch: {
    /**
     * Kiểm tra nếu startDate hoặc endDate thay đổi thì cập nhật lại time
     * vì biến time dùng để binding 2 chiều với input date
     * @param {Object} newFilter Giá trị mới của đối tượng filter
     * Author: LTQUAN (14/12/2020)
     */
    filter: function (newFilter) {
      // Nếu startDate và endDate bị xóa
      if (!newFilter.startDate || !newFilter.endDate) {
        this.time = [];
      }
    },
  },
};
</script>

<style>
@import url("./../../../../assets/css/form.css");
@import url("./../../../../assets/css/button.css");
@import url("./../../../../assets/css/filter_bar.css");
</style>
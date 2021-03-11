<template>
  <div class="pagination">
    <div class="info-limit">
      <span>Hiển thị {{ infoRecord }} bản ghi</span>
    </div>
    <div class="page">
      <ul>
        <li class="page-control" @click="onChangePage(Paginate.FIRST_PAGE)">
          <a><i class="el-icon-d-arrow-left"></i></a>
        </li>
        <li class="page-control" @click="onChangePage(Paginate.PREVIOUS_PAGE)">
          <a><i class="el-icon-arrow-left"></i></a>
        </li>
        <li
          class="page-number"
          @click="onChangePage(Paginate.FIRST, pageInfo.pagesDisplay[0])"
          :class="{ active: pageInfo.cursor == Paginate.FIRST }"
        >
          <a>{{ pageInfo.pagesDisplay[0] }}</a>
        </li>
        <li
          v-show="paginateInfo.pages >= 2"
          class="page-number"
          @click="onChangePage(Paginate.SECOND, pageInfo.pagesDisplay[1])"
          :class="{ active: pageInfo.cursor == Paginate.SECOND }"
        >
          <a>{{ pageInfo.pagesDisplay[1] }}</a>
        </li>
        <li
          v-show="paginateInfo.pages >= 3"
          class="page-number"
          @click="onChangePage(Paginate.THIRD, pageInfo.pagesDisplay[2])"
          :class="{ active: pageInfo.cursor == Paginate.THIRD }"
        >
          <a>{{ pageInfo.pagesDisplay[2] }}</a>
        </li>
        <li
          v-show="paginateInfo.pages >= 4"
          class="page-number"
          @click="onChangePage(Paginate.FOURTH, pageInfo.pagesDisplay[3])"
          :class="{ active: pageInfo.cursor == Paginate.FOURTH }"
        >
          <a>{{ pageInfo.pagesDisplay[3] }}</a>
        </li>
        <li class="page-control" @click="onChangePage(Paginate.NEXT_PAGE)">
          <a><i class="el-icon-arrow-right"></i></a>
        </li>
        <li
          class="page-control"
          disabled
          @click="onChangePage(Paginate.LAST_PAGE)"
        >
          <a><i class="el-icon-d-arrow-right"></i></a>
        </li>
      </ul>
    </div>
    <div class="info-page">
      <el-select v-model="size" placeholder="Select">
        <el-option
          v-for="item in options"
          :key="item.value"
          :label="item.label"
          :value="item.value"
        >
        </el-option>
      </el-select>
    </div>
  </div>
</template>

<script>
import { mapGetters, mapActions } from "vuex";
import { Paginate } from "./../../constants";

/**
 * Component dùng chung cho phân trang
 * Author: LTQUAN (04/12/2020)
 */
export default {
  name: "Pagination",
  data() {
    return {
      Paginate: Paginate,
      options: [
        {
          value: 25,
          label: "25 bản ghi/trang",
        },
        {
          value: 50,
          label: "50 bản ghi/trang",
        },
        {
          value: 100,
          label: "100 bản ghi/trang",
        },
        {
          value: 200,
          label: "200 bản ghi/trang",
        },
        {
          value: 500,
          label: "500 bản ghi/trang",
        },
      ],
    };
  },
  computed: {
    // Nhận các getters từ trên store, file: paginate.js
    ...mapGetters(["paginateInfo", "pageInfo", "infoRecord"]),
    // Lấy số lượng bản ghi trên 1 trang từ server, binding 2 chiều
    size: {
      /**
       * Lấy giá trị size từ store
       * Author: LTQUAN (11/12/2020)
       */
      get() {
        return this.$store.getters.size;
      },
      /**
       * Gán lại giá trị size khi thay đổi
       * @param {Number} value Chỉ số mới của size
       * Author: LTQUAN (11/12/2020)
       */
      set(value) {
        this.setPageSize(value);
        this.fetchData();
      },
    },
  },
  methods: {
    // Lấy các actions trên store, file: paginate.js
    ...mapActions(["setIndex", "fetchData", "setPageSize"]),
    /**
     * Sự kiện thay đổi trang
     * @param {Any} pageCursor Vị trí button chọn chuyển trang
     * @param {Number} pageNumber Chỉ số trang chuyển tới
     * Author: LTQUAN (11/12/2020)
     */
    onChangePage(pageCursor, pageNumber) {
      // Kiểm tra nếu sử dụng các button control giảm pageIndex
      if (
        (pageCursor == this.Paginate.FIRST_PAGE ||
          pageCursor == this.Paginate.PREVIOUS_PAGE) &&
        this.paginateInfo.hasPrevious
      ) {
        this.setIndex(pageCursor);
        this.fetchData();
      }

      // Kiểm tra nếu sử dung các button control tăng pageIndex
      if (
        (pageCursor == this.Paginate.NEXT_PAGE ||
          pageCursor == this.Paginate.LAST_PAGE) &&
        this.paginateInfo.hasNext
      ) {
        this.setIndex(pageCursor);
        this.fetchData();
      }

      // Kiểm tra nếu sử dụng các button number
      if (typeof pageCursor === "number") {
        let { index } = this.paginateInfo;
        this.setIndex({ pageCursor, pageNumber });
        // Kiểm tra nếu thay đổi mới fetch lại data
        if (index !== this.paginateInfo.index) this.fetchData();
      }
    },
  },
};
</script>

<style scoped>
@import url("./../../assets/css/pagination.css");
</style>
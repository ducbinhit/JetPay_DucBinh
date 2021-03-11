<template>
  <div class="grid">
    <table border="0" cellspacing="0">
      <thead>
        <tr>
          <th>
            <el-checkbox
              v-model="isCheck"
              @change="handleSetAllItemClicked(isCheck)"
            ></el-checkbox>
          </th>
          <th>Mã dịch vụ</th>
          <th>Tên dịch vụ</th>
          <th>Mô tả</th>
          <th>Ngày tạo</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in paginateInfo.items" :key="item.id">
          <td>
            <CheckBox
              :id="item.id"
              v-on:handleClickCheckBox="handleClickCheckBox"
              v-on:setSetAllItemClicked="setSetAllItemClicked"
            />
          </td>
          <td>{{ item.code }}</td>
          <td>{{ item.name }}</td>
          <td>{{ item.description }}</td>
          <td>{{ formatDate(item.createdDate) }}</td>
          <td>
            <el-dropdown @command="handleSelectAction" trigger="click">
              <span class="el-dropdown-link"
                ><i class="el-icon-more"></i>
              </span>
              <el-dropdown-menu slot="dropdown" class="dropdown-more">
                <el-dropdown-item :command="{ method: 'PUT', id: item.id }"
                  >Sửa</el-dropdown-item
                >
                <el-dropdown-item
                  :command="{ method: 'DELETE', id: item.id, code: item.code }"
                  >Xóa</el-dropdown-item
                >
              </el-dropdown-menu>
            </el-dropdown>
          </td>
        </tr>
      </tbody>
    </table>
    <ConfirmActionDialog />
  </div>
</template>

<script>
import mixins from "./../../../../mixins";
import { ActionConfirm } from "./../../../../constants";
import { mapActions, mapGetters } from "vuex";
import ConfirmActionDialog from "@/components/admin/ConfirmActionDialog";
import CheckBox from "@/components/admin/CheckBox";
export default {
  name: "Table",
  data() {
    return {
      isCheck: false, //Biến kiểm tra có chọn tất cả các hàng không
    };
  },
  mixins: [mixins],
  components: {
    ConfirmActionDialog,
    CheckBox,
  },
  created() {
    this.setApiUrl("/api/v1/services");
    this.fetchData();
  },
  computed: {
    ...mapGetters(["paginateInfo", "objectDetail", "apiUrl"]),
  },
  methods: {
    ...mapActions([
      "fetchData",
      "showDialog",
      "setApiUrl",
      "showConfirmDialog",
      "fetchObjectDetail",
      "changeListItem",
      "setItemClicked",
      "setAllItemClicked",
      "setListItem",
      "deleteListItem",
      "setAllItemClicked",
    ]),
    // Xử lý hiện form để sửa hoặc xóa
    //Author: NCBAO (15/12/2020)
    handleSelectAction(action) {
      if (action.method == "PUT") {
        this.fetchObjectDetail({ apiUrl: this.apiUrl, id: action.id });
        this.showDialog({ isShow: true, action: "PUT" });
      } else {
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: "Xóa dịch vụ",
          message: `Bạn có chắc chắn muốn xóa dịch vụ có mã ${action.code} ?`,
          action: ActionConfirm.CONFIRM_DELETE,
          apiUrl: this.apiUrl,
          id: action.id,
          icon: "el-icon-warning m-danger",
        });
      }
    },
    /**
     * Xử lý khi click chọn các bản ghi
     * Author: NCBAO (18/12/2020)
     */
    handleClickCheckBox(id) {
      this.changeListItem(id);
      this.setItemClicked(true);
    },
    /**
     * Hàm xử lý khi check box chọn tất cả thay đổi
     * Author: NCBAO (18/12/2020)
     */
    handleSetAllItemClicked() {
      this.setAllItemClicked(this.isCheck);
      if (this.isCheck) {
        this.setListItem(this.paginateInfo.items.map((a) => a.id));
      } else {
        this.deleteListItem();
      }
    },
    /**
     * Hàm gán lại checkBox tất cả khi checkBox con cuối cùng không được chọn
     */
    setSetAllItemClicked(isCheck) {
      this.isCheck = isCheck;
    },
  },
  watch: {
    paginateInfo: function () {
      this.setAllItemClicked(false);
      this.deleteListItem();
      this.isCheck = false;
    },
  },
};
</script>

<style scoped>
@import url("./../../../../assets/css/table.css");
.grid > table {
  width: 100%;
}
/* Thead */
/*#region Thead*/
tbody tr td:nth-child(1) {
  width: 4%;
}
thead th:nth-child(2) {
  width: 17%;
}
thead th:nth-child(3) {
  width: 20%;
}
thead th:nth-child(4) {
  width: 35%;
}
thead th:nth-child(5) {
  width: 20%;
}
thead th:nth-child(6) {
  width: 4%;
}
/*#endregion*/

/* TBody */
/*#region TBody*/
tbody tr td:nth-child(1) {
  width: 4%;
}
tbody tr td:nth-child(2) {
  width: 17%;
}
tbody tr td:nth-child(3) {
  width: 20%;
}
tbody tr td:nth-child(4) {
  width: 35%;
}
tbody tr td:nth-child(5) {
  width: 20%;
}
tbody tr td:nth-child(6) {
  width: 4%;
}
/*#endregion*/
</style>
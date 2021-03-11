<template>
  <div class="grid">
    <table border="0" cellspacing="0">
      <thead>
        <tr>
          <th>Mã ứng dụng</th>
          <th>Tên ứng dụng</th>
          <th>Địa chỉ kết nối</th>
          <th>Key xác thực</th>
          <th>Mã xác thực</th>
          <th>Mô tả</th>
          <th></th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in paginateInfo.items" :key="item.id">
          <td>{{ item.code }}</td>
          <td>{{ item.name }}</td>
          <td>{{ item.url }}</td>
          <td>{{ item.key }}</td>
          <td>{{ item.pass }}</td>
          <td>{{ item.description }}</td>
          <td>
            <el-dropdown @command="handerSelectAction" trigger="hover">
              <span class="el-dropdown-link"
                ><i class="el-icon-more"></i>
              </span>
              <el-dropdown-menu slot="dropdown" class="dropdown-more">
                <el-dropdown-item :command="{ method: HttpMethod.PUT, id: item.id }"
                  >Sửa</el-dropdown-item
                >
                <el-dropdown-item :command="{ method: HttpMethod.DELETE, id: item.id, code: item.code }"
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
//#region Import

import { ActionConfirm, Message, Icon, HttpMethod, Api } from "./../../../../constants";
import { mapActions, mapGetters } from "vuex";
import ConfirmActionDialog from "@/components/admin/ConfirmActionDialog";

//#endregion

/**
 * Bảng đối tác thanh toán
 * Author: LTQUAN (04/12/2020)
 */
export default {
  name: "Table",
  components: {
    ConfirmActionDialog,
  },
  data(){
return {
  // các http method
  HttpMethod: HttpMethod
}
  },
  created() {
    // Gán lại biến apiUrl trên store
    this.setApiUrl(Api.APPLICATION);
    // Load lại dữ liệu
    this.fetchData();
  },
  computed: {
    // Nhận các getters trên store, file: common.js
    ...mapGetters(["paginateInfo", "apiUrl"]),
  },
  methods: {
    // Nhận các action trên store, file: common.js, paginate.js
    ...mapActions([
      "fetchData",
      "showDialog",
      "setApiUrl",
      "showConfirmDialog",
      "fetchObjectDetail",
    ]),
    /**
     * Xử lý hiện form để sửa hoặc xóa
     * Author: LTQUAN (11/12/2020)
     */
    handerSelectAction(action) {
      if (action.method == HttpMethod.PUT) {
        this.fetchObjectDetail({ apiUrl: this.apiUrl, id: action.id });
        this.showDialog({ isShow: true, action: HttpMethod.PUT });
      } else {
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: Message.DELETE_APP,
          message: this.makeMsgCF(action.code),
          action: ActionConfirm.CONFIRM_DELETE,
          apiUrl: this.apiUrl,
          id: action.id,
          icon: Icon.DANGER
        });
      }
    },
    /**
     * Tạo msg confim khi xóa
     * Author: LTQUAN (18/12/2020)
     * @param {String} code Mã ứng dụng xóa
     */
    makeMsgCF(code){
      return `Bạn có chắc chắn muốn xóa ứng dụng có mã là ${code} khỏi hệ thống?`;
    }
  },
};
</script>

<style scoped>
@import url("./../../../../assets/css/table.css");
@import url("./../../../../assets/css/pages/application/table.css");
</style>
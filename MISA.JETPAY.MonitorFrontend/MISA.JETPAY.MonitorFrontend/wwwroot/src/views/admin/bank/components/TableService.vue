 <template>
  <div>
    <el-dialog
      title="Thông tin dịch vụ của đối tác có mã "
      :visible.sync="tableServiceVisible"
      :before-close="hideTableService"
      width="1000px"
    >
      <el-row :gutter="0">
        <el-col :span="12" :offset="0">
          <el-select v-model="value" placeholder="Select">
            <el-option
              v-for="item in options"
              :key="item.value"
              :label="item.label"
              :value="item.value"
            >
            </el-option>
          </el-select>
        </el-col>
        <el-col class="m-btn-right" :span="12">
          <button
            class="m-btn btn-icon m-btn-default"
            style="margin-right: 16px"
          >
            <i class="el-icon-refresh"></i>
          </button>
          <button class="m-btn btn-add" @click="showModalService(true)">
            <i class="el-icon-plus"></i><span>Thêm mới</span>
          </button>
        </el-col>
      </el-row>

      <el-row class="containt-table">
        <table border="0" cellspacing="0">
          <thead>
            <tr>
              <th>Mã dịch vụ</th>
              <th>Jetpay Key</th>
              <th>Jetpay Pass</th>
              <th>Bank Key</th>
              <th>Bank pass</th>
              <th>Url kết nối</th>
              <th>Trạng thái</th>
              <th style="width: 20px"></th>
            </tr>
          </thead>
          <tbody>
            <tr v-for="i in 5" :key="i">
              <td>VIETINBANK</td>
              <td>Ngân hàng thương mại cổ phần công thương Việt Nam</td>
              <td>VIETINBANK</td>
              <td>
                Ngân hàng TMCP Công Thương Việt Nam, tên giao dịch VietinBank,
                là một ngân hàng thương mại Nhà nước Việt Nam.
              </td>
              <td>BILLING, QRCODE, GATEWAY</td>
              <td>Hoạt động</td>
              <td>12/10/2020</td>
              <td style="width: 20px; text-align: center">
                <el-dropdown trigger="click">
                  <span class="el-dropdown-link"
                    ><i class="el-icon-more"></i>
                  </span>
                  <el-dropdown-menu slot="dropdown" class="dropdown-more">
                    <el-dropdown-item command="a">Sửa</el-dropdown-item>
                    <el-dropdown-item command="a">Xóa</el-dropdown-item>
                  </el-dropdown-menu>
                </el-dropdown>
              </td>
            </tr>
          </tbody>
        </table>
      </el-row>
      <span slot="footer" class="dialog-footer">
        <button class="m-btn m-btn-text-2 btn-add">
          <span>Đóng</span>
        </button>
      </span>
    </el-dialog>
  </div>
</template>
 
 <script>
import { mapActions, mapGetters } from "vuex";
export default {
  name: "table-service",
  computed: {
    ...mapGetters(["tableServiceVisible"]),
  },
  methods: {
    ...mapActions(["showTableService", "showModalService"]),
    hideTableService() {
      this.showTableService(false);
    },
  },
  data() {
    return {
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
      value: "",
    };
  },
};
</script>
 
<style>
@import url("./../../../../assets/css/table.css");
@import url("./../../../../assets/css/form.css");
@import url("./../../../../assets/css/dialog.css");
@import url("./../../../../assets/css/button.css");
.m-btn-right {
  display: flex;
  justify-content: flex-end;
}
.containt-table {
  height: 300px;
}
.containt-table table {
  width: 100%;
}
</style>
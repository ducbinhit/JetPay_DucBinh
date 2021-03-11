<template>
  <div class="grid">
    <table border="0" cellspacing="0">
      <thead>
        <tr>
          <th>Mã đối tác</th>
          <th>Tên đối tác</th>
          <th>Mã doanh nghiệp</th>
          <th>Mô tả</th>
          <th style="width: 20px"></th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="item in paginateInfo.items" :key="item.Id">
          <td>{{ item.code }}</td>
          <td>{{ item.name }}</td>
          <td>{{ item.masterMerchantCode }}</td>
          <td>{{ item.description }}</td>
          <td style="width: 20px">
            <el-dropdown @command="handerSelectAction" trigger="click">
              <span class="el-dropdown-link"
                ><i class="el-icon-more"></i>
              </span>
              <el-dropdown-menu slot="dropdown" class="dropdown-more">
                <el-dropdown-item :command="{ method: 'PUT', id: item.id }"
                  >Sửa</el-dropdown-item
                >
                <el-dropdown-item :command="{ method: 'DELETE', id: item.id }"
                  >Xóa</el-dropdown-item
                >
                <el-dropdown-item
                  :command="{ method: 'SHOW_SERVICE', id: item.id }"
                  >Chi tiết các dịch vụ đối tác</el-dropdown-item
                >
              </el-dropdown-menu>
            </el-dropdown>
          </td>
        </tr>
      </tbody>
    </table>
    <TableService/>
  </div>
</template>

<script>
import ConfirmActionDialog from "@/components/admin/ConfirmActionDialog";
import TableService from './TableService';
import { mapActions, mapGetters } from "vuex";
/**
 * Bảng đối tác thanh toán
 * Author: LTQUAN (04/12/2020)
 */
export default {
  name: "Table",
  components: {
    ConfirmActionDialog,
    TableService
  },
  created() {
    this.setApiUrl("/api/v1/banks");
    this.fetchData();
  },
  computed: {
    ...mapGetters(["paginateInfo", "apiUrl", "tableServiceVisible"]),
  },
  methods: {
    ...mapActions([
      "fetchData",
      "showDialog",
      "setApiUrl",
      "showConfirmDialog",
      "fetchObjectDetail",
      "showTableService"
    ]),
    // Xử lý hiện form để sửa hoặc xóa
    handerSelectAction(action) {
      if (action.method == "PUT") {
        this.fetchObjectDetail({ apiUrl: this.apiUrl, id: action.id });
        this.showDialog({ isShow: true, action: "PUT" });
      } else if (action.method == "DELETE") {
        this.showConfirmDialog({
          dialogConfirmVisible: true,
          title: "Xóa đối tác thanh toán",
          message: "Bạn có chắc chắn muốn xóa đối tác thanh toán này?",
          action: ActionConfirm.CONFIRM_DELETE,
        });
      } else {
        this.showTableService(true);
      }
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
thead th:nth-child(1) {
  width: 150px;
}
/* thead th:nth-child(2) { */
/* width: 120px; */
/* } */
thead th:nth-child(3) {
  width: 150px;
}
/* thead th:nth-child(4) {
} */
thead th:nth-child(5) {
  width: 200px;
}
thead th:nth-child(6) {
  width: 100px;
}
/*#endregion*/
/* TBody */
/*#region TBody*/
tbody tr td:nth-child(1) {
  width: 150px;
}
/* tbody tr td:nth-child(2) {
  width: 10%;
} */
tbody tr td:nth-child(3) {
  width: 150px;
}
/* tbody tr td:nth-child(4) {
  width: 10%;
} */
tbody tr td:nth-child(5) {
  width: 200px;
}
tbody tr td:nth-child(6) {
  width: 97px;
}
/*#endregion */

/* #region Response for max-width 1368px */
@media only screen and (max-width: 1368px) {
  .grid > table {
    width: 1200px;
  }
  /* Thead */
  /*#region Thead*/
  thead th:nth-child(1) {
    width: 100px;
  }
  /* thead th:nth-child(2) { */
  /* width: 120px; */
  /* } */
  thead th:nth-child(3) {
    width: 150px;
  }
  /* thead th:nth-child(4) {
} */
  thead th:nth-child(5) {
    width: 200px;
  }
  /* thead th:nth-child(6) { */
  /* width: 6%; */
  /* } */
  /*#endregion*/
  /* TBody */
  /*#region TBody*/
  tbody tr td:nth-child(1) {
    width: 100px;
  }
  /* tbody tr td:nth-child(2) {
  width: 10%;
} */
  tbody tr td:nth-child(3) {
    width: 150px;
  }
  /* tbody tr td:nth-child(4) {
  width: 10%;
} */
  tbody tr td:nth-child(5) {
    width: 200px;
  }
  /* tbody tr td:nth-child(6) {
  width: 6%;
} */
  /*#endregion */
}
/* #endregion */
</style>
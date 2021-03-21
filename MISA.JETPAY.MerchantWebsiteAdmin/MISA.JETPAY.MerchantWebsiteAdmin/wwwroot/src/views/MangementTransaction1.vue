<template>
  <div class="main">
    <layout></layout>
    <div class="transaction-details">
      <div class="title">Quản lý giao dịch thanh toán</div>
      <!-- transaction content -->
      <div class="transaction-content">
        <!-- btn group -->
        <div class="filter-form">
          <div clas="left-filter">
            <div class="select-time">
              <div class="select-text">Tháng này</div>
              <div class="icon-down">
                <img src="../assets/icons/1x/Icon-Down.png" />
              </div>
            </div>
          </div>
          <div class="icon-right-filter">
            <div class="icon-export-file">
              <button title="Cập nhật dữ liệu">
                <img src="../assets/icons/1x/Icon-export-file.png" />
              </button>
            </div>
            <div class="icon-refresh">
              <button title="Cập nhật dữ liệu">
                <img src="../assets/icons/1x/Icon-Refresh.png" />
              </button>
            </div>
          </div>
        </div>
        <!-- and btn group -->
        <!-- group money -->
        <div class="group-money">
          <div class="money-left">
            <div class="m-col">
              <div class="m-icon">Σ</div>
              <div class="m-text">Tiền hàng:</div>
              <div class="m-money">100.000.000</div>
            </div>
            <div class="m-col">
              <div class="m-icon">Σ</div>
              <div class="m-text">Giảm giá:</div>
              <div class="m-money">100.000.000</div>
            </div>
            <div class="m-col">
              <div class="m-icon">Σ</div>
              <div class="m-text">Phí giao dịch:</div>
              <div class="m-money">100.000.000</div>
            </div>
            <div class="m-col">
              <div class="m-icon">Σ</div>
              <div class="m-text">Tiền thanh toán:</div>
              <div class="m-money">100.000.000</div>
            </div>
          </div>
          <div class="money-right">
            <div class="m-col m-col1">
              <div class="m-text">Đơn vị:</div>
              <div class="m-money">VNĐ</div>
            </div>
          </div>
        </div>
        <!-- end group money -->
      </div>
      <!-- data table -->
      <div class="data-table">
        <div class="loader"></div>
        <table class="table">
          <!-- popup information -->
        <div class="popup-infomation" v-if="activePopup">
          <div class="popup-title">Quản lý cột</div>
          <div class="display-type">
            <div class="d-lable">Kiểu hiển thị</div>
            <div class="col-item">
              <div class="col-text">Nhóm thông tin</div>
              <input type="checkbox" id="switch1" /><label for="switch1"
                >Toggle</label
              >
            </div>
          </div>
          <div class="display-col">
            <div class="d-lable">Cột</div>
            <div class="col-content">
              <div class="col-item">
                <div class="col-text">Ngày tháng</div>
                <input type="checkbox" id="switch2" /><label for="switch2"
                  >Toggle</label
                >
              </div>
              <div class="col-item">
                <div class="col-text">Mã giao dịch/Mã đơn hàng</div>
                <input type="checkbox" id="switch3" /><label for="switch3"
                  >Toggle</label
                >
              </div>
              <div class="col-item">
                <div class="col-text">Khách hàng</div>
                <input type="checkbox" id="switch4" /><label for="switch4"
                  >Toggle</label
                >
              </div>
              <div class="col-item">
                <div class="col-text">Thông tin thẻ</div>
                <input type="checkbox" id="switch5" /><label for="switch5"
                  >Toggle</label
                >
              </div>
              <div class="col-item">
                <div class="col-text">Số tiền</div>
                <input type="checkbox" id="switch6" /><label for="switch6"
                  >Toggle</label
                >
              </div>
              <div class="col-item">
                <div class="col-text">Trạng thái</div>
                <input type="checkbox" id="switch7" /><label for="switch7"
                  >Toggle</label
                >
              </div>
            </div>
          </div>
        </div>
        <!-- end popup information -->
          <colgroup>
            <col width="3%" />
            <col width="15%" />
            <col width="15%" />
            <col width="18%" />
            <col width="23%" />
            <col width="15%" />
            <col width="10%" />
            <col width="5%" />
          </colgroup>
          <thead>
            <tr>
              <th fieldName="" style="padding-left: 6px">STT</th>
              <th fieldName="">Ngày tháng</th>
              <th fieldName="">Mã giao dịch/Mã đơn hàng</th>
              <th fieldName="">Khách hàng</th>
              <th fieldName="">Thông tin thẻ</th>
              <th fieldName="">Số tiền</th>
              <th fieldName="">Trạng thái</th>
              <th fieldName="" v-on:click="activePopup = !activePopup">
                <img src="../assets/icons/1x/Icon-Setting.png" />
              </th>
            </tr>
          </thead>
          <tbody id="render-data">
            <tr class="filter-data">
              <td>
                <input style="width: 35px" type="text" />
              </td>
              <td>
                <input type="text" />
              </td>
              <td>
                <input type="text" />
              </td>
              <td>
                <input type="text" />
              </td>
              <td>
                <input type="text" />
              </td>
              <td>
                <input type="text" />
              </td>
              <td>
                <input type="text" />
              </td>
              <td></td>
            </tr>
            <tr
              class="m-tr-content"
              v-on:dblclick="() => $router.push('/transaction-details')"
            >
              <td>
                <span>01</span>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày thanh toán</div>
                  <div class="m-text">19/03/2021</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày đơn hàng</div>
                  <div class="m-text">19/03/2021</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable">Mã giao dịch</div>
                  <div class="m-text">123456</div>
                </div>
                <div class="m-row">
                  <div class="m-lable">Mã đơn hàng</div>
                  <div class="m-text">6543211</div>
                </div>
              </td>
              <td>
                <div>Nguyễn Trường Giang</div>
                <div>0378914533</div>
                <div>giangnt@gmail.com</div>
                <div>Thanh Trì, Hà Nội, Việt Nam</div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-card">Loại thẻ</div>
                  <div class="m-text">VISA</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Chủ thẻ</div>
                  <div class="m-text">NGUYEN TRUONG GIANG</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Số thẻ</div>
                  <div class="m-text">1234 5678 8765 3333</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-money">Loại tiền</div>
                  <div class="m-text">VNĐ</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tiền hàng</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Giảm giá</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Phí giao dịch</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tổng tiền</div>
                  <div class="m-text">100.000.000</div>
                </div>
              </td>
              <td>
                <div class="status status-wait-active">Chờ kích hoạt</div>
              </td>
              <td>
                <div><img src="../assets/icons/1x/Icon-More.png" /></div>
              </td>
            </tr>
            <tr class="m-tr-content">
              <td>
                <span>01</span>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày thanh toán</div>
                  <div class="m-text">19/03/2021</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày đơn hàng</div>
                  <div class="m-text">19/03/2021</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable">Mã giao dịch</div>
                  <div class="m-text">123456</div>
                </div>
                <div class="m-row">
                  <div class="m-lable">Mã đơn hàng</div>
                  <div class="m-text">6543211</div>
                </div>
              </td>
              <td>
                <div>Nguyễn Trường Giang</div>
                <div>0378914533</div>
                <div>giangnt@gmail.com</div>
                <div>Thanh Trì, Hà Nội, Việt Nam</div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-card">Loại thẻ</div>
                  <div class="m-text">VISA</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Chủ thẻ</div>
                  <div class="m-text">NGUYEN TRUONG GIANG</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Số thẻ</div>
                  <div class="m-text">1234 5678 8765 3333</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-money">Loại tiền</div>
                  <div class="m-text">VNĐ</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tiền hàng</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Giảm giá</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Phí giao dịch</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tổng tiền</div>
                  <div class="m-text">100.000.000</div>
                </div>
              </td>
              <td>
                <div class="status status-processing">Đang xử lý</div>
              </td>
              <td>
                <div><img src="../assets/icons/1x/Icon-More.png" /></div>
              </td>
            </tr>
            <tr class="m-tr-content">
              <td>
                <span>01</span>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày thanh toán</div>
                  <div class="m-text">19/03/2021</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày đơn hàng</div>
                  <div class="m-text">19/03/2021</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable">Mã giao dịch</div>
                  <div class="m-text">123456</div>
                </div>
                <div class="m-row">
                  <div class="m-lable">Mã đơn hàng</div>
                  <div class="m-text">6543211</div>
                </div>
              </td>
              <td>
                <div>Nguyễn Trường Giang</div>
                <div>0378914533</div>
                <div>giangnt@gmail.com</div>
                <div>Thanh Trì, Hà Nội, Việt Nam</div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-card">Loại thẻ</div>
                  <div class="m-text">VISA</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Chủ thẻ</div>
                  <div class="m-text">NGUYEN TRUONG GIANG</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Số thẻ</div>
                  <div class="m-text">1234 5678 8765 3333</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-money">Loại tiền</div>
                  <div class="m-text">VNĐ</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tiền hàng</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Giảm giá</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Phí giao dịch</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tổng tiền</div>
                  <div class="m-text">100.000.000</div>
                </div>
              </td>
              <td>
                <div class="status status-success">Thành công</div>
              </td>
              <td>
                <div><img src="../assets/icons/1x/Icon-More.png" /></div>
              </td>
            </tr>
            <tr class="m-tr-content">
              <td>
                <span>01</span>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày thanh toán</div>
                  <div class="m-text">19/03/2021</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-date">Ngày đơn hàng</div>
                  <div class="m-text">19/03/2021</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable">Mã giao dịch</div>
                  <div class="m-text">123456</div>
                </div>
                <div class="m-row">
                  <div class="m-lable">Mã đơn hàng</div>
                  <div class="m-text">6543211</div>
                </div>
              </td>
              <td>
                <div>Nguyễn Trường Giang</div>
                <div>0378914533</div>
                <div>giangnt@gmail.com</div>
                <div>Thanh Trì, Hà Nội, Việt Nam</div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-card">Loại thẻ</div>
                  <div class="m-text">VISA</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Chủ thẻ</div>
                  <div class="m-text">NGUYEN TRUONG GIANG</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-card">Số thẻ</div>
                  <div class="m-text">1234 5678 8765 3333</div>
                </div>
              </td>
              <td>
                <div class="m-row">
                  <div class="m-lable lable-money">Loại tiền</div>
                  <div class="m-text">VNĐ</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tiền hàng</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Giảm giá</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Phí giao dịch</div>
                  <div class="m-text">100.000.000</div>
                </div>
                <div class="m-row">
                  <div class="m-lable lable-money">Tổng tiền</div>
                  <div class="m-text">100.000.000</div>
                </div>
              </td>
              <td>
                <div class="status status-error">Thẻ bị từ chối</div>
              </td>
              <td>
                <div><img src="../assets/icons/1x/Icon-More.png" /></div>
              </td>
            </tr>
          </tbody>
        </table>
        
      </div>
      <!-- end data table -->
      <div class="paging-bar">
        <div class="paging-left">Hiển thị 1-10/120 Khách hàng</div>
      </div>
      <!-- end transaction content -->
    </div>
  </div>
</template>

<script>
import Layout from "../components/Layout.vue";
export default {
  components: { Layout },
  data() {
    return {
      activePopup: false,
    };
  },
};
</script>

<style>
* {
  margin: 0;
  padding: 0;
}
.main {
  background-color: antiquewhite;
  display: flex;
    position: absolute;
  top: 56px;
  left: 240px;
  bottom: 50px;
  width: 100%;
}
.main-right {
  width: calc(100% - 250px);
  min-width: 1116px;
}
.transaction-details {
  padding-top: 14px;
  padding-left: 20px;
  padding-right: 20px;
  width: calc(100% - 282px);
  font-family: "GoogleSans Regular";
}
.line {
  margin-top: 17px;
  margin-bottom: 14px;
}
.title {
  font-family: "GoogleSans Bold";
  font-size: 16px;
}
.content-title {
  font-family: "GoogleSans Bold";
  font-size: 14px;
}
.transaction-details {
  /* width: calc(100% - 250px);
  min-width: 1116px; */
  background-color: #ffffff;
}
.line {
  border-bottom: 1px solid #d9dade;
}
/* css cho button select time */
.select-time {
  display: flex;
  align-items: center;
  border: 1px solid #d9dade;
  border-radius: 5px;
  height: 19px;
  padding: 6px 8px 7px 8px;
}
.select-text {
  color: #292b35;
  font-size: 14px;
  margin-right: 7px;
  font-family: "GoogleSans Medium";
}
/* css cho filter form */
.filter-form {
  display: flex;
  margin-top: 17px;
  height: 32px;
  justify-content: space-between;
}
.icon-right-filter {
  display: flex;
}
.icon-right-filter button {
  border: none;
  border-radius: 5px;
  width: 32px;
  height: 32px;
  background-color: #ffffff;
  border: 1px solid #d9dade;
}
.icon-right-filter button:hover {
  background-color: #bbbbbbbb;
}
.icon-export-file {
  margin-right: 12px;
}
/* css cho group money */
.group-money {
  display: flex;
  font-size: 14px;
  align-items: center;
  margin-top: 16px;
  justify-content: space-between;
}
.money-left {
  display: flex;
}
.m-col {
  display: flex;
  align-items: center;
  margin-right: 28px;
}
.m-col1 {
  margin-right: 0;
}
.m-col .m-icon {
  font-size: 20px;
  color: #74757c;
}
.m-col .m-text {
  color: #74757c;
  margin-right: 8px;
  margin-left: 3px;
}
/**
Css cho data-table
*/
table {
  position: relative;
}
.data-table .table .filter-data td {
  vertical-align: inherit;
}
.m-tr-content td {
  padding-top: 10px;
  padding-bottom: 15px;
}
/* css cho trạng thái thanh toán */
.status {
  width: fit-content;
  line-height: 24px;
  padding-left: 6px;
  padding-right: 8px;
  border-radius: 10px;
}
.status-wait-active {
  background-color: #fff3e5;
  color: #ff8800;
}
.status-processing {
  background-color: #0ba6b826;
  color: #0ba6b8;
}
.status-success {
  background-color: #9cde5c33;
  color: #32bf61;
}
.status-error {
  background-color: #f1e0e0;
  color: #dd2a2a;
}

.edit {
  font-weight: bold;
  text-align: right;
}
.m-row {
  display: flex;
}
.m-row-money {
  /* justify-content: space-between; */
}
.lable-date {
  width: 104px;
}
.m-lable {
  margin-right: 5px;
}
.lable-money {
  width: 81px;
}
.lable-card {
  width: 51px;
}
.data-table {
  height: calc(100vh - 237px);
  overflow: scroll;
  margin-top: 12px;
  overflow-x: auto;
}

.data-table .table {
  /* width: 1300px; */
  border-spacing: 0px;
  table-layout: fixed;
  border-collapse: separate;
}

.data-table .table tr {
  height: 40px;
}
.data-table .table tr input {
  border: 1px solid #d9dade;
  height: 32px;
  border-radius: 5px;
  padding-left: 10px;
  padding-right: 10px;
  outline: none;
}
.data-table .table tr input:hover {
  border: 1px solid #00966b;
}
.data-table .table tr input:focus {
  border: 1px solid #00966b;
}

tbody tr:nth-child(2n + 1) {
  background-color: #fafafa;
}

tbody tr:hover {
  background-color: #d9d9d9;
  cursor: pointer;
}
.data-table .table tr th {
  border-bottom: 1px solid #bbbbbb;
  text-align: left;
  border-top: none;
  position: sticky;
  top: 0;
  font-size: 14px;
  z-index: 5;
  background-color: #d9dade;
}

.data-table .table tr td {
  vertical-align: top;
  border: none;
  font-size: 14px;
  border-bottom: 1px solid #bbbbbb;
  padding-right: 10px;
  height: 40px;
  color: #292b35;
}

.data-table .table tr:hover td {
  background-color: #ddd;
  cursor: pointer;
}

.data-table .table tr .employee-coefficient {
  width: 140px;
  text-align: right;
  padding-right: 10px;
}
/* css cho popup information */
.popup-infomation {
  position: absolute;
  top: 43px;
  right: 0;
  width: 289px;
  height: 284px;
  border: 1px solid #dddddd;
  box-shadow: 5px 10px 18px #888888;
  border-radius: 4px;
  background-color: #ffffff;
  padding: 18px 16px 18px 16px;
}
.popup-title {
  font-family: "GoogleSans Bold";
  font-size: 16px;
  color: #292b35;
}
.d-lable {
  color: #74757c;
  font-size: 12px;
  margin-top: 16px;
  font-family: "GoogleSans Medium";
}
.col-item {
  display: flex;
  justify-content: space-between;
  margin-top: 10px;
}
.col-item .col-text {
  color: #292b35;
  font-size: 14px;
  font-family: "GoogleSans Regular";
}
/* css cho togggle switch */
input[type="checkbox"] {
  height: 0;
  width: 0;
  visibility: hidden;
}

label {
  cursor: pointer;
  text-indent: -9999px;
  width: 22px;
  height: 14px;
  background: grey;
  display: block;
  border-radius: 100px;
  position: relative;
}

label:after {
  content: "";
  position: absolute;
  top: 2px;
  left: 2px;
  width: 10px;
  height: 10px;
  background: #fff;
  border-radius: 90px;
  transition: 0.3s;
}

input:checked + label {
  background: #00966b;
}

input:checked + label:after {
  left: calc(100% - 2px);
  transform: translateX(-100%);
}

label:active:after {
  width: 10px;
}
.paging-bar {
  display: flex;
  height: 40px;
  background-color: #ffffff;
  justify-content: space-between;
  width: 100%;
}
</style>

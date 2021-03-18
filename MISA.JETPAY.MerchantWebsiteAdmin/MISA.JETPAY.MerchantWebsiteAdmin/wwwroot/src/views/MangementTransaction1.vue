<template>
  <div class="main">
    <SlideBar />
    <div class="main-right">
      <Header />
      <div class="transaction-details">
        <div class="title">Quản lý giao dịch thanh toán</div>
        <div class="line"></div>
        <!-- transaction content -->
        <div class="transaction-content">
          <!-- btn group -->
          <div class="filter-form">
            <div clas="left-filter">
              <button
                type="button"
                class="dropdown-toggle select-office"
                data-toggle="dropdown"
                aria-expanded="false"
                id="button-search-department"
              >
                Tháng này
                <i class="fas fa-caret-down"></i>
              </button>
            </div>
            <div class="icon-right-filter">
              <div class="icon-refresh">
                <button title="Cập nhật dữ liệu"><img src="../assets/icons/1x/Group-30832.png" /></button>
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
            <colgroup>
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
              <col width="" />
            </colgroup>
            <thead>
              <tr>
                <th width="50px" fieldName="" style="padding-left: 6px">STT</th>
                <th width="200px" fieldName="">Ngày tháng</th>
                <th width="200px" fieldName="">Mã giao dịch/Mã đơn hàng</th>
                <th width="200px" fieldName="">Khách hàng</th>
                <th width="300px" fieldName="">Thông tin thẻ</th>
                <th width="200px" fieldName="">Số tiền</th>
                <th width="120px" fieldName="">Trạng thái</th>
                <th width="25px" fieldName="">
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
              <tr class="m-tr-content">
                <td>
                  <span>01</span>
                </td>
                <td>
                  <div class="m-row">
                    <div class="m-lable">Ngày thanh toán</div>
                    <div class="m-text">19/03/2021</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Ngày đơn hàng</div>
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
                    <div class="m-lable">Loại thẻ</div>
                    <div class="m-text">VISA</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Chủ thẻ</div>
                    <div class="m-text">NGUYEN TRUONG GIANG</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Số thẻ</div>
                    <div class="m-text">1234 5678 8765 3333</div>
                  </div>
                </td>
                <td>
                  <div class="m-row">
                    <div class="m-lable">Loại tiền</div>
                    <div class="m-text">VNĐ</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Tiền hàng</div>
                    <div class="m-text">100.000.000</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Giảm giá</div>
                    <div class="m-text">100.000.000</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Phí giao dịch</div>
                    <div class="m-text">100.000.000</div>
                  </div>
                  <div class="m-row">
                    <div class="m-lable">Tổng tiền</div>
                    <div class="m-text">100.000.000</div>
                  </div>
                </td>
                <td>
                  <div class="status">Chờ kích hoạt</div>
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
  </div>
</template>

<script>
import Header from "../components/Header.vue";
import SlideBar from "../components/SlideBar.vue";
export default {
  components: { Header, SlideBar },
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
}
.main-right {
  width: calc(100% - 250px);
  min-width: 1116px;
}
.transaction-details {
  padding-top: 14px;
  padding-left: 20px;
  padding-right: 20px;
  font-family: "GoogleSans Regular";
  border: 1px solid #74757c;
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
.filter-form {
  display: flex;
  justify-content: space-between;
}
.icon-refresh button {
      border: none;
    border-radius: 5px;
    width: 32px;
    height: 32px;
}
.icon-refresh button:hover {
  background-color: #bbbbbbbb;
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
.data-table .table .filter-data td {
  vertical-align: inherit;
}
.m-tr-content td {
  padding-top: 10px;
  padding-bottom: 15px;
}
.status {
  width: 99px;
  line-height: 24px;
  padding-left: 6px;
  background-color: #fff3e5;
  color: #ff8800;
  border-radius: 10px;
}
.edit {
  font-weight: bold;
  text-align: right;
}
.m-row {
  display: flex;
}
.m-lable {
  margin-right: 5px;
}
.data-table {
  height: calc(100vh - 237px);
  overflow: scroll;
  margin-top: 12px;
  overflow-x: auto;
}

.data-table .table {
  width: 1300px;
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
  width: 100px;
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
.paging-bar {
  display: flex;
  height: 40px;
  background-color: #ffffff;
  justify-content: space-between;
  width: 100%;
}
</style>

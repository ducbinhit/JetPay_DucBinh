<template>
  <div class="main">
    <slide-bar></slide-bar>
    <div class="main-right">
      <Header></Header>
      <div class="transaction-details">
        <div class="title">Chi tiết giao dịch</div>
        <div class="line"></div>
        <!-- transaction content -->
        <div class="transaction-content">
          <!-- customer -->
          <div class="customer">
            <!-- customer info -->
            <div class="customer-info">
              <div class="content-title">Thông tin khách hàng</div>
              <div class="c-details">
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-User.png" />
                  <div class="c-text">Nguyễn Trường Giang</div>
                </div>
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-Phone.png" />
                  <div class="c-text">0378914553</div>
                </div>
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-Email.png" />
                  <div class="c-text">giangnt@gmail.com</div>
                </div>
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-Location.png" />
                  <div class="c-text">Thanh Trì, Hà Nội, Việt Nam</div>
                </div>
              </div>
            </div>
            <!-- end customer info -->
            <!-- card info -->
            <div class="card-info">
              <div class="content-title">Thông tin thẻ</div>
              <div class="c-details">
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-Card.png" />
                  <div class="c-text">VISA</div>
                </div>
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-User.png" />
                  <div class="c-text">Nguyễn Trường Giang</div>
                </div>
                <div class="c-row">
                  <img src="../assets/icons/1x/Icon-Card-2.png" />
                  <div class="c-text">1231 **** **** 4564</div>
                </div>
              </div>
            </div>
            <!-- end card info -->
          </div>
          <!-- end customer -->
          <!-- transaction -->
          <div class="transaction">
            <div class="content-title">Thông tin chứng từ</div>
            <div class="t-details">
              <div class="t-row">
                <div class="t-lable">Loại giao dịch</div>
                <div class="t-text">Tên loại giao dịch</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Mã đơn hàng</div>
                <div class="t-text">654321</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Mã giao dịch</div>
                <div class="t-text">123456</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Ngày đơn hàng</div>
                <div class="t-text">19/03/2021, 16:03</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Ngày thanh toán</div>
                <div class="t-text">20/03/2021, 09:18</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Diễn giải</div>
                <div class="t-text">Hhehe Abc</div>
              </div>
            </div>
          </div>
          <!-- end transaction -->
          <!-- money -->
          <div class="money">
            <div class="content-title">Thông tin số tiền</div>
            <div class="t-details">
              <div class="t-row">
                <div class="t-lable">Loại tiền</div>
                <div class="t-text">VNĐ</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Tiền hàng</div>
                <div class="t-text color-money">100.000.000</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Giảm giá</div>
                <div class="t-text color-money">100.000.000</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Phí giao dịch</div>
                <div class="t-text color-money">100.000.000</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Tổng tiền thanh toán</div>
                <div class="t-text color-money">100.000.000</div>
              </div>
              <div class="t-row">
                <div class="t-lable">Tổng tiền bằng chữ</div>
                <div class="t-text">Một trăm triệu việt nam đồng</div>
              </div>
            </div>
          </div>
          <!-- end money -->
        </div>
        <!-- end transaction content -->
      </div>
    </div>
  </div>
</template>

<script>
import Header from "../components/Header.vue";
import SlideBar from '../components/SlideBar.vue';
export default {
  components: { Header, SlideBar },
};
</script>

<style scoped>
* {
  margin:0;
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
.transaction-content {
  height: calc(100vh - 139px);
  display: flex;
}
/* css cho customer */
.customer {
  margin-right: 74px;
}
.c-row {
  display: flex;
  align-items: center;
}
.c-row img {
  margin-bottom: 8px;
  margin-top: 8px;
  margin-right: 8px;
}
.c-details {
  margin-top: 8px;
  margin-bottom: 14px;
  font-size: 14px;
  color: #292b35;
}
/* transaction */
.transaction {
  min-width: 348px;
  margin-right: 107px;
}
.t-row {
  display: flex;
  margin-bottom: 21px;
  justify-content: space-between;
}
.t-details {
  margin-top: 17px;
  font-family: "GoogleSans Medium";
}
.t-lable {
  color: #74757c;
  font-size: 12px;
  margin-right: 43px;
}
.t-text {
  font-size: 14px;
  color: #292b35;
}
/* css cho money */
.money {
  min-width: 331px;
  height: 250px;
  border-left: 1px solid #d9dade;
  padding-left: 16px;
}
.color-money {
  color: #00966b;
}
</style>

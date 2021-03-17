<template>
  <div class="g-merchant-content">
    <div class="g-merchant-logo"></div>
    <div class="g-order-money">
      <div class="g-order-lable">Số tiền thanh toán</div>
      <div class="g-money">1.300.000 đ</div>
    </div>
    <div class="g-order-id">
      <div class="g-order-lable">Mã đơn hàng</div>
      <div class="g-id">210310ZP-648451926-1615346019-97465</div>
    </div>
  </div>
</template>

<script>
</script>

<style>
/* css cho thông tin đơn hàng, merchant */
.g-merchant-content {
  position: relative;
  width: 324px;
  height: 184px;
  background-color: #ffffff;
  margin-left: 24px;
  border-radius: 5px;
  padding: 24px 24px 25px 24px;
}
.g-merchant-logo {
  width: 88px;
  height: 56px;
  background-image: url("../../assets/icons/1x/Group 30776.png");
}
.g-order-lable {
  font-size: 14px;
  color: #292b35;
}
.g-order-money {
  margin-top: 18px;
}
.g-money {
  font-size: 20px;
  color: #017fff;
  font-family: GoogleSans Black;
}
.g-order-id {
  margin-top: 23px;
}
.g-id {
  font-size: 16px;
  color: #74757c;
}
</style>

<template>
  <div class="footer">
    <div class="top">
      <div class="f-info">
        <div class="i-col">
          <img class="i-img" src="../assets/icons/2x/padlock@2x.png" />
          <div class="i-content">
            <div class="i-lable">An toàn thông tin</div>
            <div class="i-text">
              Chúng tôi cam kết mọi thông tin thanh toán của bạn được bảo mật và
              mã hóa
            </div>
          </div>
        </div>
        <div class="i-col">
          <img class="i-img" src="../assets/icons/2x/pci.png" />
          <div class="i-content">
            <div class="i-lable">Tiêu chuẩn bảo mật</div>
            <div class="i-text">
              JETPAY đảm bảo an toàn dữ liệu, đạt tiêu chuẩn bảo mật quốc tế
            </div>
          </div>
        </div>
      </div>
    </div>
    <div class="bottom">
      <div class="f-content">
        <div class="c-logo">
          <img
            class="logo-jetpay"
            src="../assets/icons/2x/JETPAY-footer@2x.png"
          />
        </div>
        <div class="content-info">
          <div class="c-left">
            <div class="c-name">Công ty cổ phần JETPAY</div>
            <div class="c-address">
              Tầng 9, Tòa nhà Technosoft, ngõ 15 Duy Tân, Phường Dịch Vọng Hậu,
              Quận Cầu Giấy, Thành phố Hà Nội, Việt Nam
            </div>
            <div class="c-license">
              Giấy phép hoạt động cung ứng dịch vụ Trung gian thanh toán số
              06/GP-NHNN ngày 22/01/2021
            </div>
          </div>
          <div class="c-right">
            <div class="c-support">Hỗ trợ khách hàng</div>
            <div class="support-info">
              <div class="c-hotline">
                <img src="../assets/icons/1x/Ellipse-243511.png" />
                <div class="hotline">
                  <div class="hotline-content">
                    Tổng đài tư vấn (3000đ/phút)
                  </div>
                  <div class="hotline-number">19008677</div>
                </div>
              </div>
              <div class="c-hotline">
                <img src="../assets/icons/1x/Bulk-Message.png" />
                <div class="c-email">support@jetpay.com</div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
export default {};
</script>
<style scoped>
.footer {
  background-color: aqua;
  font-family: GoogleSans Regular;
}
/* css cho footer top */
.top {
  background-color: #ffffff;
}
.f-info {
    margin: auto;
    width: 1164px;
    display: flex;
    padding-top: 16px;
    padding-bottom: 12px;
}
.i-col {
    display: flex;
}
.i-img {
    width: 42.11px;
    height: 55.95px;
    margin-right: 15.59px;
}
.i-col {
    margin-right: 156px;
}
.i-content {
    width: 372px;
}
.i-lable {
    font-family: GoogleSans Bold;
    font-size: 14px;
    margin-bottom: 8px;
    font-weight: bold;
    color: #292b35;
}
.i-text {
    color: #55565d;
    font-size: 14px;
}
.bottom {
    background-color: #1f212d;
}
.f-content {
  margin: auto;
  width: 1164px;
  padding-top: 24px;
  padding-bottom: 47px;
}
.logo-jetpay {
  width: 108px;
  height: 43px;
}
.content-info {
  display: flex;
  font-size: 14px;
}
.c-left {
  width: 372px;
  margin-right: 222px;
}
.c-name {
  color: #ebebee;
  font-weight: bold;
}
.c-address {
  margin-top: 5px;
  color: #ebebee;
}
.c-license {
  margin-top: 9px;
  color: #bebebe;
}
.c-support {
  color: #ebebee;
  font-family: "GoogleSans Medium";
}
.support-info {
  margin-top: 12px;
  display: flex;
}
.c-hotline {
  background-color: #74757C;
  border-radius: 18px;
  display: flex;
  width: 273px;
  height: 56px;
  align-items: center;
  margin-right: 24px;
}
.c-hotline img {
    margin-left: 8px;
    margin-right: 10px;
}
.hotline-content {
  color: #bebebe;
}
.hotline-number {
  color: #ebebee;
  font-weight: bold;
  font-size: 18px;
}
.c-email {
  color: #ebebee;
}
</style>
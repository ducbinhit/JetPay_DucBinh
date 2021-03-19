<template>
  <div class="popup-infomation">
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
</template>

<script>
// @ is an alias to /src

export default {
  name: "Home",
  components: {},
};
</script>

<style scoped>
.popup-infomation {
  width: 289px;
  height: 284px;
  border: 1px solid #dddddd;
  border-radius: 4px;
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
</style>
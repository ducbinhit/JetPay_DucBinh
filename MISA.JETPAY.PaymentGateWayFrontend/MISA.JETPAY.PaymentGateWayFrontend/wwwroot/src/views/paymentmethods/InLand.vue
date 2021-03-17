<template>
  <div id="payment-inland" style="margin: auto">
    <!-- inland content -->
    <div class="inland-content">
      <div class="i-title">Thông tin thẻ</div>
      <!-- add card form -->
      <div class="add-card-form">
        <!-- card left -->
        <div class="card-left">
          <div class="i-input">
            <div class="i-lable">Số thẻ</div>
            <input
              @focus="focusInput"
              type="text"
              class="input-text-long"
              placeholder="1234 5678 1234 5678"
              v-model="cardNumber"
              maxlength="19"
              @input="formatcardNumber"
              @blur="blurInput"
            />
          </div>
          <div class="error">
            <p class="errorExpiry">{{ errorcardNumber }}</p>
          </div>
          <div class="i-input">
            <div class="i-lable">Họ & tên trên thẻ</div>
            <input
              @focus="focusInput"
              type="text"
              class="input-text-long"
              placeholder="TA HUY THUONG"
              v-model="cardName"
              @input="formatName"
              @blur="blurInputName"
            />
          </div>
          <div class="error">
            <p class="errorExpiry">{{ errorName }}</p>
          </div>
          <div class="i-input">
            <div class="i-lable">Tháng, năm hết hạn</div>
            <input
              type="text"
              class="input-text-long"
              placeholder="12/25"
              v-model="cardExpiry"
              maxlength="5"
              @input="formatCartExpiry"
              @blur="blurInputExpiry"
            />
          </div>
          <div class="error">
            <p class="errorExpiry">{{ errorExpiry }}</p>
          </div>
          <div class="i-button">
            <button id="i-btn-payment" @click="handelPayMent">
              Thanh toán
            </button>
          </div>
          <div class="cancel-payment">
            <div class="i-icon-cancel"></div>
            <PopupCancel
              :activePopup="activePopup"
              v-on:childToParent="onClickClose"
            />
            <!-- <div class="overlay" v-if="activePopup"></div> -->
            <div class="i-cancel-text" v-on:click="activePopup = !activePopup">
              Hủy thanh toán
            </div>
          </div>
        </div>
        <!-- end card left -->
        <!-- card right -->
        <div class="card-right">
          <div class="i-card-bank">
            <div class="i-card-logo">
              <div
                class="i-logo"
                :style="{ backgroundImage: getLinkImage }"
              ></div>
            </div>
            <div class="i-card-number">{{ cardNumber }}</div>
            <div class="i-expires">EXPIES</div>
            <div class="i-card-name-date">
              <div class="i-card-name">{{ cardName | uppercase }}</div>
              <div class="i-card-expiry">{{ cardExpiry }}</div>
            </div>
          </div>
          <Banks
            v-on:GetDataBank="GetDataBank"
            v-if="activePopupBank"
            v-on:childToParent="onClickClose"
          />
          <div
            class="i-change-bank"
            v-on:click="activePopupBank = !activePopupBank"
          >
            Chọn ngân hàng khác
          </div>
        </div>
        <!-- end card right -->
      </div>
      <!-- end add card form -->
      <!-- add card note -->
      <div class="add-card-note">
        <div class="i-icon-note"></div>
        <div class="i-note">
          JETPAY thực hiện theo Tiêu Chuẩn Bảo Mật PCI-DSS, đảm bảo an toàn cho
          thanh toán của bạn
        </div>
      </div>
      <!-- end add card note -->
    </div>
    <div class="i-merchant-content">
      <div class="i-merchant-logo"></div>
      <div class="i-order-money">
        <div class="i-order-lable">Số tiền thanh toán</div>
        <div class="i-money">1.300.000 đ</div>
      </div>
      <div class="i-order-id">
        <div class="i-order-lable">Mã đơn hàng</div>
        <div class="i-id">210310ZP-648451926-1615346019-97465</div>
      </div>
      <div></div>
    </div>
    <!-- end inland content -->
  </div>
</template>

<script>
import PopupCancel from "../../components/TheCancelPopup.vue";
import Banks from "./Banks.vue";
export default {
  name: "payment-inland",
  components: {
    PopupCancel,
    Banks,
  },
  data() {
    return {
      activePopup: false,
      activePopupBank: false,
      cardNumber: "",
      cardName: "",
      cardExpiry: "",
      cardMonth: "",
      cardYear: "",
      errorExpiry: "",
      errorcardNumber: "",
      errorName: "",
      isActive: false,
      linkImage: "https://media3.scdn.vn/img3/bank/acb.jpg",
      //   borderFirst: 'border-color-normal'
    };
  },
  computed: {
    getLinkImage() {
      return `url(${this.linkImage})`;
    },
  },
  methods: {
    GetDataBank(data) {
      this.linkImage = data;
      console.log("anh", this.linkImage);
    },
    focusInput() {
      console.log("được gọi input");
      this.borderFirst = "border-color-focus";
    },

    // click bắt sự kiện $emit từ con khi click vào đóng
    onClickClose(value) {
      this.activePopup = value;
      this.activePopupBank = value;
    },
    /*
     * Hàm validate mã số thẻ
     * CreateBy : vhduong(15/3/2021)
     *
     */
    formatcardNumber(e) {
      this.isActivePadding = true;
      this.errorcardNumber = null;
      this.cardNumber = e.target.value;
      var value = this.cardNumber.replace(/\D/g, "");
      this.cardNumber = value
        .replace(/(\d{4})/, "$1 ")
        .replace(/(\d{4}) (\d{4})/, "$1 $2 ")
        .replace(/(\d{4}) (\d{4}) (\d{4})/, "$1 $2 $3 ");

      if (e.inputType == "deleteContentBackward") {
        this.errorcardNumber = null;
        let lastChar = this.cardNumber.substring(
          this.cardNumber.length,
          this.cardNumber.length - 1
        );
        // eslint-disable-next-line eqeqeq
        if (lastChar == " ") {
          this.cardNumber = this.cardNumber.substring(
            0,
            this.cardNumber.length - 1
          );
        }
      }
    },
    /*
     * Hàm validate hạn mức của thẻ
     * CreateBy : vhduong(15/3/2021)
     *
     */
    formatCartExpiry(e) {
      this.errorExpiry = null;
      this.cardExpiry = e.target.value;
      let value = this.cardExpiry.replace(/\D/g, "");
      this.cardExpiry = value.replace(/(\d{2})/, "$1/");
      var month = this.cardExpiry.substring(0, 2);
      var yearExpiry = this.cardExpiry.substring(3);
      if (month > 12) {
        this.errorExpiry = "Ngày hết hạn không hợp lệ";
      } else {
        this.cardMonth = month;
        this.cardYear = yearExpiry;
      }
      if (e.inputType == "deleteContentBackward") {
        this.errorExpiry = null;
        let lastChar = this.cardExpiry.substring(
          this.cardExpiry.length,
          this.cardExpiry.length - 1
        );
        // eslint-disable-next-line eqeqeq
        if (lastChar == "/") {
          this.cardExpiry = this.cardExpiry.substring(
            0,
            this.cardExpiry.length - 1
          );
        }
      }
    },
    /**
     * Hàm validate tên thẻ
     * CreateBy : vhduong(15/3/2021)
     *
     * * */
    formatName() {
      this.errorName = null;
    },
    /*
     * Hàm xử lý thanh toán
     * CreateBy : vhduong(15/3/2021)
     *
     * */
    handelPayMent() {
      this.isActivePadding = true;
      let isValidate = true;
      if (this.cardNumber == "") {
        this.errorcardNumber = "Vui lòng nhập đầy đủ số thẻ ";
        isValidate = false;
      }
      if (this.cardName == "") {
        this.errorName = "Vui lòng nhập Tên in trên thẻ ";
        isValidate = false;
      }
      if (this.cardExpiry == "") {
        this.errorExpiry = "Vui lòng nhập ngày hết hạn ";
        isValidate = false;
      }
      if (isValidate) {
        this.$router.push("/paymentmethods/payment-success");
      }
    },
    blurInput() {
      this.isActive = true;
      if (this.cardNumber.length < 19) {
        this.errorcardNumber = "Mã số thẻ không hợp lệ";
        // this.borderFirst = "border-color-error"
      }
    },
    blurInputName() {
      if (this.cardName == "") {
        this.errorName = "Vui lòng nhập Tên in trên thẻ";
      }
    },
    blurInputExpiry() {
      if (this.cardExpiry == "") {
        this.errorExpiry = "Vui lòng nhập ngày hết hạn ";
      }
    },
  },
  filters: {
    uppercase: function (v) {
      return v.toUpperCase();
    },
  },
};
</script>

<style>
.overlay {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  /* z-index: 5; */
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.301);
  /* background: #f3f4f7; */
}
#payment-inland {
  background-color: #f2f4f6;
  display: flex;
  width: 1168px;
  margin-left: 101px;
  margin-right: 101px;
  padding-top: 32px;
  padding-bottom: 40px;
  font-family: GoogleSans Regular;
}
.inland-content {
  width: 768px;
  padding-left: 24px;
  padding-top: 22px;
  padding-right: 40px;
  padding-bottom: 24px;
  background-color: #ffffff;
  border-radius: 5px;
}
.add-card-form {
  margin-top: 24px;
  display: flex;
  -webkit-box-pack: justify;
  justify-content: space-between;
}
.i-title {
  font-size: 18px;
  font-weight: bold;
}
.carf-left {
  background-color: red;
}
.i-lable {
  color: #74757c;
  font-size: 11px;
  margin-bottom: 4px;
}
.i-input {
  width: 330px;
  height: 39px;
  padding-top: 7px;
  padding-left: 16px;
  padding-bottom: 8px;
  margin-bottom: 10px;
  border: 1px solid;
  border-color: #d9dade;
  border-radius: 5px;
  background-color: #fcfcfc;
  font-family: GoogleSans Medium;
}
.i-input:focus-within {
  border: 1px solid #00966b;
}
.border-color-normal {
  border-color: #d9dade;
}
.border-color-focus {
  border-color: #24a7f3;
}
.border-color-error {
  border-color: red;
}
.input-text-long {
  width: 300px;
  padding: 0;
  background-color: #fcfcfc;
  font-family: GoogleSans Medium;
  font-size: 16px;
  border: none;
  outline: none;
}
.input-text-long::placeholder {
  color: #d9dade;
}
#i-btn-payment {
  width: 347px;
  height: 56px;
  margin-top: 14px;
  margin-bottom: 14px;
  background-color: #00966b;
  border-radius: 5px;
  color: #ffffff;
  font-size: 16px;
  font-family: GoogleSans Medium;
  border: none;
  cursor: pointer;
  outline: none;
}

/* css cho hủy thanh toán */
.cancel-payment {
  display: flex;
}
.i-icon-cancel {
  width: 16px;
  height: 16px;
  margin-right: 4px;
  background-image: url("../../assets/icons/1x/Group 30778.png");
}
.i-cancel-text {
  color: #dd2a2a;
  cursor: pointer;
}
/* css cho note */
.add-card-note {
  display: flex;
  align-items: center;
  margin-top: 33px;
}
.i-icon-note {
  width: 32px;
  height: 36px;
  margin-right: 12px;
  background-image: url("../../assets/icons/1x/Page-1.png");
}
.i-note {
  font-size: 14px;
  color: #74757c;
}

/* css cho thông tin thẻ */
.i-card-bank {
  width: 257px;
  height: 163px;
  background-image: url("../../assets/icons/1x/Group 30811.png");
  position: relative;
  color: #ffffff;
}
.i-card-logo {
  width: 158px;
  height: 40px;
  background-color: #ffffff;
  border-radius: 5px;
  position: absolute;
  top: 12px;
  left: 87px;
}
.i-logo {
  /* width: 138px;
  height: 19px;
  margin: 11px 10px 11px 10px; */

  height: 100%;
  margin-left: 39px;
  background-size: contain;
  background-repeat: no-repeat;
}
.i-card-number {
  position: absolute;
  top: 76px;
  left: 16px;
  font-size: 18px;
  font-weight: bold;
}
.i-expires {
  position: absolute;
  font-size: 10px;
  top: 107px;
  left: 205px;
  right: 16px;
}
.i-card-name-date {
  display: flex;
  position: absolute;
  top: 120px;
  left: 16px;
  bottom: 22px;
}
.i-card-name {
  font-size: 16px;
  margin-right: 53px;
}
.i-card-expiry {
  position: absolute;
  font-size: 16px;
  left: 185px;
}
.i-change-bank {
  margin-top: 10px;
  text-align: right;
  color: #00966b;
  font-size: 14px;
  cursor: pointer;
}

/* css cho thông tin đơn hàng, merchant */
.i-merchant-content {
  width: 372px;
  height: 184px;
  background-color: #ffffff;
  margin-left: 24px;
  border-radius: 5px;
  padding: 24px 24px 25px 24px;
}
.i-merchant-logo {
  width: 88px;
  height: 56px;
  background-image: url("../../assets/icons/1x/Group 30776.png");
}
.i-order-lable {
  font-size: 14px;
  color: #292b35;
}
.i-order-money {
  margin-top: 18px;
}
.i-money {
  font-size: 20px;
  color: #017fff;
  font-family: GoogleSans Black;
}
.i-order-id {
  margin-top: 23px;
}
.i-id {
  font-size: 16px;
  color: #74757c;
}
/* css thông báo lỗi */
.error {
  margin-bottom: 11px;
  margin-left: 5px;
}
.error1 {
  margin-top: -10px;
}
.errorExpiry {
  color: red;
  margin-top: 12px;
  font-size: 11px;
}
.blurFail {
  border: #dd2a2a;
}
</style>
<template>
  <div>
    <PopupCancel :activePopup="activePopup" v-on:childToParent="onClickClose" />
    <!--Thông tin thẻ  -->
    <div class="g-information">
      <div class="g-content">
        <div class="g-infor-left">
          <!-- Tiêu đề -->
          <div class="g-title">Thông tin thẻ</div>
          <!-- Các input nhập thông tin thẻ -->
          <div class="g-input">
            <div class="g-label">Số thẻ</div>
            <input
              v-model="cardNumber"
              type="text"
              placeholder="VD: 1324 4567 1324 4567"
              @blur="blurCardNumber"
              :maxlength="19"
              @input="formatcardNumber"
            />
          </div> 
          <div class="error">
            <p class="errorExpiry">{{ errorcardNumber }}</p>
          </div>
          <div class="g-input">
            <div class="g-label">Họ & tên trên thẻ</div>
            <input
              v-model="cardName"
              type="text"
              placeholder="VD: TA HUY THUONG"
              :maxlength="30"
              @input="formatName"
              @blur="blurInputName"
            />
          </div>
          <div class="error">
            <p class="errorExpiry">{{ errorName }}</p>
          </div>
          <div class="g-input">
            <div class="g-label">Tháng, năm hết hạn</div>
            <input
              v-model="cardExpiry"
              type="text"
              placeholder="MM/YY"
              @input="formatCartExpiry"
              :maxlength="5"
              @blur="blurInputExpiry"
            />
          </div>
          <div class="error">
            <p class="errorExpiry">{{ errorExpiry }}</p>
          </div>
          <div class="g-input">
            <div class="g-label">Mã bảo mật</div>
            <input
              v-model="CVV"
              type="text"
              placeholder="VD: 123"
              :maxlength="3"
              @input="formatCVC"
              @blur="blurInputCVC"
            />
          </div>
          <div class="error">
            <p class="errorExpiry">{{ errorCVC }}</p>
          </div>
          <div class="g-check">
            <input class="g-checkbox" type="checkbox" />
            <div>Lưu và bảo mật thẻ cho lần thanh toán sau</div>
          </div>
          <div class="g-button">
            <button class="g-pay" @click="handelPayMent">Thanh toán</button>
            <div class="g-cancel">
              <div class="g-icon-cancel"></div>
              <div
                class="g-title-cancel"
                style="font-size: 14px"
                v-on:click="activePopup = !activePopup"
              >
                Hủy thanh toán
              </div>
            </div>
          </div>
        </div>
        <!-- Thẻ -->
        <div class="g-infor-right">
          <div class="g-bank">
            <div class="g-icon-bank1"></div>
            <div class="g-icon-bank2"></div>
            <div class="g-icon-bank3"></div>
          </div>
          <div class="g-card-bank">
            <div class="g-chip"></div>
            <div class="g-card-icon"></div>
            <div class="g-card-number">{{ cardNumber }}</div>
            <div class="g-card-name">{{ cardName | uppercase }}</div>
            <div class="g-card-date">{{ cardExpiry }}</div>
          </div>
          <div class="g-select-bank">Chọn ngân hàng khác</div>
        </div>
        <!-- Lưu ý thanh toán -->
        <div class="g-footer">
          JETPAY không trực tiếp lưu thẻ của bạn. Để đảm bảo an toàn, thông tin
          thẻ của bạn chỉ được lưu bởi CyberSource, công ty quản lý thanh toán
          lớn nhất thế giới (thuộc tổ chức VISA)
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import PopupCancel from "../../components/TheCancelPopup.vue";
export default {
  components: {
    PopupCancel,
  },
  data() {
    return {
      imgCard: "../../assets/icons/1x/logo (1).png",
      CVV: "",
      cardNumber: "",
      cardName: "",
      cardExpiry: "",
      cardMonth: "",
      cardYear: "",
      errorExpiry: "",
      errorcardNumber: "",
      errorName: "",
      errorCVC: "",
      activePopup: false,
    };
  },
  methods: {
    onClickClose(value) {
      this.activePopup = value;
    },
    /*
     * Hàm validate mã số thẻ
     * CreateBy : vhduong(15/3/2021)
     *
     */
    formatcardNumber(e) {
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
      // this.cardExpiry = value.replace(/(1[0-2]|0[1-9]|\d)/, "$1/");

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
      if (this.CVV == "") {
        this.errorCVC = "Vui lòng nhập mã CVC ";
        isValidate = false;
      }
      if (isValidate) {
        this.$router.push("payment-success");
      }
    },
    formatCVC(e) {
      this.errorCVC = null;
      this.CVV = e.target.value;
      this.CVV = this.CVV.replace(/\D/g, "");
    },
    /**
     * Hàm validate Số thẻ
     */
    blurCardNumber() {
      var regexCard = /^(?:4\d{3}|5[1-5]\d{2}|6011|3[47]\d{2})([-\s]?)\d{4}\1\d{4}\1\d{3,4}$/gm;
      if (!regexCard.test(this.cardNumber)) {
        this.errorcardNumber = "Mã số thẻ không hợp lệ";
      }
      var testVisa = /^4[0-9]{12}(?:[0-9]{3})?$/gm;
      if (!testVisa.test(this.cardNumber)) {
        //
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
    blurInputCVC() {
      if (this.CVV == "") {
        this.errorCVC = "Vui lòng nhập mã CVV ";
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
<style scoped>
/* Thông tin thẻ */
.g-information {
  position: relative;
  width: 768px;
  height: 562px;
  background-color: #ffffff;
  font-family: GoogleSans Regular;
  font-size: 18px;
}
.g-content {
  display: flex;
  width: 768px;
  padding: 24px 24px;
}
/* CSS thông tin nhập */
.g-infor-left {
  width: 50%;
  height: 500px;
  background-color: #ffffff;
  text-align: left;
}
.g-title {
  font-weight: bold;
  margin-bottom: 24px;
}
.g-input {
  width: 346px;
  height: 54px;
  border: 1px solid #d9dade;
  border-radius: 4px;
  margin-top: 10px;
}
.g-input:focus-within {
  border: 1px solid #00966b;
}
.g-input .g-label {
  padding: 8px 0 0 16px;
  font-size: 12px;
}
.g-input input {
  width: 220px;
  height: 24px;
  outline: none;
  border: none;
  margin: 0 0 8px 16px;
  background-color: #fcfcfc;
  font-family: GoogleSans Medium;
  font-size: 18px;
}
.g-input input::placeholder {
  color: #d9dade;
}
.g-check {
  display: flex;
  font-size: 14px;
  margin-top: 10px;
  align-items: center;
}
.g-checkbox {
  width: 16px;
  height: 16px;
  margin-right: 5px;
  margin-left: 0;
}
.g-checkbox.g-checkbox {
  background-color: #683b3b;
}

.g-button .g-pay {
  width: 350px;
  height: 58px;
  background-color: #00966b;
  outline: none;
  border: none;
  border-radius: 4px;
  margin-top: 24px;
  color: #ffffff;
  font-weight: bold;
  cursor: pointer;
}
.g-button .g-cancel {
  display: flex;
  padding-top: 14px;
}
.g-button .g-cancel .g-icon-cancel {
  width: 16px;
  height: 16px;
  background-image: url("../../assets/icons/1x/Group 30778.png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-button .g-cancel .g-title-cancel {
  padding-left: 4px;
  color: #dd2a2a;
  cursor: pointer;
}

/* CSS thẻ */
.g-infor-right {
  position: absolute;
  top: 1px;
  left: 384px;
  width: 50%;
  height: 500px;
  background-color: #ffffff;
  z-index: 100;
}
.g-infor-right .g-bank {
  display: flex;
  padding-top: 30px;
  padding-left: 227px;
}
.g-infor-right .g-bank .g-icon-bank3 {
  width: 24px;
  height: 18px;
  padding-top: 8px;
  background-image: url("../../assets/icons/1x/JCB_logo.png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-infor-right .g-bank .g-icon-bank2 {
  width: 44px;
  height: 24px;
  background-image: url("../../assets/icons/1x/Mastercard_logo.png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-infor-right .g-bank .g-icon-bank1 {
  width: 44px;
  height: 16px;
  padding-top: 10px;
  background-image: url("../../assets/icons/1x/Visa_Inc._logo.png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-infor-right .g-card-bank {
  position: relative;
  height: 163px;
  width: 257px;
  margin: 4px 0 0 84px;
  background-image: url("../../assets/icons/1x/Group 30812.png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-infor-right .g-card-bank .g-chip {
  position: absolute;
  width: 41px;
  height: 29px;
  margin: 22px 0 0 16px;
  background-image: url("../../assets/icons/1x/Group 30800.png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-card-icon {
  position: absolute;
  width: 75px;
  height: 24px;
  margin-top: 22px;
  margin-left: 166px;
  background-image: url("../../assets/icons/1x/logo (1).png");
  background-size: contain;
  background-repeat: no-repeat;
  background-position: center;
}
.g-card-number {
  position: absolute;
  top: 83px;
  left: 16px;
  color: #ffffff;
  font-weight: bold;
  font-size: 21px;
}
.g-card-name {
  position: absolute;
  top: 120px;
  left: 16px;
  color: #ffffff;
  font-size: 16px;
}
.g-card-date {
  position: absolute;
  top: 120px;
  left: 188px;
  color: #ffffff;
  font-size: 16px;
}
.g-infor-right .g-select-bank {
  padding-top: 10px;
  padding-left: 165px;
  color: #00966b;
}
/* CSS footer */
.g-footer {
  position: absolute;
  top: 520px;
  left: 24px;
  font-size: 14px;
}
.errorExpiry {
  color: red;

  font-size: 11px;
}
</style>
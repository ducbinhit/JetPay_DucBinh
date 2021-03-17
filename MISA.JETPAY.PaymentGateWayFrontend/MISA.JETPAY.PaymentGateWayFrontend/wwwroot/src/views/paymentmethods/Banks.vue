<template>
  <div>
    <div class="overlay" v-if="test"></div>
    <div class="payment-modal">
      <div class="title-bar">
        <h2 class="title">Ngân hàng hỗ trợ</h2>
        <span
          class="icon-close fa fa-times fa-1.5x"
          id="btn-close"
          v-on:click="emitToParent"
          style="cursor: pointer"
          @click="emitToParent"
          >X</span
        >
      </div>
      <!--Danh sách ngân hàng-->
      <div class="payment-company">
        <ul class="payment-list">
          <li class="payment-search">
            <input
              v-model="search"
              class="search-input"
              type="text"
              name="search"
              id="search"
              placeholder="Tìm kiếm"
            />
          </li>
          <li
            v-for="(payment, index) in filteredList"
            :key="payment.id"
            v-bind:class="{active : selectedBank == index}"
            class="payment-item"
            @click="GetDataBank($event, index, payment.image)"
          >
            <div class="payment-item-image">
              <img :src="payment.image" alt="" />
            </div>
            <h3 class="payment-item-name">{{ payment.name }}</h3>
          </li>
        </ul>
      </div>
      <div class="btn-payment" @click="SelectBank">
        <div class="btn btn-access">
          <h3 >Xác nhận</h3>
        </div>
      </div>
    </div>
  </div>
</template>
<script>
import payments from "../../assets/data/payment.json";
export default {
  name: "Popup",
  data() {
    return {
      search: "",
      payments: payments,
      isActive: false,
      test: true,
      linkImage: "",
      selectedBank: 0,
    };
  },
  methods: {
    SelectBank: function () {
      this.$emit("GetDataBank", this.linkImage);
      this.emitToParent();
    },
    GetDataBank: function (e, index, image) {
      this.linkImage = image;
      this.selectedBank = index;
    },
    emitToParent() {
      this.$emit("childToParent", false);
    },
  },
  props: {
    activePopup: {
      type: Boolean,
      default: false,
    },
  },
  computed: {
    filteredList() {
      return this.payments.filter((payment) => {
        return payment.name.toLowerCase().includes(this.search.toLowerCase());
      });
    },
    getProduct() {
      let index = this.selectedBank;
      return this.payments[index];
    },
  },
};
</script>
<style scoped>
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}
.overlay {
  position: fixed;
  top: 0;
  left: 0;
  right: 0;
  bottom: 0;
  z-index: 101;
  width: 100%;
  height: 100%;
  background: rgba(0, 0, 0, 0.301);
  /* background: #F3F4F7; */
}
.payment-modal {
  position: absolute;
  top: 43%;
  left: 50%;
  width: 350px;
  /* height: 500px; */
  background: white;
  transform: translate(-50%, -50%);
  box-shadow: 0 0 23px -8px black;
  display: flex;
  flex-direction: column;
  overflow: hidden;
  border-radius: 4px;
  z-index: 1000;
}
.title-bar {
  height: 7%;
  display: flex;
  justify-content: space-between;
  align-items: center;
  padding: 1rem;
  position: relative;
  box-shadow: 0 0 0.9rem -0.3rem;
}
.title-bar .title {
  font-size: 18px;
}
.payment-search {
  width: 100%;
  margin-bottom: 2rem;
}
.payment-search .search-input {
  height: 40px;
  width: 92%;
  margin-left: 15px;
  border-radius: 0.5rem;
  padding-left: 10px;
  border: 0.1rem solid #C4C4C4;
  outline-color: #00966B;
}
.payment-company {
  /* flex-grow: 12; */
  height: fit-content;
  background: rgb(240, 240, 240);
}
.payment-list {
  display: flex;
  justify-content: stretch;
  align-items: flex-start;
  height: 100%;
  flex-wrap: wrap;
  list-style: none;
  padding-top: 1.5rem;
  overflow: auto;
}
.payment-item {
  width: calc((100% / 3) - 2rem);
  height: 55px;
  margin: 0 0 3rem 1.5rem;
}
.payment-item .payment-item-image {
  width: 100%;
  height: 100%;
  background: white;
  border-radius: 0.5rem;
  /* border: 0.1rem solid #C4C4C4; */
  text-align: center;
  cursor: pointer;
}
/* .payment-item .payment-item-image:hover {
  border: 1px dashed red;
  border-top: 1.5px dashed red;
} */
.active {
  border: 1px solid red;
  border-radius: 5px;
}
.isActive {
  border: none;
}
img {
  object-fit: contain;
  width: 80%;
  height: 100%;
}
.payment-item-name {
  text-align: center;
  font-size: 14px;
  font-weight: normal;
  margin-top: 0.2rem;
  cursor: pointer;
  color: rgb(43, 43, 43);
}
.btn-payment {
  height: 10%;
  /* flex-grow: 2; */
  background: rgb(240, 240, 240);
  padding: 1rem 1.5rem;
  overflow: hidden;
  position: relative;
  box-shadow: 0 0 0.9rem -0.3rem;
}
.btn-access {
  width: 100%;
  height: 100%;
  background-color: red;
  height: 44px;
}
.btn {
  border-radius: 0.5rem;
  cursor: pointer;
}
.btn-access h3 {
  text-align: center;
  position: absolute;
  top: 50%;
  left: 50%;
  transform: translate(-50%, -50%);
  color: #fff;
  font-size: 18px;
}
</style>
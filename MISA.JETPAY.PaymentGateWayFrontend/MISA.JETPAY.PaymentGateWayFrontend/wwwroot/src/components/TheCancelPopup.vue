<template>
<div>
    <div class="overlay" v-if="activePopup"></div>
    <div class="popupCancel" v-if="activePopup">

        <img class="iconCancel" src="../assets/icons/1x/cancel.png" alt="" @click="emitToParent" />
        <h1 class="popupCancel-title">Bạn muốn kết thúc giao dịch</h1>
        <p class="popupCancel-content">Thanh toán chưa được xử lý</p>
        <div class="popup-btn">
            <button class="g-btn btn-close" @click="emitToParent">Đóng</button>
            <button class="g-btn btn-cancel" @click="()=>$router.push('/paymentmethods/payment-fail')">Hủy giao dịch</button>
        </div>
    </div>
</div>
</template>

<script>
export default {
    name: "ThePopup",
    data() {
        return {
            active: true
        }
    },
    props: {
        activePopup: {
            type: Boolean,
            default: false,
        }
    },
    methods: {
        emitToParent () {
            this.$emit('childToParent', false)
        },
    },
    computed: {
    },
};
</script>

<style scoped>
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
    /* background: #f3f4f7; */
}
.g-btn {
    border-radius: 4px;
    border: none;
    outline: none;
    font-size: 16px;
}
.btn-close:active{
    background-color: #cfcdcd;
}
.btn-cancel:active{
    background-color: #c46969;
}

.btn-close {
    background: #F2F3F8;
    color: black;
    width: 120px;
    height: 48px;
    margin-right: 10px;
    
}
.btn-cancel {
    background: #DD2A2A;
    color: white;
    width: 130px;
    height: 48px;
}



.popupCancel {
    width: 372px;
    height: 191px;
    background: #fff;
    position: absolute;
    left: 50%;
    top: 35%;
    z-index: 999;
    transform: translate(-50%, -50%);
    border-radius: 8px;
    display: flex;
    flex-direction: column;
    justify-content: flex-start;
    align-items: center;
    font-family: GoogleSans Regular;
    line-height: 0;
}

.popup-btn {
    display: flex;
    justify-content: center;
    align-items: center;
    position: absolute;
    bottom: 14px;
    right: 16px;
}

.popupCancel-title {
    margin-top: 48px;
    margin-bottom: 14px;
    font-size: 18px;
    font-weight: bold;
}

.iconCancel {
    position: fixed;
    top: 18px;
    right: 16px;
    cursor: pointer;
}

.popupCancel-content {
    margin-top: 20px;
    color: #5d5f66;
}

.popupCancel-btn:nth-child(2) {
    margin-left: 8px;
}
</style>
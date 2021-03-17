<template>
    <div>
        <div class="overlay"></div>
        <Header />
        <the-notification
            :isSuccess="isSuccess"
            :notification-title="'Thanh toán không thành công'"
            :notificationContent="'Giao dịch đã bỉ hủy bởi người dùng'"
            :btnTitle="'Thanh toán lại'"
            :styleBtn="styleBtnFail"
            :icon="false"
            class="payment-fail-content"
        />
    </div>
</template>
<script>
import TheNotification from "../../components/TheNotification.vue";
import Header from "../../components/TheHeader.vue";
export default {
    components: {
        TheNotification,
        Header    
    },
    data (){
        return {
            isSuccess : false,

        }
    },
    computed: {
        styleBtnFail() {
            return {
                color: "#00966B",
                background: "#fff",
            };
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
    background: #F3F4F7;
}
.payment-fail-content .m-btn-title {
    margin-top: -15px;
}
</style>
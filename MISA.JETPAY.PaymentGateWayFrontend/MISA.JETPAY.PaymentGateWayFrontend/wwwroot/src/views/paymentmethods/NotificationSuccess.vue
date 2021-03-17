<template>
    <div>
        <div class="overlay"></div>
        <Header />
        <the-notification 
            :isSuccess="isSuccess"
            :notification-title="'Thanh toán thành công'"
            :notificationCode="'210310ZP-648451926-1615346019-97465'"
            :btnTitle="'Tiếp tục mua sắm'"
            :styleBtn="styleBtnSuccess"
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
            isSuccess : true,

        }
    },
    computed: {
        styleBtnSuccess() {
            return {
                color: "#fff"
            };
        },
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
    /* z-index: 5; */
    width: 100%;
    height: 100%;
    background: #f3f4f7;
}
</style>
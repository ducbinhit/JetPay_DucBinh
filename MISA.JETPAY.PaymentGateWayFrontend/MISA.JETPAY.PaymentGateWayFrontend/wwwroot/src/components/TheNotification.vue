<template>
    <div class="m-notification">
        <img alt="icon" src="../assets/icons/1x/oki.png" v-if="icon" />
        <img alt="icon" src="../assets/icons/1x/err.png" v-else />
        <h1 class="m-notification-title">{{ notificationTitle }}</h1>
        <h4 class="m-notification-content">{{ notificationContent }}</h4>
        <span class="m-notification-code" :class="{ active: notiCode }">{{
            notificationCode
        }}</span>
        <my-button :btnTitle="btnTitle" :style="styleBtn" />
        <span class="countDown"
            >Hệ thống sẽ tự động quay lại trang chủ Tiki sau
            <span style="color: red">{{ time }} giây</span></span
        >
    </div>
</template>

<script>
import MyButton from "./TheMyButton.vue";
export default {
    components: {
        MyButton,
    },
    name: "TheNotification",
    data() {
        return {
            time: 5,
            notiCode: true,

        };
    },
    props: {
        isSuccess: {
            type: Boolean,
            default: false,
        },
        notificationTitle: {
            type: String,
            required: true,
            default: "This is string",
        },
        notificationContent: {
            type: String,
            default: "Bạn đã thanh toán thành công",
        },
        notificationCode: {
            type: String,
            required: false,
            default: "",
        },
        btnTitle: {
            type: String,
            required: true,
            default: "Button",
        },
        icon: {
            type: Boolean,
            default: true,
        },
        styleBtn: {
            type: Object,
            required: false,
            default: function () {},
        },
    },
    methods: {
        pollData() {
            this.timeEnd = setInterval(() => {
                this.time--;
                if (this.time == 0) {
                    clearInterval(this.timeEnd);
                     if(this.isSuccess){
                         window.location = 'https://localhost:5001/home/confirm?orderId=ORDvgu_308306&payment_processing=SUCCESS&merchantId=APITEST&amount=12000';
                     }
                     else{
                         window.location = 'https://localhost:5001/home/confirm?payment_processing=ERROR';
                     }
                }
            }, 1000);
        },
    },
    created() {
        this.pollData();
    },
};
</script>

<style scoped>
.m-notification {
    width: 347px;
    min-height: 400px;
    position: absolute;
    left: 50%;
    top: 35%;
    z-index: 10;
    transform: translate(-50%, -50%);
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    font-family: GoogleSans Regular;
    line-height: 0;
}

img {
    width: 96px;
    height: 96px;
    padding-bottom: 26px;
}

.m-notification-title {
    font-size: 18px;
    margin-bottom: 30px;
}

.m-notification-content {
    font-size: 14px;
    padding-top: 10px;
    font-weight: normal;
    margin-bottom: 20px;
}

my-button {
    margin-top: 40px;
}

.countDown {
    margin-top: 20px;
    font-size: 14px;
}

.m-notification-code.active {
    padding-bottom: 40px;
    font-size: 16px;
    color: #00966b;
}
</style>

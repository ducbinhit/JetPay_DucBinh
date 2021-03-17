<template>
    <div class="m-btn m-btn-title">
        {{ btnTitle }}
    </div>
</template>

<script>
export default {
    name: "TheMyButton",
    props: {
        btnTitle: {
            type: String,
            required: true,
            default: "Button",
        },
    },
};
</script>

<style scoped>
.m-btn {
    width: 347px;
    height: 56px;
    display: flex;
    background-color: #00966b;
    justify-content: center;
    align-items: center;
    border-radius: 5px;
    cursor: pointer;
}

.m-btn .m-btn-title {
    color: #fff;
    font-size: 16px;
    font-weight: normal;
}

.m-btn-err {
    background-color: #fff;
}

.m-btn-err .m-btn-title {
    color: #00966b;
}
</style>
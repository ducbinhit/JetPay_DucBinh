<template>
    <div class="header">
        <div class="local-live">
            <div class="icon-vi"></div>
            <div style="margin-left:8px;margin-right:8px;"> Tiếng Việt</div>
            <div class="icon-arrow-down"></div>
        </div>
        <div class="notification icon-bell">
            <div class="icon-message"></div>
        </div>
        <div class="icon-user"></div>
    </div>
</template>
<script>
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
    setup() {
        
    },
})
</script>
<style >
.header{
    position: fixed;
    width: calc(100% - 240px);
    height: 56px;
    top: 0;
    right: 0;
    background-color: #F8F9FB;
}
.local-live{
    position: absolute;
    right: 120px;
    height:40px ;
    width: 146px;
    display: flex;
    border: 1px solid #f1f1f1;
    top: 8px;
    background-color: #fff;
    border-radius: 5px;
}
.local-live .icon-vi{
    width: 32px;
    height: 24px;
    background-image: url("../assets/icons/1x/300px-Flag_of_Vietnam.svg.png");
    margin-left: 8px;
}
.local-live .icon-arrow-down{
    width: 16px;
    height: 16px;
    background-image: url("../assets/icons/1x/Icon-Dropdown.png");
}
.local-live > div{
    align-self: center;
}

.notification.icon-bell{
    position: absolute;
    right: 70px;
    width: 24px;
    height: 24px;
    background-image: url("../assets/icons/1x/Icon-Bell.png");
    top: 14px;
}
.notification .icon-message{
    width: 23px;
    height: 14px;
    position: absolute;
    right: -10px;
    top: -4px;
    z-index: 999;
    background-image: url("../assets/icons/1x/Group 30824.png");
}
.icon-user{
    position: absolute;
    right: 16px;
    background-image: url("../assets/icons/1x/Group 30825.png");
    width: 36px;
    height: 36px;
    background-repeat: no-repeat;
    top: 11px;
}
</style>

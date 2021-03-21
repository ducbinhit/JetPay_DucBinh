<template>
    <div class="funtion">
        <div class="desctiption-view">{{descriptionview}}</div>
        <div class="contain-button">
            <div class="btn-add-common">
                <div class="icon-add"></div>
                <div class="text-add"> Thêm mới</div>
            </div>
            <div class="btn-function export-excel"></div>
            <div class="btn-function reload"></div>
        </div>
    </div>
</template>
<script>
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
    setup() {
        
    },
    props:{
        descriptionview:String
    }
})
</script>
<style scoped>
.funtion{
    position: absolute;
    height: 50px;
    width: 100%;
    top:16px;
}
.funtion .desctiption-view{
    position: absolute;
    left: 8px;
}
.funtion .contain-button{
    position: absolute;
    right: 8px;
    display: flex;
    
}
.btn-add-common{
display: flex;
width: 100px;
    height: 32px;
    background-color: #00966B;
    border-radius: 5px;
    cursor: pointer;
    margin-right: 8px;
}
.btn-function{
    height: 32px;
    width: 32px;
    margin-right: 8px;
    cursor: pointer;
}
.export-excel{
    background-image: url("../assets/icons/1x/icon-export.png");
    background-repeat: no-repeat;
    
}
.reload{
    background-image: url("../assets/icons/1x/Group 30832.png");
    background-repeat: no-repeat;
}
.icon-add{
    background-image: url("../assets/icons/1x/Icon-Plus.png");
    background-repeat: no-repeat;
    height: 16px;
    width: 16px;
    margin: 8px 0px 0px 4px;
}
.text-add{
    color: #fff;
    line-height: 2;
}
</style>
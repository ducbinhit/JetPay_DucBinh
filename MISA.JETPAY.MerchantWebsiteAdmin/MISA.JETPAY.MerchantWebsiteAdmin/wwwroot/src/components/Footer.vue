<template>
    <div class="footer">
        <div class="description-pagination">
            Hiển thị 1-10 trên 120 kết quả
        </div>
        <div class="pagination">
            <div class="w-pagination">
                <div class="icon-previous"></div>
            </div>
            <div class="w-pagination">1</div>
            <div class="w-pagination ">2</div>
            <div class="w-pagination">...</div>
            <div class=" w-pagination">3</div>
            <div class=" w-pagination">
                <div class="icon-next"></div>
            </div>
        </div>
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
.footer{
    position: fixed;
    bottom: 0px;
    right: 0px;
    height: 50px;
    width: calc(100% - 240px);

}
.description-pagination{
    position: absolute;
    left: 18px;
    height: 100%;
    line-height: 3;
}
.pagination{
    position: absolute;
    right: 0;
    height: 100%;
    display: flex;
}
.w-pagination{
    height: 32px;
    width: 32px;
    border: 1px solid #f1f1f1;
    border-radius: 8px;
    margin-right: 8px;
    line-height: 2;
}
.w-pagination .icon-previous{
    height: 100%;
    width: 100%;
    background-image: url("../assets/icons/1x/Icon-Up.png");
    background-repeat: no-repeat;
    background-position: 10px;
}
.w-pagination .icon-next{
    height: 100%;
    width: 100%;
    background-image: url("../assets/icons/1x/next-page.png");
    background-repeat: no-repeat;
    background-position: 10px;
}
</style>

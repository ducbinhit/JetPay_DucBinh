<template>
    <div class="sidebar">
        <div class="container-div-sidebar">
            <div class="icon-sidebar icon-sidebar-multi"></div>
            <div class="logo-jetpay"></div>
        </div>
        <div class="container-div-sidebar" style="padding-top:18px;">
            <div class="icon-sidebar icon-sidebar-dashboard"></div>
            <div class="text-sidebar">Tổng quan</div>
        </div>
        <div class="container-div-sidebar">
            <div class="icon-sidebar icon-sidebar-transaction"></div>
            <div class="text-sidebar">Quản lý giao dịch</div>
        </div>
        <div class="container-div-sidebar">
            <div class="icon-sidebar icon-sidebar-list"></div>
            <div class="text-sidebar">Danh mục</div>
            <div class="icon-arrow expand-down"></div>
        </div>
        <div class="container-div-sidebar">
            <div class="focus"></div>
            <div class="icon-sidebar icon-sidebar-users"></div>
            <div class="text-sidebar active">Quản lý người dùng</div>
            <div class="icon-arrow" ></div>
        </div>
        <div class="child-side-bar">
        <div class="container-div-sidebar">
            <div class="icon-sidebar "></div>
            <div class="text-sidebar">Danh sách người dùng</div>
        </div>
        <div class="container-div-sidebar">
            <div class="icon-sidebar "></div>
            <div class="text-sidebar">Vai trò</div>
        </div>
        </div>
        
        <div class="container-div-sidebar">
            <div class="icon-sidebar icon-sidebar-system"></div>
            <div class="text-sidebar">Hệ thống</div>
            <div ref="iconDropDown" class="icon-arrow"></div>
        </div>
        <div>
        </div>
        <!-- <SideBarItem v-for="(item,index) in listSidebarItem" :key="index" :sidebarItem="index"></SideBarItem> -->
    </div>
</template>
<script>
import { defineComponent } from '@vue/composition-api'
// import SideBarItem from './SideBarItem'
export default defineComponent({
    data(){
        return{
            isDown: true,
            listSidebarItem:[
                 {nameSidebar:"Tổng quan",classIconSidebar:"icon-sidebar-multi"},
                 {nameSidebar:"Quản lý giao dịch",classIconSidebar:"icon-sidebar-dashboard"},
                 {nameSidebar:"Danh mục",classIconSidebar:"icon-sidebar-transaction",isArrow:true},
                 {nameSidebar:"Quản lý người dùng",classIconSidebar:"icon-sidebar-list",isArrow:true},
                 {nameSidebar:"Danh sách người dùng"},
                 {nameSidebar:"Vai trò",},
                 {nameSidebar:"Hệ thống",classIconSidebar:"icon-sidebar-system",isArrow:true}
            ]
        }
    },
    methods: {
        changeIsDown(){
            this.isDown = !this.isDown;
            console.log(this.$refs.iconDropDown.focus());
        }
    },
    components:{
        // SideBarItem
    }
    
    
})
</script>
<style scoped>
.focus{
    height: 40px;
    width: 4px;
    position: absolute;
    left: 0;
    background-color: #00966B;
    border-bottom-right-radius: 20px;
    border-top-right-radius: 20px;
}
.sidebar{
    position: fixed;
    width: 240px;
    height: 100%;
    background-color: #fff;
    left: 0;
    top: 0;
    bottom: 0;
    border-right: 1px solid #f1f1f1;
}
.icon-sidebar{
    width: 24px;
    height: 24px;
    background-repeat: no-repeat;
    align-self: center;

}

.logo-jetpay{
    background-image: url("../assets/icons/1x/Group 30820.png");
    width: 90px;
    height: 32px;
    margin-left: 18px;
}
.icon-sidebar.icon-sidebar-multi{
    background-image: url("../assets/icons/1x/icon-sidebar-multi.png");
    margin-top: 8px;
}
.icon-sidebar.icon-sidebar-dashboard{
    background-image: url("../assets/icons/1x/Icon-Dash board.png");
}
.icon-sidebar.icon-sidebar-transaction{
    background-image: url("../assets/icons/1x/Icon-Transaction.png");
}
.icon-sidebar.icon-sidebar-list{
    background-image: url("../assets/icons/1x/Icon-Danh mục.png");
}
.icon-sidebar.icon-sidebar-users{
    background-image: url("../assets/icons/1x/Icon-User.png");
}
.icon-sidebar.icon-sidebar-system{
    background-image: url("../assets/icons/1x/Icon-Setting.png");
}
.container-div-sidebar{
    display: flex;
    padding-left: 18px;
    padding-top: 8px;
    height: 40px;
}
.text-sidebar{
    margin-left: 8px;
    align-self: center;
}
.text-sidebar.active{
    color: #00966B;
}
.expand-down{
    width: 16px;
    height: 16px;
    background-image: url("../assets/icons/1x/Group 32129.png");
}
.drop-down{
    width: 16px;
    height: 16px;
    background-image: url("../assets/icons/1x/Icon-Dropdown.png");
}
.icon-arrow{
    align-self: center;
    position: absolute;
    right: 8px;
    background-color: #f1f1f1;
    border-radius: 5px;
    cursor: pointer;
}
</style>
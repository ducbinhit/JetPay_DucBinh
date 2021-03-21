<template>
    <div class="manage-user">
        <Layout></Layout>
        <Function :descriptionview="descriptionview"></Function>
        <Table :listNameColumn="listColumnName" :respone="respone"></Table>
    </div>
</template>
<script>
import { defineComponent } from '@vue/composition-api'
import Table from '../../components/Table'
import Function from '../../components/Function'
import Layout from '../../components/Layout'
export default defineComponent({
    setup() {
        
    },
    data: function(){
        return{
            descriptionview:"Danh sách người dùng",
            listColumnName:[
                // nameColumn: tên cột, isFilterInput: dùng ô input để filter, isFilterSelect: dùng select để chọn filter, isAvatar: là cột có avatar để bỏ filter, isSettings: để bỏ filter, textAlign= 0 là căn trái ,1 là căn giữa
                {nameColumn:"Ảnh",fieldColumn: "avatar",isFilterInput:false,isFilterSelect:false,isAvatar:true,textAlign:0,},
                {nameColumn:"Họ và tên",fieldColumn: "fullName",isFilterInput:true,isFilterSelect:false,textAlign:0},
                {nameColumn:"Số điện thoại",fieldColumn: "phoneNumber",isFilterInput:true,isFilterSelect:false,textAlign:1},
                {nameColumn:"Email",fieldColumn: "email",isFilterInput:true,isFilterSelect:false,textAlign:0},
                {nameColumn:"Vai trò",fieldColumn: "role",isFilterInput:true,isFilterSelect:false,textAlign:0},
                {nameColumn:"Trạng thái",fieldColumn: "statusAccount",isFilterInput:false,isFilterSelect:true,textAlign:0},
                {nameColumn:"Cài đặt",fieldColumn: "iconMore",isFilterInput:true,isFilterSelect:false,isSettings:true,textAlign:1},
            ],
            respone:[
                {avatar:require("@/assets/icons/1x/Group 31039.png"),
                fullName:"Lê Đình Dần",
                phoneNumber:"0967145054",
                email:"dinhdan1324@gmail.com",
                role:"Nhân viên",
                statusAccount:"Hoạt động",
                iconMore:require("@/assets/icons/1x/Icon-More.png")}, 
            ],
        }
    },
    components:{
        Table,
        Function,
        Layout
    }
})
</script>
<style scoped>
.manage-user{
    position: absolute;
    top: 56px;
    left: 240px;
    bottom: 50px;
    right: 0px;
}



</style>
<template>
    <div class="manage-role">
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
    components:{
        Table,
        Function,
        Layout
    },
    data: function(){
        return{
            descriptionview:"Vai trò",
            listColumnName:[
                // nameColumn: tên cột, isFilterInput: dùng ô input để filter, isFilterSelect: dùng select để chọn filter, isAvatar: là cột có avatar để bỏ filter, isSettings: để bỏ filter, textAlign= 0 là căn trái ,1 là căn giữa
                {nameColumn:"Mã vai trò",fieldColumn: "roleCode",isFilterInput:true,textAlign:0},
                {nameColumn:"Tên vai trò",fieldColumn: "roleName",isFilterInput:true,textAlign:0},
                {nameColumn:"Diễn giải",fieldColumn: "roleDes",isFilterInput:true,textAlign:0},
                {nameColumn:"Cài đặt",fieldColumn: "iconMore",isSettings:true,textAlign:1},
            ],
            respone:[
                {roleCode:"ROLE1234565",
                roleName:"Giám đốc",
                roleDes:"Giám đốcccccc",
                iconMore:require("@/assets/icons/1x/Icon-More.png")}, 
            ],
        }
    },
    methods:{
        changeClass(){
        }
    }
})
</script>
<style >
.manage-role{
    position: absolute;
    top: 56px;
    left: 240px;
    bottom: 50px;
    right: 0px;
}
</style>
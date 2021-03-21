<template>
    <div class="table-common">
        <table>
            <thead class="thead-first">
                <th v-for="(item,index) in listNameColumn" :key="index">
                    <div v-if="!item.isSettings" class="text-column" :class="[{textleft:checkTextleft(item.textAlign)},{textcenter:!checkTextleft(item.textAlign)}]">{{item.nameColumn}}</div>
                    <div v-else class="icon-settings">
                    </div>

                </th>
            </thead>
            <thead class="thead-two">
                <th  v-for="(item,index) in listNameColumn" :key="index">
                    <div v-if="item.isAvatar" class="contatin-filter" :class={heightInput:item.isAvatar}>
                    </div>
                    <div v-else class="contatin-filter">
                        <div v-if="item.isFilterSelect" style="position: relative;" class="filter-wrap">
                        <div  class="contain-select" @click="isShowSelect =!isShowSelect" >
                            <div class="icon-down"></div>
                            </div>
                            <ul v-show="isShowSelect" class="filter_items">
                                <li class="filter_item" v-for="(item,index) in statusUser" :key="index">{{item}}</li>
                            </ul>
                        </div>
                        <div v-else-if="item.isSettings"></div>

                        <input v-else type="text"/>
                    </div>
                </th>
            </thead >
            <tbody>
                <tr v-for="(item,index) in respone" :key="index">
                    <td class="textleft" v-for="(itemChild,index) in mapColumn" :key="index">
                        <img v-if="itemChild=='avatar'" :src="item[itemChild]">
                        <img v-else-if="itemChild=='iconMore'" :src="item.iconMore"/>
                        <p v-else>
                            {{item[itemChild]}}
                        </p>
                    </td>
                   
                </tr>
            </tbody>
        </table>
    </div>
</template>
<script>
import { defineComponent } from '@vue/composition-api'

export default defineComponent({
    setup() {
        
    },
    created(){
        this.listNameColumn.forEach(element => {
                this.mapColumn.push(element.fieldColumn);
            });
        console.log(this.mapColumn);
    },

    methods:{
        checkTextleft:function(textAlign){
            if(textAlign==0)
                return true;
            else
                return false;
        },
        getListNameRespone(){
            this.listNameColumn.forEach(element => {
                this.mapColumn.push(element.fieldColumn);
            });
            console.log(this.mapColumn);
        }
    },
    props:{
        listNameColumn:Array,
        respone:Array
    },
    data:function(){
        return{
            isShowSelect:false,
            statusUser:[
                "Hoạt động",
                "Tạm dừng",
                "Chờ kích hoạt"
            ],
            mapColumn:[]
        }
    }

})
</script>
<style >
.textleft{
    text-align: left;
}
.textcenter{
text-align: center;
}
.icon-more-table{
    cursor: pointer;
}
.icon-settings{
    background-image: url("../assets/icons/1x/Icon-Setting.png");
    background-repeat: no-repeat;
    height: 100%;
    width: 100%;
    background-position: 25px;
}
.table-common{
    position: absolute;
    top: 66px;
    left: 8px;
    right: 8px;
    bottom: 0;
    overflow-y: scroll;
}
.table-common table{
    width: 100%;
    border-collapse: collapse;
    overflow: scroll;
}
.table-common table tbody td{
    padding: 8px 8px;
}
.heightInput{
    height: 21px;
}
.thead-first{
    /* background-color: #D9DADE; */
}
.thead-first th{
    height: 38px;
    position: sticky;
    top: 0;
    background-color: #D9DADE;
}
.thead-first .text-column{
    padding-left: 8px;
}
.thead-first th:last-child{
width: 4%;
}
.thead-first th:first-child{
width: 4%;
}
.thead-two th{
    padding-top: 8px;
    position: sticky;
    top: 40px;
    background: #fff;
}
.thead-two input{
    border: 1px solid #D9DADE;
    border-radius: 5px;
    height: 28px;
    width: 100%;
}
.contain-select{
    height: 30px;
    border: 1px solid #D9DADE;
    border-radius: 5px;
    position: relative;
}
.contain-select .icon-down{
    background-image: url("../assets/icons/1x/Icon-Down.png");
    background-repeat: no-repeat;
    height: 16px;
    width: 16px;
    position: absolute;
    top: 8px;
    right: 8px;
    cursor: pointer;
}
.contatin-filter{
    width: 95%;
}
.filter-wrap{
    position: relative;
}
.filter_items{
position: absolute;
    top: 50%;
    left: 0;
    padding: 0;
    width: 100%;
    z-index: 9999;
    list-style-type: none;
    background: #ffffff;
    border: 1px solid #e0e0e0;
    text-align: left;
    overflow: hidden;
    border-radius: 5px;
}
.filter_item
{
    padding: 7px 12px;
    border-bottom: 1px solid #e0e0e0;
    cursor: pointer;
}
.filter_item:hover{
    background-color: #00966B;
}

</style>

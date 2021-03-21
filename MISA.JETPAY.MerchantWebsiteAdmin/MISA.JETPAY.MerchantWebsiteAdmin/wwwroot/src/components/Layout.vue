<template>
    <div class="layout">
        <Sidebar></Sidebar>
        <Header></Header>
    </div>
</template>
<script>
import { defineComponent } from '@vue/composition-api'
import Sidebar from './SideBar';
import Header from './Header';
export default defineComponent({
    setup() {
        
    },
    components:{
        Sidebar,
        Header,
    }
})
</script>
<style scoped>

</style>
<template>
  <div>
    <Header />
    
        <div style="background-color : #f2f4f6;">
            <router-view />
        </div>
   
    <Footer />
  </div>
</template>

<script>
import Header from '../../components/TheHeader'
import Footer from '../../components/TheFooter'

export default {
   name: "methods",
   components: {
       Header,
       Footer
   }
}
</script>

<style>
</style>
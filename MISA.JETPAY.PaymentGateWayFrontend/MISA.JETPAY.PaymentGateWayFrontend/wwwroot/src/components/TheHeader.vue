<template>
  <div class="header">
      <div class="content">
          <div class="logo"></div>
          <div class="language">
              <div class="logo-nation"></div>
              <div class="name-language">Tiếng việt</div>
              <div class="option-language"></div>
          </div>
      </div>
  </div>
</template>

<script>
export default {

}
</script>

<style>
    .header{
        width: 1366px;
        margin: auto;
        position: relative;
        background-color: #ffff;
        height: 64px;
        font-family: GoogleSans Bold;
    }
    .header .content{
       margin-left: 101px;
        margin-right: 101px;
        height: 64px;
        display: flex;
        justify-content: space-between;
    }
    .header .content .logo{
        width: 108px;
        height: 43px;
        margin-bottom: auto;
        margin-top: auto;
        background-image: url('../assets/icons/2x/JETPAY@2x.png');           
    }
    .header .content .language{
        
        width: 160px;
        height: 48px;
        margin-bottom: auto;
        margin-top: auto;
        border: 1px solid #D9DADE;
        border-radius: 4px;
        display: flex;
    }
    .language .logo-nation{
        margin: 8px;
        height: 32px;
        width: 40px;
        background-repeat: no-repeat;
        background-size: contain;
        background-image: url('../assets/icons/2x/300px-Flag_of_Vietnam.svg@2x.png');
    }
    .language .name-language{
        margin:14px 9px 15px 0 ;
    }
    .language .option-language{
        height: 16px;
        width: 16px;
        background-image: url('../assets/icons/2x/Icon-Dropdown@2x.png');
        background-repeat: no-repeat;
        background-size: contain;
        margin: 16px 0px 16px 0px;
    }
</style>
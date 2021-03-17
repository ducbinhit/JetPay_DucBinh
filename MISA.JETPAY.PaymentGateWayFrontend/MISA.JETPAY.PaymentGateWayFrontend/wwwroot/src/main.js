import Vue from 'vue'
import App from './App.vue'
import router from './router'
import store from './store'
import VueCardFormat from 'vue-credit-card-validation';

Vue.config.productionTip = false
Vue.use(VueCardFormat);

new Vue({
  router,
  store,
  render: h => h(App)
}).$mount('#app')

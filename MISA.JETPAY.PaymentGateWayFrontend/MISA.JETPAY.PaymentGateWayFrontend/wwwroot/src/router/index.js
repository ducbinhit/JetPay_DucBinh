import Vue from 'vue'
import Router from 'vue-router'
 //import TheHeader from '@/components/TheHeader'

Vue.use(Router)

export default new Router({
  mode: 'history',
  routes: [
    {
      path: '/',
      redirect: '/merchant',
      name: 'main'
    },
    {
      path: '/merchant',
      name: 'merchant',
      component: () =>
        import('@/pages/merchants')
    },
    {
      path: '/paymentmethods',
      name: 'paymentmethods',
      component: () =>
        import('@/pages/paymentmethods'),
      children: [{
        path: '/',
        name: 'inland',
        component: () =>
            import('@/views/paymentmethods/InLand.vue')
      },
      {
        path: '/paymentmethods/inland',
        name: 'inland',
        component: () =>
            import('@/views/paymentmethods/InLand.vue')
      },
      {
        path: '/paymentmethods/global',
        name: 'global',
        component: () =>
            import('@/views/paymentmethods/Global.vue')
      }
      ]
    },
    {
      path: '/paymentmethods/payment-fail',
      name: 'paymentfail',
      component: () =>
        import('@/views/paymentmethods/NotificationFail.vue')
    },
    {
      path: '/paymentmethods/payment-success',
      name: 'paymentsuccess',
      component: () =>
        import('@/views/paymentmethods/NotificationSuccess.vue')
    },
    
  ]
})

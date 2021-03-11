import Vue from "vue";
import Router from "vue-router";

Vue.use(Router);

export default new Router({
    mode: "history",
    routes: [{
            path: "/",
            redirect: '/auth',
            name: "main"
        },
        {
            path: "/auth",
            name: "auth",
            component: () =>
                import ("@/pages/auth"),
            children: [{
                    path: "",
                    name: 'login',
                    component: () =>
                        import ("@/views/auth/Login")
                },
                {
                    path: "register",
                    name: 'register',
                    component: () =>
                        import ("@/views/auth/Register")
                }
            ]
        },
        {
            path: "/admin",
            name: "admin",
            component: () =>
                import ("@/pages/admin"),
            beforeEnter: (to, from, next) => {
                let user = localStorage.getItem('user');
                if (user) {
                    user = JSON.parse(user);
                    if (user.username == "admin" && user.password == "12345678@Abc") {
                        next();
                        return;
                    }
                }
                next('auth');
            },
            children: [{
                    path: "application",
                    name: "application",
                    component: () =>
                        import ("@/views/admin/application")
                },
                {
                    path: "bank",
                    name: "bank",
                    component: () =>
                        import ("@/views/admin/bank")
                },
                {
                    path: "service",
                    name: "service",
                    component: () =>
                        import ("@/views/admin/jetpay_service")
                },
                {
                    path: "transaction",
                    name: "transaction",
                    component: () =>
                        import ("@/views/admin/transaction")
                }
            ]
        }
    ]
});
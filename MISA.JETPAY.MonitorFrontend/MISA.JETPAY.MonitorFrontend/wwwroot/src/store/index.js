import Vue from 'vue';
import Vuex from 'vuex';
import common from './modules/common';
import pagination from './modules/pagination';
import bank from './modules/bank';
Vue.use(Vuex);

export const store = new Vuex.Store({
    modules: {
        common,
        pagination,
        bank
    }
});
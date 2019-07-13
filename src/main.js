import Vue from "vue";
import App from "./App.vue";
import router from "./router";

import MaterialKit from "./plugins/material-kit";
import VueResource from "vue-resource";
import Vuelidate from "vuelidate";

Vue.config.productionTip = false;

Vue.use(MaterialKit);
Vue.use(VueResource);
Vue.use(Vuelidate);


const NavbarStore = {
  showNavbar: false
};

Vue.mixin({
  data() {
    return {
      NavbarStore
    };
  }
});

new Vue({
  router,
  render: h => h(App)
}).$mount("#app");

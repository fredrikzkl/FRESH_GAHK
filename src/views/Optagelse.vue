<template>
  <div class="wrapper">
    <div class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-80 md-small-size-100 mx-auto text-center">
            <div class="md-card md-card md-card-signup md-theme-default">
              <div class="md-card-content">
                <h2 class="card-title text-center">Optagelse</h2>
                <div class="md-layout">
                  <!--Tekst og Generell Info-->
                  <div class="md-layout-item md-size-50 md-small-size-100 ml-auto"></div>
                  <!--Selve Formen-->
                  <div
                    class="md-layout-item md-size-40 md-medium-size-50 md-small-size-100 mr-auto"
                  >
                    <form>
                      <md-field class="md-form-group" slot="inputs">
                        <md-icon>face</md-icon>
                        <label>Fulde Navn...</label>
                        <md-input v-model="fuldenavn"></md-input>
                      </md-field>
                      <md-field class="md-form-group" slot="inputs">
                        <md-icon>mail</md-icon>
                        <label>Email...</label>
                        <md-input v-model="email"></md-input>
                      </md-field>
                    
                      <div class="md-form-group" slot="radios">
                        <!--<i class="fas fa-venus-mars"></i>-->
                        <md-radio v-model="gender" :value="mand">Mand</md-radio>
                        <md-radio v-model="gender" :value="kvinde">Kvinde</md-radio>
                      </div>
                      <div class="md-layout">
                        <div class="md-layout-item md-size-50">
                          <md-field>
                            <label for="age">Alder</label>
                            <md-input
                              type="number"
                              id="age"
                              name="age"
                              autocomplete="age"
                              v-model="age"
                            />
                          </md-field>
                        </div>

                        <div class="md-layout-item md-size-50">
                          <md-field>
                            <label for="age">År studeret</label>
                            <md-input
                              type="number"
                              id="aarStudert"
                              name="aarStudert"
                              v-model="aarStudert"
                            />
                          </md-field>
                        </div>
                      </div>
                    </form>
                  </div>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { LoginCard, Modal } from "@/components";

export default {
  components: {
    LoginCard,
    Modal
  },
  bodyClass: "singup-page",
  data() {
    return {
      classicModal: false,
      fuldenavn: null,
      email: null,
      mand: 0,
      kvinde: 1,
      gender: null,
      age: null,
      aarStudert: null
    };
  },
  methods: {
    classicModalHide() {
      this.classicModal = false;
    }
  },
  props: {
    header: {
      type: String,
      default: require("@/assets/img/profile_city.jpg")
    }
  },
  computed: {
    headerStyle() {
      return {
        backgroundImage: `url(${this.header})`
      };
    }
  }
};
</script>

<style lang="css"></style>

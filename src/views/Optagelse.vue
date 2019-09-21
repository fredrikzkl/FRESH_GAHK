<template>
  <div class="wrapper">
    <div class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-80 md-small-size-100 mx-auto text-center">
            <div class="md-card md-card md-card-signup md-theme-default">
              <div class="md-card-content">
                <h2 class="card-title text-center">Optagelse</h2>
                    <form>
                <div class="md-layout">
                  <div class="md-layout-item md-size-50 md-small-size-100 ml-auto">

                  </div>
                  <!--Selve Formen-->
                  <div class="md-layout-item md-size-40 md-medium-size-50 md-small-size-100 mr-auto">

                  </div>                  
                  </div>
                  
                  </form>
                   
                       <md-field>
                        <label>Fulde Navn</label>
                        <md-input v-model="type"></md-input>
                      </md-field>
                      <md-field>
                        <label>Email</label>
                        <md-input v-model="type"></md-input>
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

                      <md-field>
                        <label for="university">Universitet:</label>
                        <md-select class="mdb-select" v-model="unviersity" name="universitet" id="universitet">
                          <md-option value="AU">AU - Aarhus Universitetet</md-option>
                          <md-option value="AAU">AAU - Aalborg Universitetet</md-option>
                          <md-option value="CBS">CBS - Copenhagen Buisness School</md-option>
                          <md-option value="DTU">DTU - Danmarks Tekniske Universitet</md-option>
                          <md-option value="KU">KU - Københavns Universitetet</md-option>
                          <md-option value="RUC">RUC - Roskilde Universitetet</md-option>
                          <md-option value="SDU">SDU - Syddansk Universitetet</md-option>
                          <md-option value="Annet">Annet</md-option>
                        </md-select>
                      </md-field>

                      <md-field>
                        <label>Studieretning</label>
                        <md-input v-model="type"></md-input>
                      </md-field>

                        <md-field>
                        <label for="heardAbout">Hvorfra har du høt om kollegiet?</label>
                        <md-select v-model="heardAbout" name="horte-om" id="horte-om">
                          <md-option value="">På sociale medier (Facebook, Instagram)</md-option>
                          <md-option value="">På en hjemmeside</md-option>
                          <md-option value="">Fra beboere der var på mit studie for at fortælle om kollegiet</md-option>
                          <md-option value="">Annonce i avis</md-option>
                          <md-option value="">Fået anbefalet af en jeg kender</md-option>
                          <md-option value="">Set en plakat</md-option>
                          <md-option value="">Selv fundet frem til det</md-option>
                        </md-select>
                      </md-field>

                      <md-field>
                        <label>Kort motivation</label>
                        <md-textarea v-model="textarea" md-counter="500" maxlength="500"></md-textarea>
                      </md-field>
                      <md-button class="md-raised md-primary">Send</md-button>

                    
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

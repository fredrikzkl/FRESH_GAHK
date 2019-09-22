<template>
  <div class="wrapper">
    <div class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div
            class="md-layout-item md-size-80 md-small-size-100 mx-auto text-center opacity-hover {'bounce animated': animated}"
            @animationend="animated = false"
          >
            <div class="md-card md-card md-card-signup md-theme-default">
              <div class="md-card-content">
                <div id="description-content">
                  <h2 class="card-title text-center">Optagelse</h2>
                  <!-- Description CONTENT-->
                  <div class="md-layout" style="text-align:left">
                    <div class="md-layout-item md-size-50 md-small-size-100 ml-auto">
                      <h3>Ansøgningsprocess</h3>
                      <p>
                        Indstillingen består af fire beboere på kollegiet, der varetager kontakten til potentielle nye beboere. Gruppen står for rundvisning og eventuel optagelse på baggrund af indsendte ansøgninger.
                        Første skridt er at se, om man opfylder kriterierne for at søge ind på kollegiet. Derefter kan man booke en rundvisning ved at udfylde formularen til højre. Indstillingen vil herefter kontakte dig med henblik på en rundvisning, når der er udsigt til ledige værelser. På rundvisningen kan du få et bedre indtryk af husets atmosfære, værelserne og de mange traditioner, som vi værner om.
                        Efter rundvisningen sender vi dig et ansøgningsskema, som du kan udfylde med en motiveret ansøgning, hvis du synes om stedet og kunne tænke dig at bo sammen med os.
                      </p>
                    </div>
                    <div
                      class="md-layout-item md-size-50 md-medium-size-50 md-small-size-100 mr-auto"
                    >
                      <h3>Kriterier</h3>
                      <p>
                        Vi modtager ansøgninger fra studerende der er påbegyndt 3. semester på en længere videregående uddannelse såsom DTU, KU, SDU, AU, AAU, RUC, CBS, KA og lignende.
                        2/3 af værelserne er forbeholdt studerende ved Danmarks Tekniske Universitet, hvorfor der i perioder kun kan optages DTU-studerende.
                        Vi foretrækker, at ansøgere er dansktalende, da det vil gøre det nemmere for alumnen at deltage i kollegielivet.
                      </p>
                    </div>
                  </div>
                  <md-button @click="toggleForm" class="md-raised md-primary">Hent ansøgningsskema</md-button>
                </div>
                <!-- FORM CONTENT-->
                <div id="form-content">
                  <md-button
                    @click="toggleDescription"
                    class="md-icon-button md-primary"
                    style="float:left;"
                  >
                    <md-icon>arrow_back</md-icon>
                  </md-button>
                  <h2 class="card-title text-center">Ansøgning om rundvisning</h2>

                  <!-- Description CONTENT-->
                  <form id="soknadsskjema" novalidate @submit.prevent="validateSkjema">
                    <div class="md-layout">
                      <div class="md-layout-item md-size-50 md-small-size-100 ml-auto">
                        <md-field :class="getValidationClass('fultNavn')">
                          <label>Fulde Navn</label>
                          <md-input id="fultNavn" v-model="form.fultNavn"></md-input>
                          <span
                            class="md-error"
                            v-if="!$v.form.fultNavn.required"
                          >Vi trenger dit fulde navn</span>
                          <span
                            class="md-error"
                            v-else-if="!$v.form.fultNavn.minlength"
                          >Ugyldigt navn</span>
                        </md-field>
                        <md-field :class="getValidationClass('email')">
                          <label>Email</label>
                          <md-input id="email" v-model="form.email"></md-input>
                          <span class="md-error" v-if="!$v.form.email.required">Email er påkrævet</span>
                          <span class="md-error" v-else-if="!$v.form.email.email">Ugydlig Email</span>
                        </md-field>

                        <div class="md-form-group" slot="radios">
                          <md-field :class="getValidationClass('gender')">
                            <md-radio v-model="form.gender" :value="mand">Mand</md-radio>
                            <md-radio v-model="form.gender" :value="kvinde">Kvinde</md-radio>
                            <span class="md-error" v-if="!$v.form.gender.required">Vælg dit køn</span>
                          </md-field>
                          <!--<i class="fas fa-venus-mars"></i>-->
                        </div>
                        <div class="md-layout">
                          <div class="md-layout-item md-size-50">
                            <md-field :class="getValidationClass('alder')">
                              <label for="age">Alder</label>
                              <md-input
                                type="number"
                                id="age"
                                name="age"
                                autocomplete="age"
                                v-model="form.alder"
                              />
                              <span
                                class="md-error"
                                v-if="!$v.form.alder.required"
                              >Alder er påkrævet</span>
                              <span
                                class="md-error"
                                v-else-if="!$v.form.alder.between"
                              >Alder er mellem 18 og 35</span>
                            </md-field>
                          </div>

                          <div class="md-layout-item md-size-50">
                            <md-field :class="getValidationClass('aarStudert')">
                              <label for="age">År studeret</label>
                              <md-input
                                type="number"
                                id="aarStudert"
                                name="aarStudert"
                                v-model="form.aarStudert"
                              />
                              <span
                                class="md-error"
                                v-if="!$v.form.aarStudert.required"
                              >År studeret er påkrævet</span>
                              <span
                                class="md-error"
                                v-else-if="!$v.form.aarStudert.between"
                              >Du må ha studert mellem 1 og 12 år</span>
                            </md-field>
                          </div>
                        </div>

                        <md-field :class="getValidationClass('universitet')">
                          <label for="university">Universitet:</label>
                          <md-select
                            class="mdb-select"
                            v-model="form.universitet"
                            name="universitet"
                            id="universitet"
                          >
                            <md-option value="AU">AU - Aarhus Universitetet</md-option>
                            <md-option value="AAU">AAU - Aalborg Universitetet</md-option>
                            <md-option value="CBS">CBS - Copenhagen Buisness School</md-option>
                            <md-option value="DTU">DTU - Danmarks Tekniske Universitet</md-option>
                            <md-option value="KU">KU - Københavns Universitetet</md-option>
                            <md-option value="RUC">RUC - Roskilde Universitetet</md-option>
                            <md-option value="SDU">SDU - Syddansk Universitetet</md-option>
                            <md-option value="Andet">Andet</md-option>
                          </md-select>
                          <span
                            class="md-error"
                            v-if="!$v.form.universitet.required"
                          >Vælg dit universitet</span>
                        </md-field>
                      </div>
                      <!--Selve Formen-->
                      <div
                        class="md-layout-item md-size-50 md-medium-size-50 md-small-size-100 mr-auto"
                      >
                        <md-field :class="getValidationClass('studieretning')">
                          <label>Studieretning</label>
                          <md-input v-model="form.studieretning"></md-input>
                           <span
                                class="md-error"
                                v-if="!$v.form.studieretning.required"
                              >Studieretning er påkrævet</span>
                              <span
                                class="md-error"
                                v-else-if="!$v.form.studieretning.minLength"
                              >Ugyldig verdi</span>
                        </md-field>

                        <md-field :class="getValidationClass('horteOm')">
                          <label for="horteOm">Hvorfra har du høt om kollegiet?</label>
                          <md-select
                            class="mdb-select"
                            v-model="form.horteOm"
                            name="horteOm"
                            id="horteOm"
                          >
                            <md-option
                              value="På sociale medier"
                            >På sociale medier (Facebook, Instagram)</md-option>
                            <md-option value="På en hjemmeside">På en hjemmeside</md-option>
                            <md-option
                              value="Beboere der var på mit studie for at fortælle om kollegiet"
                            >Fra beboere der var på mit studie for at fortælle om kollegiet</md-option>
                            <md-option value="Annonce i avis">Annonce i avis</md-option>
                            <md-option
                              value="Fået anbefalet af en jeg kender"
                            >Fået anbefalet af en jeg kender</md-option>
                            <md-option value="Set en plakat">Set en plakat</md-option>
                            <md-option value="Selv fundet frem til det">Selv fundet frem til det</md-option>
                          </md-select>
                           <span
                                class="md-error"
                                v-if="!$v.form.horteOm.required"
                              >Vælg en påstand</span>
                          
                        </md-field>

                        <md-field :class="getValidationClass('motivasjon')">
                          <label>Kort motivation</label>
                          <md-textarea
                            v-model="form.motivasjon"
                            md-counter="500"
                            maxlength="500"
                            style="height:130px"
                          ></md-textarea>
                          <span
                                class="md-error"
                                v-if="!$v.form.motivasjon.required"
                              >Skriv noget om hvorfor du vil flytte ind hos os</span>
                              <span
                                class="md-error"
                                v-else-if="!$v.form.motivasjon.minLength"
                              >Skriv i det mindste 50 tegn</span>
                        </md-field>
                        <br />
                      </div>
                    </div>
                    <md-button type="submit" class="md-raised md-primary">Send</md-button>
                  </form>
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
import $ from "jquery";

import { validationMixin } from "vuelidate";
import {
  required,
  email,
  minLength,
  maxLength,
  between
} from "vuelidate/lib/validators";

export default {
  components: {
    LoginCard,
    Modal
  },
  mixins: [validationMixin],
  bodyClass: "singup-page",
  data() {
    return {
      mand: 0,
      kvinde: 1,
      form: {
        fultNavn: null,
        email: null,
        gender: null,
        alder: null,
        aarStudert: null,
        universitet: null,
        studieretning: null,
        horteOm: null,
        motivasjon: null
      }
    };
  },
  validations: {
    form: {
      fultNavn: {
        required,
        minLength: minLength(3)
      },
      email: {
        required,
        email
      },
      gender: {
        required
      },
      alder: {
        required,
        between: between(18, 35)
      },
      universitet: {
        required
      },
      aarStudert: {
        required,
        between: between(1, 12)
      },
      studieretning: {
        required,
        minLength: minLength(3)
      },
      horteOm: {
        required
      },
      motivasjon: {
        required,
        minLength: minLength(50)
      }
    }
  },

  methods: {
    validateSkjema() {
      this.$v.$touch();
      if (!this.$v.$invalid) {
        console.log("Skjemaet er valid");
      } else {
        console.log("STOP EN HALL MISTER");
        console.log(this.$v);
      }
    },
    getValidationClass(fieldName) {
      const field = this.$v.form[fieldName];
      if (field) {
        return {
          "md-invalid": field.$invalid && field.$dirty
        };
      }
    },
    clearForm() {
      this.$v.$reset();
      this.form.firstName = null;
      this.form.lastName = null;
      this.form.age = null;
      this.form.gender = null;
      this.form.email = null;
    },
    classicModalHide() {
      this.classicModal = false;
    },
    toggleForm() {
      $("#description-content").hide();
      $("#form-content").show();
      this.animate();
    },
    toggleDescription() {
      $("#form-content").hide();
      $("#description-content").show();
    },
    animate() {
      this.animate = true;
    }
  },
  mounted: function() {
    this.toggleForm();
  },
  props: {
    header: {
      type: String,
      default: require("@/assets/img/optagelse/header.jpg")
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

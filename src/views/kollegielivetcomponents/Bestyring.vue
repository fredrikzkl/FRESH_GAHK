<template>
  <div class="wrapper">
    <parallax class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto text-center">
            <h1 class="title">Bestyring</h1>
            <h4>På kollegiet har vi en række traditionelle fester og arrangementer, der gentages hvert år. Dertil kommer selvfølgelig alt det spontane.</h4>
            <br />
            <md-button
              href
              class="md-button md-success md-lg md-round md-theme-default"
              target="_blank"
            >
              <i class="fas fa-play"></i>Læs mer
            </md-button>
          </div>
        </div>
      </div>
    </parallax>

    <div class="main main-raised">
      <div class="section section-text pb-0">
        <div class="container">
            <h3>Denne siden er tom</h3>
        </div>
      </div>
   
    </div>
    <!--Læs mer om kollegiet seksjon-->
   
  </div>
</template>


<script>
export default {
  components: {},
  bodyClass: "blog-post",
  props: {
    header: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/header.jpg")
    },
    skovtur1: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/skovtur1.jpg")
    },
    skovtur2: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/skovtur2.jpg")
    },
    fodselsdag: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/fodselsdag.jpg")
    },
    akweekend: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/akweekend.jpg")
    },
    mathilden: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/mathilden.jpg")
    },
    fodbold: {
      type: String,
      default: require("@/assets/img/kollegielivet/aaretsgang/fodbold.jpg")
    },
    madordningHeader: {
      type: String,
      default: require("@/assets/img/kollegielivet/madordning/header.jpg")
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


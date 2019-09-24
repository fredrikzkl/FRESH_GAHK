<template>
  <div class="wrapper">
    <parallax class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div
            class="md-layout-item md-size-50 md-small-size-70 md-xsmall-size-100"
          >
            <h1 class="title">Livet på kollegiet</h1>
            <h4>
              "Alle beboere har at opføre sig som gentlemen og ladies"<br> – G. A. Hagemann
            </h4>
            <br />
            <md-button
              href="https://www.youtube.com/watch?v=dQw4w9WgXcQ"
              class="md-success md-lg"
              target="_blank"
              ><i class="fas fa-play"></i>Se Video</md-button
            >
          </div>
        </div>
      </div>
    </parallax>
    <div class="main main-raised">
      <div class="section">
        <div class="container">
          <div class="md-layout">
            <div
              class="md-layout-item md-size-66 md-small-size-100 mx-auto text-center"
            >
              <h2 class="title text-center">Visionen for GAHK</h2>
              <h5 class="description">
                GAHK skal videreføre G.A. Hagemanns ønske om at skabe et hjem præget af forpligtende fællesskab for alumnerne med særligt hensyn til nutidens krav og fremtidens muligheder. GAHK skal i tråd med Hagemanns ånd være funderet på en innovativ, fremsynet kultur, der indbyder til tværfaglig nytænkning og kunstnerisk udfoldelse.
              <br><br>
GAHK skal være et rummeligt og gæstfrit sted, som favner kvinder og mænd fra alle studieretninger.
              </h5>
              
            </div>

           

          </div>
          
          <div class="profile-tabs">
            <tabs
              :tab-name="['Alumnerne','Madordning', 'Årets Gang', 'Bestyring']"
              :tab-icon="['school','restaurant', 'event', 'gavel']"
              plain
              nav-pills-icons
              color-button="success"
            >
              <!-- here you can add your content for tab-content -->
              <Alumnerne slot="tab-pane-1"></Alumnerne>
              <Madordning slot="tab-pane-2"></Madordning>
             
            </tabs>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import { Tabs } from "@/components";

import Alumnerne from "./kollegielivetcomponents/Alumnerne";
import Madordning from "./kollegielivetcomponents/Madordning";

export default {
  components: {
    Alumnerne,
    Madordning,
    Tabs
  },
  bodyClass: "landing-page",
  props: {
    header: {
      type: String,
      default: require("@/assets/img/huset/gang.jpg")
    },
    alumne1: {
      type: String,
      default: require("@/assets/img/alumnerne/a1.jpg")
    },
    teamImg2: {
      type: String,
      default: require("@/assets/img/faces/christian.jpg")
    },
    teamImg3: {
      type: String,
      default: require("@/assets/img/faces/kendall.jpg")
    }

  },
  data() {
    return {
      name: null,
      email: null,
      message: null
    };
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

<style lang="scss" scoped>
.md-card-actions.text-center {
  display: flex;
  justify-content: center !important;
}
.contact-form {
  margin-top: 30px;
}

.md-has-textarea + .md-layout {
  margin-top: 15px;
}

.profile-tabs /deep/ {
  .md-card-tabs .md-list {
    justify-content: center!important;
  }

  [class*="tab-pane-"] {
    margin-top: 3.213rem;
    padding-bottom: 50px;

    img {
      margin-bottom: 2.142rem;
    }
  }
}
</style>

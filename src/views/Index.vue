<template>
  <div class="wrapper">
    <parallax class="page-header header-filter" :style="headerStyle">
      <div class="md-layout">
        <div class="md-layout-item">
          <div class="image-wrapper">
            <div class="brand">
              <h1>G.A Hagemanns Kollegium</h1>
              <h3>Et bedre kollegium enn NOKO</h3>
            </div>
          </div>
        </div>
      </div>
    </parallax>
    <div class="main main-raised">
      <div class="section">
        <div class="container">
          <div class="md-layout">
            <div class="md-layout-item md-size-66 md-xsmall-size-100 mx-auto text-center">
              <h2 class="title text-center">Velkommen til GAHK</h2>
              <h4
                class="description"
              >Et traditionsrigt, socialt og skønhamrende dejligt kollegium i hjertet af København.</h4>
            </div>
          </div>
          <div  @click="unmuteVid">
          <vue-plyr ref="plyr">
          <video id="promo-vid" poster="poster.png" src="video.mp4" v-on:click="unmuteVid">
            <source src="https://gahk.dk/public/image/gahk_promo_web.mp4" type="video/mp4" size="720">
          </video>
          </vue-plyr>
          </div>
          <div class="md-layout" >
            <div class="md-layout-item md-size-66 mx-auto md-small-size-100">
            </div>
          </div>

          <div class="md-layout">
            <div class="md-layout-item md-medium-size-33 md-small-size-100">
              <div class="team-player">
                <md-card class="md-card-plain">
                  <h4 class="card-title">
                    Tradition
                    <br />
                  </h4>

                  <md-card-content>
                    <p
                      class="card-description"
                    >GAHK er et selvdrevet kollegium med 61 studerende fra forskellige videregående uddannelser. Alumnerne er sammen om alt fra fællesspisning hver aften og fester i weekenden til eksamensperioder på læsesalen. Det er et af de ældste kollegier i København med vægge prydet med kunst, som skaber rammerne for en unik og åbenhjertet stemning mellem beboerne.</p>
                  </md-card-content>
                </md-card>
              </div>
            </div>

            <div class="md-layout-item md-medium-size-33 md-small-size-100">
              <div class="team-player">
                <md-card class="md-card-plain">
                  <h4 class="card-title">
                    Historie
                    <br />
                  </h4>

                  <md-card-content>
                    <p
                      class="card-description"
                    >Gustav Adolph Hagemann grundlagde kollegiet for at studerende kunne have et sted, hvor venskaber og kreativitet kunne blomstre. Siden 1908 har alumner levet en tilværelse med højt til loftet, gensidig respekt og en vilje til at bidrage med 110 procent til et enestående fællesskab.</p>
                  </md-card-content>
                </md-card>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import BasicElements from "./components/BasicElementsSection";
import Navigation from "./components/NavigationSection";
import SmallNavigation from "./components/SmallNavigationSection";
import Tabs from "./components/TabsSection";
import NavPills from "./components/NavPillsSection";
import Notifications from "./components/NotificationsSection";
import TypographyImages from "./components/TypographyImagesSection";
import JavascriptComponents from "./components/JavascriptComponentsSection";
import { LoginCard } from "@/components";

import {VuePlyr} from 'vue-plyr'
import 'vue-plyr/dist/vue-plyr.css' // only if your build system can import css, otherwise import it wherever you would import your css.



export default {
  components: {
    BasicElements,
    Navigation,
    SmallNavigation,
    Tabs,
    NavPills,
    Notifications,
    TypographyImages,
    JavascriptComponents,
    LoginCard,
    VuePlyr

  },
  data() {
    return {
      leafShow: false,
      videoOptions :  {
          autoplay : true,
          muted : true
      }
    };
  },
  methods: {
    leafActive() {
      if (window.innerWidth < 768) {
        this.leafShow = false;
      } else {
        this.leafShow = true;
      }
    },
    unmuteVid(){
      this.player.muted = false;
    }
  },
  computed: {
    headerStyle() {
      return {
        backgroundImage: `url(${this.image})`
      };
    },
    signupImage() {
      return {
        backgroundImage: `url(${this.signup})`
      };
    },
    player () {
       return this.$refs.plyr.player 
    }

  },
  mounted() {
    this.leafActive();
    window.addEventListener("resize", this.leafActive);
    this.player.play();
    this.player.muted = true;
   
  },
  beforeDestroy() {
    window.removeEventListener("resize", this.leafActive);
     
  },
  name: "index",
  bodyClass: "index-page",
  props: {
    image: {
      type: String,
      default: require("@/assets/img/gahk_fasade.jpg")
    },
    gahkfasade: {
      type: String,
      default: require("@/assets/img/gahk_fasade.jpg")
    },
    gahk1: {
      type: String,
      default: require("@/assets/img/huset/madordning2.jpg")
    },
    gahk2: {
      type: String,
      default: require("@/assets/img/huset/madordning.jpg")
    },
    teamImg3: {
      type: String,
      default: require("@/assets/img/faces/kendall.jpg")
    },
    signup: {
      type: String,
      default: require("@/assets/img/city.jpg")
    },
    landing: {
      type: String,
      default: require("@/assets/img/landing.jpg")
    },
    profile: {
      type: String, 
      default: require("@/assets/img/profile.jpg")
    }
  }
};
</script>
<style lang="scss">
.section-download {
  .md-button + .md-button {
    margin-left: 5px;
  }
}

@media all and (min-width: 991px) {
  .btn-container {
    display: flex;
  }
}
</style>

<template>
  <div class="wrapper">
    <parallax class="page-header header-filter" :style="headerStyle">
      <div class="md-layout">
        <div class="md-layout-item">
          <div class="image-wrapper">
            
            <div class="brand">
              <h1>G.A Hagemanns Kollegium</h1>
              <h3>Beste kollegium eu</h3>
            </div>
          </div>
        </div>
      </div>
    </parallax>
    <div class="main main-raised">
    <div class="section">
        <div class="container">
          <div class="md-layout">
            <div
              class="md-layout-item md-size-66 md-xsmall-size-100 mx-auto text-center"
            >
              <h2 class="title text-center">Velkommen til GAHK</h2>
              <h5 class="description">
Har du lyst til at bo sammen med studerende fra mange forskellige uddannelser på et traditionsrigt kollegium med fællesspisning, sports- og kulturarrangementer, hverdagshygge og gode fester? Har du lyst til at bo i smukke rammer i hjertet af København? Så burde du bo sammen med os. 
              </h5>
            </div>
          </div>
      <div class="md-layout">
        <div class="md-layout-item md-size-66 mx-auto md-small-size-100">
          <md-card>
            <carousel
              :per-page="1"
              loop
              :speed="700"
              autoplay
              :autoplay-timeout="5000"
              :mouse-drag="false"
              navigationEnabled
              navigationNextLabel="<i class='material-icons'>keyboard_arrow_right</i>"
              navigationPrevLabel="<i class='material-icons'>keyboard_arrow_left</i>"
            >
              <slide>
                <div class="carousel-caption">
                  <h4>
                    <md-icon>location_on</md-icon>
                    Somewhere Beyond, United States
                  </h4>
                </div>
                <img :src="carousel1" alt="carousel1" />
              </slide>
              <slide>
                <div class="carousel-caption">
                  <h4>
                    <md-icon>location_on</md-icon>
                    Yellowstone National Park, United States
                  </h4>
                </div>
                <img :src="carousel2" alt="carousel2" />
              </slide>
              <slide>
                <div class="carousel-caption">
                  <h4>
                    <md-icon>location_on</md-icon>
                    Yellowstone National Park, United States
                  </h4>
                </div>
                <img :src="carousel3" alt="carousel3" />
              </slide>
            </carousel>
          </md-card>
        </div>
      </div>

           <div class="md-layout">
              <div class="md-layout-item md-medium-size-33 md-small-size-100">
                <div class="team-player">
                  <md-card class="md-card-plain">
        
                    <h4 class="card-title">
                      Tradisjon
                      <br />
                    </h4>

                    <md-card-content>
                      <p class="card-description">
                        G. A. Hagemanns Kollegium er et af de ældste kollegier i København og huser 61 alumner indskrevet på vidt forskellige studier og opvokset i alle afkroge af landet. Siden 1908 har alumnerne inden for de gamle mure levet en tilværelse med højt til loftet, gensidig respekt og en vilje til at bidrage med 110 procent til et enestående fællesskab.
                      </p>
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
                      <p class="card-description">
                    Kollegiet er opkaldt efter grundlæggeren Gustav Adolph Hagemann og er mere end bare et sted at bo. Det unikke fællesskab, der opstår når så mange engagerede studerende bor sammen, skal der værnes om, og alle bidrager til, at stedets ånd holdes i live, og at de flotte rammer på Kristianiagade kan stå så flotte, som de stadig gør i dag.                      </p>
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
    LoginCard
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
  },
  data() {
    return {
      firstname: null,
      email: null,
      password: null,
      leafShow: false,
      carousel1: require("@/assets/img/nature-2.jpg"),
      carousel2: require("@/assets/img/nature.jpg"),
      carousel3: require("@/assets/img/nature-3.jpg")
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
    getFacebookImages(){
      var url = "https://www.facebook.com/pg/GA-Hagemanns-Kollegium-299814993380395/photos/?tab=album&album_id=299844250044136&ref=page_internal";
      this.$http.get(url).then(function(response){
        if(response.status == "200"){
            console.log(response);
        }
      })
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
    }
  },
  mounted() {
    this.getFacebookImages();
    this.leafActive();
    window.addEventListener("resize", this.leafActive);
  },
  beforeDestroy() {
    window.removeEventListener("resize", this.leafActive);
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

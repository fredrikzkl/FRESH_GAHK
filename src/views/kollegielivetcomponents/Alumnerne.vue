<template>
  <div class="md-layout">
    <div class="text-center">
        <div class="container">
          <h2 class="title">Alumnerne</h2>
          <div class="team">
            <div class="md-layout">
              <div class="md-layout-item md-medium-size-33 md-small-size-100">
                <div class="team-player">
                  <md-card class="md-card-plain">
                    <div class="md-layout-item md-size-100 mx-auto">
                      <img
                        :src="alumne1"
                        alt="Thumbnail Image"
                        class="img-raised rounded-circle img-fluid"
                      />
                    </div>
                    <h4 class="card-title">
                      Kit
                      <br />
                      <small class="card-description text-muted">Landskabsarkitektur, KU</small>
                    </h4>

                    <md-card-content>
                      <p class="card-description">
                        Jeg blev inviteret til Nye Alumners Fest af min gamle tutor, der bor her og efter festen, var jeg nødt til at sende en ansøgning. Nu har jeg boet her i to år, og jeg er vild glad for det. Jeg var spændt på at flytte på kollegie efter at have boet alene i tre år, men jeg fandt hurtigt ud af, at det er luksus at have 60 roomies, og at der også er plads til privatliv. Det kan være lidt skræmmende i starten med så mange nye mennesker, man skal bo sammen med, men folk er enorm åbne, og der er plads til at være den, man er. ​I forhold til privatliv kan man sagtens trække sig tilbage på sit værelse eller på læsesalen, hvis man har brug for at koncentrere sig om en opgave. Og så ved man, hvor man kan gå hen, hvis man vil have selskab. 

Når man kommer hjem fra en lang dag på studiet, kan man gå ned og snakke med folk i spisesalen, man kan hænge ud i TV-stuen eller også bliver der holdt drinksaften på en af salene, som vi tit gør på 4. sal, hvor jeg bor. Udover dagligdagshyggen er det fedt at bo i et hus, der emmer af historie og traditioner. Skovturen er min yndlingstradition, hvor alle sætter en dag af til fælles udflugt og man kommer lidt væk fra vante rammer, men nytårsaften er også altid en virkelig god fest.
                      </p>
                    </md-card-content>
                  </md-card>
                </div>
              </div>
              <div class="md-layout-item md-medium-size-33 md-small-size-100">
                <div class="team-player">
                  <md-card class="md-card-plain">
                    <div class="md-layout-item md-size-100 mx-auto">
                      <img
                        :src="teamImg2"
                        alt="Thumbnail Image"
                        class="img-raised rounded-circle img-fluid"
                      />
                    </div>
                    <h4 class="card-title">
                      Carla Hortensia
                      <br />
                      <small class="card-description text-muted"
                        >Designer</small
                      >
                    </h4>

                    <md-card-content>
                      <p class="card-description">
                        You can write here details about one of your team
                        members. You can give more details about what they do.
                        Feel free to add some <a href="#">links</a> for people
                        to be able to follow them outside the site.
                      </p>
                    </md-card-content>

                    <md-card-actions class="text-center">
                      <md-button
                        href="javascript:void(0)"
                        class="md-just-icon md-simple"
                      >
                        <i class="fab fa-twitter"></i>
                      </md-button>
                      <md-button
                        href="javascript:void(0)"
                        class="md-just-icon md-simple"
                      >
                        <i class="fab fa-linkedin"></i>
                      </md-button>
                    </md-card-actions>
                  </md-card>
                </div>
              </div>
              <div class="md-layout-item md-medium-size-33 md-small-size-100">
                <div class="team-player">
                  <md-card class="md-card-plain">
                    <div class="md-layout-item md-size-100 mx-auto">
                      <img
                        :src="teamImg3"
                        alt="Thumbnail Image"
                        class="img-raised rounded-circle img-fluid"
                      />
                    </div>
                    <h4 class="card-title">
                      Kendall Jenner
                      <br />
                      <small class="card-description text-muted">Model</small>
                    </h4>

                    <md-card-content>
                      <p class="card-description">
                        You can write here details about one of your team
                        members. You can give more details about what they do.
                        Feel free to add some <a href="#">links</a> for people
                        to be able to follow them outside the site.
                      </p>
                    </md-card-content>

                    <md-card-actions class="text-center">
                      <md-button
                        href="javascript:void(0)"
                        class="md-just-icon md-simple"
                      >
                        <i class="fab fa-twitter"></i>
                      </md-button>
                      <md-button
                        href="javascript:void(0)"
                        class="md-just-icon md-simple"
                      >
                        <i class="fab fa-instagram"></i>
                      </md-button>
                      <md-button
                        href="javascript:void(0)"
                        class="md-just-icon md-simple"
                      >
                        <i class="fab fa-facebook-square"></i>
                      </md-button>
                    </md-card-actions>
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

export default {
  components: {
  },
  props: {
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
  
  computed: {
    headerStyle() {
      return {
        backgroundImage: `url(${this.header})`
      };
    }
  }
};
</script>


<template>
  <div class="wrapper">
    <parallax class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto text-center">
            <h1 class="title">Madordning</h1>
            <h4>
             Vores kollegium har en obligatorisk madordning, som omfatter morgen- middag- og aftensmad. Alle hverdage sørger vores skønne madmødre, Tina og Anne, for at lave varm frokost og aftensmad til os, og ud fra et vagtsystem skiftes alumnerne til at give en hånd med. Derudover er der altid fyldt i køleskabene, så man kan smøre sig en madpakke.
            </h4>
            <br>
            <md-button
              href=""
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
        

          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
            <h3 class="title text-left">Morgenmad</h3>
            <p>Morgenmaden omfatter alle de sædvanlige morgenmadsprodukter (youghurt, mælk, brød, cornflakes, havregryn og rosiner), og fra klokken 6:30 bliver der lavet friskbrygget kaffe og te af den alumne, der har skrevet sig på morgenvagten.</p>
            <h3 class="title text-left">Frokost</h3>
            <p>Som noget særligt bliver der serveret frokost hver dag kl.11.45-12.45 i spisesalen. Der er altid mindst tre forskellige grove salater med gulerødder, rødbeder, kål, kikærter, bønner, bær mv., pålæg af forskellig art og en varm ret til dem. Generelt er frokosten designet til at kunne tages med ud af huset så de alumner, der er væk hele dagen har rig mulighed for at smøre en madpakke med køleskabets indhold og rester fra gårdsdagen.</p>
            <img alt="Raised Image" :src="madordning2" class="img-raised rounded img-fluid">
            <h3 class="title text-left">Aftensmad</h3>
            <p>Vores kære madmødre går meget op i, at vi får god og varieret kost, så de laver alt fra steg og wok til fisk, vegetarretter og koldbuffet. Somme tider laver de også dessert. Aftensmaden serveres kl. 18, og hvis man ved, at man kommer senere hjem, kan man bede aftenvagten stille en tallerken til side.</p>
            <h3 class="title text-left">Weekends</h3>
            <p>Til weekenden, hvor Tina og Anne har fri, er der købt ind til, at vi selv kan gå i køkkenet, og hvis man har et ønske om at lave noget bestemt, snakker man bare med Tina om at få bestilt varer hjem til det.</p>
            <img alt="Raised Image" :src="kokkenvagt" class="img-raised rounded img-fluid center  ">
            <h3 class="title text-left">Køkkenvagter</h3>
            <p>For at det hele kan løbe rundt, skal vi selvfølgelig bidrage. Hvis man tager tre køkkenkrydser om måneden, hvilket svarer til omkring fire timers køkkenarbejde, behøver man ikke gøre mere. Man skriver sig selv på, hvilke vagter man foretrækker alt efter om morgener, middag eller aften passer en bedst.</p>

          </div>
        </div>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  components: {},
  bodyClass: "blog-post",
  props: {
    header: {
      type: String,
      default: require("@/assets/img/madordning/madordning.jpg")
    },
    madordning1: {
      type: String,
      default: require("@/assets/img/madordning/madordning.jpg")
    },
    madordning2: {
      type: String,
      default: require("@/assets/img/madordning/madordning2.jpg")
    },
    kokkenvagt: {
      type: String,
      default: require("@/assets/img/madordning/vagt.jpg")
    }
  },

  computed: {
    headerStyle() {
      return {
        backgroundImage: `url(${this.header})`,
      };
    }
  }
};
</script>


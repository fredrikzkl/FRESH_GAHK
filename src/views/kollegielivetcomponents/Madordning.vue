<template>
  <div class="md-layout blog-post">
    <div class="text-center">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
            <h2 class="title">Madordning</h2>
            <p>Vores kollegium har en obligatorisk madordning, som omfatter morgen- middag- og aftensmad. Alle hverdage sørger vores skønne madmødre, Tina og Anne, for at lave varm frokost og aftensmad til os, og ud fra et vagtsystem skiftes alumnerne til at give en hånd med. Derudover er der altid fyldt i køleskabene, så man kan smøre sig en madpakke.</p>
            <p>Til weekenden, hvor Tina og Anne har fri, er der købt ind til, at vi selv kan gå i køkkenet, og hvis man har et ønske om at lave noget bestemt, snakker man bare med Tina om at få bestilt varer hjem til det.</p>
          </div>
        </div>

        <div class="section md-layout-item md-size-80 md-medium-size-100 mx-auto">
          <div class="md-layout">
            <div class="md-layout-item md-size-33 md-small-size-100">
              <img alt="Raised Image" :src="madordning1" class="img-raised rounded img-fluid">
            </div>
          </div>
        </div>

        <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
          <h3 class="title text-left">Morgenmad</h3>
          <p>Morgenmaden omfatter alle de sædvanlige morgenmadsprodukter (youghurt, mælk, brød, cornflakes, havregryn og rosiner), og fra klokken 6:30 bliver der lavet friskbrygget kaffe og te af den alumne, der har skrevet sig på morgenvagten.</p>
          <h3 class="title text-left">Frokost</h3>
          <p>Som noget særligt bliver der serveret frokost hver dag kl.11.45-12.45 i spisesalen. Der er altid mindst tre forskellige grove salater med gulerødder, rødbeder, kål, kikærter, bønner, bær mv., pålæg af forskellig art og en varm ret til dem. Generelt er frokosten designet til at kunne tages med ud af huset så de alumner, der  er væk hele dagen har rig mulighed for at smøre en madpakke med køleskabets indhold og rester fra gårdsdagen.</p>
           <h3 class="title text-left">Aftensmad</h3>
          <p>Vores kære madmødre går meget op i, at vi får god og varieret kost, så de laver alt fra steg og  wok til fisk, vegetarretter og koldbuffet. Somme tider laver de også dessert. Aftensmaden serveres kl. 18, og hvis man ved, at man kommer senere hjem, kan man bede aftenvagten stille en tallerken til side.</p>
           <h3 class="title text-left">Køkkenvagter</h3>
          <p>For at det hele kan løbe rundt, skal vi selvfølgelig bidrage. Hvis man tager tre køkkenkrydser om måneden, hvilket svarer til omkring fire timers køkkenarbejde, behøver man ikke gøre mere. Man skriver sig selv på, hvilke vagter man foretrækker alt efter om morgener, middag eller aften passer en bedst. </p>
        </div>
      </div>
    </div>
  </div>
</template>


<script>
export default {
  components: {},
  bodyClass: "",
  props: {
    madordning1: {
      type: String,
      default: require("@/assets/img/madordning.jpg")
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


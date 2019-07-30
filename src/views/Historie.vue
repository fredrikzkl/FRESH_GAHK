<template>
  <div class="wrapper">
    <parallax class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto text-center">
            <h1 class="title">Kollegiets Historie</h1>
            <h4>Noe tekst her</h4>
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
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
            <h3 class="title text-left">Prolog</h3>
            <p>I 1908 indviede industri- og videnskabsmanden Gustav Adolph Hagemann sit historiske kollegium på indre Østerbro under mottoet "Tien andre, vil selv du tienes." Hagemann benyttede derved en del af sin formue, der var indtjent gennem et langt liv, til at afhjælpe studerendes boligbehov.</p>
            <img alt="Raised Image" :src="historieBilde1" class="img-raised rounded center" />
            <br />
            <p>De studerendes boligforhold lå grundlæggeren meget på sinde. Han lod derfor dele af inventaret levere i sit eget hjem, så han kunne afprøve det, inden han lod kollegiet indrette med det. Således afprøvede han til eksempel forskellige sovesofaer, som alumnerne skulle sove i på deres værelser og spiste med det nikkelbestik, som han påtænkte at anvende ved måltiderne.</p>
            <br />
            <p>Da G. A. Hagemanns Kollegium blev indviet, var det et af de mest frisindede kollegier af sin tid, idet både mandlige og kvindelige studerende, som de første i Danmark, fik mulighed for at bo side om side på et kollegium. Udformningen af kollegiet og den daglige gang blev i høj grad præget af Hagemanns ideologi om fællesskabet som det centrale.</p>
            <br />
            <p>Anden Verdenskrig gik ikke hen over hovedet på alumnerne på G. A. Hagemanns Kollegium. Der er ikke megen tvivl om, at nogle af alumnerne deltog aktivt i modstandsbevægelsen, og i kollegiets indgangsparti hænger da også en mindeplade med navnene på de alumner som faldt i krigen. Kollegiet blev sågar i en periode brugt som lazaret for tyske krigsflygtninge, og det var først en gang i 1946, at alumnerne kunne flytte hjem igen til et normalt liv.</p>
            <br />
            <p>Optagelsesprøver var obligatoriske på kollegiet før i tiden. Man skulle igennem tre faser. For det første skulle man testes i sin paratviden om grundlæggeren, kollegiet og andre relevante forhold. Dernæst skulle man stjæle et skilt (derfor de mange skilte, som kollegiet har) og til slut skulle man udføre en opgave. En alumne skulle for eksempel løbe sækkevæddeløb ned ad strøget, en anden skulle holde en offentlig tale for ændernes ret til ikke at fryse om vinteren. Optagelsesprøverne praktiseres ikke længere på kollgiet, men G. A. Hagemanns Kollegium vedbliver at være et sted, hvor man ikke bare flytter ind.</p>
            <br>
            <p>Kollegiet er flere gange blevet renoveret, men altid med respekt for det arkitekturhistoriske udtryk. I nyere tid er kollegiet undergået en gennemgribende renovering, hvor stedet blandt andet fik flere værelser i stuen læsesal under taget samt TV-stue. Desværre havde støvet fra renoveringen knap lagt sig, før vandet fossede ind sommeren 2011. Kollegiet blev oversvømmet i hele underetagen, og det var ikke før til Gamle Alumners Fest i marts 2012 at kollegiet atter kunne slå dørene op til disse prægtige lokaler. </p>
            <br>
            <p>Men oversvømmelsen til trods lever Hagemanns ånd og hans tanker om kollegiet som et forpligtende fællesskab videre i bedste velgående. </p>
          </div>
        </div>
      </div>
    </div>
    <!--Læs mer om kollegiet seksjon-->
    <div class="section">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-12 md-small-size-100">
            <h2 class="title text-center">Læs mer om Kollegielivet</h2>
            <br />

            <div class="md-layout">
              <div class="md-layout-item md-size-33 md-small-size-100">
                <div class="md-card md-card-blog md-theme-default">
                  <div class="md-card-header md-card-header-image">
                    <img :src="madordningHeader" class="img" />
                  </div>
                  <div class="md-card-content">
                    <h6 class="card-category text-info">Kollegielivet</h6>
                    <h4 class="card-title">Madordning</h4>
                    <p
                      class="card-description"
                    >Læs om den fantastiske madordningen vi har her på kollegiet</p>
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
export default {
  components: {},
  bodyClass: "blog-post",
  props: {
    header: {
      type: String,
      default: require("@/assets/img/historie/header.jpg")
    },
    historieBilde1: {
      type: String,
      default: require("@/assets/img/historie/oldschoolFylla.jpg")
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


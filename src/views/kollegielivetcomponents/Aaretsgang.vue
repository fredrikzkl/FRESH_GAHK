<template>
  <div class="wrapper">
    <parallax class="section page-header header-filter" :style="headerStyle">
      <div class="container">
        <div class="md-layout">
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto text-center">
            <h1 class="title">Året på GAHK</h1>
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
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
            <!--<h3 class="title text-left">Skitur</h3>
            <p>I slutningen af januar plejer de skiglade at arrangere en skitur og flytte festerne og hverdagen ned til en uge i Frankrig.</p>
            -->

            <h3 class="title text-left">Forårskoncert</h3>
            <p>Ved forårets begyndelse optræder de kreative alumner med alt fra digte og taler til koncerter med sang, flygel og bands. Her er der også plads til gahkede indslag som gammel dagsborgsoplæsning og stand-up. 
</p>

            <h3 class="title text-left">NAF - Nye Alumners Fest</h3>
            <p>I marts/april måned arrangerer alle de nye alumner et kæmpe brag af en udsmyknings- og udklædningsfest for resten af beboere. Et tema bliver afsløret uger før, så beboerne har tid til at forberede kostumer. I løbet af dagen sker der forskellige temalege udenfor. Senere rykker aktiviteterne indenfor, hvor det rigtige tema bliver afsløret, og legene fortsætter på salene. Det hele slutter af med, at dørene åbnes til festsalen, hvor det helt rigtige tema bliver afsløret og der danses til langt ud på natten. 
</p>
            <h3 class="title text-left">Store Bededag og tovtrækning på Kastellet</h3>
            <p>Aftenen før St. Bededag mødes GAHK med arvefjenderne fra Nordisk Kollegium til tovtrækning på Kastellet. Efter NOKO'erne er nedlagt, spiser vi hveder sammen på et af vores kollegier, hvor vi prøver at feste fredsommeligt sammen</p>

            <!--Skovturen-->
            <h3 class="title text-left">Skovtur</h3>
            <p>Omkring G. A. Hagemanns fødselsdag den 16. maj tager alle alumner skovhatten på for at tilbringe en dag ud i det blå. Alumnerne vækkes med Gammel Dansk på sengen, og dagen byder blandt andet på besøg på Hagemanns gravsted og picnic på kastellet.
</p>
          </div>
          <div class="md-layout">
            <div class="md-layout-item md-size-50 md-small-size-100">
              <img alt="Raised Image" :src="skovtur1" class="img-raised rounded" />
            </div>
            <div class="md-layout-item md-size-50 md-small-size-100">
              <img alt="Raised Image" :src="skovtur2" class="img-raised rounded" />
            </div>
          </div>

          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
          
            <h3 class="title text-left">Hjemkomstfest</h3>
            <p>I begyndelsen af september samles alle alumner efter en lang sommer for at snakke om ferieminder og feste sammen. Dette sker først på salene med forskellige temaer, som holdes hemmeligt for de andre sale. Herefter inviteres alle rundt til de fem forskellige sales temaer og lege. 
</p>
            <h3 class="title text-left">Mathilden</h3>
            <p>Den måske mest traditionsrige begivenhed på GAHK er Mathilden – opkaldt efter G. A. Hagemanns hustru Mathilde Hagemann. Temaet er ’Galla’, og alle møder op i deres fineste puds til en pompøs aften med gallamiddag og Les Lanciers. Sidenhen åbnes dørene op for gæster.
</p>
            <img alt="Raised Image" :src="mathilden" class="img-raised rounded center" />
            <h3 class="title text-left">Juletid</h3>
            <p>Juletiden er ekstra hyggelig på kollegiet, fordi pigerne og drengene skiftes til at lave julekalender til hinanden samt at vække hinanden med et temapræget Lucia-optog om morgenen den 13. december.</p>
            <p>
              I december afholdes der naturligvis også julefrokost. Konceptet plejer at være helt traditionel julefrokost, hvor der er kræset for gode, gamle, danske retter, og der bliver tid til at finde juletræet frem samt en omgang "Nu det jul igen" rundt i hele bygningen.
            </p>
            <h3 class="title text-left">Nytårsaften</h3>
            <p>Året afsluttes med en storslået nytårsfest, hvor alumnerne og deres venner indbydes til middag. En fast tradition er, at alle prøver at lære at synge den russiske nationalsang, som vi efter middagen synger for vore genboer på den russiske ambassade, der til gengæld serverer vodka og skåler med os. Efter midnat kan man se fyrværkeri fra øverste sal med udsigt over København.</p>

            <h3 class="title text-left">Gamle Alumners Fest</h3>
            <p>Til GAF’en inviteres alle nuværende og gamle alumner. Det er en hyggelig aften med masser af gode historier og taler fra bestyrelsesformanden, nuværende alumner. Hvis man er heldig, er der også et par gamle alumner, der kan fortælle om kollegietiden under 2. verdenskrig eller dengang de i et syretrip i 70'erne malede 3. sal.</p>
            <h3 class="title text-left">Fastelavn</h3>
            <p>Der afholdes fastelavnsfest med meget fantasifulde kostumer og slå katten af tønden.</p>
          </div>
        </div>
      </div>
      <div class="section section-dark">
        <div class="container">
          <div class="md-layout">
            <div
              class="md-layout-item md-size-66 md-small-size-100 justify-content-center mx-auto text-center"
            >
              <h2 class="title">Begivenheder igennem hele året</h2>
            </div>
          </div>
          <div class="md-layout">
            <div class="md-layout-item md-size-40 md-small-size-100 ml-auto">
              <div class="md-card md-card-profile md-theme-default md-card-plain">
                <div class="md-card-header md-card-header-image">
                  <img :src="fodselsdag" class="img" />
                </div>

                <div class="md-card-content">
                  <h4 class="card-title">Fødselsdage</h4>
                  <p
                    class="card-description"
                  >GAHK er ens familie på godt og ondt og glemmer (stort set) aldrig en alumnes fødselsdag. Flagmesteren, der bor på det midterste værelse på 1. sal, hejser flaget på alle alumners fødselsdage, og fylgjen og/eller væsenet står som oftest for at arrangere morgenmad på sengen, i spisesalen til alles glæde eller lave kage om aftenen.</p>
                </div>
              </div>
            </div>
            <div class="md-layout-item md-size-40 md-small-size-100 ml-auto">
              <div class="md-card md-card-profile md-theme-default md-card-plain">
                <div class="md-card-header md-card-header-image">
                  <img :src="akweekend" class="img" />
                </div>

                <div class="md-card-content">
                  <h4 class="card-title">Aktivitetsweekender</h4>
                  <p
                    class="card-description"
                  >En del af kollegiets selvstyre består i, at alumnerne bidrager til bygningens vedligeholdelse. Cirka fire gange om året bliver der arrangeret aktivitetsweekend, hvor alumnerne trækker i arbejdstøjet for at male, slibe og udføre andre overkommelige opgaver. Nogle alumner sørger for ekstra god mad, og ofte er aktivitetsweekenderne faktisk ganske hyggelige.</p>
                </div>
              </div>
            </div>
            <div class="md-layout-item md-size-40 md-small-size-100 ml-auto">
              <div class="md-card md-card-profile md-theme-default md-card-plain">
                <div class="md-card-header md-card-header-image">
                  <img :src="fodbold" class="img" />
                </div>

                <div class="md-card-content">
                  <h4 class="card-title">Fodbold</h4>
                  <p
                    class="card-description"
                  >Her på GAHK har vi vores eget foldbold hold, og spiller en kamp om ugen.</p>
                </div>
              </div>
            </div>
            <div class="md-layout-item md-size-40 md-small-size-100 ml-auto">
              <div class="md-card md-card-profile md-theme-default md-card-plain">
                <div class="md-card-header md-card-header-image">
                  <img :src="fodselsdag" class="img" />
                </div>

                <div class="md-card-content">
                  <h4 class="card-title">Generalforsamlinger</h4>
                  <p
                    class="card-description"
                  >To gange om året afholdes der generalforsamling for kollegiets beboere - i marts og september. Generalforsamling oser af timelange taler og vedtagelse af ligegyldige paragraffer. Det er ikke tilfældet på GAHK! Her har generalforsamling mere karakter af et revylignende arrangement med god underholdning og garanti for masser af gratis øl. Absolut et must at deltage i som alumne.</p>
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


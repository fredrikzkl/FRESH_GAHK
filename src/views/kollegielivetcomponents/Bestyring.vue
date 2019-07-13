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
          <div class="md-layout-item md-size-66 md-small-size-100 mx-auto">
            <h3 class="title text-left">Skitur</h3>
            <p>I slutningen af januar plejer de skiglade at arrangere en skitur og flytte festerne og hverdagen ned til en uge i Frankrig.</p>
            <h3 class="title text-left">Fastelavn</h3>
            <p>I februar klæder alumnerne sig ud i mærkelige og kreative kostumer, og giver den gas til den lyse morgen.</p>
            <h3 class="title text-left">Gamle Alumners Fest</h3>
            <p>GAF'en er årets første fest, og her inviteres alle nuværende og gamle alumner. Det er en rigtig hyggelig aften med masser af gode historier og ofte taler fra bestyrelsesformanden, nuværende alumner og hvis man er heldig, er der også et par gamle alumner, der kan fortælle om kollegietiden under 2. verdenskrig eller dengang de i et syretrip i 70'erne malede 3. sal.</p>
            <h3 class="title text-left">Forårskoncert</h3>
            <p>Når blomsterne begynder at spirre, bliver klaveret støvet af og kreative sjæle optræder med at fra skønsang og klaverspil til digtoplæsning og gahkede indlsag.</p>

            <h3 class="title text-left">NAF - Nye Alumners Fest</h3>
            <p>I marts/april måned arrangerer alle de nye alumner et kæmpe brag af en udsmyknings- og udklædningsfest, der minder om en form for totalteater.. For eksempel var deltagerne et år ude at rejse, hvor de blev "vaccineret", fik mad i et kæmpestort papfly, der "styrtede ned" og landede i et arabisk land.</p>
            <h3 class="title text-left">Store Bededag og tovtrækning på Kastellet</h3>
            <p>Aftenen før St. Bededag mødes vi med arvefjenderne fra Nordisk Kollegium til tovtrækning på Kastellet. Efter vi har nedlagt NOKO'erne, spiser vi hveder sammen på deres eller vores kollegium, hvilket gerne udarter sig til en - større eller mindre - fest.</p>

            <!--Skovturen-->
            <h3 class="title text-left">Skovtur</h3>
            <p>Omkring den 16. maj, som er Hr. Hagemanns fødselsdag, river alle alumnerne en hverdag ud af kalenderen og holder fri fra eksamenslæsning til fordel for en dag ud i det blå. Alle alumner vækkes med Gammel Dansk på sengen, og dagen byder blandt andet på besøg på Hagemanns gravsted og senere picnic.</p>
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
            <h3 class="title text-left">Midsommerfest</h3>
            <p>I slutningen af juni afholdes midsommerfesten med velkomstdrinks og grillmad på terrassen, og derefter er der almindelig fest til den lyse morgen.</p>
            <h3 class="title text-left">Hjemkomstfest</h3>
            <p>I begyndelsen af september holdes fest kun for kollegiets beboere, hvor der rigtig kan hygges og snakkes efter en lang sommer, hvor mange alumner har været ude at rejse, ligesom der ofte er flyttet flere nye alumner ind i sommerens løb.</p>
            <h3 class="title text-left">Mathilden</h3>
            <p>I november er det så tid til gallafest, der er opkaldt efter G. A. Hagemanns hustru Mathilde Hagemann. Her møder pigerne op i fine kjoler, fyrene i smoking, og der serveres gallamiddag og danses Les Lanciers. Til denne fest er bestyrelsen altid indbudt, ligesom der dukker mange gamle alumner op</p>
            <img alt="Raised Image" :src="mathilden" class="img-raised rounded center" />
            <h3 class="title text-left">Juletid</h3>
            <p>De fleste alumner er hårdt hængt op af eksamener, julefrokoster og familiekomsammener i december. Men med ekstra kollegiehygge og julestemning kommer alle alumner godt igennem måneden. Pigerne og drengene skiftes til at lave julekalender til hinanden samt til at vække hinanden med Lucia-optog om morgenen den 13. december.</p>
            <p>I december afholdes der naturligvis også julefrokost. Konceptet plejer at være helt traditionel julefrokost, hvor der er kræset for gode, gamle, danske retter, og der bliver tid til at finde juletræet frem samt en omgang "Nu det jul igen" rundt i hele bygningen.</p>
            <h3 class="title text-left">Nytårsaften</h3>
            <p>Året afsluttes med en storslået nytårsfest, hvor alumnerne og deres venner indbydes til middag. En fast tradition er, at alle skal lære at synge den russiske nationalsang, og efter middagen synger vi den for vore genboer på den russiske ambassade, der gerne disker op med vodka og skåler med os. Efter midnat kan man se fyrværkeri fra læsesalen med fantastisk syn ud over København.</p>
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
                    <p class="card-description">Læs om den fantastiske madordningen vi har her på kollegiet</p>
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


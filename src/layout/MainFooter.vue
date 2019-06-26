<template>
  <footer
    class="footer"
    :class="{ [`footer-${type}`]: type }"
    :data-background-color="backgroundColor"
  >
    <div class="container">
      <nav>
        <ul>
          <li>
            <a href="">
              <i class="fas fa-map-marker"></i>
              Kristianiagade 10 - 2100 København Ø 
            </a>
          </li>
          <li>
            <a href="">
               <i class="fas fa-envelope"></i>
               Kontakt os
            </a>
          </li>
        </ul>
      </nav>
      <div>
        <!--For å ha content nederst til høyre i footeren-->
      </div>
    </div>
  </footer>
</template>
<script>
export default {
  props: {
    backgroundColor: String,
    type: String
  },
  data() {
    return {
      year: new Date().getFullYear()
    };
  }
};
</script>
<style></style>

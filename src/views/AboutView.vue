<template>
<div class="page-view">
  <header-comp />
  <about-me />
  <footer-comp />
  <desktop-footer-comp />
  </div>
</template>

<script>
import HeaderComp from "@/components/HeaderComp.vue";
import FooterComp from "@/components/FooterComp.vue";
import AboutMe from '@/components/AboutMe.vue';
import DesktopFooterComp from '@/components/DesktopFooterComp.vue';

export default {
  components: {
    HeaderComp,
    FooterComp,
    AboutMe,
    DesktopFooterComp
  },
};
</script>

<style>
#desktop-footer-comp {
  display: none;
}

#header-comp {
  height: 30svh;
}

#about-me {
  height: 60svh;
}

#footer-container {
  height: 10svh;
  position: fixed;
  bottom: 0;
}

@media (min-width: 429px) and (min-height: 927px) {
#about-me {
  height: 99%;
}
}
</style>

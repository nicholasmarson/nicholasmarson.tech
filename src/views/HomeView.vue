<template>
<div class="page-view">
  <header-comp/>
  <greeting />
  <footer-comp />
  <desktop-footer-comp />
</div>
 
</template>

<script>
// @ is an alias to /src
import HeaderComp from '@/components/HeaderComp.vue'
import Greeting from '@/components/Greeting.vue'
import FooterComp from '@/components/FooterComp.vue'
import DesktopFooterComp from '@/components/DesktopFooterComp.vue'

export default {
  name: 'HomeView',
  created() {
    let vh = window.innerHeight * 0.01;
    window.addEventListener('resize', () => {
      let vh = window.innerHeight * 0.01;
      document.documentElement.style.setProperty('--vh', `${vh}px`);
    })
  },
  components: {
    HeaderComp,
    Greeting,
    FooterComp,
    DesktopFooterComp
  }
}
</script>

<style>
#desktop-footer-comp {
  display: none;
}

#header-comp {
  height: 30svh;
}

#greeting-message {
  height: 60svh;
}

#footer-container {
  height: 10svh;
  position: fixed;
  bottom: 0;
}


@media (min-width: 429px) and (min-height: 927px) {
#greeting-message {
  height: 99%;
}
}
</style>

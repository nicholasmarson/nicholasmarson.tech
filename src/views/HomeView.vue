<template>
<div id="home-view">
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
  components: {
    HeaderComp,
    Greeting,
    FooterComp,
    DesktopFooterComp
  }
}
</script>

<style>
#home-view {
  height: 100vh;
  width: 100vw;
  display: flex;
  flex-direction: column;
}

#header-comp {
  height: 30%;
}

#greeting-message {
  height: 60%;
}

#footer-container {
  height: 10%;
}

#desktop-footer-comp {
  display: none;
}



@media (min-width: 429px) and (min-height: 927px) {
#home-view {
  height: 100vh;
}

#header-comp {
  height: 13%;
  margin: 0;
  padding: 0;
}

#picture-name-container {
  padding: 0;
  margin: 5px;
}

#greeting-message {
  height: 99%;
}

#portrait {
  height: 100px;
  margin: 5px;
}
}
</style>

<template>
<div>
  <router-view/>
</div>

</template>

<script>
import Navigation from './components/Navigation.vue'
import TitlePicture from './components/TitlePicture.vue';
import Header from './components/HeaderComp.vue';

export default {
  components: {
    Navigation,
    TitlePicture,
    Header
  }
}
</script>

<style>
@import url('https://fonts.googleapis.com/css?family=Inclusive+Sans:wght@300;400&display=swap');

#app {
  font-family: Inclusive Sans, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  width: 100vw;
  height: -webkit-fill-available;
}

html {
  height: -webkit-fill-available;
}

body {
  width: 100%;
  margin: 0;
  padding: 0;
  overflow: hidden;
  scroll-behavior: smooth;
  min-height: 100vh;
  min-height: -webkit-fill-available;
}

.router-link-active {
  margin: 0;
  padding: 0;
}

.router-link-exact-active {
  margin: 0;
  padding: 0;
}
</style>

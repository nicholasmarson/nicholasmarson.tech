<template>
  <div>
    <router-view />
  </div>
</template>

<script>
import Navigation from "./components/Navigation.vue";
import TitlePicture from "./components/TitlePicture.vue";
import Header from "./components/HeaderComp.vue";

export default {
  components: {
    Navigation,
    TitlePicture,
    Header,
  },
};
</script>

<style>
@import url("https://fonts.googleapis.com/css?family=Inclusive+Sans:wght@300;400&display=swap");

#app {
  font-family: Inclusive Sans, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  width: 100vw;
  height: 100svh;
}

html {
  height: 100svh;
}

body {
  display: flex;
  flex-direction: column;
  width: 100%;
  margin: 0;
  padding: 0;
  overflow: hidden;
  scroll-behavior: smooth;
  min-height: 100svh;
  flex: 1;
}

.router-link-active {
  margin: 0;
  padding: 0;
}

.router-link-exact-active {
  margin: 0;
  padding: 0;
}

.page-view {
  height: 100svh;
  width: 100vw;
  display: flex;
  flex-direction: column;
}

.mobile-header {
  height: 30dvh;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: #60caff;
  background: linear-gradient(to bottom, #3498db, #2980b9);
  border-bottom: 2px;
  border-bottom-style: groove;
  padding-top: 10px;
  padding-bottom: 20px;
  flex: 1;

}

.mobile-footer {
  height: 10dvh;
  position: fixed;
  bottom: 0;
  width: 100%;
  background-color: #31b8fc;
  background: linear-gradient(to bottom, #3498db, #2980b9);
  border-top: 2px;
  border-top-style: solid;
  border-top-color: black;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0;
  padding: 0;
  position: relative;
  height: 10vh;
}

.main-content {
  height: 60dvh;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  overflow: auto;
  padding: 0;
  margin: 0;
  background: repeating-linear-gradient(to bottom, #edf6fc, #d6eeff);
}

.button {
  width: 78%;
  font-family: Inclusive Sans, Helvetica, Arial, sans-serif;
  background-color: #46aadc;
  padding: 10px;
  margin-bottom: 10px;
}
</style>

<template>
  <div class="mobile-header">
    <title-picture name="Nicholas Marson" />
    {{ name }}
    <navigation id="nav-area" />

    <nav>
      <ul>
        <li>
          <router-link v-bind:to="{ name: 'home' }">
            <img src="../assets/icons8-home-50.png" id="home" />
            <p class="icon-text">Welcome</p>
          </router-link>
        </li>
        <li>
          <router-link v-bind:to="{ name: 'about' }">
            <img src="../assets/icons8-about-me-50(2).png" id="marker" />
            <p class="icon-text">About Me</p>
          </router-link>
        </li>
        <li>
          <a @click="openPDF" style="cursor: pointer">
            <img src="../assets/icons8-export-pdf-50.png" id="trophy" />
            <p class="icon-text">Resume</p>
          </a>
        </li>
      </ul>
    </nav>
  </div>
</template>

<script>
import Navigation from "./Navigation.vue";
import TitlePicture from "./TitlePicture.vue";
import resumePDF from "@/assets/Nicholas Marson Resume.pdf";

export default {
  props: {
    name: String,
  },
  components: {
    TitlePicture,
    Navigation,
  },
  methods: {
    openPDF() {
      const pdfWindow = window.open(resumePDF, "_blank");
      if (pdfWindow) {
        pdfWindow.focus();
      } else {
        alert("Please allow pop-ups for this website to view the PDF.");
      }
    },
  },
};
</script>

<style scoped>
nav {
  display: none;
}

#nav-area {
  display: none;
}

@media (min-width: 429px) and (min-height: 927px) {
  #header-comp {
    display: flex;
    padding: 0;
  }

  img {
    width: 40px;
    height: auto;
  }

  img:hover {
    cursor: pointer;
  }

  nav {
    display: flex;
    justify-content: flex-end;
    align-items: flex-end;
    padding-left: 50px;
    padding-top: 5px;
  }

  nav ul {
    display: flex;
    justify-content: flex-end;
    align-items: flex-end;
    list-style: none;
    padding: 0;
    width: 50vw;
    overflow: hidden;
    margin: 0;
  }

  nav ul li {
    text-align: center;
    padding: 5%;
  }

  a {
    text-decoration: none;
  }

  .icon-text {
    text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.5);
    font-size: 12px;
    margin: 1px;
    color: black;
    text-decoration: none;
  }

  .router-link-exact-active {
    text-decoration: underline;
    margin: 0;
    padding: 0;
  }
}
</style>
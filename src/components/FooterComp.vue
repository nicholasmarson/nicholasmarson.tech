<template>
  <div id="footer-container">
    <nav id="nav-bar">
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
        <li>
          <a
            id="menu-link"
            @click="toggleDropdown"
            style="cursor: pointer"
          >
            <img src="../assets/icons8-menu-50(3).png" id="menu" />
            <p class="icon-text">More</p>
            <ul v-if="isDropdownOpen" class="dropdown-menu">
                <li class="dropdown-option">
                  <a href="https://www.linkedin.com/in/nicholasmarson/" class="dropdown-option">LinkedIn</a>
                </li>
                <li class="dropdown-option">
                  <a href="https://github.com/nicholasmarson" class="dropdown-option">Github</a>
                </li>
                <li class="dropdown-option">
                  <a href="https://github.com/nicholasmarson/nicholas-marson-resume" class="dropdown-option">Source Code</a>
                </li>
            </ul>
          </a>
        </li>
      </ul>
    </nav>
  </div>
</template>

<script>
import resumePDF from "@/assets/Nicholas Marson Resume.pdf";

export default {
  name: "footer-comp",
  data() {
    return {
      isDropdownOpen: false,
    };
  },
  methods: {
    toggleDropdown() {
      this.isDropdownOpen = !this.isDropdownOpen;
    },
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
img {
  width: 40px;
  height: auto;
  padding: 0;
  margin: 0;
}

img:hover {
  cursor: pointer;
}

#footer-container {
  width: 100%;
  background-color: #31b8fc;
  background: linear-gradient(to bottom, #3498db, #2980b9);
  border-top: 2px;
  border-top-style: solid;
  border-top-color: black;
  display: flex;
  justify-content: center;
  align-items: center;
  margin: 0%;
  padding: 0%;
  position: relative;
  height: 10vh;
}

nav {
  height: 100%;
  width: 100%;
}

nav ul {
  list-style: none;
  padding: 0;
  display: flex;
  justify-content: center;
  align-items: center;
  width: 100vw;
  overflow: hidden;
}

nav ul li {
  text-align: center;
  flex: 1;
}

.icon-text {
  text-decoration: none;
  color: black;
  padding: 0;
  margin: 0;
  font-size: 8px;
}

a {
  text-decoration: none;
}

.router-link-exact-active {
  text-decoration: underline;
  margin: 0;
  padding: 0;
}

.dropdown-menu {
  display: flex;
  flex-direction: column;
  list-style: none;
  padding: 0;
  margin: 0;
  position: absolute;
  background-color: #2980b9;
  background: linear-gradient(to bottom, #31b8fc, #2980b9);
  box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
  left: 0;
  right: 0;
  bottom: 100%;
  border-bottom: 2px;
  border-bottom-style: solid;
  border-bottom-color: #000000;
}

.dropdown-option {
  padding: 10px;
  cursor: pointer;
}

.dropdown-option:hover {
  background-color: #f0f0f0;
  width: 100%;
}

.dropdown-option a {
  text-decoration: none;
  color: #000000;
  font-weight: normal;
}

.dropdown-option a:hover {
  color: #555;
  background-color: #f0f0f0;
}

@media (min-width: 429px) and (min-height: 927px) {
#footer-container {
  display: none;
}
}
</style>
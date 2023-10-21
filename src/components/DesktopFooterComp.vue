<template>
  <div id="desktop-footer-comp">
    <ul>
      <li>
        <a
          href="https://www.linkedin.com/in/nicholasmarson/"
          class="dropdown-option"
          >LinkedIn</a
        >
      </li>
      <li>
        <a href="https://github.com/nicholasmarson" class="dropdown-option"
          >Github</a
        >
      </li>
      <li>
        <a
          href="https://github.com/nicholasmarson/nicholas-marson-resume"
          class="dropdown-option"
          >Source Code</a
        >
      </li>
    </ul>
  </div>
</template>

<script>
export default {

};
</script>

<style scoped>
@media (min-width: 429px) and (min-height: 927px) {
ul {
  list-style: none;
  padding: 0;
  display: flex;
  justify-content: space-around;
  align-items: center;
  width: 100vw;
  overflow: hidden;
}

#desktop-footer-comp {
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

a {
    font-family: Inclusive Sans, Helvetica, Arial, sans-serif;
    color: black;
}
}

</style>
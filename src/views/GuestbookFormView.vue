<template>
  <div class="page-view">
    <header-comp />
    <guestbook-form />
    <footer-comp />
  </div>
</template>

<script>
import FooterComp from "../components/FooterComp.vue";
import HeaderComp from "../components/HeaderComp.vue";
import GuestbookForm from "../components/GuestbookForm.vue";

export default {
  name: "GuestbookView",
  components: {
    FooterComp,
    HeaderComp,
    GuestbookForm,
  }
 }
</script>

<style>
#header-comp {
  height: 30svh;
}

#guestbook-form-comp {
  height: 60svh;
}

#footer-container {
  height: 10svh;
  position: fixed;
  bottom: 0;
}
</style>
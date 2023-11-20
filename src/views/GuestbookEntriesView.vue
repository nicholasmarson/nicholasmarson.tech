<template>
    <div class="page-view">
        <header-comp class="mobile-header"/>
        <guestbook-entries class="main-content"/>
        <footer-comp class="mobile-footer"/>
    </div>
</template>

<script>
import GuestbookEntries from '../components/GuestbookEntries.vue'
import FooterComp from "../components/FooterComp.vue";
import HeaderComp from "../components/HeaderComp.vue";

export default {
  components: { 
    GuestbookEntries,
    FooterComp,
    HeaderComp,
 },

}
</script>

<style>
</style>
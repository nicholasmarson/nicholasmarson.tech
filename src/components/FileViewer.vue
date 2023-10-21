<template>
  <div>
    <button @click="openPDF">Open Resume</button>
  </div>
</template>

<script>
import resumePDF from "@/assets/Nicholas Marson Resume.pdf";

export default {
  name: "Resume",
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

<style>

</style>
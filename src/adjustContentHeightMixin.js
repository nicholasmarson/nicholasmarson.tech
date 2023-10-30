export default {
    mounted() {
      this.adjustContentHeight();
      window.addEventListener('resize', this.adjustContentHeight);
      window.addEventListener('load', this.adjustContentHeight);
    },
    beforeUnmount() {
      window.removeEventListener('resize', this.adjustContentHeight);
      window.removeEventListener('load', this.adjustContentHeight);
    },
    methods: {
      adjustContentHeight() {
        const windowHeight = window.innerHeight;
        const footerHeight = document.getElementById('footer-container').offsetHeight;
        this.$el.style.minHeight = (windowHeight - footerHeight) + 'px';
      },
    },
  };
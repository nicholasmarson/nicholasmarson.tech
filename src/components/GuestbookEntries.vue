<template>
    <div>
      <div class="entry" v-for="entry in entries" :key="entry.id">
        <span id="name">{{ entry.name }} | {{ formatDate(entry.date) }}</span>
        <br />
        <span id="message">{{ entry.message }}</span>
        <br />
        
      </div>
      <button class="button">
        <router-link class="button" v-bind:to="{ name: 'guestbookform' }"
          >View Guestbook Form</router-link
        >
      </button>
    </div>
</template>

<script>
import GuestbookService from "../services/GuestbookService";
export default {
  name: "ViewGuestBookEntries",
  data() {
    return {
      entries: [],
    }
  },
  methods: {
    formatDate(date) {
      const options = { year: "numeric", month: "long", day: "numeric" };
      return new Date(date).toLocaleDateString(undefined, options);
    },
  },
  created() {
    GuestbookService.getGuestbookEntries().then((response) => {
      this.entries = response.data;
    });
  }
};
</script>

<style scoped>

.main-content {
  height: 100vh; /* Set the height to 100% of the viewport height */
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: flex-start; /* Align entries at the top of the container */
  overflow-y: auto; /* Add a scrollbar if the content exceeds the viewport height */
}

.entry {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  border: 1px solid black;
  width: 100%; /* Set to 100% of the parent container width */
  margin-bottom: 10px; /* Add margin between entries */
  word-wrap: break-word;
  white-space: pre-line;
  padding: 20px; /* Add padding inside the entry block */
  box-sizing: border-box; /* Include padding and border in the total width and height */
}

#name {
    font-weight: bold;
    font-size: 1.25em;
    margin-bottom: 1px;
}

#message {
    margin-bottom: 1px;
    word-wrap: break-word;
    white-space: pre-line;
}

</style>
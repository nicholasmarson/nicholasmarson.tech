<template>
    <div>
      <div class="entry" v-for="entry in entries" :key="entry.id">
        <span id="name">{{ entry.name }} | {{ entry.date }}</span>
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
export default {
  name: "ViewGuestBookEntries",
  data() {
    return {
      entries: [
        {
          id: 1,
          name: "Nicholas Marson",
          message: "This is a test message.",
          date: "2021-01-01",
        },
        {
          id: 2,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
        {
          id: 3,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
        {
          id: 4,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
        {
          id: 5,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
        {
          id: 6,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
        {
          id: 7,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
        {
          id: 8,
          name: "Nicholas Marson",
          message: "This is a test message",
          date: "2021-01-01",
        },
      ],
    };
  },
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
}

#name {
    font-weight: bold;
    font-size: 1.5em;
    margin-bottom: 1px;
}

#message {
    margin-bottom: 1px;
    word-wrap: break-word;
    white-space: pre-line;
}

</style>
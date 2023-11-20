<template>
  <form class="main-content" id="guestbook-form-comp">
    <h2>If you're reading this, sign the guestbook!</h2>

    <label for="name">Name: </label>
    <input type="text" id="name" v-model="name" />

    <label for="message">Message: </label>
    <textarea id="message" v-model="message"></textarea>

    <label for="date">Date: </label>
    <input type="date" id="date" v-model="date" />

    <div id="guestbook-nav">
    <button class="button" @click.prevent="submitEntry">Submit</button>
    <button class="button">
    <router-link v-bind:to="{ name: 'guestbookentries' }">View Guestbook Entries</router-link>
    </button>
  </div> 

  </form>
</template>

<script>
export default {
  name: "GuestbookForm",

  data() {
    return {
      name: "",
      message: "",
      date: "",
    };
  },
  methods: {
    submitEntry() {
      const guestBookEntry = {
        name: this.name,
        message: this.message,
        date: this.date,
      };
    },
  },
};
</script>

<style>
#guestbook-form-comp input {
  width: 75%;
  margin-bottom: 20px;
  font-family: Inclusive Sans, Helvetica, Arial, sans-serif;
}

#guestbook-form-comp textarea {
  width: 75%;
  height: 100px;
  margin-bottom: 20px;
}

#guestbook-nav {
  display: flex;
  flex-direction: row;
  justify-content: space-between;
  width: 75%;
}
</style>
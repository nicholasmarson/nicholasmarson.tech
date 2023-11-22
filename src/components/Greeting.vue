<template>
<div id="greeting-message">
    <p id="greeting-message-text" style="white-space: pre-line;">{{ greetingMessage }}</p>
</div>
</template>

<script>
export default {
    name: "greeting",
    data() {
        return {
            greetingMessage: 
            `Hello! Welcome to my portfolio.

            This is an ever-growing project and it's purpose is to display and put to practice my development skills. It will be constantly worked on so the state it's in will vary.
            
            This is a Vue.js 3 project. I have just finished the desktop/mobile reactivity, and finally deployed!
            
            I am currently working on a guestbook component that will store form submissions in a database.
            
            I hope you enjoy!`
        }
    }
}
</script>

<style>
#greeting-message {
    background: repeating-linear-gradient(to bottom, #edf6fc, #d6eeff);
    font-size: 24px;
    padding: 10px;
    overflow: auto;
    height: 99%;
}

#greeting-message-text {
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 5px;
    overflow: auto;
}
</style>
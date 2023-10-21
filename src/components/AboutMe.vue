<template>
  <div id="about-me">
    <p id="about-me-text" style="white-space: pre-line;">{{ aboutMe }}</p> 
    <!-- style to make consecutive space only one space -->
  </div>

</template>

<script>
export default {
    name: "aboutMe",
    data() {
        return {
            aboutMe:
            `As an aspiring Full Stack Software Developer currently pursuing education in the dynamic world of software development, I am actively honing my skills in Spring Boot, Java, C#, .NET, PostgreSQL, HTML, CSS, JavaScript, Vue.js, and responsive design. Embracing the challenges of this field, I am passionate about learning and committed to becoming proficient in these technologies to craft remarkable applications and systems.

            Beyond my technical pursuits, my 10 year background in fine-dining has instilled in me a strong sense of attention to detail and dedication to customer satisfaction. These qualities seamlessly transition into my coding projects, where I prioritize user experiences and strive to deliver interfaces that are both functional and aesthetically pleasing.

            Drawing inspiration from my 20 years as a multi-instrument musician and my experience in various successful bands throughout my life I approach coding challenges with a creative mindset, exploring innovative solutions and thinking outside the box. Additionally, my adaptability and collaborative spirit make me an effective team player, eager to learn from and contribute to diverse teams in the tech industry.

            As I continue my educational journey in software development, I look forward to leveraging my diverse skill set to drive innovation, exceed expectations, and make meaningful contributions to the ever-evolving world of technology. I am excited to embark on this fulfilling career path and embrace every opportunity to grow and excel in this dynamic field.`
            
        }
    }
}
</script>

<style>
#about-me {
    background: repeating-linear-gradient(to bottom, #edf6fc, #d6eeff);
    font-size: 24px;
    padding: 10px;
    overflow: auto;
}

#about-me-text {
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 5px;
    overflow: auto;
}
</style>
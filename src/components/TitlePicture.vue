<template>
  <div id="picture-name-container">
    <img id="portrait" src="@/images/IMG_4011.jpeg" alt="Picture of me"/>
    <p id="my-name">{{ name }} </p>
  </div>
</template>

<script>
export default {
  props: {
    name: String
  }
  
}
</script>

<style>
#picture-name-container {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
  padding-top: 25px;
}

#title-area {
  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}

#portrait {
  display: flex;
  flex: 1;
  border: 4px;
  border-style: solid;
  border-radius: 50%;
  border-color: rgb(0, 0, 0);
  box-shadow: 2px 2px 5px rgba(0, 0, 0, 0.5);
  height: auto;
  width: 190px;
  margin-top: 15px;
}

#my-name {
  text-shadow: 1px 1px 2px rgba(0, 0, 0, 0.5);
  font-size: 30px;
  margin: 5px;
  color: black;
  text-decoration: underline;
  padding-top: 10px;
  margin-bottom: 26px;
}

@media (min-width: 429px) and (min-height: 927px) {
#picture-name-container {
  display: flex;
  flex-direction: row;
  align-items: flex-end;
}

#portrait {
  width: 100%;
  height: auto;
}

#my-name {
  font-size: 14px;
  margin-left: 20px;
}
}

</style>
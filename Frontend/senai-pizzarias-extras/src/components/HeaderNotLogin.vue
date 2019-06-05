<template>
  <div>
      <header>
      <h1> {{ title }} </h1>
      </header>
  </div>
</template>

<script>

export default {
    data () {
    return {
        title: 'Já Vue essas Pizzarias?'

    }
  }
}
</script>

<style scoped>
header {
    background-color: green;
    padding: 10px;
}
h1 {
    color: blue;
    text-align: center;
}
</style>

<template>
  <div>
      <footer>
      <p> {{ author }} </p>
      </footer>
  </div>
</template>

<script>



export default {
    data () {
    return { 
        author: 'Desenvolvido por Artur como exercício extra do Senai'

    }
  }
}
</script>

<style scoped>
footer {
    background-color: black;
    padding: 6px;
}
p {
    color: orange;
    text-align: center;
}

</style>

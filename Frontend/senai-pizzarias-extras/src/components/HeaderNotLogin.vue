<template>
  <div>
      
      <nav>
        <ul>
            <li><router-link to="/" exact> Home </router-link></li>
            <li><router-link to="/Login" exact><button> Entrar </button></router-link></li>
            <li> {{ title }} </li>
        </ul> 
      </nav>

      
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
ul {
    list-style-type: none;
    text-align: center;
    margin: 0;
}
li {
    display: inline-block;
    margin: 0 10px;
    color: royalblue;
}
a {
    color: #fff;
    text-decoration: none;
    padding: 6px 8px;
    border-radius: 10px;
}

nav {
    background-color: black;
    padding: 14px;
    margin-bottom: 40px;
}



</style>

<template>
  <div id="show-blogs">
      <h2> Listagem das Pizzarias Cadastradas no sistema FS </h2>


<div v-for="pizz in pizzs" v-bind="pizz" v-bind:key="pizz.id" class="single-blog">
   <!-- <router-link v-bind:to="'/Listar/' + pizz.id"> -->
     <h2 v-rainbow> {{ pizz.title | to-uppercase }} </h2>
      <!-- </router-link> -->
         <article> {{ pizz.body }} </article>
         <!-- <p> {{ pizz.nome }} </p> -->
         <!-- <p> {{ pizz.isvegan }} </p> -->
         <!-- <p> {{ pizz.categoria }} </p> -->
         <!-- <p> {{ pizz.endereco }} </p> -->
         <!-- <p> {{ pizz.telefoneComercial }} </p> -->

       </div>

  </div>
</template>

<script>

export default {
    data () {
    return {
      pizzs: []
    }
  },
  methods: {

  },
  created() {
    this.$http.get('https://jsonplaceholder.typicode.com/posts')
    // https://jsonplaceholder.typicode.com/posts
    // http://localhost:5000/api/Pizzarias
    // https://pronto-para-conectar.firebaseio.com/posts.json
    .then(function(data){
      return data.json();
    }).then(function(data){
      let pizzsArray = [];
      for (let key in data){
        data[key].id = key
        pizzsArray.push(data[key]);
      };
      this.pizzs = pizzsArray;
    })
  },
  computed: {

  },
  filters: {
    'to-uppercase': function(value){
      return value.toUpperCase();
    }
  },
  directives: {
    'rainbow': {
      bind(el, binding, vnode){
        el.style.color = '#' + Math.random().toString(16).slice(2, 8);
      }
    }
  }
}
</script>

<style>
#show-blogs{
    max-width: 800px;
    margin: 0 auto;
}
.single-blog{
  padding: 20px;
  margin: 20px 0;
  box-sizing: border-box;
  background: #eee;
}

</style>

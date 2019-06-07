<template>
  <div id="show-blogs">
      <h2>Listar</h2>
      <div v-for="blog in blogs" v-bind:key="blog.id" class="single-blog">
        <router-link v-bind:to="'/Listar/'" + blog.id><h2 v-rainbow> {{ blog.title | to-uppercase }} </h2></router-link>
        <article> {{ blog.body }} </article>
      </div>
  </div>
</template>

<script>

export default {
    data () {
    return {
      blogs: [
        
      ]

    }
  },
  methods: {

  },
  created() {
    this.$http.get('https://jsonplaceholder.typicode.com/posts')
    // https://jsonplaceholder.typicode.com/posts
    // http://localhost:5000/api/Pizzarias
    .then(function(data){
      console.log(data);
      data.body.slice(0,10);
    })
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

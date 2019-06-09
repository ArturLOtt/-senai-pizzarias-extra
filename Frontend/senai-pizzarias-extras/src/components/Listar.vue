<template>
  <div id="show-blogs">
      <h2>Listar</h2>


<div v-for="blog in blogs" v-bind="blog" v-bind:key="blog.id" class="single-blog">
   <!-- <router-link> -->
     <h2> {{ blog.title | to-uppercase }} </h2>
      <!-- </router-link> -->
         <article> </article>
       </div>






  </div>
</template>

<script>

export default {
    data () {
    return {
      blogs: []
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
      let blogsArray = [];
      for (let key in data){
        data[key].id = key
        blogsArray.push(data[key]);
      };
      this.blogs = blogsArray;
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

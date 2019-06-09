<template>
    <div id="single-blog">
        <h1> {{ pizz.title }} </h1>
        <!-- <article> {{ pizz.content }} </article> -->
        <article> {{ pizz.body }} </article>
        <!-- <p> Author: {{ pizz.Author }} </p> -->
        <ul>
          <!-- <li v-for="category in pizz.categories"> {{ category }} </li> -->
        </ul>
    </div>
</template>

<script>
export default {
    data() {
        return{
            id: this.$route.params.id,
            pizz: {}
        }
    },
    created() {
        this.$http.get('https://jsonplaceholder.typicode.com/posts' + this.id + '.json')
        // https://jsonplaceholder.typicode.com/posts
        // https://pronto-para-conectar.firebaseio.com/posts/
        .then(function(data){
            return data.json();
        }).then(function(data){
          this.pizz = data;
        });
    }
}
</script>

<style scoped>
#single-blog{
     max-width: 960px;
     margin: 0 auto;
}
</style>

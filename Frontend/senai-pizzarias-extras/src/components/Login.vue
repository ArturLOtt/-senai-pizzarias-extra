<template>
  <div>
 <h2>Login</h2>



<div id="login">
    <h2>Efetue seu login!</h2>
    <form>
        <input type="text" placeholder="email" v-model="blog.name"><br>
        <input type="password" placeholder="Password" v-model="blog.pass"><br>
        <button v-on:click="entrar">Entrar</button>
    </form>
</div>


  </div>
</template>

<script>



export default {
    data () {
      return {
        blog: {
          name: '',
          pass: ''
        }
      }
    },
    methods: {

      entrar: function(){

      // if (this.blog.name == 'gandolf' & this.blog.pass == '132') {

      // }
      }

    }

}
</script>

<style>

</style>

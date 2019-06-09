<template>
  <div>
 <h2>Login</h2>



<div id="login">
    <h2>Efetue seu login!</h2>
    <form>
        <input type="text" placeholder="email" v-model="pizz.name"><br>
        <input type="password" placeholder="Password" v-model="pizz.pass"><br>
        <button v-on:click="entrar">Entrar</button>
    </form>
</div>


  </div>
</template>

<script>



export default {
    data () {
      return {
        pizz: {
          name: '',
          pass: ''
        }
      }
    },
    methods: {

      entrar: function(){

      // if (this.pizz.name == 'gandolf' & this.pizz.pass == '132') {

      // }
      }

    }

}
</script>

<style>

</style>

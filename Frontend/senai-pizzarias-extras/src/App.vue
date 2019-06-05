<template>
  <div>

    <app-header></app-header>
    <h1>Hey Ninja style</h1>
    <app-listagem></app-listagem>
    <app-footer></app-footer>

  </div>
</template>

<script>
// import { Listar } from "./components/Listar.vue";
import Header from './components/HeaderNotLogin.vue';
import Listar from './components/Listar.vue';
import Footer from './components/Footer.vue';


export default {
components: {
  'app-header': Header,
  'app-listagem': Listar,
  'app-footer': Footer
},
    data () {
    return {

    }
  }
}
</script>

<style>

</style>

<template>
  <div>
    <app-header></app-header>
    <router-view></router-view>
    <app-footer></app-footer>

  </div>
</template>

<script>

// import HeaderYes from './components/HeaderLogin.vue';
import HeaderNot from './components/HeaderNotLogin.vue';
import Listar from './components/Listar.vue';
import Footer from './components/Footer.vue';


export default {
components: {
  // 'app-header': HeaderYes,
  'app-header': HeaderNot,
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

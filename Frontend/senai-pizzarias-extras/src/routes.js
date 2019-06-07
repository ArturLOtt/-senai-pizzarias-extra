import Listar from './components/Listar.vue';
import Login from './components/Login.vue';
import Cadastrar from './components/Cadastrar.vue';

export default [
    { path: '/', component: Listar},
    { path: '/cadastrar', component: Cadastrar},
    { path: '/login', component: Login}
]
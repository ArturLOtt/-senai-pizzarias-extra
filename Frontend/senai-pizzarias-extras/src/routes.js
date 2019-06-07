import Listar from './components/Listar.vue';
import Login from './components/Login.vue';
import Cadastrar from './components/Cadastrar.vue';
import UmItemListar from './components/UmItemListar.vue';

export default [
    { path: '/', component: Listar},
    { path: '/cadastrar', component: Cadastrar},
    { path: '/login', component: Login},
    { path: '/Listar/:id', component: UmItemListar}
]
import Listar from './components/Listar.vue';
import Login from './components/Login.vue';
import Cadastrar from './components/Cadastrar.vue';
import UmItemListar from './components/UmItemListar.vue';
import NotFound from './components/NotFound.vue';


export default [
    { path: '/', component: Listar},
    { path: '/cadastrar', component: Cadastrar},
    { path: '/login', component: Login},
    { path: '/listar/:id', component: UmItemListar},
    { path: '*', component: NotFound}
]

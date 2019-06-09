<template>
  <div>



<h2> Cadastro de Pizzaria </h2>
    <div>
        <form>
            <input>  Informe o nome da Pizzaria
            <input type="checkbox">  Informe se contém Opção Vegana
            <input> Informe a Classificação dos preços
            <input> Informe oEndereço
            <input> Informe seu telefone comercial
            <button> Enviar nova pizzaria </button>
        </form>
    </div>

<hr>

<h2>Cadastro de usuario</h2>
    <div>
        <form>
            <input>  Informe o email
            <input> Informe a senha
            <button> Cadastrar Novo Usuario </button>
        </form>
    </div>



<hr>

<h2>Exemplo funcional que eu estava usando no firebase</h2>

<div id="add-blog">
        <h2>Add a New Blog Post</h2>
        <form v-if="!submitted">
            <label>Blog Title:</label>
            <input type="text" v-model.lazy="blog.title" required />
            <label>Blog Content:</label>
            <textarea v-model.lazy.trim="blog.content"></textarea>
            <div id="checkboxes">
                <p>Blog Categories:</p>
                <label>Ninjas</label>
                <input type="checkbox" value="ninjas" v-model="blog.categories" />
                <label>Wizards</label>
                <input type="checkbox" value="wizards" v-model="blog.categories" />
                <label>Mario</label>
                <input type="checkbox" value="mario" v-model="blog.categories" />
                <label>Cheese</label>
                <input type="checkbox" value="cheese" v-model="blog.categories" />
            </div>
            <label>Author:</label>
            <select v-model="blog.author">
                <option v-for="author in authors" v-bind:key="author.id">{{ author }}</option>
            </select>
            <hr />
            <button v-on:click.prevent="post">Add Blog</button>
        </form>
        <div v-if="submitted">
            <h3>Thanks for adding your post</h3>
        </div>
    </div>


  </div>
</template>

<script>



export default {
    data () {
    return {
            blog: {
                title: '',
                content: '',
                categories: [],
                author: ''
            },
            authors: ['1st', '2nd', '3rd'],
            submitted: false,
            pizz: {
              nome: '',
              isvegan: false,
              categoria: '',
              endereco: '',
              telefoneComercial: ''
            }
        }
    },
    methods: {
        post: function(){
            this.$http.post('https://pronto-para-conectar.firebaseio.com/posts.json',
            //  this.blog).then(function(data){
             this.pizz).then(function(data){
                console.log(data);
                this.submitted = true;
            });
        }
    }
}
</script>

<style>
#add-blog *{
    box-sizing: border-box;
}
#add-blog{
    margin: 20px auto;
    max-width: 500px;
}
label{
    display: block;
    margin: 20px 0 10px;
}
input[type="text"], textarea{
    display: block;
    width: 100%;
    padding: 8px;
}
#preview{
    padding: 10px 20px;
    border: 1px dotted #ccc;
    margin: 30px 0;
}
h3{
    margin-top: 10px;
}
#checkboxes input{
    display: inline-block;
    margin-right: 10px;
}
#checkboxes label{
    display: inline-block;
    margin-top: 0;
}
</style>

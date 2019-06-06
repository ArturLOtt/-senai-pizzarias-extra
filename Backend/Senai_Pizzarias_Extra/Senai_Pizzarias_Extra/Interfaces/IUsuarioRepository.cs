using Senai_Pizzarias_Extra.Domains;
using Senai_Pizzarias_Extra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Pizzarias_Extra.Interfaces
{
    interface IUsuarioRepository
    {

        Usuario BuscarPorEmailESenha(LoginViewModel login);

        void Cadastrar(Usuario usuario);
        
    }
}

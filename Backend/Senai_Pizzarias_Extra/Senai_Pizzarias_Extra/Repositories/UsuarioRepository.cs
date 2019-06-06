using Senai_Pizzarias_Extra.Domains;
using Senai_Pizzarias_Extra.Interfaces;
using Senai_Pizzarias_Extra.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Pizzarias_Extra.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        
        SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext();
        
        public Usuario BuscarPorEmailESenha(LoginViewModel login)
        {
            using (SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext())
            {
                return ctx.Usuario.FirstOrDefault(u => u.Email == login.Email && u.Senha == login.Senha);
            }
        }

        public void Cadastrar(Usuario usuario)
        {
            using (SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext())
            {
                ctx.Usuario.Add(usuario);
                ctx.SaveChanges();
            }
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Senai_Pizzarias_Extra.Domains;
using Senai_Pizzarias_Extra.Interfaces;
using Senai_Pizzarias_Extra.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_Pizzarias_Extra.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepository usuarioRepository { get; set; }

        public UsuarioController() => usuarioRepository = new UsuarioRepository();

        //[Authorize(Roles = "3")]
        [HttpPost]
        public IActionResult Post(Usuario usuario)
        {
            try
            {
                using (SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext())
                {
                    ctx.Usuario.Add(usuario);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

  
    }
}

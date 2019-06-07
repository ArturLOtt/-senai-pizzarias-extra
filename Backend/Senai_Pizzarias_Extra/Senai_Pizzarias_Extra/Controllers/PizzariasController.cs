using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Senai_Pizzarias_Extra.Domains;
using Senai_Pizzarias_Extra.Interfaces;
using Senai_Pizzarias_Extra.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Senai_Pizzarias_Extra.Controllers
{

    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class PizzariasController : ControllerBase
    {

        private IPizzariasRepository PizzariasRepository { get; set; }

        public PizzariasController() => PizzariasRepository = new PizzariasRepository();

        UsuarioRepository usuarioRepository = new UsuarioRepository();

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                using (SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext())
                {
                    return Ok(ctx.Pizzarias.ToList());
                }
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Post(Pizzarias pizzarias)
        {
            try
            {
                using (SENAI_PIZZARIAS_EXTRAContext ctx = new SENAI_PIZZARIAS_EXTRAContext())
                {
                    ctx.Pizzarias.Add(pizzarias);
                    ctx.SaveChanges();
                }
                return Ok();
            }
            catch (Exception ex)
            {

                return BadRequest();
            }
        }



        /**/
    }
}

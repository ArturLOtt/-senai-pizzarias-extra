using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Senai_Pizzarias_Extra.Domains;
using Senai_Pizzarias_Extra.Interfaces;
using Senai_Pizzarias_Extra.Repositories;
using Senai_Pizzarias_Extra.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

//using Microsoft.AspNetCore.Http;

namespace Senai_Pizzarias_Extra.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class LoginController : ControllerBase
    {
        private IUsuarioRepository UsuarioRepository { get; set; }


        public LoginController() => UsuarioRepository = new UsuarioRepository();

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {

            try
            {
                Usuario loginUsuario = UsuarioRepository.BuscarPorEmailESenha(login);

                if (loginUsuario == null)
                {
                    return NotFound();
                }

                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, loginUsuario.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, loginUsuario.Id.ToString()),
                    //new Claim(ClaimTypes.Role, loginUsuario.IdTipoUsuario.ToString())
                };

                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("Senai_Pizzarias_Extra-chave-autenticacao"));

                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: "Senai_Pizzarias_Extra.WebApi",
                    audience: "Senai_Pizzarias_Extra.WebApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds
                );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });

            }
            catch (Exception mex)
            {
                return BadRequest(new
                {
                    mensagem = mex
                });
            }

        }
    }
}

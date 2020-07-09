using Microsoft.AspNetCore.Mvc;
using Projeto_WSTower.Domains;
using Projeto_WSTower.Repositories;
using Projeto_WSTower.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WSTower.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase 
    {
        UsuarioRepository _usuarioRepository { get; set; }
        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
          
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel usuarioLogin)
        {
            Usuario UsuarioAchado = _usuarioRepository.Login(usuarioLogin.Email, usuarioLogin.Senha, usuarioLogin.Apelido);

            if (UsuarioAchado != null)
            {
                if (UsuarioAchado.Senha == usuarioLogin.Senha)
                {
                    return Ok("Bem vindo:" + UsuarioAchado.Apelido);
                }
                else
                {
                    return BadRequest("Senha incorreta");
                }
            }
            return BadRequest("Usuario nao encontrado");
        }
    }

}
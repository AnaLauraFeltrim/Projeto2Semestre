using Microsoft.AspNetCore.Mvc;
using Projeto_WSTower.Domains;
using Projeto_WSTower.Interfaces;
using Projeto_WSTower.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WSTower.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_usuarioRepository.ListarUsuario());
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuario novoUsuario)
        {
            // se retornar true significa que o usuario foi cadastrado com sucesso
            if (_usuarioRepository.Cadastrar(novoUsuario))
            {
                return StatusCode(201);
            }
            return BadRequest();
        }



        [HttpPut]
        public IActionResult Atualizar(Usuario usuario)
        {
            try
            {
                Usuario usuarioBuscado = _usuarioRepository.BuscarPorId(usuario.Id);
                if (usuarioBuscado == null)
                    return NotFound();
                _usuarioRepository.AtualizarUsuario(usuario);
                return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        
    }
}

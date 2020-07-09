using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_WSTower.Repositories;

namespace Projeto_WSTower.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        JogadorRepository jogadorRepository = new JogadorRepository();

        [HttpGet]
        public IActionResult ListarJogadores()
        {
            return Ok(jogadorRepository.ListarJogador());
        }
    }
}

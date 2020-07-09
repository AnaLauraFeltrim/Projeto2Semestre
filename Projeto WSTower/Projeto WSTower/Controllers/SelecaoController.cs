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
    public class SelecaoController : ControllerBase
    {
        SelecaoRepository selecaoRepository = new SelecaoRepository();

        [HttpGet]
        public IActionResult ListarTodos()
        {
            return Ok(selecaoRepository.ListarSelecao());
        }
    }
}

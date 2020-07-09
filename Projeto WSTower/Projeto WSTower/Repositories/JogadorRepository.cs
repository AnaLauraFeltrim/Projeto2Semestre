using Projeto_WSTower.Contexts;
using Projeto_WSTower.Domains;
using Projeto_WSTower.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WSTower.Repositories
{
    public class JogadorRepository : IJogadorRepository
    {
        Projeto_WSTowerContext ctx = new Projeto_WSTowerContext();

        public List<Jogador> ListarJogador()
        {
                return ctx.Jogador.ToList();   
        }

    }
}

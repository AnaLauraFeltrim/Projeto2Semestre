using Projeto_WSTower.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WSTower.Interfaces
{
    interface IUsuarioRepository
    {
        List<Usuario> ListarUsuario();

        bool Cadastrar(Usuario novoUsuario);

        void AtualizarUsuario(Usuario usuario);

        Usuario BuscarPorId(int id);
    }
}

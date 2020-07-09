using Microsoft.Data.SqlClient;
using Projeto_WSTower.Contexts;
using Projeto_WSTower.Domains;
using Projeto_WSTower.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_WSTower.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        Projeto_WSTowerContext ctx = new Projeto_WSTowerContext();

        public Usuario BuscarPorId(int id)
        {
            return ctx.Usuario.FirstOrDefault(x => x.Id == id);
        }
        public void AtualizarUsuario(Usuario usuario)
        {
            Usuario usuarioAtualizado = ctx.Usuario.FirstOrDefault(x => x.Id == usuario.Id);
            usuarioAtualizado.Nome = usuario.Nome;
            usuarioAtualizado.Email = usuario.Email;
            usuarioAtualizado.Apelido = usuario.Apelido;
            usuarioAtualizado.Foto = usuario.Foto;
            usuarioAtualizado.Senha = usuario.Senha;
            ctx.Usuario.Update(usuarioAtualizado);
            ctx.SaveChanges();
            
        }

        public bool Cadastrar(Usuario novoUsuario)
        {
            Usuario usuario = ctx.Usuario.FirstOrDefault(u => u.Apelido == novoUsuario.Apelido || u.Email == novoUsuario.Email);
            if (usuario == null)
            {
                ctx.Usuario.Add(novoUsuario);
                ctx.SaveChanges();
                return true;
            }
            return false;
        }

        public Usuario Login(string email, string senha, string apelido)
        {
            if (apelido == null)
            {
                Usuario UsuarioPorEmail = ctx.Usuario.First(u => u.Email == email);
                return UsuarioPorEmail;
            }
            else
            {
                return ctx.Usuario.FirstOrDefault(u => u.Apelido == apelido);
            }
        }

        public List<Usuario> ListarUsuario()
        {
            return ctx.Usuario.ToList();
        }


    }
}

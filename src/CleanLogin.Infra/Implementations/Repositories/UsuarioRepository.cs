using CleanLogin.Application.Interfaces.Repositories;
using CleanLogin.Domain.DTOs.Usuario;
using CleanLogin.Infra.Database;
using System.Linq;

namespace CleanLogin.Infra.Implementations.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CleanLoginContext _Context;

        public UsuarioRepository(CleanLoginContext context)
        {
            _Context = context;
        }

        public UsuarioDTO CarregarPorNomeDeUsuario(string nomeDeUsuario)
        {
            var usuario = _Context.Usuario.FirstOrDefault(x => x.NomeDeUsuario.Equals(nomeDeUsuario));
            if (usuario == null)
                return null;

            return new UsuarioDTO()
            {
                Id = usuario.Id,
                Email = usuario.Email,
                Nome = $"{usuario.Nome} {usuario.Sobrenome}",
                Senha = usuario.Senha,
            };
        }
    }
}

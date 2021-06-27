using CleanLogin.Application.Interfaces.Repositories;
using CleanLogin.Application.Interfaces.UnitOfWork;
using CleanLogin.Domain.DTOs.Usuario;
using CleanLogin.Infra.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Infra.Implementations.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly IUnitOfWork _UnitOfWork;
        private readonly CleanLoginContext _Context;

        public UsuarioRepository(IUnitOfWork uoW, CleanLoginContext context)
        {
            _UnitOfWork = uoW;
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

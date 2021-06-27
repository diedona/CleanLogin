using CleanLogin.Application.Interfaces.Repositories;
using CleanLogin.Domain.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Infra.Implementations.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public UsuarioDTO CarregarPorNomeDeUsuario(string nome)
        {
            throw new NotImplementedException();
        }
    }
}

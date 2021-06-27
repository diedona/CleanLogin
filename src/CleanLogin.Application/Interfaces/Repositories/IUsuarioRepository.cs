using CleanLogin.Domain.DTOs.Usuario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Application.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        UsuarioDTO CarregarPorNomeDeUsuario(string nomeDeUsuario);
    }
}

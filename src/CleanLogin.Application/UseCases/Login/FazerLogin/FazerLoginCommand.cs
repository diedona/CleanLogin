using CleanLogin.Domain.DTOs.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Application.UseCases.Login.FazerLogin
{
    public class FazerLoginCommand : IRequest<UsuarioDTO>
    {
        public string NomeDeUsuario { get; set; }
        public string Senha { get; set; }
    }
}

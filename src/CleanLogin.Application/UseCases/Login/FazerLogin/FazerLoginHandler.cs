using CleanLogin.Domain.DTOs.Usuario;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanLogin.Application.UseCases.Login.FazerLogin
{
    public class FazerLoginHandler : IRequestHandler<FazerLoginCommand, UsuarioDTO>
    {
        public async Task<UsuarioDTO> Handle(FazerLoginCommand request, CancellationToken cancellationToken)
        {
            return new UsuarioDTO()
            {
                Id = Guid.NewGuid(),
                Nome = request.NomeDeUsuario,
                Sobrenome = "Sobrenome Fixo"
            };
        }
    }
}

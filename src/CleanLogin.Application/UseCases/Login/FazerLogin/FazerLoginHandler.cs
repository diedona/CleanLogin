using CleanLogin.Application.Interfaces.Services;
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
        private readonly ITokenService _TokenService;

        public FazerLoginHandler(ITokenService tokenService)
        {
            this._TokenService = tokenService;
        }

        public async Task<UsuarioDTO> Handle(FazerLoginCommand request, CancellationToken cancellationToken)
        {
            if (!request.NomeDeUsuario.Equals("adm") && !request.Senha.Equals("123"))
                return null;

            return new UsuarioDTO()
            {
                Id = Guid.NewGuid(),
                Token = _TokenService.GerarToken(request)
            };
        }
    }
}

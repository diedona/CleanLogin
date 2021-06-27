using CleanLogin.Application.Interfaces.Services;
using CleanLogin.Application.Interfaces.UnitOfWork;
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
        private readonly IUnitOfWork _UnitOfWork;

        public FazerLoginHandler(ITokenService tokenService, IUnitOfWork unitOfWork)
        {
            this._TokenService = tokenService;
            _UnitOfWork = unitOfWork;
        }

        public async Task<UsuarioDTO> Handle(FazerLoginCommand request, CancellationToken cancellationToken)
        {
            //if (!request.NomeDeUsuario.Equals("adm") && !request.Senha.Equals("123"))
            //    return null;

            var usuario = _UnitOfWork.UsuarioRepository.CarregarPorNomeDeUsuario(request.NomeDeUsuario);
            if (usuario == null)
                return null;

            return new UsuarioDTO()
            {
                Id = usuario.Id,
                Token = _TokenService.GerarToken(request)
            };
        }
    }
}

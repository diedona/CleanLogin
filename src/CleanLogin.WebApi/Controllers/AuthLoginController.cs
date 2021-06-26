using CleanLogin.Application.UseCases.Login.FazerLogin;
using CleanLogin.Domain.DTOs.Usuario;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanLogin.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthLoginController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthLoginController(IMediator mediatr)
        {
            _mediator = mediatr;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<UsuarioDTO>> Post([FromBody] FazerLoginCommand fazerLogin)
        {
            var usuarioDTO = await _mediator.Send(fazerLogin);
            if (usuarioDTO == null)
                return BadRequest("Dados inválidos");

            return Ok(usuarioDTO);
        }
    }
}

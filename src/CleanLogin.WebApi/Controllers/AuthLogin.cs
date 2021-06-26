using CleanLogin.Domain.DTOs.Usuario;
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
    public class AuthLogin : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public ActionResult<UsuarioDTO> Post([FromBody] LoginDTO loginDTO)
        {
            UsuarioDTO usuarioDTO = new UsuarioDTO()
            {
                Id = Guid.NewGuid(),
                Nome = "João",
                Sobrenome = "da Silva"
            };

            return Ok(usuarioDTO);
        }
    }
}

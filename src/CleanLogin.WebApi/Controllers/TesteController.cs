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
    public class TesteController : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public ActionResult<string> GetTeste([FromQuery] string nome)
        {
            if (string.IsNullOrEmpty(nome))
                return BadRequest("Cadê o nome, corno?");

            return Ok($"Olá, {nome}, eu sou diego doná!");
        }
    }
}

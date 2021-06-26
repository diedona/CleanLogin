using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Domain.DTOs.Usuario
{
    public class UsuarioDTO
    {
        public Guid Id { get; set; }
        public string Token { get; set; }
    }
}

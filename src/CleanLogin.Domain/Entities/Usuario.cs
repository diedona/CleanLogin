using CleanLogin.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; private set; }
        public string NomeDeUsuario { get; private set; }
        public Nome Nome { get; private set; }

        public Usuario(Guid id, string nomeDeUsuario, Nome nome)
        {
            Id = id;
            NomeDeUsuario = nomeDeUsuario;
            Nome = nome;
        }

        public Usuario(string nomeDeUsuario, Nome nome) : this(Guid.NewGuid(), nomeDeUsuario, nome)
        {
        }
    }
}

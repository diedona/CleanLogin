using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanLogin.Domain.ValueObjects
{
    public class Nome
    {
        public string PrimeiroNome { get; private set; }
        public string Sobrenome { get; private set; }

        public Nome(string primeiroNome, string sobrenome)
        {
            if (string.IsNullOrEmpty(primeiroNome))
                throw new ArgumentNullException(nameof(primeiroNome));

            if (string.IsNullOrEmpty(sobrenome))
                throw new ArgumentNullException(nameof(sobrenome));

            PrimeiroNome = primeiroNome;
            Sobrenome = sobrenome;
        }

        public override string ToString()
        {
            return $"{PrimeiroNome} {Sobrenome}";
        }
    }
}

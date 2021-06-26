using CleanLogin.Application.Interfaces.App;
using CleanLogin.Application.Interfaces.Services;
using CleanLogin.Application.UseCases.Login.FazerLogin;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace CleanLogin.Infra.Services
{
    public class TokenService : ITokenService
    {
        private readonly IAppSettings _AppSettings;

        public TokenService(IAppSettings appSettings)
        {
            _AppSettings = appSettings;
        }

        public string GerarToken(FazerLoginCommand fazerLogin)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_AppSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, fazerLogin.NomeDeUsuario)
                }),
                Expires = DateTime.Now.AddHours(_AppSettings.HoursAllowed),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}

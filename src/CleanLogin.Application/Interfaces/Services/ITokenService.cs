using CleanLogin.Application.UseCases.Login.FazerLogin;

namespace CleanLogin.Application.Interfaces.Services
{
    public interface ITokenService
    {
        string GerarToken(FazerLoginCommand fazerLogin);
    }
}

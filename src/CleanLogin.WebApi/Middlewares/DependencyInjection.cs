using CleanLogin.Application.Interfaces.App;
using CleanLogin.Application.Interfaces.Repositories;
using CleanLogin.Application.Interfaces.Services;
using CleanLogin.Application.Interfaces.UnitOfWork;
using CleanLogin.Infra.Implementations.Repositories;
using CleanLogin.Infra.Implementations.Services;
using CleanLogin.Infra.Implementations.UnitOfWork;
using CleanLogin.WebApi.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanLogin.WebApi.Middlewares
{
    public static class DependencyInjection
    {
        public static void AdicionarDependencyInjection(this IServiceCollection services, string section, IConfiguration configuration)
        {
            services.AddSingleton<IAppSettings>((serviceProvider) =>
            {
                return configuration.GetSection(section).Get<AppSettings>();
            });

            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}

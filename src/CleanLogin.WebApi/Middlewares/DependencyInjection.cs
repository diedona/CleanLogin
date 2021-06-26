using CleanLogin.Application.Interfaces.Services;
using CleanLogin.Infra.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CleanLogin.WebApi.Middlewares
{
    public static class DependencyInjection
    {
        public static void AdicionarDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<ITokenService, TokenService>();
        }
    }
}

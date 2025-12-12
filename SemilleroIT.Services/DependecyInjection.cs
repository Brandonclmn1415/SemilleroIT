using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SemilleroIT.Domain.Common.Options.AppConfig;
using SemilleroIT.Services.Implementations.Perfilamiento;
using SemilleroIT.Services.Interfaces.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemilleroIT.Services;

public static class DependecyInjection
{
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        #region App config
        services.ConfigureOptions<AppConfigOptionsSetup>();
        #endregion

        #region Perfilamiento
        services.AddScoped<IUsuarioService, UsuarioService>();
        #endregion

        return services;
    }
}

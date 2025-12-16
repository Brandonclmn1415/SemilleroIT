using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SemilleroIT.Domain.Common.Options.AppConfig;
using SemilleroIT.Services.Implementations.Perfilamiento;
using SemilleroIT.Services.Interfaces.Perfilamiento;
using SemilleroIT.Services.Interfaces.Inventario;
using SemilleroIT.Services.Implementations.Inventario;
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

        #region Inventario
        services.AddScoped<IInventarioService, InventarioService>();
        #endregion

        return services;
    }
}

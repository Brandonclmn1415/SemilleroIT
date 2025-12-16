using SemilleroIT.Domain.Common.Options.Database;
using SemilleroIT.Persistence.Data;
using SemilleroIT.Persistence.Repositories.Implementations.Perfilamiento;
using SemilleroIT.Persistence.Repositories.Interfaces.Perfilamiento;
using SemilleroIT.Persistence.Repositories.Implementations.Inventario;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using SemilleroIT.Domain.Interfaces.Inventario;

namespace SemilleroIT.Persistence;

public static class DependecyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        //EF Core
        services.ConfigureOptions<DatabaseOptionsSetup>();

        services.AddDbContextFactory<AppDBContext>(
            (serviceProvider, dbContextOptionsBuilder) =>
            {
                var databaseOptions = serviceProvider.GetService<IOptions<DatabaseOptions>>()!.Value;

                dbContextOptionsBuilder.UseSqlServer(databaseOptions.ConnectionString, sqlServerOptionsAction =>
                {
                    sqlServerOptionsAction.EnableRetryOnFailure(databaseOptions.MaxRetryCount);
                    sqlServerOptionsAction.CommandTimeout(databaseOptions.CommandTimeout);
                });
                dbContextOptionsBuilder.EnableDetailedErrors(databaseOptions.EnableDetailedErrors);
                dbContextOptionsBuilder.EnableSensitiveDataLogging(databaseOptions.EnableSensitiveDataLogging);
            });

        #region Perfilamiento
        services.AddScoped<IUsuarioRepository, UsuarioRepository>();
        #endregion


        #region Inventario
        services.AddScoped<IInventarioRepository, inventarioRepository>();
        #endregion

        return services;
    }
}

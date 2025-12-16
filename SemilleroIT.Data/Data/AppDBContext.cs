using Microsoft.EntityFrameworkCore;
using SemilleroIT.Domain.Entities.Inventario;
using SemilleroIT.Domain.Entities.Perfilamiento;
using SemilleroIT.Persistence.Context.TableConfig.Inventario;
using SemilleroIT.Persistence.Data.TableConfig.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Persistence.Data;

/// <summary>
/// DbContext que gestiona todas las operaciones de base de datos del aplicativo
/// </summary>
public class AppDBContext : DbContext
{
    public AppDBContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Inventarios> Inventarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Perfilamiento
        modelBuilder.ApplyConfiguration(new UsuarioConfig());
        #endregion

        #region Inventario
        modelBuilder.ApplyConfiguration(new InventarioConfig());
        #endregion

        base.OnModelCreating(modelBuilder);
    }
}
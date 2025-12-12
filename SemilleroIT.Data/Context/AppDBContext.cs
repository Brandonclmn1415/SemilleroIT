using Microsoft.EntityFrameworkCore;
using SemilleroIT.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Persisten.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        #region Usuario
        public DbSet<Usuario> Usuarios { get; set; }
        #endregion

        #region Inventario
        public DbSet<Inventario> Inventarios { get; set; }
        #endregion



    }
}

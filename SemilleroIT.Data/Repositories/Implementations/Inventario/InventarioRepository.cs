using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SemilleroIT.Domain.Entities.Inventario;
using SemilleroIT.Persistence.Data;
using SemilleroIT.Persistence.Repositories.Common;
using SemilleroIT.Domain.Interfaces.Inventario;
using Microsoft.EntityFrameworkCore;

namespace SemilleroIT.Persistence.Repositories.Implementations.Inventario
{
    public class inventarioRepository : EFCoreRepository<Inventarios>, IInventarioRepository
    {
        public inventarioRepository(IDbContextFactory<AppDBContext> dbContextFactory) : base(dbContextFactory)
        {
            
        }
        public async Task<IEnumerable<Inventarios>> GetInventariosAsync()
        {
            using var context = _dbContextFactory.CreateDbContext();
            return await context.Inventarios.ToListAsync();
        }
        public async Task<Inventarios?> GetInventarioByIdAsync(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return await context.Inventarios.FindAsync(id);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SemilleroIT.Domain.Entities.Perfilamiento;
using SemilleroIT.Persistence.Data;
using SemilleroIT.Persistence.Repositories.Common;
using SemilleroIT.Persistence.Repositories.Interfaces.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Persistence.Repositories.Implementations.Perfilamiento;

public class UsuarioRepository : EFCoreRepository<Usuario>, IUsuarioRepository
{
    public UsuarioRepository(IDbContextFactory<AppDBContext> dbContextFactory) : base(dbContextFactory)
    {
    }

    public async Task<bool> ExistUsernameAsync(string username)
    {
        using var context = _dbContextFactory.CreateDbContext();
        return await context.Set<Usuario>().FirstOrDefaultAsync(u => u.Nombre_Usuario == username);
    }

    public async Task<Usuario> GetByUsernameAsync(string username)
    {
        using var context = _dbContextFactory.CreateDbContext();
        return await context.Set<Usuario>().AnyAsync(u => u.Nombre_Usuario == username);
    }

    public async Task<bool> InsertarUsuario(Usuario usuario)
    {
        using var context = _dbContextFactory.CreateDbContext();

        Usuario? temp = context?.Usuarios?.AsNoTracking().FirstOrDefault(u => u.Id == usuario.Id);

        if (temp is null)
        {
            usuario.FechaAdicion = DateTime.Now;
            context?.Usuarios.Add(usuario);
        }
        else
        {
            usuario.FechaUltimaActualizacion = DateTime.Now;
            context?.Usuarios.Update(usuario);
        }

        int entities = await context.SaveChangesAsync();

        return entities > 0;
    }

    public Task<Usuario> UpdateAsync(Usuario usuario)
    {
        throw new NotImplementedException();
    }
}

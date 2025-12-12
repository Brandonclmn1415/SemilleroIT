using Microsoft.EntityFrameworkCore;
using SemilleroIT.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SemilleroIT.Persistence.Repositories.Common;

public abstract class EFCoreRepository<T> : IGenericRepository<T> where T : class
{
    protected readonly IDbContextFactory<AppDBContext> _dbContextFactory;

    protected EFCoreRepository(IDbContextFactory<AppDBContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public IEnumerable<T> GetAll(List<Expression<Func<T, bool>>>? filtros = null, List<Expression<Func<T, object>>>? includes = null, List<Expression<Func<T, object>>>? classifications = null, int? page = null, int? sizePage = null)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<T>> GetAllAsync(List<Expression<Func<T, bool>>>? filtros = null, List<Expression<Func<T, object>>>? includes = null, List<Expression<Func<T, object>>>? classifications = null, int? page = null, int? sizePage = null)
    {
        throw new NotImplementedException();
    }

    public async Task<T> GetById(long id)
    {
        using var context = _dbContextFactory.CreateDbContext();

        return await context.Set<T>().FindAsync(id);
    }
}

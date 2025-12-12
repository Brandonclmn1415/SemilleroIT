using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SemilleroIT.Persistence.Repositories.Common;

public interface IGenericRepository<T> where T : class
{
    public Task<IEnumerable<T>> GetAllAsync
    (
        List<Expression<Func<T, bool>>>? filtros = null,
        List<Expression<Func<T, object>>>? includes = null,
        List<Expression<Func<T, object>>>? classifications = null,
        int? page = null,
        int? sizePage = null
    );

    public IEnumerable<T> GetAll
    (
        List<Expression<Func<T, bool>>>? filtros = null,
        List<Expression<Func<T, object>>>? includes = null,
        List<Expression<Func<T, object>>>? classifications = null,
        int? page = null,
        int? sizePage = null
    );

    public Task<T> GetById(long id);
}

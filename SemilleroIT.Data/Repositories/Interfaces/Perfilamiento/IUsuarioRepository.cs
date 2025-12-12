using SemilleroIT.Domain.Entities.Perfilamiento;
using SemilleroIT.Persistence.Repositories.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Persistence.Repositories.Interfaces.Perfilamiento;

public interface IUsuarioRepository : IGenericRepository<Usuario>
{
    public Task<bool> InsertarUsuario(Usuario usuario);
}

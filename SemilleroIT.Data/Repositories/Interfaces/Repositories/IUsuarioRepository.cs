using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemilleroIT.Domain.Entidades;
using SemilleroIT.Domain.Interfaces.Repositories;


namespace SemilleroIT.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        public Task<Usuario> InsertarUsuario();
    }
}

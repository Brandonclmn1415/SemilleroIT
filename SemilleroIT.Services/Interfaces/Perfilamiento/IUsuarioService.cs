using SemilleroIT.Domain.Entities.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemilleroIT.Services.Interfaces.Perfilamiento;

public interface IUsuarioService
{
    public Task<IEnumerable<Usuario>> GetUsuarios();
}

using SemilleroIT.Domain.Entities.Perfilamiento;
using SemilleroIT.Persistence.Repositories.Interfaces.Perfilamiento;
using SemilleroIT.Services.Interfaces.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SemilleroIT.Services.Implementations.Perfilamiento;

public class UsuarioService : IUsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository) {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<IEnumerable<Usuario>> GetUsuarios()
    {
        var includes = new List<Expression<Func<Usuario, object>>>();

        return await _usuarioRepository.GetAllAsync(includes: includes);
    }
}

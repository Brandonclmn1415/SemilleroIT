using SemilleroIT.Domain.Entities.Inventario;
using SemilleroIT.Domain.Interfaces.Inventario;
using SemilleroIT.Services.Interfaces.Inventario;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SemilleroIT.Services.Implementations.Inventario;

public class InventarioService : IInventarioService
{
    private readonly IInventarioRepository _inventarioRepository;

    public InventarioService(IInventarioRepository inventarioRepository)
    {
        _inventarioRepository = inventarioRepository;
    }

    public async Task<IEnumerable<Inventarios>> GetInventariosAsync()
    {
        return await _inventarioRepository.GetInventariosAsync();
    }

    public async Task<Inventarios?> GetInventarioByIdAsync(int id)
    {
        return await _inventarioRepository.GetInventarioByIdAsync(id);
    }

}


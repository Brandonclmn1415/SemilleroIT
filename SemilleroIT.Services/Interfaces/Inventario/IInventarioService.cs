using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SemilleroIT.Domain.Entities.Inventario;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SemilleroIT.Services.Interfaces.Inventario;

public interface IInventarioService
{
    Task<IEnumerable<Inventarios>> GetInventariosAsync();
    Task<Inventarios?> GetInventarioByIdAsync(int id);
}
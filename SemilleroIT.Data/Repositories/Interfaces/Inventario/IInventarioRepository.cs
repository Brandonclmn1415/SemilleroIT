using System;
using System.Collections.Generic;
using SemilleroIT.Domain.Entities.Inventario;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Domain.Interfaces.Inventario
{
    public interface IInventarioRepository
    {
       Task<IEnumerable<Inventarios>> GetInventariosAsync();
       Task<Inventarios?> GetInventarioByIdAsync(int id);
    } 
    
}

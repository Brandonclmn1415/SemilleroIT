using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Domain.DTO.Inventario
{
    public class InventarioDTO
    {
        public string Id_Producto{ get; set; }
        public string Nombre_Producto { get; set; }
        public string Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}

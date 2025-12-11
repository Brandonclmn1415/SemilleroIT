using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Domain.Entidades
{
    public class Inventario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion_Producto { get; set; }
        public decimal Precio_Producto { get; set; }
        public int Cantidad_Producto { get; set; } 
        
    }
}

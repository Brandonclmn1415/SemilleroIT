using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SemilleroIT.Domain.Entities.Inventario
{
    [Table ("Inventarios", Schema = "Inv")]
    public class Inventarios : BaseEntity
    {

        [MaxLength  (50)]
        public string Nombre_Producto { get; set; }

        [MaxLength (50)]
        public string Descripcion_Producto { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; } 
        
    }
}

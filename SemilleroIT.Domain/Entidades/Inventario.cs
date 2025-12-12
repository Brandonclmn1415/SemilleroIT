using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SemilleroIT.Domain.Entidades
{
    [Table ("Inventario", Schema = "Seg")]
    public class Inventario
    {
        public int Id { get; set; }

        [MaxLength  (50)]
        public string Nombre { get; set; }

        [MaxLength (50)]
        public string Descripcion_Producto { get; set; }
        public decimal Precio_Producto { get; set; }
        public int Cantidad_Producto { get; set; } 
        
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Domain.Entidades
{
    [Table ("Usuario", Schema = "Seg")]
    public class Usuario
    {
        public string Id { get; set; }

        [MaxLength  (50)]
        public string Nombre_Usuario { get; set; }

        [MaxLength (50)]
        public string Nombre { get; set; }

        [MaxLength (50)]
        public string Apellido { get; set; }

        [MaxLength (50)]
        public string Correo { get; set; }
    }
}

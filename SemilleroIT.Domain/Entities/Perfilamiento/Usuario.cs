using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace SemilleroIT.Domain.Entities.Perfilamiento;

[Table ("Usuario", Schema = "Seg")]
public class Usuario : BaseEntity
{
    public long Id { get; set; }

    [MaxLength  (50)]
    public string Nombre_Usuario { get; set; }

    [MaxLength (50)]
    public string Nombre { get; set; }

    [MaxLength (50)]
    public string Apellido { get; set; }

    [MaxLength (50)]
    public string Correo { get; set; }
}

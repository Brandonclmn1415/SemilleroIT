using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Domain.DTO.Perfilamiento;

public class UserDTO
{
    [Required(ErrorMessage = "Por favor ingrese un usuario")]
    [MaxLength (50, ErrorMessage = "El usuario debe tener menos de 50 caracteres")]
    public string Usuario { get; set; }

    [Required(ErrorMessage = "Por favor ingrese una contraseña")]
    [MaxLength (50, ErrorMessage = "La contraseña debe tener menos de 50 caracteres")]
    public string Password { get; set; }
}

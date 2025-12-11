using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Domain.DTO.Usuarios
{
    public class LoginResponseDto
    {
        public string Estado {  get; set; } = string.Empty;
        public string Descripcion {  get; set; } = string.Empty;
    }
}

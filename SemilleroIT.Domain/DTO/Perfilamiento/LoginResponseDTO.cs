using SemilleroIT.Domain.Entities.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemilleroIT.Domain.DTO.Perfilamiento
{
    public class LoginResponseDTO
    {
        public bool Success { get; set; }
        public string Message { get; set; } 
        public UserDTO User { get; set; }
    }

    public class UsuarioDTO
    {
        public long Id { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string NombreCompleto 
        { 
            get 
            { 
                return $"{Nombre} {Apellido}"; 
            }
        }
    }
}

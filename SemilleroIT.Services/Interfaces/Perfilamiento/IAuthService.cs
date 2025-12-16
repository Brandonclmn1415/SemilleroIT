using System;
using System.Collections.Generic;
using System.Text;
using SemilleroIT.Domain.DTO.Perfilamiento;
using System.Threading.Tasks;

namespace SemilleroIT.Services.Interfaces.Perfilamiento
{
    public interface IAuthService
    {
        Task<LoginResponseDTO> AuthenticateAsync(UserDTO userDTO);
        Task<bool> ValidateUserAsync(string username, string password);
    }
}

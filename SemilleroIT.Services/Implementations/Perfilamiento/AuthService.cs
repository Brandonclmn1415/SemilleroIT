using Microsoft.EntityFrameworkCore;
using SemilleroIT.Domain.DTO.Perfilamiento;
using SemilleroIT.Domain.Entities.Perfilamiento;
using SemilleroIT.Persistence.Data;
using SemilleroIT.Persistence.Repositories.Implementations.Perfilamiento;
using SemilleroIT.Persistence.Repositories.Interfaces.Perfilamiento;
using SemilleroIT.Services.Interfaces.Perfilamiento;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace SemilleroIT.Services.Implementations.Perfilamiento
{
    public class AuthService : IAuthService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        private  readonly AppDBContext _appDBContext;

        public AuthService(
            UsuarioRepository usuarioRepository,
            AppDBContext context) 
        {
            _usuarioRepository = usuarioRepository;
            _appDBContext = context;
        }

        public async Task<LoginResponseDTO> AuthenticateAsync(UserDTO usuarioDTO) 
        {
            try
            {
                var usuario = await _usuarioRepository.GetByUsernameAsync(usuarioDTO.Usuario);

                if (usuario == null) 
                {
                    return new LoginResponseDTO
                    {
                        Success = false,
                        Message = "Usuario no encontrado"
                    };
                }

                if (usuario.isLocked) 
                {
                    return new LoginResponseDTO
                    {
                        Success = false,
                        Message = "Usuario bloqueado por múltiples intentos fallidos"
                    };
                }

                if (usuario.Password != usuarioDTO.Password) 
                {
                    usuario.intentosFallidos += 1;

                    if (usuario.intentosFallidos >= 3) 
                    {
                        usuario.isLocked = true;
                        await _usuarioRepository.UpdateAsync(usuario);

                        return new LoginResponseDTO
                        {
                            Success = false,
                            Message = "Usuario bloqueado por múltiples intentos fallidos"
                        };
                    }

                    await _usuarioRepository.UpdateAsync(usuario);

                    return new LoginResponseDTO
                    {
                        Success = false,
                        Message = "Contraseña incorrecta."
                    };
                }

                usuario.intentosFallidos = 0;
                usuario.FechaUltimoLogin = DateTime.UtcNow;
                await _usuarioRepository.UpdateAsync(usuario);

                return new LoginResponseDTO
                {
                    Success = true,
                    Message = "Autenticación exitosa.",
                    User = new UserDTO
                    {
                        Usuario = usuario.Nombre_Usuario,
                        Password = usuario.Password
                    }
                };

            }
            catch (Exception e) 
            {
                return new LoginResponseDTO 
                {
                    Success = false,
                    Message = "$Error durante la autenticacion: {e.Message}"
                };
            }
        }

        public async Task<bool> ValidateUserAsync(string username, string password)
        {
            var usuario = await _usuarioRepository.GetByUsernameAsync(username);

            if (usuario == null || usuario.Password != password)
                return false;

            return usuario.Password == password;

        }
    }
   
}

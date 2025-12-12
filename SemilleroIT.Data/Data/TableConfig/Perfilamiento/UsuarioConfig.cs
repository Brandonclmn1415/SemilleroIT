using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemilleroIT.Domain.Entities.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Text;

namespace SemilleroIT.Persistence.Data.TableConfig.Perfilamiento;

public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.HasIndex(u => u.Nombre_Usuario).IsUnique();
        builder.HasIndex(u => u.Correo);

        // Información Inicial
        builder.HasData(Build());
    }

    private List<Usuario> Build()
    {
        return [new Usuario() { Id = 1, Nombre_Usuario = "Administrador", Nombre = "Admin", Apellido = "istrador", Correo = "henderson.moreno@excellentiam.co", IdUsuarioAdiciono = 1, FechaAdicion = new DateTime(2025, 12, 12), FechaUltimaActualizacion = null, IdUsuarioUltimaActualizacion = null }];
    }
}

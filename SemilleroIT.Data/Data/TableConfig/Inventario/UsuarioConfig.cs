using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemilleroIT.Domain.Entities.Perfilamiento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SemilleroIT.Persistence.Context.TableConfig.Inventario
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "Seg");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nombre_Usuario)
                .HasMaxLength(50);
            builder.Property(e => e.Nombre)
                .HasMaxLength(50);
            builder.Property(e => e.Apellido)
                .HasMaxLength(50);
            builder.Property(e => e.Correo)
                .HasMaxLength(50);
        }
    }
}

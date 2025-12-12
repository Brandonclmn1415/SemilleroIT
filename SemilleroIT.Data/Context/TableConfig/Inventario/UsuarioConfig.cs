using Microsoft.EntityFrameworkCore;
using SemilleroIT.Domain.Entidades;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemilleroIT.Persisten.Repositories.Implmentaciones;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemilleroIT.Persisten.Context.TableConfig.Inventario
{
    public class UsuarioConfig : IEntityTypeConfiguration<Usuario>
    {
        public void configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
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

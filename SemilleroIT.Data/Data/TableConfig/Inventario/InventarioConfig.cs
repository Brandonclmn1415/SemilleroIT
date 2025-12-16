using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SemilleroIT.Domain.Entities.Inventario;
using System;
using System.Collections.Generic;


namespace SemilleroIT.Persistence.Context.TableConfig.Inventario
{   
    public class InventarioConfig : IEntityTypeConfiguration<Inventarios>
    {
        public void Configure(EntityTypeBuilder<Inventarios> builder) 
        {
            builder.ToTable("Inventario", "Inv");
            

            builder.HasKey(e => e.Id);
            builder.HasIndex(i => i.Nombre_Producto).IsUnique();
            builder.HasIndex(i => i.Cantidad);
            builder.HasIndex(i => i.Precio);


            builder.Property(e => e.Nombre_Producto)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Descripcion_Producto)
                .HasMaxLength(50);

            builder.HasData(Build());
        }

        private List<Inventarios> Build()
        {
            return new List<Inventarios>
            {
                new Inventarios
                {
                    Id = 1,
                    Nombre_Producto = "Laptop Dell XPS 13",
                    Descripcion_Producto = "Laptop ultradelgada con pantalla de 13 pulgadas",
                    Precio = 999.99m,
                    Cantidad = 50
                }
            };
        }
    }
}

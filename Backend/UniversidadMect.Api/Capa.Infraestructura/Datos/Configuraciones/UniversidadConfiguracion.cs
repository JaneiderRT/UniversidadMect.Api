using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Capa.Infraestructura.Datos.Modelos.Configuraciones
{
    public class UniversidadConfiguracion : IEntityTypeConfiguration<Universidad>
    {
        public void Configure(EntityTypeBuilder<Universidad> entity)
        {
            entity.Property(e => e.Direccion)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(20)
                .IsUnicode(false);
        }
    }
}

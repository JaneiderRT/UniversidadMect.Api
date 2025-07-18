using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Capa.Infraestructura.Datos.Modelos.Configuraciones
{
    public class ProfesorConfiguracion : IEntityTypeConfiguration<Profesor>
    {
        public void Configure(EntityTypeBuilder<Profesor> entity)
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Persona).WithMany(p => p.Profesor)
                .HasForeignKey(d => d.PersonaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profesor_Persona");

            entity.HasOne(d => d.Universidad).WithMany(p => p.Profesor)
                .HasForeignKey(d => d.UniversidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profesor_Universidad");
        }
    }
}

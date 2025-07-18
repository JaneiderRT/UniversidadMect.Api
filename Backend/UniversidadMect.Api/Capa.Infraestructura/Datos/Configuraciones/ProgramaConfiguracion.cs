using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Capa.Infraestructura.Datos.Modelos.Configuraciones
{
    public class ProgramaConfiguracion : IEntityTypeConfiguration<Programa>
    {
        public void Configure(EntityTypeBuilder<Programa> entity)
        {
            entity.HasKey(e => e.ProgramaId).HasName("PK_Carrera");

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.FechaModificacion).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(200)
                .IsUnicode(false);

            entity.HasOne(d => d.Universidad).WithMany(p => p.Programa)
                .HasForeignKey(d => d.UniversidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Programa_Universidad");
        }
    }
}

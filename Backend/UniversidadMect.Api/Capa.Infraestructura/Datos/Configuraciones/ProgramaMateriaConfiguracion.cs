using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Capa.Infraestructura.Datos.Modelos.Configuraciones
{
    public class ProgramaMateriaConfiguracion : IEntityTypeConfiguration<ProgramaMateria>
    {
        public void Configure(EntityTypeBuilder<ProgramaMateria> entity)
        {
            entity.HasOne(d => d.Materia).WithMany(p => p.ProgramaMateria)
                .HasForeignKey(d => d.MateriaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramaMateria_Materia");

            entity.HasOne(d => d.Programa).WithMany(p => p.ProgramaMateria)
                .HasForeignKey(d => d.ProgramaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_ProgramaMateria_Programa");
        }
    }
}

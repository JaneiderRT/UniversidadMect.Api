using Capa.Dominio.Entidades;
using Capa.Infraestructura.Datos.Modelos.Configuraciones;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UniversidadMect.Api.Capa.Infraestructura.Datos
{
    public class UniversidadContext : DbContext
    {
        public UniversidadContext(DbContextOptions<UniversidadContext> options) : base(options) { }

        public virtual DbSet<Estudiante> Estudiante { get; set; }

        public virtual DbSet<Inscripcion> Inscripcion { get; set; }

        public virtual DbSet<Materia> Materia { get; set; }

        public virtual DbSet<Persona> Persona { get; set; }

        public virtual DbSet<Profesor> Profesor { get; set; }

        public virtual DbSet<Programa> Programa { get; set; }

        public virtual DbSet<ProgramaMateria> ProgramaMateria { get; set; }

        public virtual DbSet<TipoIdentificacion> TipoIdentificacion { get; set; }

        public virtual DbSet<Universidad> Universidad { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EstudianteConfiguracion());
            modelBuilder.ApplyConfiguration(new InscripcionConfiguracion());
            modelBuilder.ApplyConfiguration(new MateriaConfiguracion());
            modelBuilder.ApplyConfiguration(new PersonaConfiguracion());
            modelBuilder.ApplyConfiguration(new ProfesorConfiguracion());
            modelBuilder.ApplyConfiguration(new ProgramaConfiguracion());
            modelBuilder.ApplyConfiguration(new ProgramaMateriaConfiguracion());
            modelBuilder.ApplyConfiguration(new TipoIdentificacionConfiguracion());
            modelBuilder.ApplyConfiguration(new UniversidadConfiguracion());
        }
    }
}

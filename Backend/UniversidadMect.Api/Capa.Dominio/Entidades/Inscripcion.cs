namespace Capa.Dominio.Entidades;

public class Inscripcion
{
    public int InscripcionId { get; set; }

    public int MateriaId { get; set; }

    public int EstudianteId { get; set; }

    public bool EsActivo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int CreadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? ModificadoPor { get; set; }

    public virtual Estudiante Estudiante { get; set; } = null!;

    public virtual Materia Materia { get; set; } = null!;
}
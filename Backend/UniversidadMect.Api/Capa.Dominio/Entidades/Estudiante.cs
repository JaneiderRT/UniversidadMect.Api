namespace Capa.Dominio.Entidades;

public class Estudiante
{
    public int EstudianteId { get; set; }

    public int PersonaId { get; set; }

    public int UniversidadId { get; set; }

    public string Codigo { get; set; } = null!;

    public int CreditosEstudiante { get; set; }

    public bool EsActivo { get; set; }

    public virtual ICollection<Inscripcion> Inscripcion { get; set; } = new List<Inscripcion>();

    public virtual Persona Persona { get; set; } = null!;

    public virtual Universidad Universidad { get; set; } = null!;
}
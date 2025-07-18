namespace Capa.Dominio.Entidades;

public class Profesor
{
    public int ProfesorId { get; set; }

    public int PersonaId { get; set; }

    public int UniversidadId { get; set; }

    public string Codigo { get; set; } = null!;

    public bool EsActivo { get; set; }

    public virtual ICollection<Materia> Materia { get; set; } = new List<Materia>();

    public virtual Persona Persona { get; set; } = null!;

    public virtual Universidad Universidad { get; set; } = null!;
}
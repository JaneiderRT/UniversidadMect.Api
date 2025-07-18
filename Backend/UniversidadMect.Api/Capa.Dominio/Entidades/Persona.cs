namespace Capa.Dominio.Entidades;

public class Persona
{
    public int PersonaId { get; set; }

    public int? UserId { get; set; }

    public string PrimerNombre { get; set; } = null!;

    public string? SegundoNombre { get; set; }

    public string PrimerApellido { get; set; } = null!;

    public string? SegundoApellido { get; set; }

    public string Sexo { get; set; } = null!;

    public int TipoIdentificacionId { get; set; }

    public string? Identificacion { get; set; }

    public string Direccion { get; set; } = null!;

    public string? Adicional { get; set; }

    public bool EsActivo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int CreadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? ModificadoPor { get; set; }

    public virtual ICollection<Estudiante> Estudiante { get; set; } = new List<Estudiante>();

    public virtual ICollection<Profesor> Profesor { get; set; } = new List<Profesor>();

    public virtual TipoIdentificacion TipoIdentificacion { get; set; } = null!;
}
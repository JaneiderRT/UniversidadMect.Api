namespace Capa.Dominio.Entidades;

public class Materia
{
    public int MateriaId { get; set; }

    public string Nombre { get; set; } = null!;

    public int CreditosMateria { get; set; }

    public int ProfesorId { get; set; }

    public bool EsActivo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int CreadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? ModifcadoPor { get; set; }

    public virtual ICollection<Inscripcion> Inscripcion { get; set; } = new List<Inscripcion>();

    public virtual Profesor Profesor { get; set; } = null!;

    public virtual ICollection<ProgramaMateria> ProgramaMateria { get; set; } = new List<ProgramaMateria>();
}
namespace Capa.Dominio.Entidades;

public class Programa
{
    public int ProgramaId { get; set; }

    public int UniversidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public int CreditosTotales { get; set; }

    public bool EsActivo { get; set; }

    public DateTime FechaCreacion { get; set; }

    public int CreadoPor { get; set; }

    public DateTime? FechaModificacion { get; set; }

    public int? ModificadoPor { get; set; }

    public virtual ICollection<ProgramaMateria> ProgramaMateria { get; set; } = new List<ProgramaMateria>();

    public virtual Universidad Universidad { get; set; } = null!;
}
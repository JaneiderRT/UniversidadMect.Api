namespace Capa.Dominio.Entidades;

public class ProgramaMateria
{
    public int ProgramaMateriaId { get; set; }

    public int ProgramaId { get; set; }

    public int MateriaId { get; set; }

    public virtual Materia Materia { get; set; } = null!;

    public virtual Programa Programa { get; set; } = null!;
}
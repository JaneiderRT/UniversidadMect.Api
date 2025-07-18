namespace Capa.Dominio.Entidades;

public class Universidad
{
    public int UniversidadId { get; set; }

    public string Nombre { get; set; } = null!;

    public int Nit { get; set; }

    public int CodigoVerificacion { get; set; }

    public string Direccion { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public bool EsActivo { get; set; }

    public virtual ICollection<Estudiante> Estudiante { get; set; } = new List<Estudiante>();

    public virtual ICollection<Profesor> Profesor { get; set; } = new List<Profesor>();

    public virtual ICollection<Programa> Programa { get; set; } = new List<Programa>();
}
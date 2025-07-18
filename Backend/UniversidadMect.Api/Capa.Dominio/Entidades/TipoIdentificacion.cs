namespace Capa.Dominio.Entidades;

public class TipoIdentificacion
{
    public int TipoIdentificacionId { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Persona> Persona { get; set; } = new List<Persona>();
}
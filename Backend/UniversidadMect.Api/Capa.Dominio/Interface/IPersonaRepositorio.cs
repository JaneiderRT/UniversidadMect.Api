using Capa.Dominio.Entidades;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Dominio.Interface
{
    public interface IPersonaRepositorio : ICrudSql<Persona>
    {
    }
}

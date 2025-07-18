using Capa.Dominio.Entidades;

namespace UniversidadMect.Api.Capa.Aplicacion.Interface
{
    public interface IUniversidadServicio
    {
        public Task<Universidad> ConsultarUniversidadPorId(int id);
    }
}

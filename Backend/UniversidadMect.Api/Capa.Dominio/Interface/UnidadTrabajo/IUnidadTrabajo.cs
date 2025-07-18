namespace UniversidadMect.Api.Capa.Dominio.Interface.UnidadTrabajo
{
    public interface IUnidadTrabajo : IDisposable
    {
        IEstudianteRepositorio iEstudianteRepositorio { get; }

        IInscripcionRepositorio iInscripcionRepositorio { get; }

        IMateriaRepositorio iMateriaRepositorio { get; }

        IPersonaRepositorio iPersonaRepositorio { get; }

        IProfesorRepositorio iProfesorRepositorio { get; }

        IProgramaMateriaRepositorio iProgramaMateriaRepositorio { get; }

        IProgramaRepositorio iProgramaRepositorio { get; }

        ITipoIdentificacionRepositorio iTipoIdentificacionRepositorio { get; }

        IUniversidadRepositorio iUniversidadRepositorio { get; }

        void Dispose();

        Task DisposeAsync();

        Task SaveChangesAsync();
    }
}

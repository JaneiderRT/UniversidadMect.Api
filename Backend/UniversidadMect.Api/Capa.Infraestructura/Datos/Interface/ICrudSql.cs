namespace UniversidadMect.Api.Capa.Infraestructura.Datos.Interface
{
    public interface ICrudSql<T> where T : class
    {
        #region Consultas BDD
        Task<T> GetById(int id);
        IEnumerable<T> GetAll();
        #endregion

        #region Insercion BDD
        Task Insert(T entity);
        #endregion

        #region Actualizar BDD
        void Update(T entity);
        #endregion
    }
}

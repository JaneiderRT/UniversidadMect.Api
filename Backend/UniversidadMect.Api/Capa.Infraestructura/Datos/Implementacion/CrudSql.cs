using Microsoft.EntityFrameworkCore;
using UniversidadMect.Api.Capa.Aplicacion.Utilidades;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Interface;

namespace UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion
{
    public class CrudSql<T> : ICrudSql<T> where T : class
    {
        protected readonly DbSet<T> _dbSet;
        protected readonly DbContext _context;

        public CrudSql(DbContext dbContext)
        {
            _dbSet = dbContext.Set<T>();
            _context = dbContext;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet.AsQueryable();
            }
            catch (Exception ex)
            {
                throw new ExcepcionGenerica("Se ha presentado un error al momento de consultar todos los datos. " + ex.Message);
            }
        }

        public async Task<T> GetById(int id)
        {
            try
            {
                return await _dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new ExcepcionGenerica("Se ha presentado un error al momento de consultar el dato. " + ex.Message);
            }
        }

        public async Task Insert(T entity)
        {
            try
            {
                await _dbSet.AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new ExcepcionGenerica("Se ha presentado un error al momento de insertar el registro. " + ex.Message);
            }
        }

        public void Update(T entity)
        {
            try
            {
                _dbSet.Update(entity);
            }
            catch (Exception ex)
            {
                throw new ExcepcionGenerica("Se ha presentado un error al momento de actualizar el registro. " + ex.Message);
            }
        }
    }
}

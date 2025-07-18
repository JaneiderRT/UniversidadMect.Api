using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Programa;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class ProgramaRepositorio : CrudSql<Programa>, IProgramaRepositorio
    {
        private readonly UniversidadContext _context;

        public ProgramaRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ProgramaDTO>> ConsultarProgramasPorUniversidad(int universidadId)
        {
            return await _context.Programa
                .Where(pro => pro.UniversidadId == universidadId)
                .Select(pro => new ProgramaDTO
                {
                    ProgramaId = pro.ProgramaId,
                    UniversidadId = pro.UniversidadId,
                    Nombre = pro.Nombre,
                    CreditosTotales = pro.CreditosTotales,
                    EsActivo = pro.EsActivo,

                }).ToListAsync();
        }
    }
}

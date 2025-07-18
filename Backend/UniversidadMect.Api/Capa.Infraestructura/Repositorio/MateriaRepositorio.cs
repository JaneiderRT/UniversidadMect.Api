using Capa.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using UniversidadMect.Api.Capa.Aplicacion.DTOs.Materia;
using UniversidadMect.Api.Capa.Dominio.Interface;
using UniversidadMect.Api.Capa.Infraestructura.Datos;
using UniversidadMect.Api.Capa.Infraestructura.Datos.Implementacion;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UniversidadMect.Api.Capa.Infraestructura.Repositorio
{
    public class MateriaRepositorio : CrudSql<Materia>, IMateriaRepositorio
    {
        private readonly UniversidadContext _context;

        public MateriaRepositorio(UniversidadContext context) : base(context)
        {
            _context = context;
        }

        public async Task<MateriaDTO> ConsultarMateriaPorId(int id)
        {
            return await _context.Materia
                .Join(_context.ProgramaMateria,
                    mat => mat.MateriaId,
                    pmat => pmat.MateriaId,
                    (mat, pmat) => new
                    {
                        Materias = mat,
                        ProgramaMaterias = pmat
                    }
                )
                .Join(_context.Programa,
                    mat => mat.ProgramaMaterias.ProgramaId,
                    pro => pro.ProgramaId,
                    (mat, pro) => new
                    {
                        Materias = mat.Materias,
                        ProgramaMaterias = mat.ProgramaMaterias,
                        Programas = pro
                    }

                )
                .Where(mat => mat.Materias.MateriaId == id)
                .Select(mat => new MateriaDTO
                {
                    MateriaId = mat.Materias.MateriaId,
                    Nombre = mat.Materias.Nombre,
                    CreditosMateria = mat.Materias.CreditosMateria,
                    ProfesorId = mat.Materias.ProfesorId,
                    EsActivo = mat.Materias.EsActivo,
                    NombrePrograma = mat.Programas.Nombre,

                }).FirstAsync();
        }

        public async Task<IEnumerable<MateriaDTO>> ConsultarMateriasPorProgramaId(int programaId)
        {
            return await _context.Materia
                .Join(_context.ProgramaMateria,
                    mat => mat.MateriaId,
                    pmat => pmat.MateriaId,
                    (mat, pmat) => new
                    {
                        Materias = mat,
                        ProgramaMaterias = pmat
                    }
                )
                .Join(_context.Programa,
                    mat => mat.ProgramaMaterias.ProgramaId,
                    pro => pro.ProgramaId,
                    (mat, pro) => new
                    {
                        Materias = mat.Materias,
                        ProgramaMaterias = mat.ProgramaMaterias,
                        Programas = pro
                    }

                )
                .Where(mat => mat.Programas.ProgramaId == programaId)
                .Select(mat => new MateriaDTO
                {
                    MateriaId = mat.Materias.MateriaId,
                    Nombre = mat.Materias.Nombre,
                    CreditosMateria = mat.Materias.CreditosMateria,
                    ProfesorId = mat.Materias.ProfesorId,
                    EsActivo = mat.Materias.EsActivo,
                    NombrePrograma = mat.Programas.Nombre,

                }).ToListAsync();
        }
    }
}

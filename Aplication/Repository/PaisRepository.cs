using Dominio.Entities;
using Dominio.Interfaces;
using iText.Kernel.Geom;
using Microsoft.EntityFrameworkCore;
using Persistencia.Data;

namespace Aplication.Repository
{
    public class PaisRepository : GenericRepository<Pais>, IPaisRepository
    {
        private readonly IncidenciasContext _contetx;
        public PaisRepository(IncidenciasContext context) : base(context)
        {
            _contetx = context; 
        }

        public override async Task<IEnumerable<Pais>> GetAllAsync(){

            return await _contetx.Paises
                            .Include(p => p.Departamentos)
                            .ToListAsync();
        }

        public override async Task<(int totalRegistros, IEnumerable<Pais> registros)> GetAllAsync(int pageIndex, int pageSize, string search){
            var query = _contetx.Paises as IQueryable<Pais>;
            if(!String.IsNullOrEmpty(search)){
                query = query.Where(p => p.NombrePais.ToLower().Contains(search));
            }
            query = query.OrderBy(p => p.Id);
            var totalRegistros = await query.CountAsync();
            var registros = await query
                                    .Include(p => p.Departamentos)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize)
                                    .ToListAsync();
            return (totalRegistros, registros); 
        }

    }
}
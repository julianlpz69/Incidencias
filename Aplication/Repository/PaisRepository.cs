using Dominio.Entities;
using Dominio.Interfaces;
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

    }
}